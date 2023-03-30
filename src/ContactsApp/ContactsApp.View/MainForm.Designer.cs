namespace ContactsApp.View
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ContactsAppTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ContactsManagementPanel = new System.Windows.Forms.Panel();
			this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.AddContactButton = new System.Windows.Forms.PictureBox();
			this.EditContactButton = new System.Windows.Forms.PictureBox();
			this.RemoveContactButton = new System.Windows.Forms.PictureBox();
			this.FindContactLabel = new System.Windows.Forms.Label();
			this.FindTextBox = new System.Windows.Forms.TextBox();
			this.ContactsListBox = new System.Windows.Forms.ListBox();
			this.ContactDisplayPanel = new System.Windows.Forms.Panel();
			this.NotificationPanel = new System.Windows.Forms.Panel();
			this.CloseNotificationButton = new System.Windows.Forms.Button();
			this.NotificationSurnamesLabel = new System.Windows.Forms.Label();
			this.NotficationBirthdayLabel = new System.Windows.Forms.Label();
			this.NotificationPictureBox = new System.Windows.Forms.PictureBox();
			this.VKTextBox = new System.Windows.Forms.TextBox();
			this.VKLabel = new System.Windows.Forms.Label();
			this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
			this.DateOfBirthLabel = new System.Windows.Forms.Label();
			this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.PhoneNumberLabel = new System.Windows.Forms.Label();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.FullNameTextBox = new System.Windows.Forms.TextBox();
			this.FullNameLabel = new System.Windows.Forms.Label();
			this.ContactPictureBox = new System.Windows.Forms.PictureBox();
			this.ContactsAppTableLayoutPanel.SuspendLayout();
			this.ContactsManagementPanel.SuspendLayout();
			this.ButtonsTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RemoveContactButton)).BeginInit();
			this.ContactDisplayPanel.SuspendLayout();
			this.NotificationPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NotificationPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ContactPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ContactsAppTableLayoutPanel
			// 
			this.ContactsAppTableLayoutPanel.ColumnCount = 2;
			this.ContactsAppTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.ContactsAppTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ContactsAppTableLayoutPanel.Controls.Add(this.ContactsManagementPanel, 0, 0);
			this.ContactsAppTableLayoutPanel.Controls.Add(this.ContactDisplayPanel, 1, 0);
			this.ContactsAppTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContactsAppTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.ContactsAppTableLayoutPanel.Name = "ContactsAppTableLayoutPanel";
			this.ContactsAppTableLayoutPanel.RowCount = 1;
			this.ContactsAppTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ContactsAppTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
			this.ContactsAppTableLayoutPanel.TabIndex = 0;
			// 
			// ContactsManagementPanel
			// 
			this.ContactsManagementPanel.Controls.Add(this.ButtonsTableLayoutPanel);
			this.ContactsManagementPanel.Controls.Add(this.FindContactLabel);
			this.ContactsManagementPanel.Controls.Add(this.FindTextBox);
			this.ContactsManagementPanel.Controls.Add(this.ContactsListBox);
			this.ContactsManagementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContactsManagementPanel.Location = new System.Drawing.Point(3, 3);
			this.ContactsManagementPanel.Name = "ContactsManagementPanel";
			this.ContactsManagementPanel.Size = new System.Drawing.Size(244, 444);
			this.ContactsManagementPanel.TabIndex = 0;
			// 
			// ButtonsTableLayoutPanel
			// 
			this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonsTableLayoutPanel.ColumnCount = 3;
			this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ButtonsTableLayoutPanel.Controls.Add(this.AddContactButton, 0, 0);
			this.ButtonsTableLayoutPanel.Controls.Add(this.EditContactButton, 1, 0);
			this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveContactButton, 2, 0);
			this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 407);
			this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
			this.ButtonsTableLayoutPanel.RowCount = 1;
			this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(238, 34);
			this.ButtonsTableLayoutPanel.TabIndex = 6;
			// 
			// AddContactButton
			// 
			this.AddContactButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
			this.AddContactButton.Location = new System.Drawing.Point(0, 0);
			this.AddContactButton.Margin = new System.Windows.Forms.Padding(0);
			this.AddContactButton.Name = "AddContactButton";
			this.AddContactButton.Size = new System.Drawing.Size(79, 34);
			this.AddContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.AddContactButton.TabIndex = 12;
			this.AddContactButton.TabStop = false;
			this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
			this.AddContactButton.MouseEnter += new System.EventHandler(this.AddContactButton_MouseEnter);
			this.AddContactButton.MouseLeave += new System.EventHandler(this.AddContactButton_MouseLeave);
			// 
			// EditContactButton
			// 
			this.EditContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
			this.EditContactButton.Location = new System.Drawing.Point(79, 0);
			this.EditContactButton.Margin = new System.Windows.Forms.Padding(0);
			this.EditContactButton.Name = "EditContactButton";
			this.EditContactButton.Size = new System.Drawing.Size(79, 34);
			this.EditContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.EditContactButton.TabIndex = 12;
			this.EditContactButton.TabStop = false;
			this.EditContactButton.MouseEnter += new System.EventHandler(this.EditContactButton_MouseEnter);
			this.EditContactButton.MouseLeave += new System.EventHandler(this.EditContactButton_MouseLeave);
			// 
			// RemoveContactButton
			// 
			this.RemoveContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RemoveContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
			this.RemoveContactButton.Location = new System.Drawing.Point(158, 0);
			this.RemoveContactButton.Margin = new System.Windows.Forms.Padding(0);
			this.RemoveContactButton.Name = "RemoveContactButton";
			this.RemoveContactButton.Size = new System.Drawing.Size(80, 34);
			this.RemoveContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.RemoveContactButton.TabIndex = 12;
			this.RemoveContactButton.TabStop = false;
			this.RemoveContactButton.MouseEnter += new System.EventHandler(this.RemoveContactButton_MouseEnter);
			this.RemoveContactButton.MouseLeave += new System.EventHandler(this.RemoveContactButton_MouseLeave);
			// 
			// FindContactLabel
			// 
			this.FindContactLabel.AutoSize = true;
			this.FindContactLabel.Location = new System.Drawing.Point(3, 5);
			this.FindContactLabel.Name = "FindContactLabel";
			this.FindContactLabel.Size = new System.Drawing.Size(33, 15);
			this.FindContactLabel.TabIndex = 2;
			this.FindContactLabel.Text = "Find:";
			// 
			// FindTextBox
			// 
			this.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FindTextBox.Location = new System.Drawing.Point(42, 3);
			this.FindTextBox.Name = "FindTextBox";
			this.FindTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.FindTextBox.Size = new System.Drawing.Size(199, 23);
			this.FindTextBox.TabIndex = 1;
			// 
			// ContactsListBox
			// 
			this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ContactsListBox.FormattingEnabled = true;
			this.ContactsListBox.IntegralHeight = false;
			this.ContactsListBox.ItemHeight = 15;
			this.ContactsListBox.Items.AddRange(new object[] {
            "Абдулбасиров Магомедтагир",
            "Абельцев Сергей",
            "Аверчев Владимир",
            "Агафонов Валентин",
            "Агафонов Егор",
            "Адамишин Анатолий",
            "Айздердзис Андрей",
            "Айпин Еремей",
            "Акбаев Азрет"});
			this.ContactsListBox.Location = new System.Drawing.Point(3, 32);
			this.ContactsListBox.Name = "ContactsListBox";
			this.ContactsListBox.Size = new System.Drawing.Size(238, 375);
			this.ContactsListBox.TabIndex = 0;
			// 
			// ContactDisplayPanel
			// 
			this.ContactDisplayPanel.Controls.Add(this.NotificationPanel);
			this.ContactDisplayPanel.Controls.Add(this.VKTextBox);
			this.ContactDisplayPanel.Controls.Add(this.VKLabel);
			this.ContactDisplayPanel.Controls.Add(this.DateOfBirthTextBox);
			this.ContactDisplayPanel.Controls.Add(this.DateOfBirthLabel);
			this.ContactDisplayPanel.Controls.Add(this.PhoneNumberTextBox);
			this.ContactDisplayPanel.Controls.Add(this.PhoneNumberLabel);
			this.ContactDisplayPanel.Controls.Add(this.EmailTextBox);
			this.ContactDisplayPanel.Controls.Add(this.EmailLabel);
			this.ContactDisplayPanel.Controls.Add(this.FullNameTextBox);
			this.ContactDisplayPanel.Controls.Add(this.FullNameLabel);
			this.ContactDisplayPanel.Controls.Add(this.ContactPictureBox);
			this.ContactDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContactDisplayPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ContactDisplayPanel.Location = new System.Drawing.Point(253, 3);
			this.ContactDisplayPanel.Name = "ContactDisplayPanel";
			this.ContactDisplayPanel.Size = new System.Drawing.Size(544, 444);
			this.ContactDisplayPanel.TabIndex = 1;
			// 
			// NotificationPanel
			// 
			this.NotificationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NotificationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
			this.NotificationPanel.Controls.Add(this.CloseNotificationButton);
			this.NotificationPanel.Controls.Add(this.NotificationSurnamesLabel);
			this.NotificationPanel.Controls.Add(this.NotficationBirthdayLabel);
			this.NotificationPanel.Controls.Add(this.NotificationPictureBox);
			this.NotificationPanel.Location = new System.Drawing.Point(0, 369);
			this.NotificationPanel.Name = "NotificationPanel";
			this.NotificationPanel.Size = new System.Drawing.Size(544, 75);
			this.NotificationPanel.TabIndex = 11;
			// 
			// CloseNotificationButton
			// 
			this.CloseNotificationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseNotificationButton.FlatAppearance.BorderSize = 0;
			this.CloseNotificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseNotificationButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
			this.CloseNotificationButton.Location = new System.Drawing.Point(509, 3);
			this.CloseNotificationButton.Name = "CloseNotificationButton";
			this.CloseNotificationButton.Size = new System.Drawing.Size(32, 32);
			this.CloseNotificationButton.TabIndex = 3;
			this.CloseNotificationButton.UseVisualStyleBackColor = true;
			// 
			// NotificationSurnamesLabel
			// 
			this.NotificationSurnamesLabel.AutoSize = true;
			this.NotificationSurnamesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.NotificationSurnamesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
			this.NotificationSurnamesLabel.Location = new System.Drawing.Point(79, 38);
			this.NotificationSurnamesLabel.Name = "NotificationSurnamesLabel";
			this.NotificationSurnamesLabel.Size = new System.Drawing.Size(192, 15);
			this.NotificationSurnamesLabel.TabIndex = 2;
			this.NotificationSurnamesLabel.Text = "Абакумов, Петров, Иванов и др.";
			// 
			// NotficationBirthdayLabel
			// 
			this.NotficationBirthdayLabel.AutoSize = true;
			this.NotficationBirthdayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.NotficationBirthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
			this.NotficationBirthdayLabel.Location = new System.Drawing.Point(79, 23);
			this.NotficationBirthdayLabel.Name = "NotficationBirthdayLabel";
			this.NotficationBirthdayLabel.Size = new System.Drawing.Size(127, 15);
			this.NotficationBirthdayLabel.TabIndex = 1;
			this.NotficationBirthdayLabel.Text = "Today is a Bitrhday of:";
			// 
			// NotificationPictureBox
			// 
			this.NotificationPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
			this.NotificationPictureBox.Location = new System.Drawing.Point(3, 3);
			this.NotificationPictureBox.Name = "NotificationPictureBox";
			this.NotificationPictureBox.Size = new System.Drawing.Size(70, 70);
			this.NotificationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.NotificationPictureBox.TabIndex = 0;
			this.NotificationPictureBox.TabStop = false;
			// 
			// VKTextBox
			// 
			this.VKTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.VKTextBox.Location = new System.Drawing.Point(109, 239);
			this.VKTextBox.Name = "VKTextBox";
			this.VKTextBox.Size = new System.Drawing.Size(175, 23);
			this.VKTextBox.TabIndex = 10;
			this.VKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VKTextBox_KeyPress);
			// 
			// VKLabel
			// 
			this.VKLabel.AutoSize = true;
			this.VKLabel.Location = new System.Drawing.Point(109, 221);
			this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.VKLabel.Name = "VKLabel";
			this.VKLabel.Size = new System.Drawing.Size(24, 15);
			this.VKLabel.TabIndex = 9;
			this.VKLabel.Text = "VK:";
			// 
			// DateOfBirthTextBox
			// 
			this.DateOfBirthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DateOfBirthTextBox.Location = new System.Drawing.Point(109, 185);
			this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
			this.DateOfBirthTextBox.Size = new System.Drawing.Size(175, 23);
			this.DateOfBirthTextBox.TabIndex = 8;
			this.DateOfBirthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateOfBirthTextBox_KeyPress);
			// 
			// DateOfBirthLabel
			// 
			this.DateOfBirthLabel.AutoSize = true;
			this.DateOfBirthLabel.Location = new System.Drawing.Point(109, 167);
			this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.DateOfBirthLabel.Name = "DateOfBirthLabel";
			this.DateOfBirthLabel.Size = new System.Drawing.Size(76, 15);
			this.DateOfBirthLabel.TabIndex = 7;
			this.DateOfBirthLabel.Text = "Date of Birth:";
			// 
			// PhoneNumberTextBox
			// 
			this.PhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PhoneNumberTextBox.Location = new System.Drawing.Point(109, 131);
			this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
			this.PhoneNumberTextBox.Size = new System.Drawing.Size(175, 23);
			this.PhoneNumberTextBox.TabIndex = 6;
			this.PhoneNumberTextBox.Text = "+7(999) 111-22-33";
			this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
			// 
			// PhoneNumberLabel
			// 
			this.PhoneNumberLabel.AutoSize = true;
			this.PhoneNumberLabel.Location = new System.Drawing.Point(109, 113);
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
			this.EmailTextBox.Location = new System.Drawing.Point(109, 77);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(435, 23);
			this.EmailTextBox.TabIndex = 4;
			this.EmailTextBox.Text = "abakumov@no.mail";
			this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(109, 59);
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
			this.FullNameTextBox.Location = new System.Drawing.Point(109, 23);
			this.FullNameTextBox.Name = "FullNameTextBox";
			this.FullNameTextBox.Size = new System.Drawing.Size(435, 23);
			this.FullNameTextBox.TabIndex = 2;
			this.FullNameTextBox.Text = "Абакумов Дмитрий Николаевич";
			this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
			// 
			// FullNameLabel
			// 
			this.FullNameLabel.AutoSize = true;
			this.FullNameLabel.Location = new System.Drawing.Point(109, 5);
			this.FullNameLabel.Name = "FullNameLabel";
			this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
			this.FullNameLabel.TabIndex = 1;
			this.FullNameLabel.Text = "Full Name:";
			// 
			// ContactPictureBox
			// 
			this.ContactPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
			this.ContactPictureBox.Location = new System.Drawing.Point(3, 3);
			this.ContactPictureBox.Name = "ContactPictureBox";
			this.ContactPictureBox.Size = new System.Drawing.Size(100, 100);
			this.ContactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ContactPictureBox.TabIndex = 0;
			this.ContactPictureBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ContactsAppTableLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "ContactsApp";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.ContactsAppTableLayoutPanel.ResumeLayout(false);
			this.ContactsManagementPanel.ResumeLayout(false);
			this.ContactsManagementPanel.PerformLayout();
			this.ButtonsTableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RemoveContactButton)).EndInit();
			this.ContactDisplayPanel.ResumeLayout(false);
			this.ContactDisplayPanel.PerformLayout();
			this.NotificationPanel.ResumeLayout(false);
			this.NotificationPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NotificationPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ContactPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel ContactsAppTableLayoutPanel;
		private Panel ContactsManagementPanel;
		private Panel ContactDisplayPanel;
		private Label FindContactLabel;
		private TextBox FindTextBox;
		private ListBox ContactsListBox;
		private TableLayoutPanel ButtonsTableLayoutPanel;
		private PictureBox ContactPictureBox;
		private Label FullNameLabel;
		private TextBox FullNameTextBox;
		private Label EmailLabel;
		private TextBox PhoneNumberTextBox;
		private Label PhoneNumberLabel;
		private TextBox EmailTextBox;
		private TextBox VKTextBox;
		private Label VKLabel;
		private TextBox DateOfBirthTextBox;
		private Label DateOfBirthLabel;
		private Panel NotificationPanel;
		private PictureBox NotificationPictureBox;
		private Label NotficationBirthdayLabel;
		private Label NotificationSurnamesLabel;
		private Button CloseNotificationButton;
		private PictureBox RemoveContactButton;
		private PictureBox EditContactButton;
		private PictureBox AddContactButton;
	}
}