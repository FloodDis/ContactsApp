using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model;

/// <summary>
/// Проект.
/// </summary>
internal class Project
{
	/// <summary>
	/// Список всех контактов, созданных в приложении.
	/// </summary>
	private List<Contact> _contacts;

	/// <summary>
	/// Возвращает кол-во контактов в списке.
	/// </summary>
	public int ContactsCount
	{
		get { return _contacts.Count; }
	}

	/// <summary>
	/// Возвращает или задает контакт по индексу.
	/// </summary>
	/// <param name="index">Индекс контакта.</param>
	public Contact this[int index]
	{
		get { return _contacts[index]; }
		set
		{
			_contacts[index] = value;
			SortContactsByFullName();
		}
	}

	/// <summary>
	/// Удаляет контакт из списка.
	/// </summary>
	/// <param name="index">Индекс контакта.</param>
	void RemoveContact(int index)
	{
		_contacts.RemoveAt(index);
	}

	/// <summary>
	/// Добавляет контакт в список.
	/// </summary>
	/// <param name="contact">Контакт, который нужно добавить.</param>
	void AddContact(Contact contact)
	{
		_contacts.Add(contact);
	}

	/// <summary>
	/// Сортирует контакты в списке по полному имени.
	/// </summary>
	void SortContactsByFullName()
	{
		var sortedContacts = _contacts.OrderBy(x => x.FullName);
		_contacts = sortedContacts.ToList();
	}

	/// <summary>
	/// Находит в списке контактов именинников.
	/// </summary>
	/// <returns>Список именнинков.</returns>
	List<Contact> FindBirthdayPeople()
	{
		List<Contact> result = new();
		foreach (Contact contact in _contacts)
		{
			if (contact.DateOfBirth == DateTime.Today)
			{
				result.Add(contact);
			}
		}

		return result;
	}

	/// <summary>
	/// Находит контакты по подстроке.
	/// </summary>
	/// <param name="subString">Подстрока, по которой производится поиск.</param>
	/// <returns>Список контактов, содержащих в себе подстроку.</returns>
	List<Contact> FindContactsBySubstring(string subString)
	{
		List<Contact> result = new();
		foreach (Contact contact in _contacts)
		{
			if (contact.FullName.Contains(subString))
			{
				result.Add(contact);
			}
		}

		return result;
	}
}
