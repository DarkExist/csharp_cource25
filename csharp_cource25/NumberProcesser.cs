using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cource25
{
    public static class NumberProcesser
    {
        public static BigInteger SumOfTwo( BigInteger[] numbers )
        {
            Array.Sort(numbers);
            return numbers[^1] + numbers[^2];
        }
    }
}
