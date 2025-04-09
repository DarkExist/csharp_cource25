using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp_cource25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_cource25.Tests
{
	[TestClass]
	public class FarenheitToCelsiumConverterTests
	{
		[TestMethod]
		[DataRow(32, 0)]
		[DataRow(50, 10)]
		[DataRow(212, 100)]
		public void ConvertTest(double farenheit, double celsium)
		{
			var result = FarenheitToCelsiumConverter.Convert(farenheit);
			Assert.AreEqual(celsium, result);
		}
	}
}