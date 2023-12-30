using System;
namespace week_12
{
	public class Product:IReport
	{
		public string ProductName { get; set; }

		private float _productPrice;
		public float ProductPrice
		{
			get { return this._productPrice; }
			set
			{
				this._productPrice = value;
			}
		}

		public Product(string productName, float productPrice)
		{
			this.ProductName = productName;
			this.ProductPrice = productPrice;
		}

		public string Report()
		{
            return $"Product Name: {this.ProductName}, Product Price: {this.ProductPrice}";
        }
	}
}

