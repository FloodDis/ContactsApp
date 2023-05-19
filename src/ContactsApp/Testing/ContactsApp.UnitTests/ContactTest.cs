namespace ContactsApp.UnitTests;

[TestFixture]
public class ContactTest
{
	[Test(Description = "Позитивный тест геттера и сеттера FullName")]
	public void Test_FullName_CorrectValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = "Сеченов Владислав";
		contact.FullName = expected;
		var actual = contact.FullName;

		//Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "Негативный тест геттера и сеттера FullName (длина имени больше 100)")]
	public void Test_FullName_FalseValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var wrongFullName = "Сеченов ВладиславСеченов ВладиславСеченов ВладиславСеченов ВладиславСеченов ВладиславСеченов ВладиславСеченов ВладиславСеченов Владислав";
		
		//Assert
		Assert.Throws<ArgumentException>(() => contact.FullName = wrongFullName,
			"Должно возникать исключение, если полное имя длиннее 100 символов");
	}

	[Test(Description = "Тест геттера и сеттера FullName (каждое слово начинается с заглавной буквы)")]
	public void Test_FullName_TitleCase()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = "Сеченов Владислав";
		contact.FullName = "сеченов владислав";
		var actual = contact.FullName;

		//Assert
		Assert.AreEqual(expected, actual);
	}
}