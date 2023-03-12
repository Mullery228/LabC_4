void Calculate(double a, double b)
{
    double c = Math.Pow(a, b);
    Console.WriteLine($"\n{a} в степени {b} = {c}");
}


Console.WriteLine("Введите число для возведения в степень:");
double first = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень:");
double second = Convert.ToDouble(Console.ReadLine());
Calculate(first, second);

