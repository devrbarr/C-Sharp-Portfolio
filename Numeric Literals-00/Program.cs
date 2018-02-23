using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Numeric_Literals_00
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = 456483738923729273;
            var num2 = 456_483_738_923_729_273;

            var b1 = 0b0001010;
            var b2 = 0b10101000;

            var host1 = 0b11111111_00000000_00000000_00001010;
            var host2 = 0b11111111_10101000_00000000_00000101;


            WriteLine($"old way: {num1} \nnew way: {num2} ");
            WriteLine("\n");
            WriteLine($"b1 to base 10: { (int)b1 } \nb2 to base 10: {(int)b2}");
            WriteLine("\n");
            WriteLine($"These two hosts are { (new IPFun().SameSubnet(host1, host2, IPFun.IPv4Class.C) ? "on" : "not")} the same subnet.");
            ReadLine();
            
        }
    }

    public class IPFun
    {
        public enum IPv4Class : uint
        {
            A = 0b11111111_00000000_00000000_00000000,
            B = 0b11111111_11111111_00000000_00000000,
            C = 0b11111111_11111111_11111111_00000000

        }

        public bool SameSubnet(uint host1, uint host2, IPv4Class IPv4Class)
        {
            var subnet1 = host1 & (uint)IPv4Class;
            var subnet2 = host2 & (uint)IPv4Class;

            return subnet1 == subnet2;
        }
    }
}
