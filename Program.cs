namespace PracownicyMVP
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var view = new View.Form1();
			var model = new Model.EmployeeList();
			var presenter = new Presenter.MainPresenter(view, model);
			Application.Run(view);
		}
	}
}