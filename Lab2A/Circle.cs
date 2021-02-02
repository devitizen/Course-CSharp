/// Jonghwan Lee, 000811948
/// Oct 11, 2020
/// 
/// Lab Assignment 2 (Fall 2020)
/// 
/// I, Jonghwan Lee, 000811948 certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace Lab2A
{
	/// <summary>
	/// Class for the shape of circle
	/// </summary>
	class Circle : Shape
	{
		protected double radius;

		/// <summary>
		/// Constructor. This assigns the Type property.
		/// </summary>
		public Circle()
		{
			Type = "Circle";
			SetData();
		}

		/// <summary>
		/// Method to calculate the area of the shape
		/// </summary>
		/// <returns>area of the shape</returns>
		public override double CalculateArea()
		{
			double area = PI * Math.Pow(radius, 2);
			return Math.Round(area , 2);
		}

		/// <summary>
		/// 2D-shape doesn't have a volume. 
		/// This implements the abstract method of the parent class.
		/// </summary>
		/// <returns>0</returns>
		public override double CalculateVolume()
		{
			return 0;
		}

		/// <summary>
		/// Method to prompt the user to enter elements of the shape
		/// </summary>
		public override void SetData()
		{
			Console.Write("Enter the radius : ");
			radius = Convert.ToDouble(Console.ReadLine());
		}

		/// <summary>
		/// Method to display the object
		/// </summary>
		/// <returns>member fields and methods</returns>
		public override string ToString()
		{
			return string.Format("{0,-13}{1,15:N}{2,15:N}{3}",
								 Type, CalculateArea(), CalculateVolume(), $"  radius:{radius}");
		}
	}
}
