/// Jonghwan Lee, 000811948
/// Sep 24, 2020
/// Lab Assignment 1 (Fall 2020)
/// 
/// I, Jonghwan Lee, 000811948 certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
using System;

namespace Lab1
{
	/// <summary>
	/// This class includes information and methods for a employee.
	/// </summary>	
	class Employee
	{
		private string name;
		private int number;
		private decimal rate;
		private double hours;
		private decimal gross;

		/// <summary>
		/// This is the constructor to create the Employee object.
		/// </summary>
		/// <param name="name">name of employee</param>
		/// <param name="number">employee number</param>
		/// <param name="rate">wage for a hour</param>
		/// <param name="hours">hours worked</param>
		public Employee (string name, int number, decimal rate, double hours)
		{
			this.name = name;
			this.number = number;
			this.rate = rate;
			this.hours = hours;
			if (hours <= 40)
				gross = rate * Convert.ToDecimal(hours);
			else
				gross = rate * 40 + rate * Convert.ToDecimal((hours-40)*1.5);
		}

		/// <summary>
		/// The following five methods are getters for the data, name, number, rate, hours, and gross pay.
		/// </summary>
		public decimal getGross() {	return gross; }
		public double getHours() { return hours; }
		public string getName() { return name; }
		public int getNumber() { return number; }
		public decimal getRate() { return rate; }

		/// <summary>
		/// This is the method of ToString to dispaly the object. 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0,-20}{1,9}{2,9}{3,7}{4,12}", name, number, "$" + Math.Round(rate, 2, MidpointRounding.AwayFromZero),
								  hours.ToString("0.00"), "$" + Math.Round(gross, 2, MidpointRounding.AwayFromZero));
		}
			
		/// <summary>
		/// The following four methods are setters for the data, name, number, rate, and hours.
		/// </summary>
		/// <param name="hours"></param>
		public void setHours(double hours) { this.hours = hours; }
		public void setNames(string name) { this.name = name; }
		public void setNumber(int number) { this.number = number; }
		public void setRate(decimal rate) { this.rate = rate; }

	}
}
