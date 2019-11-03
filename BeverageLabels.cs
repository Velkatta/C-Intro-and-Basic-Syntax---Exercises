using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyPer100ml = double.Parse(Console.ReadLine());
            double sugarPer100ml = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {productName}:");

            double kcal = volume * energyPer100ml / 100;
            double sugars = volume * sugarPer100ml /100;

            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}