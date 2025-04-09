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
	public class SeriesProviderTests
	{
		[TestMethod]
		[DynamicData("GetTestData", DynamicDataSourceType.Method)]
		public void MeanCalculateTest(List<double> data)
		{
			Assert.AreEqual(SeriesProvider.MeanCalculate(data),
				data.Sum() / data.Count);
		}

		private static IEnumerable<object[]> GetTestData()
		{
			yield return new object[] { new List<double>() { 1.33, 2.5, 0.5, -0.9, 6.66, 7.77 } };
			yield return new object[] { new List<double>() { 9.3, 1.555, 3.512, -0.229, 2.656, -4.77 } };
			yield return new object[] { new List<double>() { 0.33, 1.3, 0.55, -0.1, 2.66, -4.3 } };
			yield return new object[] { new List<double>() { 112.4, 2.12415, 125215.5, -786.55, 1112.66, 247.47 } };
		}
	}
}