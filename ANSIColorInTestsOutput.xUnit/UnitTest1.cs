using Socolin.ANSITerminalColor;
using Xunit.Abstractions;

namespace ANSIColorInTestsOutput.xUnit;

public class UnitTest1
{
	private readonly ITestOutputHelper _output;

	public UnitTest1(ITestOutputHelper output)
	{
		this._output = output;
	}
	
	[Fact]
	public void Test1()
	{
		_output.WriteLine(AnsiColor.Foreground(96, 120, 200).Colorize("Test colored output"));
		Assert.Equal("Fail", AnsiColor.Foreground(200, 120, 200).Colorize("Colored assert"));
	}
}