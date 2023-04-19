using PracownicyMVP.Model;
using static PracownicyMVP.Model.Employee;

namespace PracownicyMVP.View
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
		}

		public event Action AddPerson;
		public event Action SerializeList;
		public event Action DeserializeList;
		public event Action<int> SelectEmployee;
		public event Action Reset;

		void SelectEmployeeFromListBox(object sender, EventArgs e)
		{
			if (sender is ListBox listbox)
			{
				SelectEmployee?.Invoke(listbox.SelectedIndex);
			}
		}
		public void AddToListBox(Employee p)
		{
			listBox1.Items.Add(p);
		}

		private void addPerson(object sender, EventArgs e)
		{
			AddPerson?.Invoke();
		}

		private void serialize_list(object sender, EventArgs e)
		{
			SerializeList?.Invoke();
		}

		private void deserialize_list(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			DeserializeList?.Invoke();
		}

		public void SetFormValues(Employee p)
		{
			textBox1.Text = p.Name;
			textBox2.Text = p.Surname;
			dateTimePicker1.Value = p.Birthdate;
			numericUpDown1.Value = p.Salary;
			comboBox1.SelectedIndex = (int)p.Position;
			switch (p.Contract)
			{
				case TypeOfContract.Indefinite:
					radioButton1.Checked = true;
					break;
				case TypeOfContract.FixedTerm:
					radioButton2.Checked = true;
					break;
				case TypeOfContract.Comission:
					radioButton2.Checked = true;
					break;
			}
		}

		private void reset(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Reset?.Invoke();
		}
	}
}