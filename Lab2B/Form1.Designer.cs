namespace Lab2B
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.janeRB = new System.Windows.Forms.RadioButton();
			this.patRB = new System.Windows.Forms.RadioButton();
			this.ronRB = new System.Windows.Forms.RadioButton();
			this.sueRB = new System.Windows.Forms.RadioButton();
			this.lauraRB = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.standardRB = new System.Windows.Forms.RadioButton();
			this.childRB = new System.Windows.Forms.RadioButton();
			this.studentRB = new System.Windows.Forms.RadioButton();
			this.seniorRB = new System.Windows.Forms.RadioButton();
			this.serviceBox = new System.Windows.Forms.GroupBox();
			this.cutCB = new System.Windows.Forms.CheckBox();
			this.colourCB = new System.Windows.Forms.CheckBox();
			this.highlightsCB = new System.Windows.Forms.CheckBox();
			this.extensionsCB = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numClientVisitTB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.calculateBtn = new System.Windows.Forms.Button();
			this.clearBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.totalPriceLbl = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.serviceBox.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lauraRB);
			this.groupBox1.Controls.Add(this.sueRB);
			this.groupBox1.Controls.Add(this.ronRB);
			this.groupBox1.Controls.Add(this.patRB);
			this.groupBox1.Controls.Add(this.janeRB);
			this.groupBox1.Location = new System.Drawing.Point(12, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(210, 252);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hairdresser";
			// 
			// janeRB
			// 
			this.janeRB.AutoSize = true;
			this.janeRB.Checked = true;
			this.janeRB.Location = new System.Drawing.Point(17, 41);
			this.janeRB.Name = "janeRB";
			this.janeRB.Size = new System.Drawing.Size(124, 23);
			this.janeRB.TabIndex = 0;
			this.janeRB.TabStop = true;
			this.janeRB.Text = "Jane Samley";
			this.janeRB.UseVisualStyleBackColor = true;
			// 
			// patRB
			// 
			this.patRB.AutoSize = true;
			this.patRB.Location = new System.Drawing.Point(17, 81);
			this.patRB.Name = "patRB";
			this.patRB.Size = new System.Drawing.Size(124, 23);
			this.patRB.TabIndex = 0;
			this.patRB.Text = "Pat Johnson";
			this.patRB.UseVisualStyleBackColor = true;
			// 
			// ronRB
			// 
			this.ronRB.AutoSize = true;
			this.ronRB.Location = new System.Drawing.Point(17, 124);
			this.ronRB.Name = "ronRB";
			this.ronRB.Size = new System.Drawing.Size(142, 23);
			this.ronRB.TabIndex = 0;
			this.ronRB.Text = "Ron Chambers";
			this.ronRB.UseVisualStyleBackColor = true;
			// 
			// sueRB
			// 
			this.sueRB.AutoSize = true;
			this.sueRB.Location = new System.Drawing.Point(17, 165);
			this.sueRB.Name = "sueRB";
			this.sueRB.Size = new System.Drawing.Size(109, 23);
			this.sueRB.TabIndex = 0;
			this.sueRB.Text = "Sue Pallon";
			this.sueRB.UseVisualStyleBackColor = true;
			// 
			// lauraRB
			// 
			this.lauraRB.AutoSize = true;
			this.lauraRB.Location = new System.Drawing.Point(17, 206);
			this.lauraRB.Name = "lauraRB";
			this.lauraRB.Size = new System.Drawing.Size(138, 23);
			this.lauraRB.TabIndex = 0;
			this.lauraRB.Text = "Laura Renkins";
			this.lauraRB.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.seniorRB);
			this.groupBox2.Controls.Add(this.studentRB);
			this.groupBox2.Controls.Add(this.childRB);
			this.groupBox2.Controls.Add(this.standardRB);
			this.groupBox2.Location = new System.Drawing.Point(12, 292);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(210, 219);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Client Type";
			// 
			// standardRB
			// 
			this.standardRB.AutoSize = true;
			this.standardRB.Checked = true;
			this.standardRB.Location = new System.Drawing.Point(17, 42);
			this.standardRB.Name = "standardRB";
			this.standardRB.Size = new System.Drawing.Size(140, 23);
			this.standardRB.TabIndex = 0;
			this.standardRB.TabStop = true;
			this.standardRB.Text = "Standard Adult";
			this.standardRB.UseVisualStyleBackColor = true;
			// 
			// childRB
			// 
			this.childRB.AutoSize = true;
			this.childRB.Location = new System.Drawing.Point(17, 83);
			this.childRB.Name = "childRB";
			this.childRB.Size = new System.Drawing.Size(181, 23);
			this.childRB.TabIndex = 0;
			this.childRB.Text = "Child (12 and under)";
			this.childRB.UseVisualStyleBackColor = true;
			// 
			// studentRB
			// 
			this.studentRB.AutoSize = true;
			this.studentRB.Location = new System.Drawing.Point(17, 124);
			this.studentRB.Name = "studentRB";
			this.studentRB.Size = new System.Drawing.Size(87, 23);
			this.studentRB.TabIndex = 0;
			this.studentRB.Text = "Student";
			this.studentRB.UseVisualStyleBackColor = true;
			// 
			// seniorRB
			// 
			this.seniorRB.AutoSize = true;
			this.seniorRB.Location = new System.Drawing.Point(17, 165);
			this.seniorRB.Name = "seniorRB";
			this.seniorRB.Size = new System.Drawing.Size(147, 23);
			this.seniorRB.TabIndex = 0;
			this.seniorRB.Text = "Senior (over 65)";
			this.seniorRB.UseVisualStyleBackColor = true;
			// 
			// serviceBox
			// 
			this.serviceBox.Controls.Add(this.extensionsCB);
			this.serviceBox.Controls.Add(this.highlightsCB);
			this.serviceBox.Controls.Add(this.colourCB);
			this.serviceBox.Controls.Add(this.cutCB);
			this.serviceBox.Location = new System.Drawing.Point(245, 21);
			this.serviceBox.Name = "serviceBox";
			this.serviceBox.Size = new System.Drawing.Size(213, 252);
			this.serviceBox.TabIndex = 2;
			this.serviceBox.TabStop = false;
			this.serviceBox.Text = "Services";
			// 
			// cutCB
			// 
			this.cutCB.AutoSize = true;
			this.cutCB.Location = new System.Drawing.Point(20, 42);
			this.cutCB.Name = "cutCB";
			this.cutCB.Size = new System.Drawing.Size(55, 23);
			this.cutCB.TabIndex = 0;
			this.cutCB.Text = "Cut";
			this.cutCB.UseVisualStyleBackColor = true;
			// 
			// colourCB
			// 
			this.colourCB.AutoSize = true;
			this.colourCB.Location = new System.Drawing.Point(20, 83);
			this.colourCB.Name = "colourCB";
			this.colourCB.Size = new System.Drawing.Size(80, 23);
			this.colourCB.TabIndex = 0;
			this.colourCB.Text = "Colour";
			this.colourCB.UseVisualStyleBackColor = true;
			// 
			// highlightsCB
			// 
			this.highlightsCB.AutoSize = true;
			this.highlightsCB.Location = new System.Drawing.Point(20, 124);
			this.highlightsCB.Name = "highlightsCB";
			this.highlightsCB.Size = new System.Drawing.Size(106, 23);
			this.highlightsCB.TabIndex = 0;
			this.highlightsCB.Text = "Highlights";
			this.highlightsCB.UseVisualStyleBackColor = true;
			// 
			// extensionsCB
			// 
			this.extensionsCB.AutoSize = true;
			this.extensionsCB.Location = new System.Drawing.Point(20, 165);
			this.extensionsCB.Name = "extensionsCB";
			this.extensionsCB.Size = new System.Drawing.Size(114, 23);
			this.extensionsCB.TabIndex = 0;
			this.extensionsCB.Text = "Extensions";
			this.extensionsCB.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.numClientVisitTB);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Location = new System.Drawing.Point(245, 292);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(213, 219);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Client Visits";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Number of Client Visits :";
			// 
			// numClientVisitTB
			// 
			this.numClientVisitTB.Location = new System.Drawing.Point(32, 83);
			this.numClientVisitTB.Name = "numClientVisitTB";
			this.numClientVisitTB.Size = new System.Drawing.Size(161, 26);
			this.numClientVisitTB.TabIndex = 1;
			this.numClientVisitTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(144, 536);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Total Price : ";
			// 
			// calculateBtn
			// 
			this.calculateBtn.Location = new System.Drawing.Point(29, 583);
			this.calculateBtn.Name = "calculateBtn";
			this.calculateBtn.Size = new System.Drawing.Size(109, 42);
			this.calculateBtn.TabIndex = 5;
			this.calculateBtn.Text = "Calculate";
			this.calculateBtn.UseVisualStyleBackColor = true;
			this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
			// 
			// clearBtn
			// 
			this.clearBtn.Location = new System.Drawing.Point(179, 583);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(109, 42);
			this.clearBtn.TabIndex = 5;
			this.clearBtn.Text = "Clear";
			this.clearBtn.UseVisualStyleBackColor = true;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.Location = new System.Drawing.Point(329, 583);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(109, 42);
			this.exitBtn.TabIndex = 5;
			this.exitBtn.Text = "Exit";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// totalPriceLbl
			// 
			this.totalPriceLbl.AutoSize = true;
			this.totalPriceLbl.Location = new System.Drawing.Point(247, 536);
			this.totalPriceLbl.Name = "totalPriceLbl";
			this.totalPriceLbl.Size = new System.Drawing.Size(0, 19);
			this.totalPriceLbl.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 640);
			this.Controls.Add(this.totalPriceLbl);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.calculateBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.serviceBox);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Perfect Cut Hair Salon";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.serviceBox.ResumeLayout(false);
			this.serviceBox.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton lauraRB;
		private System.Windows.Forms.RadioButton sueRB;
		private System.Windows.Forms.RadioButton ronRB;
		private System.Windows.Forms.RadioButton patRB;
		private System.Windows.Forms.RadioButton janeRB;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton seniorRB;
		private System.Windows.Forms.RadioButton studentRB;
		private System.Windows.Forms.RadioButton childRB;
		private System.Windows.Forms.RadioButton standardRB;
		private System.Windows.Forms.GroupBox serviceBox;
		private System.Windows.Forms.CheckBox extensionsCB;
		private System.Windows.Forms.CheckBox highlightsCB;
		private System.Windows.Forms.CheckBox colourCB;
		private System.Windows.Forms.CheckBox cutCB;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox numClientVisitTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button calculateBtn;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Label totalPriceLbl;
	}
}

