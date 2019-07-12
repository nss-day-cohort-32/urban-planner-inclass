using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building EliotTowers = new Building("420 Avenue"){
                Width = 60,
                Depth = 90,
                Stories = 3
            };

            EliotTowers.Construct();

            EliotTowers.Purchase("Shelley");

            Console.WriteLine(EliotTowers.Address);
            Console.WriteLine("-------------");
            Console.WriteLine($"Designed by {EliotTowers.Designer}");
            Console.WriteLine($"Constructed on {EliotTowers.DateConstructed}");
            Console.WriteLine($"Owned by {EliotTowers.Owner}");
            Console.WriteLine($"{EliotTowers.Volume} cubic meters of space");
        }
    }
}
