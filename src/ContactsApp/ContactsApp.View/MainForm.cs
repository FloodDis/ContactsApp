using ContactsApp.Model;
using System;
using System.ComponentModel.Design;

namespace ContactsApp.View;

public partial class MainForm : Form
{
	/// <summary>
	/// Список всех контактов.
	/// </summary>
	private Project _project;

	/// <summary>
	/// Список отображаемых контактов.
	/// </summary>
	private List<Contact> _displayedContacts;

	public MainForm()
	{
		InitializeComponent();
		_project = new Project();
		_displayedContacts = new List<Contact>();
	}

	/// <summary>
	/// Обновить отображаемые контакты в ListBox.
	/// </summary>
	private void UpdateListBox()
	{
		List<Contact> contacts = _project.FindContactsBySubstring(FindTextBox.Text);
		_displayedContacts.Clear();
		_displayedContacts.AddRange(contacts);
		ContactsListBox.Items.Clear();
		foreach (Contact contact in _displayedContacts)
		{
			ContactsListBox.Items.Add(contact.FullName);
		}
	}

	/// <summary>
	/// Обновить отображаемый на правой панели контакт.
	/// </summary>
	private void UpdateSelectedContact(int index)
	{
		Contact contactToShow = _displayedContacts[index];
		FullNameTextBox.Text = contactToShow.FullName;
		EmailTextBox.Text = contactToShow.Email;
		PhoneNumberTextBox.Text = contactToShow.PhoneNumber;
		DateOfBirthTextBox.Text = contactToShow.DateOfBirth.ToString();
		VKTextBox.Text = contactToShow.VKId;
	}

	private void ClearSelectedContact()
	{
		FullNameTextBox.Text = "";
		EmailTextBox.Text = "";
		PhoneNumberTextBox.Text = "";
		DateOfBirthTextBox.Text = "";
		VKTextBox.Text = "";
	}

	private void AddContactButton_MouseEnter(object sender, EventArgs e)
	{
		AddContactButton.Image = Properties.Resources.add_contact_32x32;
		AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
	}

	private void AddContactButton_Click(object sender, EventArgs e)
	{
		string[] fullNames = {
			"Сеченов Владислав", "Иван Иванов", "Кирилл Сидоров",
			"Алена Сергеева", "Евгений Дмитриев", "Роман Романов",
			"Ирина Попова", "Павел Семёнов", "Семён Кузнецов"
		};

		string[] emails = {
			"adh@mail.ru", "bjcksd@mail.ru", "cbhds@mail.ru",
			"bhcge@mail.ru", "vbyuru@mail.ru", "b3h2@mail.ru",
			"bviriroir@mail.ru", "vbudh34@mail.ru", "vbhf52@mail.ru"
		};

		var rand = new Random();
		int fullNameIndex = rand.Next(fullNames.Length);
		int emailIndex = rand.Next(emails.Length);

		Contact newContact = new();
		newContact.FullName = fullNames[fullNameIndex];
		newContact.Email = emails[emailIndex];
		newContact.VKId = rand.Next(100000).ToString();
		newContact.PhoneNumber =
			"+7 (" + rand.Next(100, 999).ToString() + ") "
			+ rand.Next(100, 999).ToString() + "-"
			+ rand.Next(10, 99).ToString() + "-"
			+ rand.Next(10, 99).ToString();
		newContact.DateOfBirth = DateTime.Today;
		_project.AddContact(newContact);
		UpdateListBox();
	}

	private void AddContactButton_MouseLeave(object sender, EventArgs e)
	{
		AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
		AddContactButton.BackColor = Color.White;
	}

	private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
	{
		RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
		RemoveContactButton.BackColor = Color.FromArgb(250, 245, 245);
	}

	private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
	{
		RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
		RemoveContactButton.BackColor = Color.White;
	}

	private void EditContactButton_MouseEnter(object sender, EventArgs e)
	{
		EditContactButton.Image = Properties.Resources.edit_contact_32x32;
		EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
	}

	private void EditContactButton_MouseLeave(object sender, EventArgs e)
	{
		EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
		EditContactButton.BackColor = Color.White;
	}

	private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.Handled = true;
	}

	private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.Handled = true;
	}

	private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.Handled = true;
	}

	private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.Handled = true;
	}

	private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.Handled = true;
	}

	private void MainForm_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.F1)
		{
			var aboutForm = new AboutForm();
			aboutForm.ShowDialog();
		}
	}

	private void CloseNotificationButton_Click(object sender, EventArgs e)
	{
		CloseNotificationButton.Visible = false;
		NotificationPanel.Visible = false;
		NotificationPictureBox.Visible = false;
		NotificationSurnamesLabel.Visible = false;
		NotficationBirthdayLabel.Visible = false;
	}

	private void RemoveContactButton_Click(object sender, EventArgs e)
	{
		if (ContactsListBox.SelectedIndex == -1)
		{
			ClearSelectedContact();
			return;
		}

		DialogResult result = MessageBox.Show("Do you really want to remove...?",
			"Remove element",
			MessageBoxButtons.OKCancel);
		if (result == DialogResult.OK)
		{
			_project.RemoveContact(ContactsListBox.SelectedIndex);
			UpdateListBox();
			if (ContactsListBox.Items.Count == 0)
			{
				ClearSelectedContact();
			}
		}
	}

	private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ContactsListBox.SelectedIndex == -1)
		{
			ClearSelectedContact();
			return;
		}
		UpdateSelectedContact(ContactsListBox.SelectedIndex);
	}
}