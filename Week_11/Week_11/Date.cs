using System;
namespace Week_11
{
	public class Date
	{
		private int _year;
		private int _month;
		private int _day;

		public Date(int year, int month, int day)
		{
			this.Year = year;
			this.Day = day;
			this.Month = month;
		}

        // PROPERTIES   (Remember value keyword while using properties)
        public int Month 
		{
			get { return _month; }
			private set
			{
                if (value >= 1 || value <= 12)
                {
                    this._month = value;
                }

                if (value < 1)
                {
                    this._month = 1;
                }

                if (value > 12)
                {
                    this._month = 12;
                }
            }
		}

		public int Day
		{
			get { return _day; }
			private set
			{
                if (value >= 1 || value <= 31)
                {
                    this._day = value;
                }

                if (value < 1)
                {
                    this._day = 1;
                }

                if (value > 31)
                {
                    this._day = 31;
                }
            }
		}

		public int Year
		{
			get { return _year; }
			private set { this._year = value; }
		}

        // GETTERS AND SETTERS
        /*
		public int GetYear()
		{
			return this._year;
		}

		public void SetYear(int year) {
			this._year = year;
		}

		public int GetMonth()
		{
			return this._month;
		}

		public void SetMonth(int month)
		{
            if (month >= 1 || month <= 12)
            {
                this._month = month;
            }

            if (month < 1)
            {
                this._month = 1;
            }

            if (month > 12)
            {
                this._month = 12;
            }
        }

		public int GetDay()
		{
			return this._day;
		}

		public void SetDay(int day)
		{
			if(day >= 1 || day <= 31)
			{
			this._day = day;
			}

			if(day < 1)
			{
				this._day = 1;
			}

			if(day > 31)
			{
				this._day = 31;
			}
		}
		*/

        public int TotalDays
        {
            get { return (this.Month-1) * 30 + this.Day; }
        }

        public override string ToString()
        {
			 return $"{this.Year}-{this.Month}-{this.Day}";
        }
    }
}

