using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _40kCrusader.model;

namespace _40kCrusader
{
    //the class for adding unit types to the json. Write all the info in manually. Saves it to the json so we can
    //call back to it later and make army building easier.
    public class UnitAdding
    {
       public static UnitPresets unitPresets = new UnitPresets();
        public static void GiveUnitName()
        {
            string Name;
            string PointValue;
            Console.WriteLine("What is the name of the unit you are adding?");
            Name = Console.ReadLine().ToLower();
            unitPresets.Name = Name;

            Console.WriteLine("What is the point value of the Unit?");
            PointValue = Console.ReadLine();
            if (int.TryParse(PointValue, out int parsedValue))
                {
                    unitPresets.PointValue = parsedValue;
                }
                else
                {
                    Console.WriteLine("Invalid point value.");
                }

        }

        public static void UnitModels()
        {
            string unitModeltype;
            Console.WriteLine("How many model type does the Unit have?");
            unitModeltype = Console.ReadLine();

            switch(unitModeltype)
            {
                case "1":
                    {
                        Console.WriteLine("Name of unit: ");
                        unitPresets.Model1 = Console.ReadLine().ToLower();
                        break;
                    }
                    case "2":
                    {
                        Console.WriteLine("Name of unit1: ");
                        unitPresets.Model1 = Console.ReadLine().ToLower();
                        Console.WriteLine("Name of unit2: ");
                        unitPresets.Model2 = Console.ReadLine().ToLower();
                        break;
                    }
                    case "3":
                    {
                        Console.WriteLine("Name of unit1: ");
                        unitPresets.Model1 = Console.ReadLine().ToLower();
                        Console.WriteLine("Name of unit2: ");
                        unitPresets.Model2 = Console.ReadLine().ToLower();
                        Console.WriteLine("Name of unit3: ");
                        unitPresets.Model2 = Console.ReadLine().ToLower();
                        break;
                    }
                       case "4":
                    {
                        Console.WriteLine("Name of unit1: ");
                        unitPresets.Model1 = Console.ReadLine().ToLower();
                        Console.WriteLine("Name of unit2: ");
                        unitPresets.Model2 = Console.ReadLine().ToLower();
                        Console.WriteLine("Name of unit3: ");
                        unitPresets.Model2 = Console.ReadLine().ToLower();
                         Console.WriteLine("Name of unit4: ");
                        unitPresets.Model2 = Console.ReadLine().ToLower();
                        break;     
                    }
            }

        }
    }
}