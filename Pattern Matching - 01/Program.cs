using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using TheCompanyDemo;


namespace Pattern_Matching___01
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager[] Mgrs = {
                new Manager { FirstName = "Emilie", LastName = "Smith", NumberOfReports = 1_012, Id = 501 },
                new Manager {FirstName = "Marcie", LastName = "Matstone", NumberOfReports = 14, Id = 231998 }
            };

            foreach(var mgr in Mgrs)
            {
                switch (mgr)
                {
                    case Manager m when m.NumberOfReports >= 1_000:
                        m.Rank = Employee.Ranks.SrExec;
                        break;
                    case Manager m when m.NumberOfReports <= 25:
                        m.Rank = Employee.Ranks.Manager;
                        break;
                    default:
                        break;
                }

                WriteLine($"{mgr.ToString()} is a(n) {mgr.Rank}");
            }

            ReadLine();
        }
    }
}
