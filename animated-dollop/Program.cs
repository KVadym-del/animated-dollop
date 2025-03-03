using System.Numerics;

BigInteger add(BigInteger a, BigInteger b) => a + b;
BigInteger multiply(BigInteger a, BigInteger b) => a * b;
double division(double a, double b) => a / b;

Console.WriteLine("Hello, World!");
Console.WriteLine(add(12, 3));
Console.WriteLine(multiply(12, 3));
Console.WriteLine(division(12, 3));

static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or empty");
    }

    double sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

static int FindMaxValue(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Array cannot be null or empty");
    }

    int maxValue = numbers[0];
    foreach (int number in numbers)
    {
        if (number > maxValue)
        {
            maxValue = number;
        }
    }

    return maxValue;
}

int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(CalculateAverage(numbers));
Console.WriteLine(FindMaxValue(numbers));

return 0;