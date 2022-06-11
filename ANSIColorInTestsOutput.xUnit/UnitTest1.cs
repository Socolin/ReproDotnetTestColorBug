using Socolin.ANSITerminalColor;
using Xunit.Abstractions;

namespace ANSIColorInTestsOutput.xUnit;

public class UnitTest1
{
	private readonly ITestOutputHelper output;
	public UnitTest1(ITestOutputHelper output)
	{
		this.output = output;
	}
	[Fact]
	public void Test1()
	{
		output.WriteLine(AnsiColor.Foreground(96, 120, 200).Colorize("Test colored output"));
	}
}