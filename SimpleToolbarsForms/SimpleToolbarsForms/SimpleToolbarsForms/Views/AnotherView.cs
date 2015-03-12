using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SimpleToolbarsForms.Views
{
    public class AnotherView : BaseView
    {
        #region Ctor
        public AnotherView()
        {
            Button goBackButton = new Button
            {
                Text = "Go Back",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };

            goBackButton.Clicked += (s, e) =>
            {
                Navigation.PopAsync();
            };

            this.Content = goBackButton;
        }
        #endregion
    }
}