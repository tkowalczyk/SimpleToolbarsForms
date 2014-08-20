using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace SimpleToolbarsForms.Views
{
    public class MainView : BaseView
    {
        #region ToolBarItems
        private void OpenSettingsView()
        {
            Debug.WriteLine("Settings Clicked");
        }
        private void OpenSignUpView()
        {
            Debug.WriteLine("SignUp Clicked");
        }

        private void OpenSignInView()
        {
            Debug.WriteLine("SignIn Clicked");
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
        public MainView()
        {
            this.ToolbarItems.Clear();

            this.BackgroundImage = "home.png";

            var toolBarItemsList = new List<ToolbarItem>();
            toolBarItemsList = GetToolBarItems().ToList<ToolbarItem>();

            foreach (var toolBarItem in toolBarItemsList)
            {
                this.ToolbarItems.Add(toolBarItem);
            }

            this.Content = new Label
            {
                Text = "MainView",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
        }
        #endregion
    }
}