using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_cource25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
using System.Numerics;

namespace csharp_cource25.Tests
{
	[TestClass]
	public class ForProviderTests
	{
		[TestMethod]
		[DynamicData("GetTestData", DynamicDataSourceType.Method)]
		public void SumOfSquaresFromAtoBTest(BigInteger a, BigInteger b, BigInteger expectedResult)
		{
			var result = ForProvider.SumOfSquaresFromAtoB(a, b);
			Assert.AreEqual(result, expectedResult);
		}

		private static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] {new BigInteger(1), new BigInteger(3), new BigInteger(14) };
			yield return new object[] {new BigInteger(1), new BigInteger(4), new BigInteger(30) };
			yield return new object[] {new BigInteger(1), new BigInteger(5), new BigInteger(55) };
			yield return new object[] {new BigInteger(3), new BigInteger(5), new BigInteger(50) };
		}
	}
}