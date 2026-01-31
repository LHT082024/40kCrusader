using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _40kCrusader.model;

namespace _40kCrusader
{
    public class UnitAdding
    {
        UnitPresets unitPresets = new UnitPresets();
        public static void MakeSquad()
        {
            string Name;
            Console.WriteLine("What is the name of the unit you are adding?");
            Name = Console.ReadLine().ToLower();
            Console.WriteLine($"{Name}");


        }
    }
}