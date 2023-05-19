namespace ContactsApp.UnitTests;

[TestFixture]
public class ContactTest
{
	[Test(Description = "���������� ���� ������� � ������� FullName")]
	public void Test_FullName_CorrectValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = "������� ���������";
		contact.FullName = expected;
		var actual = contact.FullName;

		//Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "���������� ���� ������� � ������� FullName (����� ����� ������ 100)")]
	public void Test_FullName_FalseValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var wrongFullName = "������� ���������������� ���������������� ���������������� ���������������� ���������������� ���������������� ���������������� ���������";
		
		//Assert
		Assert.Throws<ArgumentException>(() => contact.FullName = wrongFullName,
			"������ ��������� ����������, ���� ������ ��� ������� 100 ��������");
	}

	[Test(Description = "���� ������� � ������� FullName (������ ����� ���������� � ��������� �����)")]
	public void Test_FullName_TitleCase()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = "������� ���������";
		contact.FullName = "������� ���������";
		var actual = contact.FullName;

		//Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "���������� ���� ������� � ������� Email")]
	public void Test_Email_CorrectValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = "hjasfd@mail.ru";
		contact.Email = expected;
		var actual = contact.FullName;

		//Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "���������� ���� ������� � ������� Email (����� email ������ 100)")]
	public void Test_Email_FalseValue_EmailLength()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var wrongEmail = "hjdfdsbhdvhsbhjacsbhjacsbasbhabcshbascbhjacsbhjasbchabschbascbacsbhjacsbhjascbhjaschaschvjacsvhjavscavschvacsvhjacshjavschvacsvhascvhjasvchacsjvacvajcvjhacjhacsvhjv@mail.ru"

		//Assert
		Assert.Throws<ArgumentException>(() => contact.FullName = wrongEmail,
			"������ ��������� ����������, ���� email ������� 100 ��������");
	}

	[Test(Description = "���������� ���� ������� � ������� Email (email ������ ��������������� Regex ��������)")]
	public void Test_Email_FalseValue_RegexPattern()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var wrongEmail = "jskdfhk";

		//Assert
		Assert.Throws<ArgumentException>(() => contact.FullName = wrongEmail,
			"������ ��������� ����������, ���� email �� ������������ Regex ��������");
	}
}