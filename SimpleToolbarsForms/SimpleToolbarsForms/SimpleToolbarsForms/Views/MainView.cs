using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace SimpleToolbarsForms.Views
{
    public class MainView : BaseView
    {
        #region Ctor
        public MainView()
        {
            this.BackgroundImage = "home.png";

            Button goToAnotherView = new Button
            {
                Text = "Go to AnotherView",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };

            goToAnotherView.Clicked += (s, e) =>
                {
                    Navigation.PushAsync(new AnotherView());
                };

            this.Content = goToAnotherView;
        }
        #endregion
    }
}