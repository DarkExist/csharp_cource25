using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cource25
{
    public static class NumberReverser
    {
        public static BigInteger Reverse(BigInteger number)
        {
			char[] charArray = number.ToString().ToCharArray();
			Array.Reverse(charArray);
			return BigInteger.Parse(new string(charArray));
        }
    }
}
