using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShare7_NumericLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            var host1 = 0b11111111_00000000_00000000_00011010;
            var host2 = 0B11111111_00000000_00000000_00110011;

            IPv4.IPv4Utils util = new IPv4.IPv4Utils();
            Console.WriteLine($"Same Subnet? {util.IsSameSubnet(host1, host2, util.IPClass = IPv4.IPv4Utils.IPClasses.A)}");
            Console.ReadLine();
        }
    }
}
