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
			this.ContactsAppLabel = new System.Windows.Forms.Label();
			this.VersionAppLabel = new System.Windows.Forms.Label();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.EmailAdressLabel = new System.Windows.Forms.Label();
			this.GitHubLabel = new System.Windows.Forms.Label();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.OKButton = new System.Windows.Forms.Button();
			this.FormPanel = new System.Windows.Forms.Panel();
			this.IconsLinkLabel = new System.Windows.Forms.LinkLabel();
			this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.IconResourceLabel = new System.Windows.Forms.Label();
			this.LicenseTextBox = new System.Windows.Forms.TextBox();
			this.FooterPanel.SuspendLayout();
			this.FormPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ContactsAppLabel
			// 
			this.ContactsAppLabel.AutoSize = true;
			this.ContactsAppLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ContactsAppLabel.Location = new System.Drawing.Point(14, 33);
			this.ContactsAppLabel.Margin = new System.Windows.Forms.Padding(3, 33, 3, 0);
			this.ContactsAppLabel.Name = "ContactsAppLabel";
			this.ContactsAppLabel.Size = new System.Drawing.Size(182, 37);
			this.ContactsAppLabel.TabIndex = 0;
			this.ContactsAppLabel.Text = "ContactsApp";
			// 
			// VersionAppLabel
			// 
			this.VersionAppLabel.AutoSize = true;
			this.VersionAppLabel.Location = new System.Drawing.Point(18, 73);
			this.VersionAppLabel.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
			this.VersionAppLabel.Name = "VersionAppLabel";
			this.VersionAppLabel.Size = new System.Drawing.Size(42, 20);
			this.VersionAppLabel.TabIndex = 1;
			this.VersionAppLabel.Text = "v. 1.0";
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Location = new System.Drawing.Point(18, 119);
			this.AuthorLabel.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(57, 20);
			this.AuthorLabel.TabIndex = 2;
			this.AuthorLabel.Text = "Author:";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(136, 119);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(64, 0, 3, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(135, 20);
			this.NameLabel.TabIndex = 3;
			this.NameLabel.Text = "Vladislav Sechenov";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(18, 152);
			this.EmailLabel.Margin = new System.Windows.Forms.Padding(8, 13, 3, 0);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(55, 20);
			this.EmailLabel.TabIndex = 4;
			this.EmailLabel.Text = "E-mail:";
			// 
			// EmailAdressLabel
			// 
			this.EmailAdressLabel.AutoSize = true;
			this.EmailAdressLabel.Location = new System.Drawing.Point(136, 152);
			this.EmailAdressLabel.Margin = new System.Windows.Forms.Padding(64, 0, 3, 0);
			this.EmailAdressLabel.Name = "EmailAdressLabel";
			this.EmailAdressLabel.Size = new System.Drawing.Size(157, 20);
			this.EmailAdressLabel.TabIndex = 5;
			this.EmailAdressLabel.Text = "fake.mailbox@no.mail";
			// 
			// GitHubLabel
			// 
			this.GitHubLabel.AutoSize = true;
			this.GitHubLabel.Location = new System.Drawing.Point(17, 185);
			this.GitHubLabel.Margin = new System.Windows.Forms.Padding(8, 13, 3, 0);
			this.GitHubLabel.Name = "GitHubLabel";
			this.GitHubLabel.Size = new System.Drawing.Size(59, 20);
			this.GitHubLabel.TabIndex = 6;
			this.GitHubLabel.Text = "GitHub:";
			// 
			// FooterPanel
			// 
			this.FooterPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.FooterPanel.Controls.Add(this.OKButton);
			this.FooterPanel.Location = new System.Drawing.Point(0, 479);
			this.FooterPanel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(584, 63);
			this.FooterPanel.TabIndex = 9;
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(487, 17);
			this.OKButton.Margin = new System.Windows.Forms.Padding(0, 17, 10, 0);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(83, 29);
			this.OKButton.TabIndex = 14;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// FormPanel
			// 
			this.FormPanel.Controls.Add(this.IconsLinkLabel);
			this.FormPanel.Controls.Add(this.GitHubLinkLabel);
			this.FormPanel.Controls.Add(this.IconResourceLabel);
			this.FormPanel.Controls.Add(this.LicenseTextBox);
			this.FormPanel.Controls.Add(this.FooterPanel);
			this.FormPanel.Controls.Add(this.ContactsAppLabel);
			this.FormPanel.Controls.Add(this.VersionAppLabel);
			this.FormPanel.Controls.Add(this.GitHubLabel);
			this.FormPanel.Controls.Add(this.AuthorLabel);
			this.FormPanel.Controls.Add(this.EmailAdressLabel);
			this.FormPanel.Controls.Add(this.NameLabel);
			this.FormPanel.Controls.Add(this.EmailLabel);
			this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FormPanel.Location = new System.Drawing.Point(0, 0);
			this.FormPanel.Margin = new System.Windows.Forms.Padding(3, 4, 6, 4);
			this.FormPanel.Name = "FormPanel";
			this.FormPanel.Size = new System.Drawing.Size(584, 541);
			this.FormPanel.TabIndex = 10;
			// 
			// IconsLinkLabel
			// 
			this.IconsLinkLabel.AutoSize = true;
			this.IconsLinkLabel.Location = new System.Drawing.Point(246, 443);
			this.IconsLinkLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.IconsLinkLabel.Name = "IconsLinkLabel";
			this.IconsLinkLabel.Size = new System.Drawing.Size(83, 20);
			this.IconsLinkLabel.TabIndex = 13;
			this.IconsLinkLabel.TabStop = true;
			this.IconsLinkLabel.Text = "icons8.com";
			this.IconsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IconsLinkLabel_LinkClicked);
			// 
			// GitHubLinkLabel
			// 
			this.GitHubLinkLabel.AutoSize = true;
			this.GitHubLinkLabel.Location = new System.Drawing.Point(136, 185);
			this.GitHubLinkLabel.Name = "GitHubLinkLabel";
			this.GitHubLinkLabel.Size = new System.Drawing.Size(197, 20);
			this.GitHubLinkLabel.TabIndex = 12;
			this.GitHubLinkLabel.TabStop = true;
			this.GitHubLinkLabel.Text = "https://github.com/FloodDis";
			this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
			// 
			// IconResourceLabel
			// 
			this.IconResourceLabel.AutoSize = true;
			this.IconResourceLabel.Location = new System.Drawing.Point(14, 443);
			this.IconResourceLabel.Margin = new System.Windows.Forms.Padding(8, 13, 0, 0);
			this.IconResourceLabel.Name = "IconResourceLabel";
			this.IconResourceLabel.Size = new System.Drawing.Size(263, 20);
			this.IconResourceLabel.TabIndex = 11;
			this.IconResourceLabel.Text = "All used images are downloaded from";
			// 
			// LicenseTextBox
			// 
			this.LicenseTextBox.Location = new System.Drawing.Point(14, 231);
			this.LicenseTextBox.Margin = new System.Windows.Forms.Padding(3, 25, 3, 4);
			this.LicenseTextBox.Multiline = true;
			this.LicenseTextBox.Name = "LicenseTextBox";
			this.LicenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.LicenseTextBox.Size = new System.Drawing.Size(556, 208);
			this.LicenseTextBox.TabIndex = 10;
			this.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
			this.LicenseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicenseTextBox_KeyPress);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(584, 541);
			this.Controls.Add(this.FormPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.FooterPanel.ResumeLayout(false);
			this.FormPanel.ResumeLayout(false);
			this.FormPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Label ContactsAppLabel;
		private Label VersionAppLabel;
		private Label AuthorLabel;
		private Label NameLabel;
		private Label EmailLabel;
		private Label EmailAdressLabel;
		private Label GitHubLabel;
		private Panel FooterPanel;
		private Panel FormPanel;
		private LinkLabel GitHubLinkLabel;
		private Label IconResourceLabel;
		private TextBox LicenseTextBox;
		private LinkLabel IconsLinkLabel;
		private Button OKButton;
	}
}