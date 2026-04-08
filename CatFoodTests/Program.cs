using DuckStudio.CatFood.Functions;

namespace CatFoodTests
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("测试 Print.PrintWithPrefix");
            Print.PrintWithPrefix("[yellow]预期这条内容是黄色的[/]", Print.MSHead.Question, markuped: true);
            Print.PrintWithPrefix("[yellow][预期这条内容没有颜色][/]", Print.MSHead.Question);

            Console.WriteLine();
            Console.WriteLine("测试 Print.PrintMultilineWithPrefix");
            Print.PrintMultilineWithPrefix(["这是", "多行", "[blue]内容[/]", "输出", "(禁用标记)"], "-");
            Console.WriteLine();
            Print.PrintMultilineWithPrefix(["这是", "多行", "[blue]内容[/]", "输出", "(启用标记)"], "-", markuped: true);
        }
    }
}
