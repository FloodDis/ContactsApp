using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp.Model;

static public class ProjectManager
{
	/// <summary>
	/// Путь по умолчанию для сохранения и загрузки
	/// </summary>
	private static string _defaultPath = Environment.ExpandEnvironmentVariables(@".\Notes.txt");

	/// <summary>
	/// Заданный пользователем путь для сохранения и загрузки
	/// </summary>
	private static string _path = _defaultPath;

	public static string Path
	{
		get { return _path; }
		set { _path = value; }
	}

	/// <summary>
	/// Сохранить список заметок
	/// </summary>
	/// <param name="project">Список заметок для сохранения</param>
	public static void Save(Project project)
	{
		JsonSerializer serializer = new();
		if (!File.Exists(_path))
		{
			File.Create(_path).Close();
		}

		using (StreamWriter sw = new(_path))
		using (JsonWriter writer = new JsonTextWriter(sw))
		{
			serializer.Serialize(writer, project);
		}
	}

	/// <summary>
	/// Загрузить список заметок
	/// </summary>
	/// <returns>Загруженный список заметок</returns>
	public static Project Load()
	{
		Project project = new();
		JsonSerializer serializer = new();
		if (!File.Exists(_path))
		{
			return new Project();
		}

		using (StreamReader sr = new(_path))
		using (JsonReader reader = new JsonTextReader(sr))
		{
			project = serializer.Deserialize<Project>(reader);
		}

		if (project == null)
		{
			return new Project();
		}
		return project;
	}
}
