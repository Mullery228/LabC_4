void Calculate(int a)
{
    int c = 0;
    var array = a.ToString().Select(e => int.Parse(e.ToString())).ToArray();    // Переводим целое число a в массив, где каждая цифра соответствует каждому индексу массива
    foreach (var item in array) // Уже работаем с массивом
    {
        c += item;
    }
    Console.WriteLine(c);
}


Console.WriteLine("Введите число для рассчета суммы его цифр:");
int b = Convert.ToInt32(Console.ReadLine());
Calculate(b);
