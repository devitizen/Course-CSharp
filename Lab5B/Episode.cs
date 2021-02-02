/// Jonghwan Lee, 000811948
/// Dec 10, 2020
/// 
/// Lab Assignment 5 (Fall 2020)
/// 
/// I, Jonghwan Lee (000811948), certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5B
{
	/// <summary>
	/// Class for the Episode data
	/// </summary>
	class Episode
	{
		public string StoryId { get; private set; }
		public int SeasonYear { get; private set; }
		public string Title { get; private set; }

		/// <summary>
		/// Constructor of Episode class
		/// </summary>
		/// <param name="storyId">story id</param>
		/// <param name="seasonYear">year of season</param>
		/// <param name="title">title</param>
		public Episode(string storyId, int seasonYear, string title)
		{
			StoryId = storyId;
			SeasonYear = seasonYear;
			Title = title;
		}
	}
}
