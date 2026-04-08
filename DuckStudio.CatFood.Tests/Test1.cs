using DuckStudio.CatFood.Functions;

namespace DuckStudio.CatFood.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestTerminalCalculateCharactersDisplayed()
        {
            if (OperatingSystem.IsWindows())
            {
                Assert.AreEqual(9, Terminal.CalculateCharactersDisplayed("六个字33a"));
            }
        }
    }
}
