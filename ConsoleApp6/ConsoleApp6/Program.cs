using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите десятичное число");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = Convert.ToString(a, 16);
            Console.WriteLine(b);
        }
    }
}
