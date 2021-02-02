/// Jonghwan Lee, 000811948
/// Oct 11, 2020
/// 
/// Lab Assignment 2 (Fall 2020)
/// 
/// I, Jonghwan Lee, 000811948 certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace Lab2A
{
	/// <summary>
	/// Main class of the application and controls the flow of the whole application
	/// </summary>	
	class Program
	{
		/// <summary>
		/// Main method of the class and a starting point for this application 
		/// This method controls the application by adding objects, displaying the menu, and displaying the result.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			DisplayMenu();
			List<Shape> shapes = new List<Shape>();

			while (true)
			{
				try
				{
					int choice = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine();

					if (choice == 0)
						break;
					else if (choice > 0 && choice < 11)
						AddShapes(shapes, choice);
					else
						Console.WriteLine("Invalid choice. Please enter 0 to 10.");

				} catch (Exception e)
				{
					Console.WriteLine();
					Console.WriteLine(e.Message);
					Console.WriteLine("Please enter a number.");
				}

				DisplayMenu();
			}

			DisplayResult(shapes);
			Console.WriteLine("Press any key to quit.");
			Console.ReadKey();
		}

		/// <summary>
		/// Method to create the objects for shapes with the selection of users
		/// </summary>
		/// <param name="shapes">List array for the object of Shape</param>
		/// <param name="choice">User's selection from the menu</param>
		private static void AddShapes(List<Shape> shapes, int choice)
		{
			if (choice == 1)
				shapes.Add(new Rectangle());
			else if (choice == 2)
				shapes.Add(new Square());
			else if (choice == 3)
				shapes.Add(new Box());
			else if (choice == 4)
				shapes.Add(new Cube());
			else if (choice == 5)
				shapes.Add(new Ellipse());
			else if (choice == 6)
				shapes.Add(new Circle());
			else if (choice == 7)
				shapes.Add(new Cylinder());
			else if (choice == 8)
				shapes.Add(new Sphere());
			else if (choice == 9)
				shapes.Add(new Triangle());
			else if (choice == 10)
				shapes.Add(new Tetrahedron());
		}

		/// <summary>
		/// Method to display the result of creating objects, including the titles
		/// </summary>
		/// <param name="shapes">List array for the object of Shape</param>
		public static void DisplayResult(List<Shape> shapes)
		{
			Console.Clear();
			Console.WriteLine($"There are {Shape.GetCount()} shapes : ");
			Console.WriteLine();
			Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,0}", "Shape", "Area", "Volume", "Details");
			Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,0}", 
				              "=============", "=============", "=============", "=========================");

			foreach (Shape s in shapes)
				Console.WriteLine(s.ToString());

			Console.WriteLine();
		}

		/// <summary>
		/// Method to display the menu
		/// </summary>
		private static void DisplayMenu()
		{
			Console.WriteLine("===================");
			Console.WriteLine("1. Rectangle");
			Console.WriteLine("2. Square");
			Console.WriteLine("3. Box");
			Console.WriteLine("4. Cube");
			Console.WriteLine("5. Ellipse");
			Console.WriteLine("6. Circle");
			Console.WriteLine("7. Cylinder");
			Console.WriteLine("8. Sphere");
			Console.WriteLine("9. Triangle");
			Console.WriteLine("10. Tetrahedron");
			Console.WriteLine("===================");
			Console.Write("Enter choice (0 to display the result and exit): ");
		}
	}
}
