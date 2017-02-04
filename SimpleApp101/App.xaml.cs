using Xamarin.Forms;

namespace SimpleApp101
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new SimpleApp101Page();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
