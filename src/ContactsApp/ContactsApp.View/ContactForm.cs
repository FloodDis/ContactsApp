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

	/// <summary>
	/// Конструктор формы.
	/// </summary>
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
	/// Присвоить данные из элементов формы в объект _contact.
	/// </summary>
	private void UpdateContact()
	{
		_contact.FullName = FullNameTextBox.Text;
		_contact.Email = EmailTextBox.Text;
		_contact.PhoneNumber = PhoneNumberTextBox.Text;
		_contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
		_contact.VKId = VKTextBox.Text;
	}

	/// <summary>
	/// Проверяет правильность введенных данных
	/// </summary>
	/// <returns>true - ошибок нет, false - есть ошибки при введении данных.</returns>
	private bool CheckFormOnErrors()
	{
		string allErrors = "";
		if (_surnameError != "")
		{
			allErrors += _surnameError + "\n";
		}
		if (_emailError != "")
		{
			allErrors += _emailError + "\n";
		}
		if (_phoneNumberError != "")
		{
			allErrors += _phoneNumberError + "\n";
		}
		if (_dateOfBirthError != "")
		{ 
			allErrors += _dateOfBirthError + "\n";
		}
		if(_vkIdError != "")
		{
			allErrors += _vkIdError + "\n";
		}
		if(allErrors != "")
		{
			MessageBox.Show(allErrors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
		return true;
	}

	/// <summary>
	/// Изменяет цвет картинки для добавления фотографии
	/// при наведении на нее курсора.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
	{
		AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
	}

	/// <summary>
	/// Изменяет цвет картинки для добавления фотографии
	/// при отведении от нее курсора.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
	{
		AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
	}

	/// <summary>
	/// Закрывает форму.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void CancelButton_Click(object sender, EventArgs e)
	{
		Close();
	}

	/// <summary>
	/// Запрещает вводить в поле для номера телефона все
	/// символы, кроме цифр и '-', '(', ')', ' ', '+'.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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
		UpdateContact();
	}
}
