/// Jonghwan Lee, 000811948
/// Dec 10, 2020
/// 
/// Lab Assignment 5 (Fall 2020)
/// 
/// I, Jonghwan Lee (000811948), certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5B
{
	public partial class Form1 : Form
	{
		private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=COMP10204_Lab5;Integrated Security=True";
		private SqlConnection dbCon;

		List<Doctor> doctors = new List<Doctor>();
		List<Companion> companions = new List<Companion>();
		List<Episode> episodes = new List<Episode>();

		int method = 2;
		int selectedId = 0;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Event handler for loading the form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			// Connect database
			try
			{
				dbCon = new SqlConnection(connectionString);
				dbCon.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error opening DB connection due to: {ex.Message}");
			}

			// Create three list arrays by throwing a query to database
			SqlDataReader reader;
			try
			{
				// Create doctor list array
				string commandString = "SELECT * FROM doctor";
				SqlCommand command = new SqlCommand(commandString, dbCon);

				reader = command.ExecuteReader();
				while (reader.Read())
				{
					int doctorId = (int)reader[0];
					string actor = reader[1].ToString();
					int series = (int)reader[2];
					int age = (int)reader[3];
					//string debut = reader[4].ToString();
					byte[] picture = (byte[])reader[5];

					Doctor doctor = new Doctor(doctorId, actor, series, age, picture);
					doctors.Add(doctor);
					doctorCB.Items.Add(doctor.DoctorId);
				}
				reader.Close();

				// Create companion list array
				commandString = "SELECT * FROM companion";
				command = new SqlCommand(commandString, dbCon);

				reader = command.ExecuteReader();
				while (reader.Read())
				{
					string name = reader[0].ToString();
					string actor = reader[1].ToString();
					int doctorId = (int)reader[2];
					string storyId = reader[3].ToString();

					Companion companion = new Companion(name, actor, doctorId, storyId);
					companions.Add(companion);
				}
				reader.Close();

				// Create episode list array
				commandString = "SELECT * FROM episode";
				command = new SqlCommand(commandString, dbCon);

				reader = command.ExecuteReader();
				while (reader.Read())
				{
					string storyId = reader[0].ToString();
					//int season = (int)reader[1];
					int seasonYear = (int)reader[2];
					string title = reader[3].ToString();

					Episode episode = new Episode(storyId, seasonYear, title);
					episodes.Add(episode);
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error creating List Array due to : {ex.Message}");
			}

			doctorCB.SelectedIndex = 0;
			DisplayDoctor(0);
		}

		/// <summary>
		/// Event handler for seleting a doctor in the combo box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void doctorCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			DisplayDoctor(doctorCB.SelectedIndex);
		}

		private void DisplayDoctor(int index)
		{
			selectedId = doctors[index].DoctorId;
			MatchCompanions();

			playedTB.Text = doctors[index].Actor;
			seriesTB.Text = doctors[index].Series.ToString();
			ageTB.Text = doctors[index].Age.ToString();

			byte[] photo = doctors[index].Picture;
			MemoryStream stream = new MemoryStream(photo);
			Image image = Image.FromStream(stream);
			doctorPictureBox.Image = Image.FromStream(stream);
		}

		/// <summary>
		/// Method to retrieve companion data from the database
		/// This is done by using SQL and using LINQ
		/// </summary>
		private void MatchCompanions()
		{
			compLB.Items.Clear();
			yearTB.Text = "";
			episodeTB.Text = "";

			// Solve using SQL
			if (method == 1)  
			{
				SqlDataReader reader;
				try
				{
					string commandString = "SELECT companion.name, companion.actor, companion.storyid, episode.seasonyear, episode.title "
											+ "FROM companion "
											+ "JOIN episode ON companion.storyid = episode.storyid "
											+ "WHERE doctorid = @id ORDER BY episode.seasonyear, episode.storyid ";
					SqlCommand command = new SqlCommand(commandString, dbCon);

					SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
					param.Value = selectedId;
					command.Parameters.Add(param);

					reader = command.ExecuteReader();
					while (reader.Read())
					{
						string name = reader["name"].ToString();
						string actor = reader["actor"].ToString();
						string storyId = reader["storyid"].ToString();
						int seasonYear = (int)reader["seasonyear"];
						string title = reader["title"].ToString();

						compLB.Items.Add($"{name} ({actor})");
						compLB.Items.Add($"\"{title}\" ({seasonYear})");
						compLB.Items.Add("\r\n");
					}
					reader.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error creating List Array due to : {ex.Message}");
				}
			}
			// Solve using LINQ
			else
			{
				//var linqComp = companions
				//						 .Where(companion => companion.DoctorId == selectedId)
				//						 .Join(episodes,
				//								companion => companion.StoryId,
				//								episode => episode.StoryId,
				//								(companion, episode) => new {
				//									Name = companion.Name,
				//									Actor = companion.Actor,
				//									SeasonYear = episode.SeasonYear,
				//									Title = episode.Title,
				//									StoryId = episode.StoryId
				//								})
				//						 .OrderBy(episode => (episode.SeasonYear, episode.StoryId));

				var linqComp = from c in companions
							   join e in episodes
							   on c.StoryId equals e.StoryId
							   where c.DoctorId == selectedId
							   orderby e.SeasonYear, e.StoryId
							   select new
							   {
								   Name = c.Name,
								   Actor = c.Actor,
								   SeasonYear = e.SeasonYear,
								   Title = e.Title
							   };

				foreach(var comp in linqComp)
				{
					compLB.Items.Add($"{comp.Name} ({comp.Actor})");
					compLB.Items.Add($"\"{comp.Title}\" ({comp.SeasonYear})");
					compLB.Items.Add("\r\n");
				}
			}

			string fItem = compLB.Items[1].ToString();
			episodeTB.Text = fItem.Substring(1, fItem.Length - 9);
			yearTB.Text = fItem.Substring(fItem.LastIndexOf("(") + 1, 4);
		}

		/// <summary>
		/// Event handler for selecting SQL
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void sqlRB_CheckedChanged(object sender, EventArgs e)
		{
			if (sqlRB.Checked)
				method = 1;
			MatchCompanions();
		}

		/// <summary>
		/// Event handler for selecting LINQ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void linqRB_CheckedChanged(object sender, EventArgs e)
		{
			if (linqRB.Checked)
				method = 2;
			MatchCompanions();
		}

		/// <summary>
		/// Method to exit from the applicatino
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitFileMenu_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
