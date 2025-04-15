using Xunit;
using System;

public class SumOfDigitsTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(5, 5)]
    [InlineData(123, 6)]
    [InlineData(999, 27)]
    [InlineData(1024, 7)]
    public void SumOfDigits_ValidInput_ReturnsCorrectSum(int number, int expected)
    {
        int result = Program.SumOfDigits(number);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SumOfDigits_NegativeNumber_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Program.SumOfDigits(-5));
    }

    [Fact]
    public void Main_InvalidInput_PrintsErrorMessage()
    {
        var input = new StringReader("abc");
        var output = new StringWriter();
        Console.SetIn(input);
        Console.SetOut(output);

        Program.Main();

        Assert.Contains("Ошибка ввода!", output.ToString());
    }

    [Fact]
    public void Main_NegativeInput_PrintsErrorMessage()
    {
        var input = new StringReader("-5");
        var output = new StringWriter();
        Console.SetIn(input);
        Console.SetOut(output);

        Program.Main();

        Assert.Contains("Ошибка ввода!", output.ToString());
    }
}
