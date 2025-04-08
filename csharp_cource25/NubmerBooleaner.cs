using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cource25
{
    public static class NubmerBooleaner
    {
        public static bool IsAandBOdd(BigInteger a, BigInteger b)
        {
            return !a.IsEven && !b.IsEven;
        }
    }
}
