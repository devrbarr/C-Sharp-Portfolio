using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_00.WhatsNew
{

    /*
        Why? 
            - Makes reading large numeric values easier to read. Useful when working with binary numbers.
        How?
            - Use binary literals ( 0b ) prefix
            - Use the digit separator ( _ underscore ) with decimal, float, float, and long
        Recall:
            - uint
                - System Type: UInt32
                - Size: 32 bits
                - Value Range: 0 to 2^32-1
            -ulong
                - System Type: UInt64
                - Size: 64 bits
                - Value Range: 0 to 2^64-1


    */
    public class _00_Subnet
    {
        public enum IPClass : uint
        {
            A = 0b11111111_00000000_00000000_00000000,
            B = 0b11111111_11111111_00000000_00000000,
            C = 0b11111111_11111111_11111111_00000000

        }

        public uint Host1 {get;set;}
        public uint Host2 { get; set; }
        public IPClass IPClassToTest { get; set; }

        public bool IsSameSubNet()
        {
            var ipclass = (uint)IPClassToTest;
            var Subnet1 = Host1 & ipclass;
            var Subnet2 = Host2 & ipclass;

            return Subnet1 == Subnet2;

        }
    }
}
