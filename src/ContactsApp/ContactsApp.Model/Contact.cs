using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model;

/// <summary>
/// Класс контакта.
/// </summary>
internal class Contact
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
	/// ID ВКонтакте контакта
	/// </summary>
	private string _vkId;

	/// <summary>
	/// Возвращает или задает полное имя контакта.
	/// </summary>
	public string FullName
	{
		get { return _fullName; }
		set 
		{ 
			if(value.Length > 100)
			{
				throw 
					new ArgumentException("Полное имя не может быть больше 100 символов!");
			}
			/*string nameToCheck = value;
			string[] nameArray = nameToCheck.Split(' ');

			for (int i = 0; i < nameArray.Length; i++)
			{

				if (nameArray[i][0].ToString().ToUpper() != nameArray[i][0].ToString())
				{

				}
			}*/
			_fullName = value;
		}
	}

	public string Email
	{
		get { return _email; }
		set
		{
			if(value.Length > 100)
			{
				throw
					new ArgumentException("Email не может быть больше 100 символов!");
			}
		}
	}

	public string PhoneNumber
	{
		get { return _phoneNumber; }
		set
		{
			
			_phoneNumber = value;
		}
	}

	public DateTime DateOfBirth
	{
		get { return _dateOfBirth; }
		set
		{
			_dateOfBirth = value;
		}
	}

	public string VKId
	{
		get { return _vkId; }
		set
		{
			if(value.Length > 50) 
			{
				throw
					new ArgumentException("VKId не может быть больше 50 символов!");
			}
			_vkId = value;
		}
	}
}
