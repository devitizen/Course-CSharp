/// Jonghwan Lee, 000811948
/// Oct 11, 2020
/// 
/// Lab Assignment 2 (Fall 2020)
/// 
/// I, Jonghwan Lee, 000811948 certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
	/// <summary>
	/// Class for the shape of ellipse
	/// </summary>
	class Ellipse : Circle
	{
		protected double radius2;

		/// <summary>
		/// Constructor. This assigns the Type property.
		/// </summary>
		public Ellipse()
		{
			Type = "Ellipse";
		}

		/// <summary>
		/// Method to calculate the area of the shape
		/// </summary>
		/// <returns>area of the shape</returns>
		public override double CalculateArea()
		{
			double area = PI * radius * radius2;
			return Math.Round(area , 2);
		}

		/// <summary>
		/// Method to prompt the user to enter elements of the shape
		/// </summary>
		public override void SetData()
		{
			base.SetData();
			Console.Write("Enter the second radius : ");
			radius2 = Convert.ToDouble(Console.ReadLine());
		}

		/// <summary>
		/// Method to display the object
		/// </summary>
		/// <returns>member fields and methods</returns>
		public override string ToString()
		{
			return base.ToString() + $", 2nd radius:{radius2}";
		}

	}
}
