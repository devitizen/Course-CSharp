/// Jonghwan Lee, 000811948
/// Sep 24, 2020
/// Lab Assignment 1 (Fall 2020)
/// 
/// I, Jonghwan Lee, 000811948 certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
using System;
using System.IO;

namespace Lab1
{
	/// <summary>
	/// This class is the main class in the application and controls the flow of the whole application.
	/// </summary>	
	class Program
	{
		/// <summary>
		/// Main method of the class and starting point for this application. 
		/// This method controls the application by loading data from the file, creating a view and controlling the view.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Employee[] myEmployees = Read();

			if (myEmployees != null)
			{
				EmployeeView employeeView = new EmployeeView(myEmployees);
				employeeView.DisplayData(myEmployees);

				int choice = 0;
				while (choice >= 0 && choice <= 5)
				{
					choice = employeeView.ProcessChoice();
					Employee[] sortedMyEmployees = Sort(myEmployees, choice);
					employeeView.DisplayData(sortedMyEmployees);
				}
			} 
			else
			{
				Console.WriteLine("Exception terminates program. Preass any key to close");
				Console.ReadKey();
			}
		}

		/// <summary>
		/// This is the method to read data from the file and create an array of Employee objects.
		/// This performs checking an exception and an error from user inputs.
		/// </summary>
		/// <returns>an array of Employee objects</returns>
		private static Employee[] Read()
		{
			Employee[] myEmployees = new Employee[100];

			FileStream fs = null;
			StreamReader sr = null;
			int size = 0;

			try
			{
				fs = new FileStream("../../employee.txt", FileMode.Open);
				sr = new StreamReader(fs);

				int count = 0;
				while (!sr.EndOfStream && count < myEmployees.Length)
				{
					//read
					string line = sr.ReadLine();

					//parse
					string[] record = line.Split(',');
					string name = record[0];

					if (int.TryParse(record[1], out int number) == false)
						Console.WriteLine("Failed to parse the number from the file");

					if (decimal.TryParse(record[2], out decimal rate) == false)
						Console.WriteLine("Failed to parse the rate from the file");

					if (double.TryParse(record[3], out double hours) == false)
						Console.WriteLine("Failed to parse the hours from the file");

					//create
					myEmployees[count] = new Employee(name, number, rate, hours);
					count++;
				}
				size = count;
				
			} 
			catch (Exception e)
			{
				Console.WriteLine($"Exception occurs when loading data due to  : {e.Message}");
				return null;
			}
			finally
			{
				if (fs != null)
					fs.Close();
				if (sr != null)
					sr.Close();
			}

			// Remove the null elements at the end of data in the array
			Employee[] myEmployeesData = new Employee[size];
			for(int i = 0; i < size; i++)
			{
				if (myEmployees[i] != null)
					myEmployeesData[i] = myEmployees[i];
			}

			return myEmployeesData;
		}

		/// <summary>
		/// This is the method to sort the data according to the user's choice. 
		/// The order of elements is adjusted as every element is compared to the other elements one by one.
		/// The Insert method is executed to insert an element into a specific position in the array.
		/// </summary>
		/// <param name="myEmployees">array of Employee objects to be sorted</param>
		/// <param name="choice">user's choice on how to sort data</param>
		/// <returns>sorted array of Employee objects</returns>
		private static Employee[] Sort(Employee[] myEmployees, int choice)
		{
			int sizeEmployees = myEmployees.Length;
			Employee[] sortedEmployees = new Employee[sizeEmployees];

			for (int i = 0; i < sizeEmployees; i++)
			{
				for (int j = 0; j < sizeEmployees; j++)
				{
					if (sortedEmployees[j] == null)
					{
						sortedEmployees[j] = myEmployees[i];
						break;
					}
					else
					{
						if ((choice == 1 && string.Compare(sortedEmployees[j].getName(), myEmployees[i].getName()) == 1) ||
							(choice == 2 && sortedEmployees[j].getNumber() > myEmployees[i].getNumber()) ||
							(choice == 3 && sortedEmployees[j].getRate() < myEmployees[i].getRate()) ||
							(choice == 4 && sortedEmployees[j].getHours() < myEmployees[i].getHours()) ||
							(choice == 5 && sortedEmployees[j].getGross() < myEmployees[i].getGross()))
						{
							sortedEmployees = Insert(sortedEmployees, j, myEmployees[i]);
							break;
						}
					}
				}
			}

			return sortedEmployees;
		}

		/// <summary>
		/// This is the method to insert an object of Employee into the specific position in the array.
		/// </summary>
		/// <param name="sortedEmployees">array of Employee objects to be adjusted</param>
		/// <param name="position">position where the object should be located</param>
		/// <param name="employee">object of Employee to be input</param>
		/// <returns>array of Employee objects inserted with new object</returns>
		private static Employee[] Insert (Employee[] sortedEmployees, int position, Employee employee)
		{
			int arraySize = sortedEmployees.Length;
			Employee[] insertedEmployees = new Employee[arraySize];

			for(int i = 0; i < position; i++)
				insertedEmployees[i] = sortedEmployees[i];

			for (int j = position; j < arraySize - 1; j++)
				insertedEmployees[j + 1] = sortedEmployees[j];
				
			insertedEmployees[position] = employee;

			return insertedEmployees;
		}

	}
}
