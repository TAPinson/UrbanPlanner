﻿using System;

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
            buildingWriter(FiveOneTwoEigth);

            Building OneOneZeroOne = new Building("110 1st Avenue");
            OneOneZeroOne.Construct();
            OneOneZeroOne.Purchase("Leroy Jenkins");
            OneOneZeroOne.AddStories(33);
            OneOneZeroOne.AddWidth(150);
            OneOneZeroOne.AddDepth(10);
            buildingWriter(OneOneZeroOne);

            Building TwoEightFiveSeventh = new Building("285 7th Avenue");
            TwoEightFiveSeventh.Construct();
            TwoEightFiveSeventh.Purchase("Scott Bakula");
            TwoEightFiveSeventh.AddStories(1);
            TwoEightFiveSeventh.AddWidth(15);
            TwoEightFiveSeventh.AddDepth(10);
            buildingWriter(TwoEightFiveSeventh);

            Building OneEightTwoMaple = new Building("182 Maple Ct");
            OneEightTwoMaple.Construct();
            OneEightTwoMaple.Purchase("Skip Douglas");
            OneEightTwoMaple.AddStories(2);
            OneEightTwoMaple.AddWidth(52);
            OneEightTwoMaple.AddDepth(9);
            buildingWriter(OneEightTwoMaple);





        }

        static void buildingWriter(Building building)
        {
            Console.WriteLine(building.Address);
            Console.WriteLine("----------------");
            Console.WriteLine($"Designed by {building.Designer}");
            Console.WriteLine($"Constructed on {building.DateConstructed}");
            Console.WriteLine($"Owned by {building.Owner}");
            Console.WriteLine($"{building.Volume} cubic meters of space");

        }
    }
}
