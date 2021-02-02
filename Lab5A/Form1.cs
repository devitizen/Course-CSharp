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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5A
{
	public partial class Form1 : Form
	{
		private Graphics g;
		private Color c = Color.SkyBlue;
		int fRate = 0;
		int fLength = 200;
		int bHeight = 0;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Event handler to paint panel 
		/// To draw the bucket 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DrawingPanel_Paint(object sender, PaintEventArgs e)
		{
			g = drawingPanel.CreateGraphics();
			g.DrawLine(new Pen(Color.White), 99, 91, 99, 201);
			g.DrawLine(new Pen(Color.White), 99, 201, 300, 201);
			g.DrawLine(new Pen(Color.White), 300, 201, 300, 91);
		}

		/// <summary>
		/// Event handler to click the Color button
		/// To choose the water color
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void colourBtn_Click(object sender, EventArgs e)
		{
			colorChooserCdl.Color = c;
			colorChooserCdl.ShowDialog();
			c = colorChooserCdl.Color;
		}

		/// <summary>
		/// Event handler to scroll the Track bar
		/// To set the water speed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void controlTrb_Scroll(object sender, EventArgs e)
		{
			// adjust the speed along with timer's inverval
			fRate = (int)Math.Floor((decimal)(controlTrb.Value / 5)) + 1;

			if (controlTrb.Value == 0)
				closeFaucet();
			else
			{
				if(bHeight  >= 100)
					initialize();
				openFaucet();
			}
		}

		/// <summary>
		/// Method to handle the case the faucet opens
		/// </summary>
		/// <param name="fLength"></param>
		private void openFaucet()
		{
			fTimer.Enabled = true;
			fTimer_Tick(null, null);

			bTimer.Enabled = true;
			bTimer_Tick(null, null);
		}

		/// <summary>
		/// Event handler of Timer
		/// This controls the shape and color of water from the faucet.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fTimer_Tick(object sender, EventArgs e)
		{
			g.FillRectangle(new SolidBrush(c), 110, 0, 17, fLength);
		}

		/// <summary>
		/// Event handler of Timer
		/// This controls the shape and color of water in the bucket.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bTimer_Tick(object sender, EventArgs e)
		{
			if (bHeight < 100)
			{
				bHeight += fRate;
				fLength = 200 - bHeight;
				g.FillRectangle(new SolidBrush(c), 100, fLength, 200, fRate);
			}
			else
				closeFaucet();
		}

		/// <summary>
		/// Method to handle when the faucet closes
		/// </summary>
		/// <param name="fLength"></param>
		private void closeFaucet()
		{
			fTimer.Enabled = false;
			bTimer.Enabled = false;
			g.FillRectangle(new SolidBrush(Color.Black), 110, 0, 17, fLength);
			controlTrb.Value = 0;
		}

		/// <summary>
		/// Method to initilize the panel
		/// </summary>
		private void initialize()
		{
			g.FillRectangle(new SolidBrush(Color.Black), 100, 0, 200, 200);
			fLength = 200;
			bHeight = 0;
		}

		/// <summary>
		/// Event handler to close the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void closeBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
