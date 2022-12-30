int Fib(int n)
{
    double sq5 = Math.Sqrt(5);
    double a = (1 + sq5) / 2;
    double b = (1 - sq5) / 2;

    return (int)((Math.Pow(a, n) - Math.Pow(b, n)) / sq5);
}

Console.WriteLine(Fib(7));