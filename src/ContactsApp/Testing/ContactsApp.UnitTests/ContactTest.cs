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
}