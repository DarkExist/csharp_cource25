using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cource25
{
    public static class SeriesProvider
    {
        public static double MeanCalculate(List<double> data)
        {
            return data.Sum() / data.Count;
        }
    }
}
