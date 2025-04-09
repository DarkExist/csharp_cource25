using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cource25
{
    public static class ProcProvider
    {
        public static int RootCount(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;

            switch (d)
            {
                case > 0:
                    return 2;
                case 0:
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
