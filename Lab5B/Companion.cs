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
	/// Class for the Companion data
	/// </summary>
	class Companion
	{
		public string Name { get; private set; }
		public string Actor { get; private set; }
		public int DoctorId { get; private set; }
		public string StoryId { get; private set; }

		/// <summary>
		/// Constructor of Companion class
		/// </summary>
		/// <param name="name">character name</param>
		/// <param name="actor">actor name</param>
		/// <param name="doctorId">doctor id</param>
		/// <param name="storyId">story id</param>
		public Companion(string name, string actor, int doctorId, string storyId)
		{
			Name = name;
			Actor = actor;
			DoctorId = doctorId;
			StoryId = storyId;
		}
	}
}
