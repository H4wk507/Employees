using PracownicyMVP.Model;
using static PracownicyMVP.Model.Employee;

namespace PracownicyMVP.Presenter
{
    class MainPresenter
    {
        private readonly View.Form1 view;
        private readonly EmployeeList model;
        public MainPresenter(View.Form1 view, EmployeeList model)
        {
            this.view = view;
            this.model = model;
            this.view.AddPerson += AddPerson;
            this.view.SelectEmployee += SelectEmployee;
            this.view.SerializeList += SerializeList;
            this.view.DeserializeList += DeserializeList;
            this.view.Reset += Reset;
        }

        private void Reset()
        {
            model.list.Clear();
        }

        private void DeserializeList()
        {
            model.Deserialize();
			foreach (Employee p in model.list)
			{
				view.AddToListBox(p);
			}
		}

        private void SerializeList()
        {
            model.Serialize();
        }

        private void AddPerson()
        {
            if (string.IsNullOrEmpty(view.textBox1.Text) || 
                string.IsNullOrEmpty(view.textBox2.Text))
            {
                MessageBox.Show("Wypełnij brakujące pola!");
            }
            else
            {
                TypeOfContract radioValue = TypeOfContract.Indefinite;
                if (view.radioButton2.Checked)
                {
					radioValue = TypeOfContract.FixedTerm;
				}
				else if (view.radioButton3.Checked)
                {
					radioValue = TypeOfContract.Comission;
				}
                TypeOfPosition position = StringToPosition(view.comboBox1.Text);
				Employee pracownik = new(view.textBox1.Text, view.textBox2.Text, view.dateTimePicker1.Value, 
                    view.numericUpDown1.Value, position, radioValue);
                model.list.Add(pracownik);
                view.AddToListBox(pracownik);
            }
        }

        private void SelectEmployee(int index)
        {
            /* handles selecting employee from the listbox */
            if (index > -1 && index < model.list.Count)
            {
                Employee p = model.list.ElementAt(index);
                view.SetFormValues(p);
            }
        }

        private static TypeOfPosition StringToPosition(string s)
        {
			return s switch
			{
				"Inżynier" => TypeOfPosition.Engineer,
				"Młodszy Programista" => TypeOfPosition.Junior,
				"Projektant" => TypeOfPosition.Designer,
				"Starszy Programista" => TypeOfPosition.Senior,
				"Tester" => TypeOfPosition.Tester,
				_ => TypeOfPosition.Unknown,
			};
		}

        
    }
}
