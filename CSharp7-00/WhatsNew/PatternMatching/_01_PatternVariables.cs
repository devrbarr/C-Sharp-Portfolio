using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_00.WhatsNew.PatternMatching
{
    class _01_PatternVariables
    {
    }

    class PatternMatchingDemo01
    {
        public int SimpleSum(IEnumerable<int> vals)
        {
            return vals.Sum();
        }

        public int MoreComplicatedSum00(IEnumerable<object> o)
        {
            var sum = 0;
            foreach(var item in o)
            {
                // 'is' pattern matching expression
                if(item is int val)
                {
                    sum += val;
                }else if(item is IEnumerable<object> roles)
                {
                    sum += MoreComplicatedSum00(roles);
                }
            }

            return sum;
        }
    }
}
