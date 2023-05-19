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
		var actual = contact.Email;

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
		Assert.Throws<ArgumentException>(() => contact.Email = wrongEmail,
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
		Assert.Throws<ArgumentException>(() => contact.Email = wrongEmail,
			"������ ��������� ����������, ���� email �� ������������ Regex ��������");
	}

	[Test(Description = "���������� ���� ������� � ������� PhoneNumber")]
	public void Test_PhoneNumber_CorrectValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var firstExpected = "+7 (345) 234-45-65";
		contact.PhoneNumber = firstExpected;
		var firstActual = contact.PhoneNumber;

		var secondExpected = "+79261234567";
		contact.PhoneNumber = secondExpected;
		var secondActual = contact.PhoneNumber;

		var thirdExpected = "89261234567";
		contact.PhoneNumber = thirdExpected;
		var thirdActual = contact.PhoneNumber;

		//Assert
		Assert.AreEqual(firstExpected, firstActual);
		Assert.AreEqual(secondExpected, secondActual);
		Assert.AreEqual(thirdExpected, thirdActual);
	}

	[Test(Description = "���������� ���� ������� � ������� PhoneNumber")]
	public void Test_PhoneNumber_FalseValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var firstWrongPhoneNumber = "98643";
		var secondWrongPhoneNumber = "75823";
		var thirdWrongPhoneNumber = "+74321";

		//Assert
		Assert.Throws<ArgumentException>(() => contact.PhoneNumber = firstWrongPhoneNumber,
			"������ ��������� ����������, ���� ����� �������� �� ������������ Regex ��������");
		Assert.Throws<ArgumentException>(() => contact.PhoneNumber = secondWrongPhoneNumber,
			"������ ��������� ����������, ���� ����� �������� �� ������������ Regex ��������");
		Assert.Throws<ArgumentException>(() => contact.PhoneNumber = thirdWrongPhoneNumber,
			"������ ��������� ����������, ���� ����� �������� �� ������������ Regex ��������");
	}

	[Test(Description = "���������� ���� ������� � ������� DateOfBirth")]
	public void Test_DateOfBirth_CorrectValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = DateTime.Now;
		contact.DateOfBirth = expected;
		var actual = contact.DateOfBirth;

		//Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "���������� ���� ������� � ������� DateOfBirth (��� �������� ������ 1900)")]
	public void Test_DateOfBirth_FalseValue_MinValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var wrongDateOfBirth = new DateTime(1899,10,12);

		//Assert
		Assert.Throws<ArgumentException>(() => contact.DateOfBirth = wrongDateOfBirth,
			"������ ��������� ����������, ���� ����� �������� �� ������������ Regex ��������");
	}

	[Test(Description = "���������� ���� ������� � ������� DateOfBirth (��� �������� ������ �������� ����)")]
	public void Test_DateOfBirth_FalseValue_MaxValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var wrongDateOfBirth = new DateTime(DateTime.Today.Year, 1, 3);

		//Assert
		Assert.Throws<ArgumentException>(() => contact.DateOfBirth = wrongDateOfBirth,
			"������ ��������� ����������, ���� ����� �������� �� ������������ Regex ��������");
	}
}