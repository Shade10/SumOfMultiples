using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_multiples
{
    public class SumOfMultiples
    {
        public static int To(int[] factors, int limit)
        {
            return Enumerable
                .Range(0, limit)
                .Aggregate(0, (sum, n) =>
                    factors.Any((m) => n % m == 0) ? sum + n : sum);
        }
    }
}