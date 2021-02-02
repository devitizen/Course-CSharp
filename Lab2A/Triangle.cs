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
	/// Class for the shape of triangle
	/// </summary>
	class Triangle : Rectangle
	{
		protected double length3;

		/// <summary>
		/// Constructor. This assigns the Type property.
		/// </summary>
		public Triangle()
		{
			Type = "Triangle";
		}

		/// <summary>
		/// Method to calculate the area of the shape (Heron's formula)
		/// </summary>
		/// <returns>area of the shape</returns>
		public override double CalculateArea()
		{
			double s = (length + length2 + length3) / 2;
			double area = Math.Sqrt(s * (s-length) * (s - length2) * (s - length3));
			return Math.Round(area , 2);
		}

		/// <summary>
		/// Method to prompt the user to enter elements of the shape
		/// </summary>
		public override void SetData()
		{
			base.SetData();
			Console.Write("Enter the length of the 3rd side : ");
			length3 = Convert.ToDouble(Console.ReadLine());
		}

		/// <summary>
		/// Method to display the object
		/// </summary>
		/// <returns>member fields and methods</returns>
		public override string ToString()
		{
			return base.ToString() + $", 3rd side:{length3}";
		}
	}
}
