﻿using Antlr4.Runtime;

namespace IataMessageProcessor.Parsers.TextMessages
{
    public class SyntaxErrorListener : BaseErrorListener
    {
        public List<SyntaxError> SyntaxErrors = new List<SyntaxError>();

        public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line,
            int charPositionInLine,
            string msg, RecognitionException e)
        {
            SyntaxErrors.Add(new SyntaxError
            {
                Recognizer = recognizer,
                OffendingSymbol = offendingSymbol,
                Line = line,
                CharPositionInLine = charPositionInLine,
                Message = msg,
                E = e
            });
            base.SyntaxError(output, recognizer, offendingSymbol, line, charPositionInLine, msg, e);
        }
    }

    public class SyntaxError
    {
        public IRecognizer Recognizer { get; set; }
        public Object OffendingSymbol { get; set; }
        public int Line { get; set; }
        public int CharPositionInLine { get; set; }
        public String Message { get; set; }
        public RecognitionException E { get; set; }

        public override string ToString()
        {
            return this.Message;
        }
    }
}
