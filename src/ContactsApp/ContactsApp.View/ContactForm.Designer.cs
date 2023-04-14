namespace ContactsApp.View
{
	partial class ContactForm
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
			this.ContactPanel = new System.Windows.Forms.Panel();
			this.AddPhotoButton = new System.Windows.Forms.PictureBox();
			this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.OKButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.VKTextBox = new System.Windows.Forms.TextBox();
			this.VKLabel = new System.Windows.Forms.Label();
			this.DateOfBirthLabel = new System.Windows.Forms.Label();
			this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.PhoneNumberLabel = new System.Windows.Forms.Label();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.FullNameTextBox = new System.Windows.Forms.TextBox();
			this.FullNameLabel = new System.Windows.Forms.Label();
			this.ContactPictureBox = new System.Windows.Forms.PictureBox();
			this.ContactPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).BeginInit();
			this.FooterPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ContactPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ContactPanel
			// 
			this.ContactPanel.Controls.Add(this.AddPhotoButton);
			this.ContactPanel.Controls.Add(this.DateOfBirthDateTimePicker);
			this.ContactPanel.Controls.Add(this.FooterPanel);
			this.ContactPanel.Controls.Add(this.VKTextBox);
			this.ContactPanel.Controls.Add(this.VKLabel);
			this.ContactPanel.Controls.Add(this.DateOfBirthLabel);
			this.ContactPanel.Controls.Add(this.PhoneNumberTextBox);
			this.ContactPanel.Controls.Add(this.PhoneNumberLabel);
			this.ContactPanel.Controls.Add(this.EmailTextBox);
			this.ContactPanel.Controls.Add(this.EmailLabel);
			this.ContactPanel.Controls.Add(this.FullNameTextBox);
			this.ContactPanel.Controls.Add(this.FullNameLabel);
			this.ContactPanel.Controls.Add(this.ContactPictureBox);
			this.ContactPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContactPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ContactPanel.Location = new System.Drawing.Point(0, 0);
			this.ContactPanel.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
			this.ContactPanel.Name = "ContactPanel";
			this.ContactPanel.Size = new System.Drawing.Size(525, 341);
			this.ContactPanel.TabIndex = 2;
			// 
			// AddPhotoButton
			// 
			this.AddPhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
			this.AddPhotoButton.Location = new System.Drawing.Point(12, 113);
			this.AddPhotoButton.Name = "AddPhotoButton";
			this.AddPhotoButton.Size = new System.Drawing.Size(100, 32);
			this.AddPhotoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.AddPhotoButton.TabIndex = 14;
			this.AddPhotoButton.TabStop = false;
			this.AddPhotoButton.MouseEnter += new System.EventHandler(this.AddPhotoButton_MouseEnter);
			this.AddPhotoButton.MouseLeave += new System.EventHandler(this.AddPhotoButton_MouseLeave);
			// 
			// DateOfBirthDateTimePicker
			// 
			this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(118, 194);
			this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
			this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(175, 23);
			this.DateOfBirthDateTimePicker.TabIndex = 13;
			// 
			// FooterPanel
			// 
			this.FooterPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.FooterPanel.Controls.Add(this.OKButton);
			this.FooterPanel.Controls.Add(this.CancelButton);
			this.FooterPanel.Location = new System.Drawing.Point(0, 295);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(525, 46);
			this.FooterPanel.TabIndex = 12;
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(358, 12);
			this.OKButton.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(73, 22);
			this.OKButton.TabIndex = 1;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(440, 12);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(0, 13, 14, 13);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(73, 22);
			this.CancelButton.TabIndex = 0;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// VKTextBox
			// 
			this.VKTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.VKTextBox.Location = new System.Drawing.Point(118, 248);
			this.VKTextBox.Name = "VKTextBox";
			this.VKTextBox.Size = new System.Drawing.Size(175, 23);
			this.VKTextBox.TabIndex = 10;
			// 
			// VKLabel
			// 
			this.VKLabel.AutoSize = true;
			this.VKLabel.Location = new System.Drawing.Point(118, 230);
			this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.VKLabel.Name = "VKLabel";
			this.VKLabel.Size = new System.Drawing.Size(24, 15);
			this.VKLabel.TabIndex = 9;
			this.VKLabel.Text = "VK:";
			// 
			// DateOfBirthLabel
			// 
			this.DateOfBirthLabel.AutoSize = true;
			this.DateOfBirthLabel.Location = new System.Drawing.Point(118, 176);
			this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.DateOfBirthLabel.Name = "DateOfBirthLabel";
			this.DateOfBirthLabel.Size = new System.Drawing.Size(76, 15);
			this.DateOfBirthLabel.TabIndex = 7;
			this.DateOfBirthLabel.Text = "Date of Birth:";
			// 
			// PhoneNumberTextBox
			// 
			this.PhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PhoneNumberTextBox.Location = new System.Drawing.Point(118, 140);
			this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
			this.PhoneNumberTextBox.Size = new System.Drawing.Size(175, 23);
			this.PhoneNumberTextBox.TabIndex = 6;
			this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
			// 
			// PhoneNumberLabel
			// 
			this.PhoneNumberLabel.AutoSize = true;
			this.PhoneNumberLabel.Location = new System.Drawing.Point(118, 122);
			this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.PhoneNumberLabel.Name = "PhoneNumberLabel";
			this.PhoneNumberLabel.Size = new System.Drawing.Size(88, 15);
			this.PhoneNumberLabel.TabIndex = 5;
			this.PhoneNumberLabel.Text = "PhoneNumber:";
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EmailTextBox.Location = new System.Drawing.Point(118, 86);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(395, 23);
			this.EmailTextBox.TabIndex = 4;
			this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(118, 68);
			this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(44, 15);
			this.EmailLabel.TabIndex = 3;
			this.EmailLabel.Text = "E-mail:";
			// 
			// FullNameTextBox
			// 
			this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FullNameTextBox.Location = new System.Drawing.Point(118, 32);
			this.FullNameTextBox.Name = "FullNameTextBox";
			this.FullNameTextBox.Size = new System.Drawing.Size(395, 23);
			this.FullNameTextBox.TabIndex = 2;
			this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
			// 
			// FullNameLabel
			// 
			this.FullNameLabel.AutoSize = true;
			this.FullNameLabel.Location = new System.Drawing.Point(118, 14);
			this.FullNameLabel.Name = "FullNameLabel";
			this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
			this.FullNameLabel.TabIndex = 1;
			this.FullNameLabel.Text = "Full Name:";
			// 
			// ContactPictureBox
			// 
			this.ContactPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
			this.ContactPictureBox.Location = new System.Drawing.Point(12, 12);
			this.ContactPictureBox.Margin = new System.Windows.Forms.Padding(12, 12, 3, 3);
			this.ContactPictureBox.Name = "ContactPictureBox";
			this.ContactPictureBox.Size = new System.Drawing.Size(100, 100);
			this.ContactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ContactPictureBox.TabIndex = 0;
			this.ContactPictureBox.TabStop = false;
			// 
			// ContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(525, 341);
			this.Controls.Add(this.ContactPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ContactForm";
			this.ShowIcon = false;
			this.ContactPanel.ResumeLayout(false);
			this.ContactPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).EndInit();
			this.FooterPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ContactPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel ContactPanel;
		private TextBox VKTextBox;
		private Label VKLabel;
		private Label DateOfBirthLabel;
		private TextBox PhoneNumberTextBox;
		private Label PhoneNumberLabel;
		private TextBox EmailTextBox;
		private Label EmailLabel;
		private TextBox FullNameTextBox;
		private Label FullNameLabel;
		private PictureBox ContactPictureBox;
		private DateTimePicker DateOfBirthDateTimePicker;
		private Panel FooterPanel;
		private Button OKButton;
		private Button CancelButton;
		private PictureBox AddPhotoButton;
	}
}