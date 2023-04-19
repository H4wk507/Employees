namespace PracownicyMVP.Model
{
    public class Employee
    {
        public enum TypeOfPosition {
            Engineer,
            Junior,
            Designer,
            Senior,
            Tester,
            Unknown,
        }

        public enum TypeOfContract
        {
            Indefinite,
            FixedTerm,
            Comission,
            Unknown,
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public decimal Salary { get; set; }
        public TypeOfPosition Position { get; set; }
        public TypeOfContract Contract { get; set; }
	    public Employee() {}
		public Employee(string name, string surname, DateTime birthdate, decimal salary, 
            TypeOfPosition position, TypeOfContract contract)
		{
			Name = name;
            Surname = surname;
            Birthdate = birthdate;
            Salary = salary;
            Position = position;
            Contract = contract;
		}

		public override string ToString()
        {
            string position = PositionToString(Position);
            string contract = ContractToString(Contract);
            return $"{Name}, {Surname}, {Birthdate.ToShortDateString()}, {Salary}, {position}, {contract}";
        }

		private static string ContractToString(TypeOfContract c)
		{
			return c switch
			{
				TypeOfContract.Indefinite => "Nieokreślony",
				TypeOfContract.FixedTerm => "Określony",
				TypeOfContract.Comission => "Zlecenie",
				_ => "Unknown",
			};
		}
		private static string PositionToString(TypeOfPosition p)
        {
			return p switch
			{
				TypeOfPosition.Engineer => "Inżynier",
				TypeOfPosition.Junior => "Młodszy Programista",
				TypeOfPosition.Designer => "Projektant",
				TypeOfPosition.Senior => "Starszy Programista",
				TypeOfPosition.Tester => "Tester",
				_ => "Unknown",
			};
		}
	}
}
