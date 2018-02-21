using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Tuples00
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************** General Stuff About Tuples: AKA Fun with Tubles :-) :-> :-| ***************/
            // 00: Tuble literal with nunamed elements

            var Emp1 = (101, "Bob", "Smith", "Tech Writer 3", true);

            WriteLine($"Emp Id: {Emp1.Item1}\nName: {Emp1.Item2 + " " + Emp1.Item3}\nTitle: {Emp1.Item4}\nActive Employee:{Emp1.Item5}");
            WriteLine(Emp1);

            // 01: Explicit Tuple type
            (int, string, string, string, bool) Emp2 = (102, "James", "Gordon", "Tech Manager 4", true); // Notice: 'var' is not required with Tuples
            WriteLine(Emp2);
            WriteLine($"Emp2's name is, {Emp2.Item2 + " " + Emp2.Item3}");

            // 02: Naming your Tuple elements

            var Emp3 = (Id: 105, FirstName: "Joel", LastName: "Londagard", JobTitle: "Business Systems Consultant", ActiveEmpoyee: true);
            WriteLine($"{Emp3.FirstName + " " + Emp3.LastName} is a {Emp3.Item4}"); // Notice "Item4" <T> is not listed in the intellisense but is still available.

            // 03: Arrays

            (string name, int stars)[] Drummers = { ("Vinnie", 5), ("Phil Collins", 3), ("Stuart Copeland", 5), ("Trey Cool", 1) };
            var sortedDrummers = Drummers.OrderBy(d => d.stars);
            var v = sortedDrummers.Where(d => d.name.Contains("Vin")).FirstOrDefault();
            WriteLine(v);

            // 04: A Few more things before we continue on ...

            // A: Tuples are value types with mutable elements

            var Pet1 = ("Max", "dog");
            var Pet2 = Pet1;
            Pet2.Item1 = "Meadows";
            Pet2.Item2 = "cat";

            WriteLine(Pet1);
            WriteLine(Pet2);

            // B: Tuple types are compaitble by element types ... *NOT* element names

            (string make, string model, int year) c1 = ("Ford", "Tarus", 2012);
            (string manufactorer, string product, int qty) c2 = ("Betty Crocker", "Cake Mix", 8);

            c2 = c1; // no compiler error! 

            WriteLine(c2); // I was expecting cake!


            ReadLine();
        }
    }
}
