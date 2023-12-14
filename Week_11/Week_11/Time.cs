using System;
namespace Week_11
{
	public class Time
	{
		private int _hours;
		private int _minutes;

		public Time(int hours, int minutes)
		{
			this.Hours = hours;
			this.Minutes = minutes;
		}

		public int Hours
		{
			get { return _hours; }
			set
			{
				if(value < 0)
				{
					this._hours = 0;
				}else if( value > 24)
				{
					this._hours = 24;
				}else
				{
					this._hours = value;
				}
			}
		}

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0)
                {
                    this._minutes = 0;
                }
                else if (value > 60)
                {
                    this._minutes = 60;
                }
                else
                {
                    this._minutes = value;
                }
            } 
        }

		public int TotalMinutes
		{
			get { return this.Hours * 60 + this.Minutes; }
		}

        public override string ToString()
        {
            return $"{this.Hours}:{this.Minutes}";
        }
    }
}

