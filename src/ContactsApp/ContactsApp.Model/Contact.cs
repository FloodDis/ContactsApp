using System.Globalization;
using System.Text.RegularExpressions;

namespace ContactsApp.Model;

/// <summary>
/// Описывает контакт.
/// </summary>
public class Contact
{
	/// <summary>
	/// Полное имя контакта.
	/// </summary>
	private string _fullName;

	/// <summary>
	/// E-mail контакта.
	/// </summary>
	private string _email;

	/// <summary>
	/// Номер телефона контакта.
	/// </summary>
	private string _phoneNumber;

	/// <summary>
	/// Дата рождения контакта.
	/// </summary>
	private DateTime _dateOfBirth;

	/// <summary>
	/// ID ВКонтакте контакта.
	/// </summary>
	private string _vkId;

	/// <summary>
	/// Паттерн для валидации email.
	/// Пример правильного email: dshkg@mail.ru
	/// </summary>
	private const string _emailRegex = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

	/// <summary>
	/// Паттерн для валидации номера телефона.
	/// Пример правильного номера телефона: 8(926)123-45-67
	/// </summary>
	private const string _phoneNumberRegex = "^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$";

	/// <summary>
	/// Возвращает или задает полное имя контакта.
	/// </summary>
	public string FullName
	{
		get { return _fullName; }
		set
		{
			if (value.Length > 100)
			{
				throw
					new ArgumentException("Полное имя не может быть больше 100 символов!");
			}
			TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
			string titleCase = textInfo.ToTitleCase(value);
			_fullName = titleCase;
		}
	}

	/// <summary>
	/// Возвращает или задает E-mail контакта.
	/// </summary>
	public string Email
	{
		get
		{
			return _email;
		}
		set
		{
			if (value.Length > 100)
			{
				throw
					new ArgumentException("Email не может быть больше 100 символов!");
			}
			if (!Regex.IsMatch(value, _emailRegex))
			{
				throw
					new ArgumentException("Email введен неверно!");
			}
			_email = value;
		}
	}

	/// <summary>
	/// Возвращает или задает телефонный номер контакта.
	/// </summary>
	public string PhoneNumber
	{
		get
		{
			return _phoneNumber;
		}
		set 
		{ 
			if(!Regex.IsMatch(value, _phoneNumberRegex))
			{
				throw
					new ArgumentException("Номер телефона введен неверно!");
			}
			_phoneNumber = value; 
		}
	}

	/// <summary>
	/// Возвращает или задает день рождения контакта.
	/// </summary>
	public DateTime DateOfBirth
	{
		get
		{
			return _dateOfBirth;
		}
		set
		{
			if (value.Year < 1900)
			{
				throw new ArgumentException("Год рождения не может быть меньше 1900!");
			}
			if (value > DateTime.Today)
			{
				throw new ArgumentException("Дата рождения не может быть позже сегодняшнего дня!");
			}
			_dateOfBirth = value;
		}
	}

	/// <summary>
	/// Возвращает или задает ID Вконтакте контакта.  
	/// </summary>
	public string VKId
	{
		get
		{
			return _vkId;
		}
		set
		{
			if (value.Length > 50)
			{
				throw
					new ArgumentException("VKId не может быть больше 50 символов!");
			}
			_vkId = value;
		}
	}
}
