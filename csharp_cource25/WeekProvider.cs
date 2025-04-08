using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cource25
{
    public static class WeekProvider
    {
        public static Dictionary<int, string> dayOfWeekDict = new Dictionary<int, string> ()
        {
           {1, "Monday"},
		   {2, "Tuesday"},
		   {3, "Wednesday"},
		   {4, "Thursday"},
		   {5, "Friday"},
		   {6, "Saturday"},
		   {7, "Sunday"}
		};
        public static string DayOfWeekByNumber(int number)
        {
            return dayOfWeekDict[number];
        }
    }
}
