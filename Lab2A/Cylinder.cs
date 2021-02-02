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

namespace Lab2A
{
	/// <summary>
	/// Class for the shape of cylinder
	/// </summary>
	class Cylinder : Circle
	{
		private double height;

		/// <summary>
		/// Constructor. This assigns the Type property.
		/// </summary>
		public Cylinder()
		{
			Type = "Cylinder";
		}

		/// <summary>
		/// Method to calculate the area of the shape
		/// </summary>
		/// <returns>area of the shape</returns>
		public override double CalculateArea()
		{
			double area = base.CalculateArea() * 2 + 2 * PI * radius * height;
			return Math.Round(area, 2) ;
		}

		/// <summary>
		/// Method to calculate the volume of the shape
		/// </summary>
		/// <returns>volume of the shape</returns>
		public override double CalculateVolume()
		{
			double volume = base.CalculateArea() * height;
			return Math.Round(volume, 2);
		}

		/// <summary>
		/// Method to prompt the user to enter elements of the shape
		/// </summary>
		public override void SetData()
		{
			base.SetData();
			Console.Write("Enter the height : ");
			height = Convert.ToDouble(Console.ReadLine());
		}

		/// <summary>
		/// Method to display the object
		/// </summary>
		/// <returns>member fields and methods</returns>
		public override string ToString()
		{
			return base.ToString() + $", height:{height}";
		}
	}
}
