using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharp7_00.WhatsNew;
using CSharp7_00.WhatsNew.PatternMatching;

namespace CSharp7_00
{
    class Program
    {
        static void Main(string[] args)
        {
            // 00 CompareHosts();

            // 01 Pattern Matching: The basics
            //SimplePatternMatching();
            
            // 01.00 Pattern Matching: A practical example
            //PracticalPatternMatching00();

            // 01.01 Pattern Matching: A more practical example
            PracticalPatternMatching01(new TheCompany().BuildTheCompany01());
            Console.ReadLine();
        }


        static void CompareHosts()
        {
            _00_Subnet s = new _00_Subnet();
            s.Host1 = 0b00001010_00000000_00000000_00001011;
            s.Host2 = 0b00001010_00000000_00000000_00011100;
            s.IPClassToTest = _00_Subnet.IPClass.A;

            // String Interplation (c#6)
            Console.WriteLine($"Host1 and Host2 are on the same subnet: { s.IsSameSubNet() }");

            _00_Subnet s1 = new _00_Subnet();
            s1.Host1 = 0b11000000_10101000_00000000_10110011;
            s1.Host2 = 0b11000000_10101000_00000001_00011001;
            s1.IPClassToTest = _00_Subnet.IPClass.C;

            Console.WriteLine($"Host1 and Host2 are on the same subnet: { s1.IsSameSubNet() }");

            Console.ReadLine();
        }

        static void SimplePatternMatching()
        {
            PatternMatchingDemo01 pmd01 = new PatternMatchingDemo01();
            IEnumerable<int> myRole = new int[] { 5, 4, 3, 6, 5, 5, 1 };


            var myRole1 = new object[] { 5, 6, 3, 3, 1, 2, 4, 3, 6 };
            var myRole2 = new object[] { 4, 6, 6, 1, 3, 3, 6, 2, 2 };

            IEnumerable<object> myRoles = new[] { myRole1 };
            IEnumerable<object> myRolesA = new[] { myRole1, myRole2 };



            Console.WriteLine("Total: " + pmd01.SimpleSum(myRole));
            Console.WriteLine("Total: " + pmd01.MoreComplicatedSum00(myRoles));
            Console.WriteLine("Total: " + pmd01.MoreComplicatedSum00(myRolesA));
            Console.ReadLine();
        }

        static void PracticalPatternMatching00()
        {
            IEnumerable<object> MyCompany = new TheCompany().BuildTheCompany00();
            
            foreach (var thing in MyCompany)
            {
                switch (thing)
                {
                    case Manager mgr:
                        mgr.AssignedPositionStatus = (mgr.NumberOfDirects >= 500) ? Employee.PositionStatus.SrExec : Employee.PositionStatus.JrExec;
                        break;
                    case Employee emp:
                        break;
                    case ConfrenceRoom cr:
                        break;
                    case null:
                        break;
                    default:
                        throw new InvalidOperationException("Don't know what this is :-(");

                }
            }

            

        }

        static void PracticalPatternMatching01(IEnumerable<object> TheCompany)
        {
            foreach(var thing in TheCompany)
            {
                switch (thing)
                {
                    case Manager m when m.NumberOfDirects > 100 && m.NumberOfDirects <= 500:
                        m.AssignedPositionStatus = Employee.PositionStatus.JrExec;
                        Console.WriteLine("Jr Exec: " + m.ToString());
                        break;
                    case Manager m when m.NumberOfDirects > 500 && m.NumberOfDirects <= 1500:
                        m.AssignedPositionStatus = Employee.PositionStatus.SrExec;
                        Console.WriteLine("Sr. Exec: " + m.ToString());
                        break;
                    case Employee e:
                        Console.WriteLine($"Team Member: { e.ToString() }");
                        break;
                    case ConfrenceRoom cfrm:
                        Console.WriteLine($"Confrence Room { cfrm.CRName } seats { cfrm.NumberOfSeats }");
                        break;
                    case IEnumerable<object> SubList when SubList.Any():
                        PracticalPatternMatching01(SubList);
                        break;
                    case null:
                        throw new ArgumentNullException();
                        
                    default:
                        throw new InvalidOperationException();
                }
            }

            
        }
    }
}
