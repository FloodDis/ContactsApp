using ContactsApp.Model;
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
		foreach(Contact contact in _displayedContacts)
		{
			ContactsListBox.Items.Add(contact.FullName);
		}
	} 

	private void AddContactButton_MouseEnter(object sender, EventArgs e)
	{
		AddContactButton.Image = Properties.Resources.add_contact_32x32;
		AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
	}

	private void AddContactButton_Click(object sender, EventArgs e)
	{
		var contactForm = new ContactForm();
		contactForm.ShowDialog();
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
		if(e.KeyCode == Keys.F1)
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
}