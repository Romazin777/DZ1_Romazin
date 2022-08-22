// Пример №1
//int x = new Random().Next(100,1000);
//           Console.WriteLine($"сгенерировалось случайное число {x}");

// Пример №2
//void PrintMaxDigit()
//            {
//                int x = new Random().Next(100,1000);
//                Console.WriteLine($"сгенерировалось случайное число {x}");
//                int x1=x/100;
//               int x3=x%10;
//                Console.Write($"{x1}{x3}");
//            }
//            PrintMaxDigit();
            

//Пример №3 
//void PrintMaxDigit()
//            {
//                int x = new Random().Next(10,100);
//                Console.WriteLine($"сгенерировалось случайное число {x}");
//                int x1=x/10;
//                int x2=x%10;
//                if (x1>x2) Console.WriteLine(x1);
//                else Console.WriteLine(x2);
//            }
//
            //PrintMaxDigit();
            //PrintMaxDigit();
//            void PrintMaxDigitArg(int xx)
//            {

              //  Console.WriteLine($"сгенерировалось случайное число {xx}");
//                int x1=xx/10;
//                int x2=xx%10;
//                if (x1>x2) Console.WriteLine(x1);
//                else Console.WriteLine(x2);
//            } 
//            PrintMaxDigitArg(int.Parse(Console.ReadLine()));

// Пример №4
//string PrintMaxDigitF(int x)
//            {
//                //int x = new Random().Next(100,1000);
//                //Console.WriteLine($"сгенерировалось случайное число {x}");
//                int x1=x/100;
//                int x3=x%10;
//                return $"{x1}{x3}";
//            }
//        int x = new Random().Next(100,1000);
//        Console.WriteLine($"сгенерировалось случайное число {x}");
//       Console.WriteLine(PrintMaxDigitF(x));
// Пример №5 ( Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно
//string Kratnoe()
//{
//    Console.WriteLine("введите первое число");
//    int x1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("введите второе число");
//    int x2 = Convert.ToInt32(Console.ReadLine());
//    int ostatok = x1%x2;
//    if (ostatok == 0)
//    {
//    return "кратно"; 
//    }
//    else 
//    {
//    return "Не кратно, остаток: " + $"{ostatok}"; 
//    }
//}
//Console.WriteLine(Kratnoe());

// Пример № 6
void Kratnoe(int x1,int x2)
              {
                if (x1 % x2 == 0)
                {
                    Console.WriteLine("кратно");
                }
                else
                {
                    Console.WriteLine($" не кратно, остаток {x1 % x2}");
                }
              }  

            void EvenNumberPrint(int a, int b)
            {
                if (b > a)     Kratnoe(b,a);
                else Kratnoe(a,b);
            }

            int xx=int.Parse(Console.ReadLine());
            int yy=int.Parse(Console.ReadLine());
            EvenNumberPrint(xx,yy);
            EvenNumberPrint(yy,xx);
