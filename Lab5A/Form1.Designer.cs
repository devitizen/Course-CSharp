
namespace Lab5A
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.colourBtn = new System.Windows.Forms.Button();
			this.closeBtn = new System.Windows.Forms.Button();
			this.controlTrb = new System.Windows.Forms.TrackBar();
			this.drawingPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.colorChooserCdl = new System.Windows.Forms.ColorDialog();
			this.bTimer = new System.Windows.Forms.Timer(this.components);
			this.fTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.controlTrb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// colourBtn
			// 
			this.colourBtn.Location = new System.Drawing.Point(50, 26);
			this.colourBtn.Name = "colourBtn";
			this.colourBtn.Size = new System.Drawing.Size(75, 23);
			this.colourBtn.TabIndex = 0;
			this.colourBtn.Text = "Colour";
			this.colourBtn.UseVisualStyleBackColor = true;
			this.colourBtn.Click += new System.EventHandler(this.colourBtn_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.Location = new System.Drawing.Point(147, 26);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(75, 23);
			this.closeBtn.TabIndex = 1;
			this.closeBtn.Text = "Close";
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// controlTrb
			// 
			this.controlTrb.Location = new System.Drawing.Point(30, 81);
			this.controlTrb.Name = "controlTrb";
			this.controlTrb.Size = new System.Drawing.Size(104, 45);
			this.controlTrb.TabIndex = 2;
			this.controlTrb.Scroll += new System.EventHandler(this.controlTrb_Scroll);
			// 
			// drawingPanel
			// 
			this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.drawingPanel.Location = new System.Drawing.Point(0, 215);
			this.drawingPanel.Name = "drawingPanel";
			this.drawingPanel.Size = new System.Drawing.Size(329, 219);
			this.drawingPanel.TabIndex = 3;
			this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(40, 150);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 68);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// bTimer
			// 
			this.bTimer.Interval = 50;
			this.bTimer.Tick += new System.EventHandler(this.bTimer_Tick);
			// 
			// fTimer
			// 
			this.fTimer.Tick += new System.EventHandler(this.fTimer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(329, 434);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.drawingPanel);
			this.Controls.Add(this.controlTrb);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.colourBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "A Drop in the Bucket";
			((System.ComponentModel.ISupportInitialize)(this.controlTrb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button colourBtn;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.TrackBar controlTrb;
		private System.Windows.Forms.FlowLayoutPanel drawingPanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ColorDialog colorChooserCdl;
		private System.Windows.Forms.Timer bTimer;
		private System.Windows.Forms.Timer fTimer;
	}
}

