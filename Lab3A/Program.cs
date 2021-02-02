/// Jonghwan Lee, 000811948
/// Oct 29, 2020
/// 
/// Lab Assignment 3 (Fall 2020)
/// 
/// I, Jonghwan Lee, 000811948 certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
	/// <summary>
	/// Main class of the application and controls the flow of the whole application
	/// The methods in this class reads data from the file, shows the menu, 
	/// and displays the data according to the user's selection.
	/// </summary>
	class Program
	{
		/// <summary>
		/// Main method of a starting point for this application 
		/// This method controls the application by creating objects, displaying 
		/// the menu and the result.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Media[] mediaObj = ReadData();

			while(true)
			{
				Console.Clear();
				DisplayMenu();

				int choice = ParseInt(Console.ReadLine());
				Console.WriteLine();

				if (choice == 6)
					break;
				else if (choice >= 1 && choice <= 4)
					DiplayResult(mediaObj, choice);
				else if (choice == 5)
				{
					Console.Write("Enter a search string: ");
					string keyword = Console.ReadLine();
					Console.WriteLine();
					SearchByTitle(mediaObj, keyword);
				}
				else
					Console.WriteLine("*** Invalid Choice - Try Again ***");

				Console.WriteLine();
				Console.WriteLine("Press any key to continue . . .");
				Console.ReadKey();
			}
		}

		/// <summary>
		/// Method to read data from the text file, which has information of three types of media
		/// Book, one of the media, has a summary in the next line, 
		/// and some records have a multiple lines for the summary.
		/// </summary>
		/// <returns>array of Media objects</returns>
		private static Media[] ReadData()
		{
			Media[] mediaObj = new Media[100];
			FileStream fs = null;
			StreamReader sr = null;

			try
			{
				fs = new FileStream("../../Data.txt", FileMode.Open);
				sr = new StreamReader(fs);

				int count = 0;
				string emptyLine = "";
				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					string[] record = line.Split('|');

					if (record[0] == "BOOK")
						mediaObj[count] = new Book(record[1], ParseInt(record[2]), record[3], "");
					else if (record[0] == "MOVIE")
						mediaObj[count] = new Movie(record[1], ParseInt(record[2]), record[3], "");
					else if (record[0] == "SONG")
						mediaObj[count] = new Song(record[1], ParseInt(record[2]), record[3], record[4]);
					else if (record[0] == "")
					{
						emptyLine = "\n\n";
						continue;
					}
					else if (record[0] == "-----")
						continue;
					else
					{
						// Process lines for summary 
						Media m = mediaObj[count - 1];
						if (m is Book bk)
						{
							bk.Summary += emptyLine;
							bk.Summary += record[0];
						}
						else if (m is Movie mv)
						{
							mv.Summary += emptyLine;
							mv.Summary += record[0];
						}
						emptyLine = "";
						continue;
					}
					count++;
				}
			} 
			catch(Exception e)
			{
				Console.WriteLine($"Exception occurs when loading data due to: {e.Message}");
				return null;
			}
			finally
			{
				if (fs != null)
					fs.Close();
				if (sr != null)
					sr.Close();
			}

			return mediaObj;
		}

		/// <summary>
		/// Method to return an integer value converted from the string value
		/// </summary>
		/// <param name="str">string need to be converted</param>
		/// <returns>integer from the string</returns>
		private static int ParseInt(string str)
		{
			if (int.TryParse(str, out int year) == false)
				return 0;

			return year;
		}

		/// <summary>
		/// Method to display the menu of this application
		/// </summary>
		private static void DisplayMenu()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Nick's Media Collection");
			Console.WriteLine("=======================");
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("1. List All Books");
			Console.WriteLine("2. List All Movies");
			Console.WriteLine("3. List All Songs");
			Console.WriteLine("4. List Media");
			Console.WriteLine("5. Search All Media by Title");
			Console.WriteLine();
			Console.WriteLine("6. Exit Program");
			Console.WriteLine();
			Console.Write("Enter choice: ");
		}

		/// <summary>
		/// Method to display the result according to the user's selection
		/// </summary>
		/// <param name="mediaObj">array of the Media objects</param>
		/// <param name="choice">user's selection</param>
		private static void DiplayResult(Media[] mediaObj, int choice)
		{
			foreach(Media m in mediaObj)
			{
				if (m == null)
					break;
				else if ((choice == 1 && m is Book bk) ||
						 (choice == 2 && m is Movie mv) ||
						 (choice == 3 && m is Song sg) ||
						 (choice == 4))
				{
					Console.WriteLine(m);
					Console.WriteLine("--------------------");
				}
			}
		}

		/// <summary>
		/// Method to display the result from matching the keyword entered by user 
		/// to the title of media
		/// </summary>
		/// <param name="mediaObj">array of the Media objects</param>
		/// <param name="keyword">keyword entered by user</param>
		private static void SearchByTitle(Media[] mediaObj, string keyword)
		{
			foreach(Media m in mediaObj)
			{
				if (m == null)
					break;
				else if (m.Search(keyword))
				{
					Console.WriteLine(m);

					// Add summary for books and movies
					if (m is Book bk)
					{
						Console.WriteLine();
						Console.WriteLine(bk.Decrypt());
					} 
					else if(m is Movie mv)
					{
						Console.WriteLine();
						Console.WriteLine(mv.Decrypt());
					}

					Console.WriteLine("--------------------");
				}
			}
		}
	}
}