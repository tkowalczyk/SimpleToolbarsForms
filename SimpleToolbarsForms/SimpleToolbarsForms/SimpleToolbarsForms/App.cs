using SimpleToolbarsForms.Views;
using Xamarin.Forms;

namespace SimpleToolbarsForms
{
	public class App : Application
	{
		public App()
		{
			MainPage = new NavigationPage(new MainView());
		}
	}
}