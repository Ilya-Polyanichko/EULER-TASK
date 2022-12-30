int unitSum(int n) => (n * (n + 1)) / 2;

int sum = 3 * unitSum((int)(999 / 3)) + 5 * unitSum((int)(999 / 5)) - 15 * unitSum((int)(999 / 15));
Console.WriteLine($"Сумма всех кратных 3 и 5 ниже 1000 равна {sum}");