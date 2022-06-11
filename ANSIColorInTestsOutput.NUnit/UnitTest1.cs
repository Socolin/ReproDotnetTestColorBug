
using Socolin.ANSITerminalColor;

namespace ANSIColorInTestsOutput.NUnit;

public class Tests
{
	[SetUp]
	public void Setup()
	{
	}

	[Test]
	public void Test1()
	{
		Console.WriteLine(AnsiColor.Foreground(96, 120, 200).Colorize("Test colored output"));
	}
}