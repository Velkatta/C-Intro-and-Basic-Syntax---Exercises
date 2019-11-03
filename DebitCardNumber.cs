using System;

namespace _01._Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            Console.Write($"{firstNumber:d4} ");
            Console.Write($"{secondNumber:d4} ");
            Console.Write($"{thirdNumber:d4} ");
            Console.WriteLine($"{fourthNumber:d4}");
        }
    }
}