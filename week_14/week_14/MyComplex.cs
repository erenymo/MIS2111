using System;
namespace week_14
{
	public class MyComplex
	{
		public int Real { get; set; }
		public int Imaginary { get; set; }

		public MyComplex(int real, int imaginary)
		{
			this.Real = real;
			this.Imaginary = imaginary;
		}

        public override string ToString()
        {
            return $"{this.Real} + {this.Imaginary}i";
        }

		// operator overload
		public static MyComplex operator +(MyComplex lhs, MyComplex rhs)
		{
			int r = lhs.Real + rhs.Real;
			int i = lhs.Imaginary + rhs.Imaginary;
			return new MyComplex(r, i);
		}

        public static MyComplex operator -(MyComplex lhs, MyComplex rhs)
        {
            int r = lhs.Real - rhs.Real;
            int i = lhs.Imaginary - rhs.Imaginary;
            return new MyComplex(r, i);
        }

        public static MyComplex operator ++(MyComplex obj)
        {
			obj.Real++;
			return new MyComplex(obj.Real, obj.Imaginary);
        }

		/*
		public static explicit operator int(MyComplex obj) // type casting, mycomplex to int
		{
			return obj.Real;
		}*/

        public static implicit operator int(MyComplex obj) // type casting, mycomplex to int
        {
            return obj.Real;
        }

		// karşılaştırma operatorleri çiftler halinde gelir.
		// (=='i değiştiriyorsan !='i de tanımlamak zorundasın, < tanımlıyorsan >'ü de tanımlamak zorundasın)
		public static bool operator ==(MyComplex lhs, MyComplex rhs)
		{
			return lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary;
		}

        public static bool operator !=(MyComplex lhs, MyComplex rhs)
        {
            return lhs.Real != rhs.Real || lhs.Imaginary != rhs.Imaginary;
        }
    }
}

