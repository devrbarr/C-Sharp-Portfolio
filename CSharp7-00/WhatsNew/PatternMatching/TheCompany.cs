using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_00.WhatsNew.PatternMatching
{
    public class Employee
    {
        public enum PositionStatus
        {
            TeamMember = 0,
            Manager = 1,
            JrExec = 2,
            SrExec = 3
        }
        public int EmpId { get; set; }
        public int ReportsToEmpId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PositionStatus AssignedPositionStatus { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    public class Manager : Employee
    {
        public int NumberOfDirects { get; set; }

    }

    public class ConfrenceRoom
    {
        public int CRId { get; set; }
        public string CRName { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasProjector { get; set; }
    }

    public class TheCompany
    {
        public object[] BuildTheCompany00()
        {
            var Emp1 = new Employee { EmpId = 7876327, FirstName = "William", LastName = "Ricker", ReportsToEmpId = 43927 };
            var Emp2 = new Employee { EmpId = 12208, FirstName = "Beverly", LastName = "Crusher", ReportsToEmpId = 43927 };
            var Emp3 = new Employee { EmpId = 9339, FirstName = "B'Elanna", LastName = "Torres", ReportsToEmpId = 93839 };
            var Emp4 = new Employee { EmpId = 7382927, FirstName = "Tom", LastName = "Paris", ReportsToEmpId = 93839 };
            var Mgr1 = new Manager { EmpId = 93839, FirstName = "Kathryn", LastName = "Janeway", NumberOfDirects = 141 };
            var Mgr2 = new Manager { EmpId = 43927, FirstName = "Jean-Luc", LastName = "Picard", NumberOfDirects = 1041 };
            var CR1 = new ConfrenceRoom { CRId = 1, CRName = "10 Forward", HasProjector = true, NumberOfSeats = 30 };
            var CR2 = new ConfrenceRoom { CRId = 2, CRName = "Transporter Room 3", HasProjector = true, NumberOfSeats = 15 };
            var CR3 = new ConfrenceRoom { CRId = 3, CRName = "Sick Bay", HasProjector = false, NumberOfSeats = 5 };

            return new object[] { Emp1, Emp2, Emp3, Emp4, Mgr1, Mgr2, CR1, CR2, CR3 };
        }

        public object[] BuildTheCompany01()
        {
            var emps = new Employee[] {
                new Employee { EmpId = 7876327, FirstName = "William", LastName = "Ricker", ReportsToEmpId = 43927 },
                new Employee { EmpId = 12208, FirstName = "Beverly", LastName = "Crusher", ReportsToEmpId = 43927 },
                new Employee { EmpId = 9339, FirstName = "B'Elanna", LastName = "Torres", ReportsToEmpId = 93839 },
                new Employee { EmpId = 7382927, FirstName = "Tom", LastName = "Paris", ReportsToEmpId = 93839 }
            };

            var mgrs = new Manager[]
            {
                new Manager { EmpId = 93839, FirstName = "Kathryn", LastName = "Janeway", NumberOfDirects = 141 },
                new Manager { EmpId = 43927, FirstName = "Jean-Luc", LastName = "Picard", NumberOfDirects = 1041 }
            };

            var cfrms = new ConfrenceRoom[]
            {
                new ConfrenceRoom { CRId = 1, CRName = "10 Forward", HasProjector = true, NumberOfSeats = 30 },
                new ConfrenceRoom { CRId = 2, CRName = "Transporter Room 3", HasProjector = true, NumberOfSeats = 15 },
                new ConfrenceRoom { CRId = 3, CRName = "Sick Bay", HasProjector = false, NumberOfSeats = 5 }
            };

            return new object[] { emps, mgrs, cfrms };


        }
    }

}
