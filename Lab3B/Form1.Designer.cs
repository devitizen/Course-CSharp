namespace Lab3B
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
			this.hairdresserCB = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.totalPriceTB = new System.Windows.Forms.TextBox();
			this.exitBtn = new System.Windows.Forms.Button();
			this.resetBtn = new System.Windows.Forms.Button();
			this.calculateTotalPriceBtn = new System.Windows.Forms.Button();
			this.addServiceBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.serviceLB = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chargedItemsLB = new System.Windows.Forms.ListBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.priceLB = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// hairdresserCB
			// 
			this.hairdresserCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.hairdresserCB.FormattingEnabled = true;
			this.hairdresserCB.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laurie Renkins"});
			this.hairdresserCB.Location = new System.Drawing.Point(6, 25);
			this.hairdresserCB.Name = "hairdresserCB";
			this.hairdresserCB.Size = new System.Drawing.Size(172, 26);
			this.hairdresserCB.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(553, 256);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 18);
			this.label5.TabIndex = 0;
			this.label5.Text = "Total Price:";
			// 
			// totalPriceTB
			// 
			this.totalPriceTB.BackColor = System.Drawing.SystemColors.Control;
			this.totalPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.totalPriceTB.ForeColor = System.Drawing.SystemColors.ControlText;
			this.totalPriceTB.Location = new System.Drawing.Point(644, 253);
			this.totalPriceTB.Name = "totalPriceTB";
			this.totalPriceTB.ReadOnly = true;
			this.totalPriceTB.Size = new System.Drawing.Size(126, 26);
			this.totalPriceTB.TabIndex = 3;
			this.totalPriceTB.TabStop = false;
			this.totalPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// exitBtn
			// 
			this.exitBtn.Location = new System.Drawing.Point(610, 299);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(160, 38);
			this.exitBtn.TabIndex = 4;
			this.exitBtn.TabStop = false;
			this.exitBtn.Text = "Exit";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// resetBtn
			// 
			this.resetBtn.Location = new System.Drawing.Point(444, 299);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(160, 38);
			this.resetBtn.TabIndex = 4;
			this.resetBtn.TabStop = false;
			this.resetBtn.Text = "Reset";
			this.resetBtn.UseVisualStyleBackColor = true;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// calculateTotalPriceBtn
			// 
			this.calculateTotalPriceBtn.Enabled = false;
			this.calculateTotalPriceBtn.Location = new System.Drawing.Point(278, 299);
			this.calculateTotalPriceBtn.Name = "calculateTotalPriceBtn";
			this.calculateTotalPriceBtn.Size = new System.Drawing.Size(160, 38);
			this.calculateTotalPriceBtn.TabIndex = 4;
			this.calculateTotalPriceBtn.TabStop = false;
			this.calculateTotalPriceBtn.Text = "Calculate Total Price";
			this.calculateTotalPriceBtn.UseVisualStyleBackColor = true;
			this.calculateTotalPriceBtn.Click += new System.EventHandler(this.calculateTotalPriceBtn_Click);
			// 
			// addServiceBtn
			// 
			this.addServiceBtn.Enabled = false;
			this.addServiceBtn.Location = new System.Drawing.Point(112, 299);
			this.addServiceBtn.Name = "addServiceBtn";
			this.addServiceBtn.Size = new System.Drawing.Size(160, 38);
			this.addServiceBtn.TabIndex = 4;
			this.addServiceBtn.TabStop = false;
			this.addServiceBtn.Text = "Add Service";
			this.addServiceBtn.UseVisualStyleBackColor = true;
			this.addServiceBtn.Click += new System.EventHandler(this.addServiceBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.hairdresserCB);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 225);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select a Hairdresser:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.serviceLB);
			this.groupBox2.Location = new System.Drawing.Point(218, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(223, 225);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Select a Service:";
			// 
			// serviceLB
			// 
			this.serviceLB.FormattingEnabled = true;
			this.serviceLB.ItemHeight = 18;
			this.serviceLB.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extension",
            "Up-do"});
			this.serviceLB.Location = new System.Drawing.Point(7, 25);
			this.serviceLB.Name = "serviceLB";
			this.serviceLB.Size = new System.Drawing.Size(210, 184);
			this.serviceLB.TabIndex = 0;
			this.serviceLB.SelectedIndexChanged += new System.EventHandler(this.serviceLB_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chargedItemsLB);
			this.groupBox3.Location = new System.Drawing.Point(447, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(214, 225);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Charged Items:";
			// 
			// chargedItemsLB
			// 
			this.chargedItemsLB.FormattingEnabled = true;
			this.chargedItemsLB.ItemHeight = 18;
			this.chargedItemsLB.Location = new System.Drawing.Point(7, 26);
			this.chargedItemsLB.Name = "chargedItemsLB";
			this.chargedItemsLB.Size = new System.Drawing.Size(201, 184);
			this.chargedItemsLB.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.priceLB);
			this.groupBox4.Location = new System.Drawing.Point(667, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(110, 225);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Price:";
			// 
			// priceLB
			// 
			this.priceLB.FormattingEnabled = true;
			this.priceLB.ItemHeight = 18;
			this.priceLB.Location = new System.Drawing.Point(7, 26);
			this.priceLB.Name = "priceLB";
			this.priceLB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.priceLB.Size = new System.Drawing.Size(97, 184);
			this.priceLB.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(785, 350);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.addServiceBtn);
			this.Controls.Add(this.calculateTotalPriceBtn);
			this.Controls.Add(this.resetBtn);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.totalPriceTB);
			this.Controls.Add(this.label5);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Perfect Cut Hair Salon";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox hairdresserCB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox totalPriceTB;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Button resetBtn;
		private System.Windows.Forms.Button calculateTotalPriceBtn;
		private System.Windows.Forms.Button addServiceBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListBox serviceLB;
		private System.Windows.Forms.ListBox chargedItemsLB;
		private System.Windows.Forms.ListBox priceLB;
	}
}

