
namespace Lab5B
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.doctorPictureBox = new System.Windows.Forms.PictureBox();
			this.doctorCB = new System.Windows.Forms.ComboBox();
			this.ageTB = new System.Windows.Forms.TextBox();
			this.seriesTB = new System.Windows.Forms.TextBox();
			this.yearTB = new System.Windows.Forms.TextBox();
			this.episodeTB = new System.Windows.Forms.TextBox();
			this.playedTB = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.compLB = new System.Windows.Forms.ListBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.linqRB = new System.Windows.Forms.RadioButton();
			this.sqlRB = new System.Windows.Forms.RadioButton();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(938, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitFileMenu});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitFileMenu
			// 
			this.exitFileMenu.Name = "exitFileMenu";
			this.exitFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitFileMenu.Size = new System.Drawing.Size(180, 22);
			this.exitFileMenu.Text = "Exit";
			this.exitFileMenu.Click += new System.EventHandler(this.exitFileMenu_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.doctorPictureBox);
			this.groupBox1.Controls.Add(this.doctorCB);
			this.groupBox1.Controls.Add(this.ageTB);
			this.groupBox1.Controls.Add(this.seriesTB);
			this.groupBox1.Controls.Add(this.yearTB);
			this.groupBox1.Controls.Add(this.episodeTB);
			this.groupBox1.Controls.Add(this.playedTB);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(377, 401);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "The Doctor";
			// 
			// doctorPictureBox
			// 
			this.doctorPictureBox.Location = new System.Drawing.Point(198, 119);
			this.doctorPictureBox.Name = "doctorPictureBox";
			this.doctorPictureBox.Size = new System.Drawing.Size(158, 201);
			this.doctorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.doctorPictureBox.TabIndex = 4;
			this.doctorPictureBox.TabStop = false;
			// 
			// doctorCB
			// 
			this.doctorCB.BackColor = System.Drawing.SystemColors.Window;
			this.doctorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.doctorCB.FormattingEnabled = true;
			this.doctorCB.Location = new System.Drawing.Point(120, 41);
			this.doctorCB.Name = "doctorCB";
			this.doctorCB.Size = new System.Drawing.Size(236, 28);
			this.doctorCB.TabIndex = 3;
			this.doctorCB.SelectedIndexChanged += new System.EventHandler(this.doctorCB_SelectedIndexChanged);
			// 
			// ageTB
			// 
			this.ageTB.BackColor = System.Drawing.Color.White;
			this.ageTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ageTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ageTB.Enabled = false;
			this.ageTB.ForeColor = System.Drawing.Color.Black;
			this.ageTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.ageTB.Location = new System.Drawing.Point(120, 194);
			this.ageTB.Name = "ageTB";
			this.ageTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ageTB.Size = new System.Drawing.Size(55, 26);
			this.ageTB.TabIndex = 1;
			// 
			// seriesTB
			// 
			this.seriesTB.BackColor = System.Drawing.Color.White;
			this.seriesTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.seriesTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.seriesTB.Enabled = false;
			this.seriesTB.ForeColor = System.Drawing.Color.Black;
			this.seriesTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.seriesTB.Location = new System.Drawing.Point(120, 155);
			this.seriesTB.Name = "seriesTB";
			this.seriesTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.seriesTB.Size = new System.Drawing.Size(55, 26);
			this.seriesTB.TabIndex = 1;
			// 
			// yearTB
			// 
			this.yearTB.BackColor = System.Drawing.Color.White;
			this.yearTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.yearTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.yearTB.Enabled = false;
			this.yearTB.ForeColor = System.Drawing.Color.Black;
			this.yearTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.yearTB.Location = new System.Drawing.Point(120, 116);
			this.yearTB.Name = "yearTB";
			this.yearTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.yearTB.Size = new System.Drawing.Size(55, 26);
			this.yearTB.TabIndex = 1;
			// 
			// episodeTB
			// 
			this.episodeTB.BackColor = System.Drawing.Color.White;
			this.episodeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.episodeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.episodeTB.Enabled = false;
			this.episodeTB.ForeColor = System.Drawing.Color.Black;
			this.episodeTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.episodeTB.Location = new System.Drawing.Point(21, 359);
			this.episodeTB.Name = "episodeTB";
			this.episodeTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.episodeTB.Size = new System.Drawing.Size(335, 26);
			this.episodeTB.TabIndex = 1;
			// 
			// playedTB
			// 
			this.playedTB.BackColor = System.Drawing.Color.White;
			this.playedTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.playedTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.playedTB.Enabled = false;
			this.playedTB.ForeColor = System.Drawing.Color.Black;
			this.playedTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.playedTB.Location = new System.Drawing.Point(120, 77);
			this.playedTB.Name = "playedTB";
			this.playedTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.playedTB.Size = new System.Drawing.Size(236, 26);
			this.playedTB.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(17, 325);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(128, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "First full episode:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 197);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Age at start:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Series:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Year:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Played by:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Doctor:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.compLB);
			this.groupBox2.Location = new System.Drawing.Point(395, 42);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(394, 401);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Companions and their first episode with this Doctor:";
			// 
			// compLB
			// 
			this.compLB.FormattingEnabled = true;
			this.compLB.ItemHeight = 20;
			this.compLB.Location = new System.Drawing.Point(18, 41);
			this.compLB.Name = "compLB";
			this.compLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.compLB.Size = new System.Drawing.Size(359, 344);
			this.compLB.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(795, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(132, 206);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.linqRB);
			this.groupBox3.Controls.Add(this.sqlRB);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(796, 268);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(131, 100);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Query";
			// 
			// linqRB
			// 
			this.linqRB.AutoSize = true;
			this.linqRB.Checked = true;
			this.linqRB.Location = new System.Drawing.Point(6, 56);
			this.linqRB.Name = "linqRB";
			this.linqRB.Size = new System.Drawing.Size(119, 19);
			this.linqRB.TabIndex = 0;
			this.linqRB.TabStop = true;
			this.linqRB.Text = "Solve using LINQ";
			this.linqRB.UseVisualStyleBackColor = true;
			this.linqRB.CheckedChanged += new System.EventHandler(this.linqRB_CheckedChanged);
			// 
			// sqlRB
			// 
			this.sqlRB.AutoSize = true;
			this.sqlRB.Location = new System.Drawing.Point(6, 31);
			this.sqlRB.Name = "sqlRB";
			this.sqlRB.Size = new System.Drawing.Size(115, 19);
			this.sqlRB.TabIndex = 0;
			this.sqlRB.TabStop = true;
			this.sqlRB.Text = "Solve using SQL";
			this.sqlRB.UseVisualStyleBackColor = true;
			this.sqlRB.CheckedChanged += new System.EventHandler(this.sqlRB_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 452);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Doctor and Companions";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox playedTB;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox doctorPictureBox;
		private System.Windows.Forms.ComboBox doctorCB;
		private System.Windows.Forms.TextBox ageTB;
		private System.Windows.Forms.TextBox seriesTB;
		private System.Windows.Forms.TextBox yearTB;
		private System.Windows.Forms.ListBox compLB;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton linqRB;
		private System.Windows.Forms.RadioButton sqlRB;
		private System.Windows.Forms.TextBox episodeTB;
	}
}

