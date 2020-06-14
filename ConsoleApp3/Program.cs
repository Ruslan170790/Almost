using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
           
            if (num > 5 && num < 10) 
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Не известное значение");
            }
            Console.ReadKey();

        }
    }
}


