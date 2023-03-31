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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.OKButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.IconsLinkLabel = new System.Windows.Forms.LinkLabel();
			this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.label9 = new System.Windows.Forms.Label();
			this.LicenseTextBox = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "ContactsApp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 55);
			this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "v. 1.0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 89);
			this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Author:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(119, 89);
			this.label4.Margin = new System.Windows.Forms.Padding(56, 0, 3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Vladislav Sechenov";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 114);
			this.label5.Margin = new System.Windows.Forms.Padding(7, 10, 3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "E-mail:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(119, 114);
			this.label6.Margin = new System.Windows.Forms.Padding(56, 0, 3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(126, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "fake.mailbox@no.mail";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 139);
			this.label7.Margin = new System.Windows.Forms.Padding(7, 10, 3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "GitHub:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.OKButton);
			this.panel1.Location = new System.Drawing.Point(0, 359);
			this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(511, 47);
			this.panel1.TabIndex = 9;
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(426, 13);
			this.OKButton.Margin = new System.Windows.Forms.Padding(0, 13, 9, 0);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(73, 22);
			this.OKButton.TabIndex = 14;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.IconsLinkLabel);
			this.panel2.Controls.Add(this.GitHubLinkLabel);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.LicenseTextBox);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(511, 406);
			this.panel2.TabIndex = 10;
			// 
			// IconsLinkLabel
			// 
			this.IconsLinkLabel.AutoSize = true;
			this.IconsLinkLabel.Location = new System.Drawing.Point(215, 332);
			this.IconsLinkLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.IconsLinkLabel.Name = "IconsLinkLabel";
			this.IconsLinkLabel.Size = new System.Drawing.Size(68, 15);
			this.IconsLinkLabel.TabIndex = 13;
			this.IconsLinkLabel.TabStop = true;
			this.IconsLinkLabel.Text = "icons8.com";
			this.IconsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IconsLinkLabel_LinkClicked);
			// 
			// GitHubLinkLabel
			// 
			this.GitHubLinkLabel.AutoSize = true;
			this.GitHubLinkLabel.Location = new System.Drawing.Point(119, 139);
			this.GitHubLinkLabel.Name = "GitHubLinkLabel";
			this.GitHubLinkLabel.Size = new System.Drawing.Size(160, 15);
			this.GitHubLinkLabel.TabIndex = 12;
			this.GitHubLinkLabel.TabStop = true;
			this.GitHubLinkLabel.Text = "https://github.com/FloodDis";
			this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 332);
			this.label9.Margin = new System.Windows.Forms.Padding(7, 10, 0, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(207, 15);
			this.label9.TabIndex = 11;
			this.label9.Text = "All used images are downloaded from";
			// 
			// LicenseTextBox
			// 
			this.LicenseTextBox.Location = new System.Drawing.Point(12, 173);
			this.LicenseTextBox.Margin = new System.Windows.Forms.Padding(3, 19, 3, 3);
			this.LicenseTextBox.Multiline = true;
			this.LicenseTextBox.Name = "LicenseTextBox";
			this.LicenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.LicenseTextBox.Size = new System.Drawing.Size(487, 157);
			this.LicenseTextBox.TabIndex = 10;
			this.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
			this.LicenseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicenseTextBox_KeyPress);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(511, 406);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Panel panel1;
		private Panel panel2;
		private LinkLabel GitHubLinkLabel;
		private Label label9;
		private TextBox LicenseTextBox;
		private LinkLabel IconsLinkLabel;
		private Button OKButton;
	}
}