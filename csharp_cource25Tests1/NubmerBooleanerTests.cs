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
	public class NubmerBooleanerTests
	{
		[TestMethod]
		[DynamicData("GetTestData", DynamicDataSourceType.Method)]
		public void IsAandBOddTest(BigInteger a, BigInteger b, bool expectedResult)
		{
			Assert.AreEqual(NubmerBooleaner.IsAandBOdd(a, b), expectedResult);
		}

		private static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { new BigInteger(1), new BigInteger(3), true };
			yield return new object[] { new BigInteger(22), new BigInteger(44), false };
			yield return new object[] { new BigInteger(12), new BigInteger(53), false };
			yield return new object[] { new BigInteger(35), new BigInteger(22), false };
		}
	}
}