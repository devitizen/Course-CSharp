/// Jonghwan Lee, 000811948
/// Oct 11, 2020
/// 
/// Lab Assignment 2 (Fall 2020)
/// 
/// I, Jonghwan Lee, 000811948 certify that this material is my original work.  
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

namespace Lab2B
{
	/// <summary>
	/// This class is for the form of the calculation for a hair salon.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// This method is for the event of clicking the Calculation button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void calculateBtn_Click(object sender, EventArgs e)
		{
			// Base rate
			decimal baseRate = 0;
			if (janeRB.Checked)
				baseRate = 30;
			else if (patRB.Checked)
				baseRate = 45;
			else if (ronRB.Checked)
				baseRate = 40;
			else if (sueRB.Checked)
				baseRate = 50;
			else if (lauraRB.Checked)
				baseRate = 55;

			// Services rate
			decimal service = 0;
			if (cutCB.Checked)
				service += 30;
			if (colourCB.Checked)
				service += 40;
			if (highlightsCB.Checked)
				service += 50;
			if (extensionsCB.Checked)
				service += 200;

			// Discount rate
			decimal discount = 0;
			if (childRB.Checked)
				discount = 10;
			else if (studentRB.Checked)
				discount = 5;
			else if (seniorRB.Checked)
				discount = 15;

			// Additional discount rate
			decimal addDiscount = 0;
			if (int.TryParse(numClientVisitTB.Text, out int numVisits))
			{
				if (numVisits >= 4 && numVisits <= 8)
					addDiscount = 5;
				else if (numVisits >= 9 && numVisits <= 13)
					addDiscount = 10;
				else if (numVisits >= 14)
					addDiscount = 15;
			}
			else 
				numClientVisitTB.Focus();

			// Total price
			if (service <= 0)
			{
				string message = "You must select at least one service.";
				string title = "Missing Service";
				MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			else if (numVisits <= 0)
			{
				numClientVisitTB.Focus();
				string message = "Number of Visits must be an integer greater than 0.";
				string title = "Incorrect Value";
				MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				decimal total = (baseRate + service) * (100 - (discount + addDiscount)) / 100;
				totalPriceLbl.Text = total.ToString("C");
			}

		}

		/// <summary>
		/// This method is for the event of clicking the Clear button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void clearBtn_Click(object sender, EventArgs e)
		{
			janeRB.Checked = true;
			cutCB.Checked = false;
			colourCB.Checked = false;
			highlightsCB.Checked = false;
			extensionsCB.Checked = false;
			standardRB.Checked = true;
			numClientVisitTB.Clear();
		}

		/// <summary>
		/// This method is for the event of clicking the Exit button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
