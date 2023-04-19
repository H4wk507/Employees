using System.Xml.Serialization;

namespace PracownicyMVP.Model
{
	public class EmployeeList
	{
		public List<Employee> list = new();

		public void Serialize()
		{
			XmlSerializer serializer = new(typeof(List<Employee>));
			using FileStream fileStream = new("./serialized.xml", FileMode.Create);
			serializer.Serialize(fileStream, list);
			MessageBox.Show("Zapisano pomyślnie!");
		}

		public void Deserialize()
		{
			if (!File.Exists("./serialized.xml"))
			{
				return;
			}
			list.Clear();
			XmlSerializer deserializer = new(typeof(List<Employee>), new XmlRootAttribute("ArrayOfEmployee"));
			File.Exists("./serialized.xml");
			using FileStream fileStream = new("./serialized.xml", FileMode.Open);
			List<Employee>? employees = (List<Employee>?)deserializer.Deserialize(fileStream);
			if (employees != null)
			{
				foreach (Employee p in employees)
				{
					list.Add(p);
				}
			}
		}
	}

}
