using System.Globalization;
using System.Text.RegularExpressions;

namespace ContactsApp.Model;

/// <summary>
/// Описывает контакт.
/// </summary>
public class Contact
{
	/// <summary>
	/// Паттерн для валидации email.
	/// Пример правильного email: dshkg@mail.ru
	/// </summary>
	private const string _emailRegex = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

	/// <summary>
	/// Паттерн для валидации номера телефона.
	/// Пример правильного номера телефона: 
	/// +79261234567
	/// 89261234567
	/// 79261234567
	/// +7 926 123 45 67
	/// 8(926)123-45-67
	/// 123-45-67
	/// 9261234567
	/// 79261234567
	/// (495)1234567
	/// (495) 123 45 67
	/// 89261234567
	/// 8-926-123-45-67
	/// 8 927 1234 234
	/// 8 927 12 12 888
	/// 8 927 12 555 12
	/// 8 927 123 8 123
	/// </summary>
	private const string _phoneNumberRegex = "^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$";

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
	/// Возвращает или задает полное имя контакта.
	/// </summary>
	public string FullName
	{
		get
		{
			return _fullName;
		}
		set
		{
			if (value.Length > 100)
			{
				var message = "Полное имя не может быть больше 100 символов.";
				throw new ArgumentException(message);
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
				var message = "Полное имя не может быть больше 100 символов.";
				throw new ArgumentException(message);
			}
			if (!Regex.IsMatch(value, _emailRegex))
			{
				var message = "Email введен неверно.";
				throw new ArgumentException(message);
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
			if (!Regex.IsMatch(value, _phoneNumberRegex))
			{
				var message = "Номер телефона введен неверно.";
				throw new ArgumentException(message);
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
				var message = "Год рождения не может быть меньше 1900.";
				throw new ArgumentException(message);
			}
			if (value.Year > DateTime.Now.Year)
			{
				var message = "Дата рождения не может быть позже сегодняшнего дня.";
				throw new ArgumentException(message);
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
				var message = "VKId не может быть больше 50 символов.";
				throw new ArgumentException(message);
			}
			_vkId = value;
		}
	}
}
