using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            string health = new string('|', currentHealth) + new string('.', maxHealth - currentHealth);

            string energy = new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Health: |{health}|");
            Console.WriteLine($"Energy: |{energy}|");
        }
    }
}