using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharp7_PatternMatching.BizDomain;
namespace CSharp7_PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            var TheCompany = new TheCompany().Build();
            Demo00(TheCompany);
        }

        static void Demo00(object[] TheCompany)
        {
            

            foreach(var thing in TheCompany)
            {
                switch (thing)
                {
                    
                }
            }
        }
    }
}
