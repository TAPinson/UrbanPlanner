using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {


            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Dan Quayle");
            FiveOneTwoEigth.AddStories(3);
            FiveOneTwoEigth.AddWidth(50);
            FiveOneTwoEigth.AddDepth(10);
            Console.WriteLine(FiveOneTwoEigth.Address);
            Console.WriteLine("----------------");
            Console.WriteLine($"Designed by {FiveOneTwoEigth.Designer}");
            Console.WriteLine($"Constructed on {FiveOneTwoEigth.DateConstructed}");
            Console.WriteLine($"Owned by {FiveOneTwoEigth.Owner}");
            Console.WriteLine($"{FiveOneTwoEigth.Volume} cubic meters of space");
        }
    }
}
