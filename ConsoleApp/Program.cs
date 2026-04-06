using DuckStudio.CatFood.Functions;
using Spectre.Console;

namespace ConsoleApp
{
    internal class Program
    {
        private const string content = "[yellow]Hello, World![/]";

        static void Main()
        {
            Console.WriteLine(content);
            Console.MarkupLine(content);
            Print.PrintWithPrefix(content, Print.MSHead.Success, markuped: true);

            AnsiConsole.MarkupLine(content);
        }
    }
}
