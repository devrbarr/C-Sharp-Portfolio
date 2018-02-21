using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Tuples01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 00: Tuples as return type
            var b = MakeDude();
            WriteLine(b);

            // 01: More with methods

            int[] scores = { 17, 46, 39, 62, 81, 79, 52, 24 };
            GradingUtils utils = new GradingUtils();
            //var s = ch1.GetAvgAndCount(scores);
            //var (average, count) = ch1.GetAvgAndCount(scores);
            var (average, count, threshold) = utils.GetAvgAndCount(scores, 51);
            //WriteLine($"Avg score as {s.avg } and number of students is {s.count}.");

            //WriteLine($"Avg score as {average} and number of students is {count}.");

            WriteLine($"Avg score as {average} and number of students is {count}. Threshold is 51 and the class is { (threshold ? "below" : "above") } average.");




            ReadLine();
        }

        static (string name, int age) MakeDude() => ("Bob", 37);
    }

    public class GradingUtils
    {
        public (int avg, int count) GetAvgAndCount(int[] scores)
        {
            var returnTuple = (avg: 0, count: 0);
            returnTuple = (returnTuple.avg = scores.Sum() / scores.Count(), returnTuple.count = scores.Count());
            return returnTuple;
        }

        public (int avg, int cnt, bool threshold) GetAvgAndCount(int[] scores, int threshold)
        {

            var info = (avg: 0, count: 0, subAve: true);
            info = (scores.Sum() / scores.Count(), scores.Count(), info.avg.IsBelowAvg(threshold));
            return info;
        }
    }

    public static class ExtensionMethodsRB
    {
        public static bool IsBelowAvg(this int classAvg, int threshold)
        {
            if (classAvg < threshold) return true;
            else return false;
        }
    }

}
