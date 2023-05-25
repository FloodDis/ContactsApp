namespace ContactsApp.UnitTests;

[TestFixture]
internal class ProjectManagerTest
{
	[Test(Description = "Тест сохранения и загрузки списка контактов")]
	public void Test_ProjectManager_SaveLoad()
	{
		// Setup
		var project = new Project();
		var contactToAdd = ContactFactory.CreateContact();

		// Testing
		project.AddContact(contactToAdd);
		project.AddContact(contactToAdd);
		var expected = project.Contacts;
		ProjectManager.Save(project);
		var actual = ProjectManager.Load().Contacts;

		// Assert
		Assert.AreEqual(expected.ToString(), actual.ToString());

		if (File.Exists(ProjectManager.Path))
		{
			File.Delete(ProjectManager.Path);
		}
	}

	[Test(Description ="Тест свойства Path")]
	public void Test_ProjectManager_Path() 
	{
		var expected = @"..\Notes.txt";

		ProjectManager.Path = expected;
		var actual = ProjectManager.Path;

		Assert.AreEqual(expected, actual);
	}
}
