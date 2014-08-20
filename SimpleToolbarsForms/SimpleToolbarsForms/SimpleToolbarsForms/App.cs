using SimpleToolbarsForms.Views;
using Xamarin.Forms;

namespace SimpleToolbarsForms
{
	public class App
	{
        private static Page NavPage;
        public static Page GetMainPage()
        {
            NavPage = new NavigationPage(new MainView());

            return NavPage;
        }
	}
}
