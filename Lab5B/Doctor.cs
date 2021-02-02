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
	/// Class for the Doctor data
	/// </summary>
	class Doctor
	{
		public int DoctorId { get; private set; }
		public string Actor { get; private set; }
		public int Series { get; private set; }
		public int Age { get; private set; }
		public byte[] Picture { get; private set; }

		/// <summary>
		/// Constructor of Doctor class
		/// </summary>
		/// <param name="doctorId">doctor ID</param>
		/// <param name="actor">actor name</param>
		/// <param name="series">series</param>
		/// <param name="age">age at start</param>
		/// <param name="picture">picture of actor</param>
		public Doctor(int doctorId, string actor, int series, int age, byte[] picture)
		{
			DoctorId = doctorId;
			Actor = actor;
			Series = series;
			Age = age;
			Picture = picture;
		}
	}
}
