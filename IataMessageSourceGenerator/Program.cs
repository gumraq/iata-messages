using IataMessageSourceGenerator;
using FluentResults;


List<string> lines = new List<string>();
string line;
Console.WriteLine("Enter one or more lines of text (press CTRL+Z to exit):");
do
{
    line = Console.ReadLine();
    if (line != null)
    {
        lines.Add(line);
    }
} while (line != null);

if (!lines.Any())
{
    Environment.Exit(-1);
}

EntryPointParser parser = new EntryPointParser();
Result<string> csharp = parser.Proc(string.Join("\r\n", lines));

if (!csharp.IsSuccess)
{
    Environment.Exit(1);
}

Console.WriteLine(csharp.Value);