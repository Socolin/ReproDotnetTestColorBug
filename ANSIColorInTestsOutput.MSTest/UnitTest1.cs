using Socolin.ANSITerminalColor;

namespace ANSIColorInTestsOutput.MSTest;

[TestClass]
public class UnitTest1
{
	[TestMethod]
	public void ConsoleWriteLine()
	{
		Console.WriteLine(AnsiColor.Foreground(96, 120, 200).Colorize("Test colored output"));
		Assert.Fail(AnsiColor.Foreground(200, 120, 200).Colorize("Colored assert"));
	}

	[TestMethod]
	public void TestContextColor()
	{
		Console.WriteLine(AnsiColor.Foreground(96, 120, 200).Colorize("Test colored output"));
		Assert.Fail(AnsiColor.Foreground(200, 120, 200).Colorize("Colored assert"));
	}

	/// <summary>
	/// Gets or sets the test context which provides
	/// information about and functionality for the current test run.
	/// </summary>
	public TestContext TestContext { get; set; }
}