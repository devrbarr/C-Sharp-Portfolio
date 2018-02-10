using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_PatternMatching.BizDomain
{
    public class Employee
    {
        public enum Ranks
        {
            TeamMember = 0,
            Manager = 1,
            JrExec = 2,
            SrExec = 3,
            CEO = 4
        }
        public int Id { get; set; }
        public int ReportsToId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public Ranks Rank { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    public class Manager : Employee
    {
        public int NumberOfReports { get; set; }
    }

    public class ConfrenceRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasProjector { get; set; }  
        public int SeatingCapacity { get; set; }
    }

    public class TheCompany
    {
        public object[] Build()
        {
            var Mgrs = new[]
            {
                new Manager { Id = 101, FirstName = "Jean-Luc", LastName = "Picard", NumberOfReports = 1041 },
                new Manager { Id = 102, FirstName = "Kathryn", LastName = "Janeway", NumberOfReports = 141}

            };

            var Emps = new[]
            {
                new Employee { Id = 1021, FirstName = "William", LastName = "Ricker", ReportsToId = 101},
                new Employee { Id = 3432, FirstName = "Beverly", LastName = "Crusher", ReportsToId = 101},
                new Employee {Id = 3382, FirstName = "B'Elanna", LastName = "Torres", ReportsToId = 102},
                new Employee {Id = 38289, FirstName = "Tom", LastName = "Paris", ReportsToId = 102}
            };

            var CRs = new[]
            {
                new ConfrenceRoom { Id = 1, Name = "10 Forward", SeatingCapacity = 200, HasProjector = true},
                new ConfrenceRoom { Id = 2, Name = "Transporter Room 3", SeatingCapacity = 10, HasProjector = false},
                new ConfrenceRoom { Id = 3, Name = "Sick Bay", SeatingCapacity = 5, HasProjector = false},
                new ConfrenceRoom { Id= 4, Name = "Shuttle Bay 2", SeatingCapacity = 35, HasProjector = true}
            };

            return new object[] { Mgrs, Emps, CRs };
        }
    }
}
