using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Pattern_Matching___00
{
    class Program
    {
        static void Main(string[] args)
        {
            //00: that's easy, they're all ints :: object[] stuff = { 1, 5, 7, 9 };
            //01: A good mix of stuff
            //object[] stuff = { 5, 0b11111111_11111111_000000000_00000000, false, "some text", 101, 7, false, new StringBuilder() };
            //02: A better mix of stuff
            object[] stuff = { 5, 0b11111111_11111111_000000000_00000000, new object[] { 99,991, "string 1", "string 2", 992, new object[] {1_000,1_001, 1_002 }, 993}, false, "some text", 101, 7, false, new StringBuilder() };
            //PatternMatching00(stuff);
            PatternMatching01(stuff);
            ReadLine();
        }

        // 00: public static void PatternMatching00(object[] stuff)
        public static void PatternMatching00(IEnumerable<object> stuff)
        {
            foreach(var thing in stuff)
            {
                //old style
                //if(thing is int)
                //{
                //    var newThing = (int)thing; // or var newThing = thing as int
                //    Console.WriteLine($"{newThing} is an int.");
                //}

                // Using Pattern Matching and the imporved *is* expression
                if(thing is int i)
                {
                    WriteLine($"{i} is an int");
                }else if(thing is IEnumerable<object> moreStuff)
                {
                    PatternMatching00(moreStuff);
                }
            }
        }

        public static void PatternMatching01(IEnumerable<object> stuff)
        {
            foreach(var thing in stuff)
            {
                switch (thing)
                {
                    case int i when i >= 1_000:
                        WriteLine($"{i} is >= than 1,000");
                        break;
                    case int i:
                        WriteLine($"{i} is an int");
                        break;
                    case string s:
                        WriteLine($"\"{s}\" is a string");
                        break;
                    case IEnumerable<object> additionalStuff when additionalStuff.Any():
                        PatternMatching01(additionalStuff);
                        break;
                    case null:
                        throw new ArgumentNullException();
                    default:
                        //throw new InvalidOperationException("Err! What the heck!?");
                        break;
                }
            }
        }
    }
}
