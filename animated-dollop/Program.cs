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

int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(CalculateAverage(numbers));

return 0;