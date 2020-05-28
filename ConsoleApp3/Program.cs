using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string action;

            Console.WriteLine("Введите число");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите действие");
            action = Console.ReadLine();

            switch(action)
            {
                case "+":
                    Console.WriteLine(x + y);
                    break;
                case "-":
                    Console.WriteLine(x - y);
                    break;
                case "*":
                    Console.WriteLine(x * y);
                    break;
                case "/":
                    if (y == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        Console.WriteLine(x / y);
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Error");
                    }
                    break;
            }
        }
       
    }
}
