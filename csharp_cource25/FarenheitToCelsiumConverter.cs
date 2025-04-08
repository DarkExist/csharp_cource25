using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cource25
{
    public static class FarenheitToCelsiumConverter
    {
        public static double Convert(double farenheitValue)
        {
			return Math.Round((farenheitValue - 32) * (5.0 / 9), 4);
        }
    }
}
