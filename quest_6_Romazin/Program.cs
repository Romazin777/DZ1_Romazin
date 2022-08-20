Console.WriteLine("Введите число");
    int numb = Convert.ToInt32(Console.ReadLine());
    if (numb % 2 == 0)
    {
        Console.WriteLine("Число " + numb + " четное");
    }
    else
    {
        Console.WriteLine("Число " + numb + " нечетное");
    }