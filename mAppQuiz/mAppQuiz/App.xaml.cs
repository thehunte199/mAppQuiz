using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace mAppQuiz
{
    public partial class App : Application
    {
        public NavigationPage TopNavigation { get; private set; }


        public App()
        {
            InitializeComponent();
            var sideBarMenu = new MenuPage();
            TopNavigation = new NavigationPage(new MainPage());
            var hamburgerBar = new RootPage();
            hamburgerBar.Master = sideBarMenu;
            //This detail page is actually the login screen wrapped w/ navigation functionality
            hamburgerBar.Detail = TopNavigation;
            MainPage = hamburgerBar;
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
