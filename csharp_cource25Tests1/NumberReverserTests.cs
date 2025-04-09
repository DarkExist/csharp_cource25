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
	public class NumberReverserTests
	{
		[TestMethod]
		[DynamicData("GetTestData", DynamicDataSourceType.Method)]
		public void ReverseTest(BigInteger a, BigInteger expectedResult)
		{
			Assert.AreEqual(expectedResult, NumberReverser.Reverse(a));
		}

		private static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { new BigInteger(1), new BigInteger(1) };
			yield return new object[] { new BigInteger(1256), new BigInteger(6521) };
			yield return new object[] { new BigInteger(3333), new BigInteger(3333) };
			yield return new object[] { new BigInteger(10900), new BigInteger(901) };
		}
	}
}