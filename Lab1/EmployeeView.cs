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
	/// This class is for the view of the application.
	/// </summary>
	class EmployeeView
	{
		private Employee[] employees;

		/// <summary>
		/// This is the constructor to create the EmployeeView object.
		/// </summary>
		/// <param name="employees">an array of Employee objects</param>
		public EmployeeView(Employee[] employees)
		{
			this.employees = employees;
		}

		/// <summary>
		/// This is the method to get user's selection from the menu of the application.
		/// </summary>
		/// <returns>user's selection : 1 to 6 is a valid range</returns>
		public int ProcessChoice()
		{
			DisplayMenu();
			string input = Console.ReadLine();
			Console.Clear();

			int choice = 0;
			if ( (int.TryParse(input, out int parsedInput) == false) || parsedInput < 1 || parsedInput > 6 )
				Console.Write("\nInvalid input. Please enter a valid number between 1 and 6. \n");
			else if (parsedInput >= 1 && parsedInput <= 6)
				choice = parsedInput;

			return choice;
		}

		/// <summary>
		/// This is the method to display the menu that enables user to select the way to sort the data.
		/// </summary>
		public void DisplayMenu()
		{
			Console.WriteLine("");
			Console.WriteLine("1. Sort by Employee Name");
			Console.WriteLine("2. Sort by Employee Number");
			Console.WriteLine("3. Sort by Employee Pay Rate");
			Console.WriteLine("4. Sort by Employee Hours");
			Console.WriteLine("5. Sort by Employee Gross Pay");
			Console.WriteLine("");
			Console.WriteLine("6. Exit");
			Console.WriteLine("");
			Console.Write("Enter choice : ");
		}

		/// <summary>
		/// This is the method to display the data processed with a header of data names. 
		/// </summary>
		/// <param name="employees">data to be shown, an array of Employee objects</param>
		public void DisplayData(Employee[] employees)
		{
			Console.WriteLine("");
			Console.WriteLine(string.Format("{0,-20}{1,9}{2,9}{3,7}{4,12}{5,30}",
								"==================", "======", "======", "=====", "=========", "--------------"));
			Console.WriteLine(string.Format("{0,-20}{1,9}{2,9}{3,7}{4,12}{5,30}", 
								"Employee", "Number", "Rate", "Hours", "Gross Pay", "Nick's Company"));
			Console.WriteLine(string.Format("{0,-20}{1,9}{2,9}{3,7}{4,12}{5,30}", 
								"==================", "======", "======", "=====", "=========", "--------------"));

			foreach(Employee emp in employees)
				Console.WriteLine(emp);
		}

	}
}
