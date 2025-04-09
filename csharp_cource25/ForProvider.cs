using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cource25
{
    public static class ForProvider
    {
        public static BigInteger SumOfSquaresFromAtoB(BigInteger a, BigInteger b)
        {
            BigInteger sum = BigInteger.Zero;

            for (BigInteger integer = a; integer <= b; integer++)
            {
                sum += integer * integer;
            }
            return sum;
        }
    }
}
