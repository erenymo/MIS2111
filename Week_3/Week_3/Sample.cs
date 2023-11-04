using System;
namespace Week_3
{
	// You can not create object from static class
	internal static class Sample
	{

		// const variable's all letters are written in uppercase
		// const variables are immutable.
		// const behaviour like static member
		public const float PI = 3.14f;

		public static float AnotherStaticMember = 5.0f;

        //public int OneMoreMember = 5;

        public static void Report()
        {
			Console.WriteLine("Report from the static class");
        }
    }
}

