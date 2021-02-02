/// Jonghwan Lee, 000811948
/// Oct 29, 2020
/// 
/// Lab Assignment 3 (Fall 2020)
/// 
/// I, Jonghwan Lee (000811948), certify that this material is my original work.  
/// No other person's work has been used without due acknowledgement.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{
	/// <summary>
	/// Class to control the form of the application for Perfect Cut Hair Salon.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Method to set the initial status of the component when loading the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			hairdresserCB.SelectedIndex = 0;
		}

		/// <summary>
		/// Method for the event of clicking the "Add Service" button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addServiceBtn_Click(object sender, EventArgs e)
		{
			if(chargedItemsLB.Items.Count == 0)
			{
				string hairdresser = hairdresserCB.SelectedItem.ToString();
				chargedItemsLB.Items.Add(hairdresser);
				priceLB.Items.Add(rateHairdresser(hairdresser).ToString("C"));
				hairdresserCB.Enabled = false;
			}

			string service = serviceLB.SelectedItem.ToString();
			chargedItemsLB.Items.Add(service);
			priceLB.Items.Add(rateService(service).ToString("C"));

			calculateTotalPriceBtn.Enabled = true;
		}

		/// <summary>
		/// Method to set the rate of hairdressers 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		private double rateHairdresser(string name)
		{
			string firstName = name.Substring(0, name.IndexOf(" "));

			double price = 0;
			if (firstName == "Jane")
				price = 30;
			else if (firstName == "Pat")
				price = 45;
			else if (firstName == "Ron")
				price = 40;
			else if (firstName == "Sue")
				price = 50;
			else if (firstName == "Laurie")
				price = 55;

			return price;
		}

		/// <summary>
		/// Method to set the rate of services
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		private double rateService(string item)
		{
			double price = 0;
			if (item == "Cut")
				price = 30;
			else if (item == "Wash, blow-dry, and style")
				price = 20;
			else if (item == "Colour")
				price = 40;
			else if (item == "Highlights")
				price = 50;
			else if (item == "Extension")
				price = 200;
			else if (item == "Up-do")
				price = 60;

			return price;
		}

		/// <summary>
		/// Method for the event of selecting the item in the "Select a Service" list box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void serviceLB_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (serviceLB.SelectedIndex >= 0)
				addServiceBtn.Enabled = true;
		}

		/// <summary>
		/// Method for the event of clicking the "Calculate Total Price" button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void calculateTotalPriceBtn_Click(object sender, EventArgs e)
		{
			double totalPrice = 0;
			foreach(string item in priceLB.Items)
			{
				string price = item.Substring(1);
				totalPrice += Double.Parse(price);
			}

			totalPriceTB.Text = totalPrice.ToString("C");
		}

		/// <summary>
		/// Method for the event of clicking the "Reset" button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void resetBtn_Click(object sender, EventArgs e)
		{
			hairdresserCB.Enabled = true;
			hairdresserCB.SelectedIndex = 0;
			hairdresserCB.Focus();
			serviceLB.SelectedIndex = -1;
			chargedItemsLB.Items.Clear();
			priceLB.Items.Clear();
			totalPriceTB.Text = "";
			addServiceBtn.Enabled = false;
			calculateTotalPriceBtn.Enabled = false;
		}

		/// <summary>
		/// Method for the event of clicking the "Exit" button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
