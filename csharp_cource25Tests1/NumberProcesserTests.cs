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
	public class NumberProcesserTests
	{
		[TestMethod]
		[DynamicData("GetTestData", DynamicDataSourceType.Method)]
		public void SumOfTwoTest(List<BigInteger> data, BigInteger expectedResult)
		{
			Assert.AreEqual(NumberProcesser.SumOfTwo(data.ToArray()), expectedResult);
		}

		private static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { new List<BigInteger>() {123, 22, -10}, new BigInteger(145) };
			yield return new object[] { new List<BigInteger>() { 55, 72, 10 }, new BigInteger(127) };
			yield return new object[] { new List<BigInteger>() { -40, -10, -250 }, new BigInteger(-50) };
		}
	}
}