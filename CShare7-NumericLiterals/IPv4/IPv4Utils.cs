using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShare7_NumericLiterals.IPv4
{
    class IPv4Utils
    {
        public enum IPClasses : uint
        {
            A = 0b11111111_00000000_00000000_00000000,
            B = 0b11111111_11111111_00000000_00000000,
            C = 0b11111111_11111111_11111111_00000000
        }

        public IPClasses IPClass { get; set; }  

        public bool IsSameSubnet(uint host1, uint host2, IPClasses IPClass)
        {
            var SubNet1 = host1 & (uint)IPClass;
            var SubNet2 = host2 & (uint)IPClass;

            return SubNet1 == SubNet2;
        }
    }
}
