using System;
namespace Week_6
{
	public static class Utilities // if class is static, than all the methods and attributes must be static.
	{
		// Extension method
		public static int Negate(this int n)
		{
			return n * -1;
		}
	}
}

