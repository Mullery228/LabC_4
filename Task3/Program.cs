void Calculate()
{
    Console.WriteLine("Сгенерированный массив из 8-ми элементов: ");
    Random random = new Random();
    var array = new List<int>();
    for(int i = 0; i < 8; i++)
    {
        int a = random.Next(1, 100);
        array.Add(a);
    }
    foreach (int i in array)
    {
        Console.Write("{0} ", i);
    }
}

Calculate();