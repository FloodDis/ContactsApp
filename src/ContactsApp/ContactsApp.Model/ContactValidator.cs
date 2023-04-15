namespace ContactsApp.Model;

public static class ContactValidator
{
	public static void CheckLengthOfValue(string value, string objectName, int maxLength)
	{
		if(value.Length > maxLength)
		{
			var message = $"{objectName} не может быть больше {maxLength} символов.";
			throw new ArgumentException(message);
		}
	}
}
