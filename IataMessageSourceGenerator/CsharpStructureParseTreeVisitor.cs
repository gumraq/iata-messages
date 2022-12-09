using System;
using Antlr4.Runtime.Tree;
using MoreLinq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IataMessageSourceGenerator
{
    internal class CsharpStructureParseTreeVisitor : ANTLRv4ParserBaseVisitor<string>
    {

        private List<ClassBuilder> builders;

        private List<string> simpleProps;
        private Stack<string> separators;
        private Dictionary<string,string> readonlyProps;

        public CsharpStructureParseTreeVisitor()
        {
            this.builders = new List<ClassBuilder>();
            this.simpleProps = new List<string>();
            this.separators = new Stack<string>();
            this.readonlyProps = new Dictionary<string, string>();
        }

        public void SourceCode()
        {
            this.SourceCodeStandard();
            this.SourceCodeParts();
            this.SourceCodeFormatter();
            this.SourceCodeParser();
            this.UnusedProperties();
        }

        private async void SourceCodeStandard()
        {
            ClassBuilder? firstBuilder = builders.FirstOrDefault();
            string className = firstBuilder?.Name?.FirstCharToUpper() ?? "NoName";

            if (firstBuilder != null)
            {
                string code = firstBuilder.ToString();
                code = $@"using IataMessageStandard.{className}Parts;

namespace IataMessageStandard
{"{"}
{code}{"}"}";

                await this.Write($"{className}.cs", code);
            }
        }

        private async void SourceCodeParts()
        {
            string className = builders.FirstOrDefault()?.Name.FirstCharToUpper() ?? "NoName";
            string code = string.Join("\r\n\r\n", builders.Skip(1).Select(b => b.ToString()));
            
            code = $@"namespace IataMessageStandard.{className}Parts
{"{"}
{code}
{"}"}
";
            
            await this.Write($"{className}Parts.cs", code);
        }

        private async void SourceCodeFormatter()
        {
            string className = builders.FirstOrDefault()?.Name.FirstCharToUpper() ?? "NoName";
            string visitorSourcCode = $@"using IataMessageStandard;
using IataMessageStandard.{className}Parts;

namespace IataMessageProcessor.Formatters.TextMessages
{"{"}
    public partial class TextMessageFormatter :
    #region inherits interfaces
{string.Join(",\r\n", builders.Select(b => $"    IVisitor<{b.Name.FirstCharToUpper()}, string>"))}
    #endregion

{"    {"}
{string.Join("\r\n\r\n", builders.Select(b => $@"        public string Visit({b.Name.FirstCharToUpper()} e)
{"        {"}
            if (e == null)
{"            {"}
                return string.Empty;
{"            }"}

            return ${'"'}{string.Join(string.Empty, b.Properties.Select(FormatProp))}{(b.WithAttribute ? "{sCRLF}" : string.Empty)}{'"'};
{"        }"}"))}
{"    }"}
{"}"}
";

            await this.Write($"{className}Formatter.cs", visitorSourcCode);
        }

        private async void SourceCodeParser()
        {
            ClassBuilder? firstBuilder = builders.FirstOrDefault();
            string className = firstBuilder?.Name?.FirstCharToUpper() ?? "NoName";
            string sourceCode = $@"using Antlr4.Runtime;
using FluentResults;

namespace IataMessageProcessor.Parsers.TextMessages
{"{"}
    public class Fwb17MessageParser : Parser<string>
    {"{"}
        public Fwb17MessageParser()
        {"{"}
        {"}"}

        public Fwb17MessageParser(IParser<string> parser) : base(parser)
        {"{"}
        {"}"}

        protected override bool IsThisCase(string standatdMessage)
        { "{"}
            try
            {"{"}
                using var reader = new StringReader(standatdMessage);
                string firstLine = reader.ReadLine();
                return string.Equals(firstLine, {"\""}FWB/17{"\""});
            {"}"}
            catch
            {"{"}
                return false;
            {"}"}
        {"}"}

        protected override Result<object> Proccess(string standatdMessage)
        {"{"}
            try
            {"{"}
                var inputStream = new AntlrInputStream(standatdMessage);
                var speakLexer = new fwb17Lexer(inputStream);
                var commonTokenStream = new CommonTokenStream(speakLexer);
                var fwb17Parser = new fwb17Parser(commonTokenStream);
                var errorListener = new SyntaxErrorListener();
                fwb17Parser.AddErrorListener(errorListener);
                var fwb17Context = fwb17Parser.fwb17();
                var visitor = new MessageParseTreeVisitor<IataMessageStandard.Fwb17>();

                visitor.Visit(fwb17Context);
                visitor.ExpressionExecute()();

                return Result.Ok(visitor.Message);

            {"}"}
            catch (Exception ex)
            {"{"}
                return Result.Fail(new Error({"\""}Не удалось разложить FWB/17{"\""}).CausedBy(ex));
            {"}"}
        {"}"}
    {"}"}
{"}"}";
            await this.Write($"{className}Parser.cs", sourceCode);
        }

        private void UnusedProperties()
        {
            var unusedTokens = this.simpleProps.Except(this.builders.SelectMany(b => b.Properties).Select(p => p.Name)).ToList();
        }

        private async Task Write(string fileName, string content)
        {
            await File.WriteAllTextAsync(fileName, content);
        }

        string FormatProp(PropInfo propInfo)
        {
            string separator = string.Empty;
            if (!string.IsNullOrEmpty(propInfo.Attribute1))
            {
                if (propInfo.Attribute1 == "SeparatorSlant")
                {
                    separator = "{sSlant}"; 
                }
                else if (propInfo.Attribute1 == "SeparatorHyphen")
                {
                    separator = "{sHyphen}";
                }
                else if (propInfo.Attribute1 == "SeparatorCrlf")
                {
                    separator = "{sCRLF}";
                }
                else
                {
                    separator = propInfo.Attribute1;
                }
            }

            if (propInfo.Type == PropType.CLASS)
            {
                return separator + "{this.Visit(e." + propInfo.Name.FirstCharToUpper() + ")}";
            }
            if (propInfo.Type == PropType.LIST)
            {
                return separator + "{string.Join(string.Empty, e." + propInfo.Name.FirstCharToUpper() + "?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
            }
            if (propInfo.Type == PropType.STRING)
            {
                return separator + "{e." + propInfo.Name.FirstCharToUpper() +"}";
            }

            return string.Empty;
        }

        public override string VisitRules(ANTLRv4Parser.RulesContext context)
        {
            this.FillListStringProps(context);
            this.FillReadonlyProps(context);

            base.VisitRules(context);
            if (this.separators.Any())
            {
                this.builders[^1].WithAttribute = true;
                this.separators.Clear();
            }

            return string.Empty;
        }

        private void FillListStringProps(ANTLRv4Parser.RulesContext context)
        {
            context.ruleSpec()
                .Select(rs => rs.parserRuleSpec())
                .Where(prs => prs != null)
                .ForEach(prs =>
                {
                    string nameOfProp = prs.RULE_REF().GetText();
                    if (!IsRulerefExist(prs))
                    {
                        simpleProps.Add(nameOfProp);
                    }
                });
        }

        private void FillReadonlyProps(ANTLRv4Parser.RulesContext context)
        {
            context.ruleSpec()
                .Select(rs => rs.lexerRuleSpec())
                .Where(prs => prs != null)
                .ForEach(prs =>
                {
                    string nameOfProp = prs.TOKEN_REF().GetText();

                    readonlyProps.Add(nameOfProp, prs.lexerRuleBlock().GetText().Trim('\''));
                });
        }

        private bool IsRulerefExist(IParseTree parseTree)
        {
            int i = 0;
            IParseTree child = parseTree.GetChild(i);
            while (child != null)
            {
                if (IsRulerefExist(child))
                {
                    return true;
                }

                if (child is ANTLRv4Parser.RulerefContext)
                {
                    return true;
                }

                child = parseTree.GetChild(++i);
            }

            return false;
        }

        public override string VisitParserRuleSpec(ANTLRv4Parser.ParserRuleSpecContext context)
        {
            string name = context.RULE_REF().GetText();
            if (!this.simpleProps.Contains(name))
            {
                ANTLRv4Parser.ElementContext[] elements = context
                    .ruleBlock()
                    .ruleAltList()
                    .labeledAlt()
                    .SelectMany(la => la
                        .alternative()
                        .element())
                    .ToArray();

                if (this.separators.Any())
                {
                    this.builders[^1].WithAttribute = true;
                    this.separators.Clear();
                }

                this.builders.Add(new ClassBuilder { Name = name });
                foreach (ANTLRv4Parser.ElementContext element in elements)
                {
                    this.Atom(element);
                    this.Ebnf(element);
                }
            }

            return base.VisitParserRuleSpec(context);
        }

        private void Atom(ANTLRv4Parser.ElementContext element)
        {
            ANTLRv4Parser.AtomContext atom = element.atom();
            if (atom != null)
            {
                string ebnfSuffix = element.ebnfSuffix()?.GetText();
                ANTLRv4Parser.RulerefContext ruleref = atom.ruleref();
                ANTLRv4Parser.TerminalContext terminal = atom.terminal();
                string atomName = atom.GetText();
                if (ruleref != null)
                {
                    PropType pt;
                    if (this.simpleProps.Contains(atomName))
                    {
                        pt = PropType.STRING;
                    }
                    else if (!string.IsNullOrEmpty(ebnfSuffix) && (ebnfSuffix == "*" || ebnfSuffix == "+"))
                    {
                        pt = PropType.LIST;
                    }
                    else
                    {
                        pt = PropType.CLASS;
                    }

                    PropInfo pi = new PropInfo { Type = pt, Name = atom.GetText() };
                    if (separators.Any())
                    {
                        pi.Attribute1 = separators.Pop();
                        separators.Clear();
                    }

                    this.readonlyProps.TryGetValue(pi.Name, out var constVal);
                    pi.Const = constVal;

                    this.builders[^1].Properties.Add(pi);
                }
                else if (terminal != null)
                {
                    string terminalName = atom.GetText();
                    if (terminalName.StartsWith("Separator"))
                    {
                        separators.Push(terminalName);
                    }
                    else
                    {
                        var pi = new PropInfo { Type = PropType.STRING, Name = atom.GetText().Trim('\'') };
                        this.readonlyProps.TryGetValue(pi.Name, out var constVal);
                        pi.Const = constVal;
                        this.builders[^1].Properties.Add(pi);
                    }
                }

                
            }
        }

        private void Ebnf(ANTLRv4Parser.ElementContext element)
        {
            ANTLRv4Parser.EbnfContext ebnf = element.ebnf();
            if (ebnf != null)
            {
                foreach (ANTLRv4Parser.ElementContext elem in ebnf.block().altList().alternative().SelectMany(a => a.element()))
                {
                    this.Atom(elem);
                    this.Ebnf(elem);
                }
            }
        }

        class ClassBuilder
        {
            public bool WithAttribute { get; set; }
            public string Name { get; set; }
            public List<PropInfo> Properties { get; set; }

            public ClassBuilder()
            {
                this.Properties = new List<PropInfo>();
            }

            public override string ToString()
            {
                return $@"{(this.WithAttribute? "    [SeparatorCrlf]\r\n" : string.Empty)}    public class {this.Name.FirstCharToUpper()}
{"    {"}{string.Join(string.Empty,this.Properties.Select(p =>
        {
            if (p.Type == PropType.CLASS)
            {
                return $"\r\n        {(string.IsNullOrEmpty(p.Attribute1) ? string.Empty: $"[{p.Attribute1}]\r\n        ")}{(string.IsNullOrEmpty(p.Attribute2) ? string.Empty : $"[{p.Attribute2}]\r\n        ")}public {p.Name.FirstCharToUpper()} {p.Name.FirstCharToUpper()} {"{"} get; set; {"}"}";
            }

            if (p.Type == PropType.LIST)
            {
                return $"\r\n        {(string.IsNullOrEmpty(p.Attribute1) ? string.Empty : $"[{p.Attribute1}]\r\n        ")}{(string.IsNullOrEmpty(p.Attribute2) ? string.Empty : $"[{p.Attribute2}]\r\n        ")}public List<{p.Name.FirstCharToUpper()}> {p.Name.FirstCharToUpper()} {"{"} get; set; {"}"}";
            }

            if (p.Type == PropType.STRING)
            {
                return $"\r\n        {(string.IsNullOrEmpty(p.Attribute1) ? string.Empty : $"[{p.Attribute1}]\r\n        ")}{(string.IsNullOrEmpty(p.Attribute2) ? string.Empty : $"[{p.Attribute2}]\r\n        ")}public string {p.Name.FirstCharToUpper()} {"{"} get {(string.IsNullOrEmpty(p.Const) ? "; set; " : string.Concat("{return \"",p.Const,"\";}"))} {"}"}";
            }

            return string.Empty;
        }))}
{"    }"}";
            }
        }

        class PropInfo
        {
            public string Attribute1 { get; set; }
            public string Attribute2 { get; set; }
            public string Const { get; set; }
            public PropType Type { get; set; }
            public string Name { get; set; }
        }

        enum PropType
        {
            CLASS,
            LIST,
            STRING
        }
    }

    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => input[0].ToString().ToUpper() + input.Substring(1)
            };
    }
}

