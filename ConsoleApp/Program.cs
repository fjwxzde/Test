using DuckStudio.CatFood.Functions;
using Spectre.Console;

namespace ConsoleApp
{
    internal class Program
    {
        private const string content = "[yellow]Hello, World![/]";

        static void Main()
        {
            Console.WriteLine($"void Console.WriteLine(string? value): {content}");
            Console.MarkupLine($"void SystemConsoleExtensions.extension(Console).MarkupLine(string markup) [DuckStudio.CatFood 2.0.0.2]: {content}");
            Print.PrintWithPrefix(content, Print.MSHead.Success, markuped: true);

            AnsiConsole.MarkupLine($"void AnsiConsole.MarkupLine(string value) [DuckStudio.CatFood 2.0.0.1]: {content}");
        }
    }
}
