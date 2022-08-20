Console.WriteLine("Введите число");
    int numb = Convert.ToInt32(Console.ReadLine());
        if (numb < 2 )
    {
        Console.WriteLine("Чётных чисел до " + numb + " нет");
    }
    for (int numbX = 2; numbX <= numb; numbX = numbX + 2)
    {
        Console.Write("{0}, ", + numbX);
    }