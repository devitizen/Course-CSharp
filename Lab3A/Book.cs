/// Jonghwan Lee, 000811948
/// Oct 29, 2020
/// 
/// Lab Assignment 3 (Fall 2020)
/// 
/// I, Jonghwan Lee, 000811948 certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
	/// <summary>
	/// Class for the Book objects. This class inherits from the Media class 
	/// and implements IEncryptable interface.
	/// </summary>
	class Book : Media, IEncryptable
	{
		private string Author { get; set; }
		internal string Summary { get; set; }

		/// <summary>
		/// Constructor to create the Book objects. This passes two parameters to the parent class.
		/// </summary>
		/// <param name="title">title of media</param>
		/// <param name="year">year of media</param>
		/// <param name="author">author of book</param>
		/// <param name="summary">summary of book</param>
		public Book(string title, int year, string author, string summary) : base(title, year)
		{
			Author = author;
			Summary = summary;
		}

		/// <summary>
		/// Method to call the algorithm for encryption
		/// </summary>
		/// <returns>encrypted text</returns>
		public string Encrypt()
		{
			return ProcessSummary();
		}

		/// <summary>
		/// Method to call the algorithm for decryption
		/// </summary>
		/// <returns>decrypted text</returns>
		public string Decrypt()
		{
			return ProcessSummary();
		}

		/// <summary>
		/// Method to encrypt and decrypt a text. A simple Rot13 algorithm is used.
		/// </summary>
		/// <returns>encrypted or decrypted text</returns>
		public string ProcessSummary()
		{
			string keyword = "";
			string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			for (int i = 0; i < Summary.Length; i++)
			{
				int position = alphabet.IndexOf(Summary[i]);
				if (position < 0)
					keyword += Summary[i];
				else if (position <= 12 || position >= 26 && position <= 38)
					keyword += alphabet[position + 13];
				else
					keyword += alphabet[position - 13];
			}

			return keyword;
		}

		/// <summary>
		/// Method to display values of properties
		/// </summary>
		/// <returns>values of properties</returns>
		public override string ToString()
		{
			return $"Book Title: {base.Title} ({base.Year})\nAuthor: {Author}";
		}
	}
}
