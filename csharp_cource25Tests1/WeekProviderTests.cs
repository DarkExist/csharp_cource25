using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_cource25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace csharp_cource25.Tests
{
	[TestClass]
	public class WeekProviderTests
	{
		[TestMethod]
		[DynamicData("GetTestData", DynamicDataSourceType.Method)]
		public void DayOfWeekByNumberTest(int dayNumber, string expectedDay)
		{
			Assert.AreEqual(WeekProvider.DayOfWeekByNumber(dayNumber), expectedDay);
		}

		private static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { 1, "Monday" };
			yield return new object[] { 7, "Sunday" };
			yield return new object[] { 5, "Friday" };
		}
	}
}