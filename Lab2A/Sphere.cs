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
	/// Class for the shape of sphere
	/// </summary>
	class Sphere : Circle
	{
		/// <summary>
		/// Constructor. This assigns the Type property.
		/// </summary>
		public Sphere()
		{
			Type = "Sphere";
		}

		/// <summary>
		/// Method to calculate the area of the shape
		/// </summary>
		/// <returns>area of the shape</returns>
		public override double CalculateArea()
		{
			double area = 4 * base.CalculateArea();
			return Math.Round(area, 2);
		}

		/// <summary>
		/// Method to calculate the volume of the shape
		/// </summary>
		/// <returns>volume of the shape</returns>
		public override double CalculateVolume()
		{
			double volume = (4 * PI * Math.Pow(radius, 3)) / 3;
			return Math.Round(volume, 2);
		}

	}
}
