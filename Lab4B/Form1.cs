/// Jonghwan Lee, 000811948
/// Nov 21, 2020
/// 
/// Lab Assignment 4 (Fall 2020)
/// 
/// I, Jonghwan Lee (000811948), certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab4B
{
	/// <summary>
	/// Class to control the form of the application 
	/// </summary>
	public partial class Form1 : Form
	{
		private Stack<string> lines;	// stack collection to read a store and store data
		private string fileName;		// file name to be read	

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Method to set initial value when loading form, setting properties of OpenFileDialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "HTML files (*.html)|*.html";
			openFileDialog1.InitialDirectory = Application.StartupPath;
			openFileDialog1.Title = "Select a html file to check";
		}

		/// <summary>
		/// Method for the Load File ment
		/// Display the OpenFileDialog and store a data into Stack collection
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fileLoadfileMenu_Click(object sender, EventArgs e)
		{
			// Initializes ListBox
			resultLB.Items.Clear();

			if (openFileDialog1.ShowDialog() != DialogResult.OK)
				MessageBox.Show("You did not select a file!");
			else
			{
				try
				{
					string path = openFileDialog1.FileName;
					StreamReader sr = File.OpenText(path);
					lines = new Stack<string>();

					while (!sr.EndOfStream)
					{
						string line = sr.ReadLine();
						lines.Push(line);
					}

					if (lines != null)
					{
						fileName = path.Substring(path.LastIndexOf("\\") + 1);
						statusLbl.Text = "Loaded: " + fileName;
						processCheckMenu.Enabled = true;
					}
				} 
				catch(Exception ex)
				{
					Console.WriteLine("Error in reading a file : " + ex.Message); 
				}

			}
		}

		/// <summary>
		/// Method for the Check Tag menu
		/// Extracts tags from the Stack collection, recreates List array for per tag,
		/// and checks if the html file is balanced
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void processCheckMenu_Click(object sender, EventArgs e)
		{
			// Extracts tags only
			List<string> tags = new List<string>();
			tags = ExtractTags(lines);

			// Checks if balanced, and displays result
			Stack<string> openTags = new Stack<string>();
			string tagType = "";            
			string lastTagType = "";
			bool isBalanced = true;
			int indent = 0;
			foreach (string tag in tags)
			{
				// Determines tag type
				if (tag.Contains("img") || tag.Contains("hr") || tag.Contains("br"))
					tagType = "non-container";
				else if (tag.Contains("</"))
				{
					tagType = "closing";
					if (tag.Substring(2) != openTags.Pop().Substring(1))
						isBalanced = false;
				}
				else
				{
					tagType = "opening";
					openTags.Push(tag);
				}

				// Calculates indenting
				if (tagType == "opening" && lastTagType == "opening")
					indent++;
				else if (tagType == "closing" && lastTagType == "closing")
					indent--;

				// Displays result
				string result = $"{new String(' ', indent * 2)}Found {tagType} tag: {tag}";
				resultLB.Items.Add(result);
				lastTagType = tagType;

				// Not balanced
				if (!isBalanced)
					break;
			}

			if (isBalanced)
				statusLbl.Text = fileName + " has balanced tags.";
			else
				statusLbl.Text = fileName + " does not have balanced tags.";
		}

		/// <summary>
		/// Method to extract tags from the initial Stack collection
		/// Makes an array with elements by tags
		/// </summary>
		/// <param name="lines"></param>
		/// <returns></returns>
		private List<string> ExtractTags(Stack<string> lines)
		{
			// Extract tags only
			Stack<string> tagLines = new Stack<string>();
			foreach (string line in lines)
			{
				if (line != "")
				{
					string tagLine = "";
					int tagOpenStatus = 0;      // 0: line starts, 1: tag opens, 2: tag closes
					foreach (char chr in line)
					{
						if (chr == '<')
							tagOpenStatus = 1;

						if (chr == ' ' && tagOpenStatus == 1)
							tagOpenStatus = 2;

						if (tagOpenStatus == 1)
							tagLine += Char.ToLower(chr);

						if (chr == '>')
						{
							if (tagOpenStatus == 2)
								tagLine += Char.ToLower(chr);
							tagOpenStatus = 2;
						}
					}

					tagLines.Push(tagLine);
				}
			}

			// Recreates array with an element per tag
			List<string> tags = new List<string>();
			foreach (string line in tagLines)
			{
				string tag = "";
				foreach (char chr in line)
				{
					tag += chr;
					if (chr == '>')
					{
						tags.Add(tag);
						tag = "";
					}
				}
			}

			return tags;
		}

		/// <summary>
		/// Method for the Exit menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fileExitMenu_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
	
}
