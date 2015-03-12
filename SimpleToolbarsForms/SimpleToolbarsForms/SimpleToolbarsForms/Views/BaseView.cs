using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using System.Linq;

namespace SimpleToolbarsForms.Views
{
    public class BaseView : ContentPage
    {
        #region ToolBarItems
        private void OpenSettingsView()
        {
			DisplayAlert("Toolbar Sample", "Settings Clicked", "OK");
        }
        private void OpenSignUpView()
        {
			DisplayAlert("Toolbar Sample", "SignUp Clicked", "OK");
        }

        private void OpenSignInView()
        {
			DisplayAlert("Toolbar Sample", "SignIn Clicked", "OK");
        }

        private IList<ToolbarItem> GetToolBarItems()
        {
            var list = new List<ToolbarItem>();

            var tiGrid = new ToolbarItem
            {
                Priority = 0,
                Order = ToolbarItemOrder.Primary
            };

            list.Add(tiGrid);

            list.Add(
                new ToolbarItem(
                    "Settings",
                    "settings.png",
                    OpenSettingsView,
                    ToolbarItemOrder.Primary, 0)
                );
            list.Add(
                new ToolbarItem(
                    "Sign In",
                    "signin.png",
                    OpenSignInView,
                    ToolbarItemOrder.Secondary, 2)
                );
            list.Add(
                new ToolbarItem(
                    "Sign Up",
                    "signup.png",
                    OpenSignUpView,
                    ToolbarItemOrder.Secondary, 3)
                );

            return list;
        }
        #endregion

        #region Ctor
        public BaseView()
        {
            
        }
        #endregion

        #region Overrides
        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.ToolbarItems.Clear();

            var toolBarItemsList = new List<ToolbarItem>();
            toolBarItemsList = GetToolBarItems().ToList<ToolbarItem>();

            foreach (var toolBarItem in toolBarItemsList)
            {
                this.ToolbarItems.Add(toolBarItem);
            }
        }
        #endregion
    }
}