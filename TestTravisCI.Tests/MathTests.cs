
using Xunit;

namespace TestTravisCI.Tests
{
	public class MathTests
	{
		[Fact]
		public void PassingTest()
		{
			Assert.Equal(5, 5);
		}

		[Fact]
		public void PassingTest2()
		{
			Assert.True(true);
		}

		[Theory]
		[InlineData(3)]
		[InlineData(5)]
		[InlineData(7)]
		public void TestIsOdd(int value)
		{
			Assert.True(MyMathFunctions.IsOdd(value));
		}

		[Theory]
		[InlineData(2, 3)]
		[InlineData(23,12)]
		public void TestAdd(double val1, double val2)
		{
			Assert.Equal(val1 + val2, MyMathFunctions.Add(val1, val2));
		}
	}
}
