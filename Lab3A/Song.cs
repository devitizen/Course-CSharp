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
	/// Class for the Song objects. This class inherits from the Media class. 
	/// </summary>
	class Song : Media
	{
		private string Album { get; set; }
		private string Artist { get; set; }

		/// <summary>
		/// Constructor to create the Song objects. This passes two parameters to the parent class.
		/// </summary>
		/// <param name="title">title of media</param>
		/// <param name="year">year of media</param>
		/// <param name="album">album of song</param>
		/// <param name="artist">artist of song</param>
		public Song(string title, int year, string album, string artist) : base(title, year)
		{
			Album = album;
			Artist = artist;
		}

		/// <summary>
		/// Method to display values of properties
		/// </summary>
		/// <returns>values of properties</returns>
		public override string ToString()
		{
			return $"Song Title: {base.Title} ({base.Year})\nAlbum: {Album}   Artist: {Artist}";
		}
	}
}
