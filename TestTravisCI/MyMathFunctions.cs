namespace TestTravisCI
{
    public static class MyMathFunctions
    {
		public static bool IsOdd(this int value)
		{
			return value % 2 == 1;
		}

		public static double Add(this double num1, double num2)
		{
			return num1 + num2;
		}
	}
}
