using System;
namespace week_13
{
	public class Coordinate<T> where T:IComparable<T> // GENERIC Class (T harfi gördüğü yere istenilen data type'i yazar.)
	{ // where T:IComparable ==>> Bu generic class'ta kullanılacak T türünün mutlaka IComparable interfacesini implement etmiş olması gerekmektedir.
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }
    }
}

