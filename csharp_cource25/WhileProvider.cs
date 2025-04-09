using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cource25
{
    public static class WhileProvider
    {
        public static (int, decimal) DepositCalculate(
            decimal startSum,
            decimal percent,
            decimal endSum)
        {
            int k = 0;

            while (endSum > startSum)
            {
                startSum *= 1 + percent / 100;
                k++;
            }
            return (k, startSum);
        }
    }
}
