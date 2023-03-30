namespace ContactsApp.View
{
	partial class AboutForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "ContactsApp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "v. 1.0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 98);
			this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Author:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(119, 98);
			this.label4.Margin = new System.Windows.Forms.Padding(56, 0, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Vladislav Sechenov";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 129);
			this.label5.Margin = new System.Windows.Forms.Padding(7, 16, 3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "E-mail:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(119, 129);
			this.label6.Margin = new System.Windows.Forms.Padding(56, 0, 3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(126, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "fake.mailbox@no.mail";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 160);
			this.label7.Margin = new System.Windows.Forms.Padding(7, 16, 3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "GitHub:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(119, 160);
			this.label8.Margin = new System.Windows.Forms.Padding(56, 0, 3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(160, 15);
			this.label8.TabIndex = 7;
			this.label8.Text = "https://github.com/FloodDis";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Location = new System.Drawing.Point(16, 205);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(483, 157);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(511, 399);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private RichTextBox richTextBox1;
	}
}