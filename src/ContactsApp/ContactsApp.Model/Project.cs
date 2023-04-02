namespace ContactsApp.Model;

/// <summary>
/// Описывает проект.
/// </summary>
public class Project
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
	public void RemoveContact(int index)
	{
		_contacts.RemoveAt(index);
	}

	/// <summary>
	/// Добавляет контакт в список.
	/// </summary>
	/// <param name="contact">Контакт, который нужно добавить.</param>
	public void AddContact(Contact contact)
	{
		_contacts.Add(contact);
	}

	/// <summary>
	/// Сортирует контакты в списке по полному имени.
	/// </summary>
	public void SortContactsByFullName()
	{
		var sortedContacts = _contacts.OrderBy(x => x.FullName);
		_contacts = sortedContacts.ToList();
	}

	/// <summary>
	/// Находит в списке контактов именинников.
	/// </summary>
	/// <returns>Список именнинков.</returns>
	public List<Contact> FindBirthdayPeople()
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
	public List<Contact> FindContactsBySubstring(string subString)
	{
		List<Contact> result = new();
		foreach (Contact contact in _contacts)
		{
			if (contact.FullName.Contains(subString))
			{
				result.Add(contact);
			}
		}

		if (result.Count == 0)
		{
			return _contacts;
		}

		return result;
	}

	/// <summary>
	/// Конструктор по умолчанию.
	/// </summary>
	public Project()
	{
		_contacts = new List<Contact>();
	}
}
