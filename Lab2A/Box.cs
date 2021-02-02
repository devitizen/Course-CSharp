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
	/// Class for the shape of box
	/// </summary>
	class Box : Triangle
	{
		/// <summary>
		/// Constructor. This assigns the Type property.
		/// </summary>
		public Box()
		{
			Type = "Box";
		}

		/// <summary>
		/// Method to calculate the area of the shape
		/// </summary>
		/// <returns>area of the shape</returns>
		public override double CalculateArea()
		{
			double area = (length * length2) * 2 + (length * length3) * 2 + (length2 * length3) * 2;
			return Math.Round(area, 2);
		}

		/// <summary>
		/// Method to calculate the volume of the shape
		/// </summary>
		/// <returns>volume of the shape</returns>
		public override double CalculateVolume()
		{
			double volume = length * length2 * length3;
			return Math.Round(volume, 2);
		}
	}
}
