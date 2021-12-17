using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
	public class OperationsTests
	{
		[Test]
		public void max_NormalArray_returnmaximus()
		{
			List<int> array = new List<int>();
			array.Add(3);
			array.Add(1);
			array.Add(-5);
			array.Add(-10);
			array.Add(5);

			int output = Operations.Max(array);

			Assert.AreEqual(5, output);
		}

		[Test]
		public void max_EmptyArray_ReturnZero()
		{
			List<int> array = new List<int>();

			int output = Operations.Max(array);

			Assert.AreEqual(0, output);
		}

		[Test]
		public void max_NullArray_ReturnZero()()
		{
			List<int> array = null;

			int output = Operations.Max(array);

			Assert.AreEqual(0, output);
		}
	}
}