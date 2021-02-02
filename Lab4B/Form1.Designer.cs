namespace Lab4B
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.fileLoadfileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.fileExitMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.processMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.processCheckMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.statusLbl = new System.Windows.Forms.Label();
			this.resultLB = new System.Windows.Forms.ListBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.processMenu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(467, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLoadfileMenu,
            this.fileExitMenu});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "File";
			// 
			// fileLoadfileMenu
			// 
			this.fileLoadfileMenu.Name = "fileLoadfileMenu";
			this.fileLoadfileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.fileLoadfileMenu.Size = new System.Drawing.Size(170, 22);
			this.fileLoadfileMenu.Text = "Load File...";
			this.fileLoadfileMenu.Click += new System.EventHandler(this.fileLoadfileMenu_Click);
			// 
			// fileExitMenu
			// 
			this.fileExitMenu.Name = "fileExitMenu";
			this.fileExitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.fileExitMenu.Size = new System.Drawing.Size(170, 22);
			this.fileExitMenu.Text = "Exit";
			this.fileExitMenu.Click += new System.EventHandler(this.fileExitMenu_Click);
			// 
			// processMenu
			// 
			this.processMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processCheckMenu});
			this.processMenu.Name = "processMenu";
			this.processMenu.Size = new System.Drawing.Size(59, 20);
			this.processMenu.Text = "Process";
			// 
			// processCheckMenu
			// 
			this.processCheckMenu.Enabled = false;
			this.processCheckMenu.Name = "processCheckMenu";
			this.processCheckMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.processCheckMenu.Size = new System.Drawing.Size(175, 22);
			this.processCheckMenu.Text = "Check Tags";
			this.processCheckMenu.Click += new System.EventHandler(this.processCheckMenu_Click);
			// 
			// statusLbl
			// 
			this.statusLbl.AutoSize = true;
			this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLbl.Location = new System.Drawing.Point(13, 39);
			this.statusLbl.Name = "statusLbl";
			this.statusLbl.Size = new System.Drawing.Size(116, 20);
			this.statusLbl.TabIndex = 1;
			this.statusLbl.Text = "No File Loaded";
			// 
			// resultLB
			// 
			this.resultLB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLB.FormattingEnabled = true;
			this.resultLB.ItemHeight = 18;
			this.resultLB.Location = new System.Drawing.Point(17, 84);
			this.resultLB.Name = "resultLB";
			this.resultLB.Size = new System.Drawing.Size(436, 436);
			this.resultLB.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 541);
			this.Controls.Add(this.resultLB);
			this.Controls.Add(this.statusLbl);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Nick\'s Simple HTML File Checker";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem fileLoadfileMenu;
		private System.Windows.Forms.ToolStripMenuItem fileExitMenu;
		private System.Windows.Forms.ToolStripMenuItem processMenu;
		private System.Windows.Forms.ToolStripMenuItem processCheckMenu;
		private System.Windows.Forms.Label statusLbl;
		private System.Windows.Forms.ListBox resultLB;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

