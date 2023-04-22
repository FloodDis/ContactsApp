using ContactsApp.Model;
using System.Security.Policy;

namespace ContactsApp.View;

public partial class ContactForm : Form
{
	/// <summary>
	/// Контакт.
	/// </summary>
	private Contact _contact = new Contact();

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

		UpdateForm();
	}

	/// <summary>
	/// Возвращает или задает контакт.
	/// </summary>
	public Contact Contact
	{
		get { return _contact; }
		set 
		{ 
			_contact = value;
			UpdateForm();
		}
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
	/// Проверяет правильность введенных данных.
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
		if (_vkIdError != "")
		{
			allErrors += _vkIdError + "\n";
		}
		if (allErrors != "")
		{
			MessageBox.Show(allErrors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
		return true;
	}

	/// <summary>
	/// Изменяет цвет иконки добавления фотографии при наведении
	/// на нее курсора.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
	{
		AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
	}

	/// <summary>
	/// Изменяет цвет иконки добавления фотографии, когда курсор
	/// не наведен на нее.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
	{
		AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
	}

	/// <summary>
	/// Проверяет вводимые символы в поле для номера телефона.
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

	/// <summary>
	/// Присваивает полное имя, введенное в текстовое поле,
	/// соотвестующей переменной.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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

	/// <summary>
	/// Присваивает email, введенный в текстовое поле,
	/// соотвестующей переменной.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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

	/// <summary>
	/// Присваивает номер телефона, введенный в текстовое поле,
	/// соотвестующей переменной.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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

	/// <summary>
	/// Присваивает дату рождения, выбранную в DateTimePicker,
	/// соотвестующей переменной.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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

	/// <summary>
	/// Присваивает VK ID, введенный в текстовое поле,
	/// соотвестующей переменной.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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

	/// <summary>
	/// Добавляет новый контакт/обновляет старый.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void OKButton_Click(object sender, EventArgs e)
	{
		if (!CheckFormOnErrors())
		{
			return;
		}

		UpdateContact();

		DialogResult = DialogResult.OK;
		Close();
	}

	/// <summary>
	/// Отменяет добавление/редактирование контакта.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void CancelButton_Click(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}
}
