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
	public class WhileProviderTests
	{
		[TestMethod]
		[DynamicData("GetTestData", DynamicDataSourceType.Method)]
		public void DepositCalculateTest(
			decimal startSum,
			decimal percent,
			decimal endSum,
			(int, decimal) expectedResult)
		{
			var result = WhileProvider.DepositCalculate(startSum, percent, endSum);
			Assert.AreEqual(expectedResult, result);
		}

		private static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { 1000M, 8M, 1100M, (2, 1166.4M) };
			yield return new object[] { 500M, 10M, 1050M, (8, 1071.794405M) };
		}
	}
}