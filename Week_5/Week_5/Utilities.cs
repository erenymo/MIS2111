using System;
namespace Week_5
{
	public static class Utilities
	{
		public static int Add(int a, int b)
		{
			Console.WriteLine("Add with two arguments");
			return a + b;
		}

		// OVERLOADING (same method name)
		public static int Add(int a, int b, int c = 0 /*DEFAULT VALUE*/)
		{
            Console.WriteLine("Add with three arguments");
            return a + b + c;
		}

		/*
		public static int Add(int[] numbers)
		{
            int summary = 0;
			foreach(int i in numbers)
			{
				summary += i;
			}
				return summary;
		}
		*/

		// Method signature = Methodname / argument qty / argument type
		// params keyword (limitsiz sayıda argüman almaya izin verir.)
		public static int Add(params int[] arr)
		{
            int summary = 0;
            foreach (int i in arr)
            {
                summary += i;
            }
            return summary;
        }
    }
}

