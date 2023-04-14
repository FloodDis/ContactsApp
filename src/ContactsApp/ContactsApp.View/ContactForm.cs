using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View;

public partial class ContactForm : Form
{
	/// <summary>
	/// Контакт.
	/// </summary>
	private Contact _contact;

	/// <summary>
	/// Текст ошибки при вводе полного имени контакта.
	/// </summary>
	private string _surnameError;

	/// <summary>
	/// Текст ошибки при вводе email контакта.
	/// </summary>
	private string _emailError;

	/// <summary>
	/// Текст ошибки при вводе номера телефона контакта.
	/// </summary>
	private string _phoneNumberError;

	/// <summary>
	/// Текст ошибки при вводе даты рождения контакта.
	/// </summary>
	private string _dateOfBirthError;

	/// <summary>
	/// Текст ошибки при вводе VK ID контакта.
	/// </summary>
	private string _vkIdError;

	public ContactForm()
	{
		InitializeComponent();
		_contact = ContactFactory.CreateContact();
		UpdateForm();
	}

	/// <summary>
	/// Отображает данные контакта в форме.
	/// </summary>
	private void UpdateForm()
	{
		FullNameTextBox.Text = _contact.FullName;
		EmailTextBox.Text = _contact.Email;
		PhoneNumberTextBox.Text = _contact.PhoneNumber;
		DateOfBirthDateTimePicker.Value = _contact.DateOfBirth;
		VKTextBox.Text = _contact.VKId;
	}

	/// <summary>
	/// Проверяет правильность введенных данных
	/// </summary>
	/// <returns>true - ошибок нет, false - есть ошибки при введении данных.</returns>
	private bool CheckFormOnErrors()
	{
		if (_surnameError != "")
		{
			MessageBox.Show(_surnameError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
		if (_emailError != "")
		{
			MessageBox.Show(_emailError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
		if (_phoneNumberError != "")
		{
			MessageBox.Show(_phoneNumberError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
		if (_dateOfBirthError != "")
		{
			MessageBox.Show(_dateOfBirthError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
		if(_vkIdError != "")
		{
			MessageBox.Show(_vkIdError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
		return true;
	}

	private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
	{
		AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
	}

	private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
	{
		AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
	}

	private void CancelButton_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
	{
		if ((e.KeyChar >= '0')
			&& (e.KeyChar <= '9')
			|| (e.KeyChar == '-')
			|| (e.KeyChar == '(')
			|| (e.KeyChar == ')')
			|| (e.KeyChar == ' ')
			|| (e.KeyChar == (char)Keys.Back)
			|| (e.KeyChar == '+'))
		{
			return;
		}
		e.Handled = true;
	}

	private void FullNameTextBox_TextChanged(object sender, EventArgs e)
	{
		try
		{
			_contact.FullName = FullNameTextBox.Text;
			FullNameTextBox.BackColor = Color.White;
			_surnameError = "";
		}
		catch (ArgumentException ex)
		{
			_surnameError = ex.Message;
			FullNameTextBox.BackColor = Color.LightPink;
		}
	}

	private void EmailTextBox_TextChanged(object sender, EventArgs e)
	{
		try
		{
			_contact.Email = EmailTextBox.Text;
			EmailTextBox.BackColor = Color.White;
			_emailError = "";
		}
		catch (ArgumentException ex)
		{
			_emailError = ex.Message;
			EmailTextBox.BackColor = Color.LightPink;
		}
	}

	private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
	{
		try
		{
			_contact.PhoneNumber = PhoneNumberTextBox.Text;
			PhoneNumberTextBox.BackColor = Color.White;
			_phoneNumberError = "";
		}
		catch (ArgumentException ex)
		{
			_phoneNumberError = ex.Message;
			PhoneNumberTextBox.BackColor = Color.LightPink;
		}
	}

	private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
	{
		try
		{
			_contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
			_dateOfBirthError = "";
		}
		catch (ArgumentException ex)
		{
			_dateOfBirthError = ex.Message;
		}
	}

	private void VKTextBox_TextChanged(object sender, EventArgs e)
	{
		try
		{
			_contact.VKId = VKTextBox.Text;
			VKTextBox.BackColor = Color.White;
			_vkIdError = "";
		}
		catch (ArgumentException ex)
		{
			_vkIdError = ex.Message;
			VKTextBox.BackColor = Color.LightPink;
		}
	}

	private void OKButton_Click(object sender, EventArgs e)
	{
		if (!CheckFormOnErrors())
		{
			return;
		}
	}
}
