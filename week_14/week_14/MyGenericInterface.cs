using System;
namespace week_14
{
	public interface MyGenericInterface<T> //GENERIC INTERFACE DEFINITION
	{
		T Report();
		void Insert(T data);
	}
}

