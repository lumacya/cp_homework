using Xunit;
using System;
using System.IO;

public class BinarySearchTests
{
    // Тесты для метода BinarySearch
    [Fact]
    public void TestElementPresent_Middle()
    {
        int[] array = { 1, 3, 5, 7, 9 };
        int result = Program.BinarySearch(array, 5);
        Assert.Equal(2, result);
    }

    [Fact]
    public void TestElementPresent_First()
    {
        int[] array = { 2, 4, 6, 8, 10 };
        int result = Program.BinarySearch(array, 2);
        Assert.Equal(0, result);
    }

    [Fact]
    public void TestElementPresent_Last()
    {
        int[] array = { 2, 4, 6, 8, 10 };
        int result = Program.BinarySearch(array, 10);
        Assert.Equal(4, result);
    }

    [Fact]
    public void TestElementAbsent_Greater()
    {
        int[] array = { 1, 2, 3 };
        int result = Program.BinarySearch(array, 4);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void TestElementAbsent_Lower()
    {
        int[] array = { 1, 2, 3 };
        int result = Program.BinarySearch(array, 0);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void TestSingleElement_Present()
    {
        int[] array = { 5 };
        int result = Program.BinarySearch(array, 5);
        Assert.Equal(0, result);
    }

    [Fact]
    public void TestSingleElement_Absent()
    {
        int[] array = { 5 };
        int result = Program.BinarySearch(array, 3);
        Assert.Equal(-1, result);
    }

    [Fact]
    public void TestEmptyArray()
    {
        int[] array = { };
        int result = Program.BinarySearch(array, 5);
        Assert.Equal(-1, result);
    }

    // Тесты для консольного ввода/вывода
    [Fact]
    public void TestMain_ElementFound()
    {
        string input = "1 3 5 7 9\n5\n";
        string expectedOutput = "Индекс: 2";
        TestConsoleIO(input, expectedOutput);
    }

    [Fact]
    public void TestMain_ElementNotFound()
    {
        string input = "1 3 5 7 9\n4\n";
        string expectedOutput = "NO";
        TestConsoleIO(input, expectedOutput);
    }

    [Fact]
    public void TestMain_InvalidArrayInput()
    {
        string input = "invalid\n";
        string expectedOutput = "Ошибка ввода массива!";
        TestConsoleIO(input, expectedOutput);
    }

    [Fact]
    public void TestMain_InvalidTargetInput()
    {
        string input = "1 2 3\ninvalid\n";
        string expectedOutput = "Ошибка ввода значения!";
        TestConsoleIO(input, expectedOutput);
    }

    private void TestConsoleIO(string input, string expectedOutputPart)
    {
        // Перенаправляем ввод/вывод
        var consoleIn = new StringReader(input);
        var consoleOut = new StringWriter();
        Console.SetIn(consoleIn);
        Console.SetOut(consoleOut);

        // Запуск программы
        Program.Main();

        // Проверка вывода
        string output = consoleOut.ToString();
        Assert.Contains(expectedOutputPart, output);
    }
}
