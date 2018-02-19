using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static System.Console;

namespace Tuples_01
{
    class Program
    {

        static (string, int) GetPerson() => ("Bob", 123);
        static void Main(string[] args)
        {
            var p = GetPerson();
            (string, int) p1 = GetPerson();

            var otherP = p;
            otherP.Item1 = "Sam";
            otherP.Item2 = 89897;


            WriteLine($"Name: {p.Item1}. Number: {p.Item2}.");
            WriteLine($"Name: {otherP.Item1}. Number: {otherP.Item2}.");



            (string, int)[] Employees = { ("Bob", 109), ("Phil", 151), ("Jimmy", 101)   };
            var sortedEmployees = Employees.OrderBy(e => e.Item2); 

            var Bob = sortedEmployees.Where(e => e.Item1 == "Bob");


            



            ReadLine();
            
        }
    }
}
