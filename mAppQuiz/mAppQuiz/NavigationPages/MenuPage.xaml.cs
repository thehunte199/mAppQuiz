using mAppQuiz.ContentPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mAppQuiz
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MenuPage : ContentPage
	{
        public ListView ListView { get { return listView; } }
        public MenuPage ()
		{
            InitializeComponent ();
            var masterPageItems = new List<RootPageMenuItem>();
            masterPageItems.Add(new RootPageMenuItem
            {
                Title = "Home Page",
                IconSource = "contacts.png",
                TargetType = typeof(HomePage)
            });
            masterPageItems.Add(new RootPageMenuItem
            {
                Title = "Create Course",
                IconSource = "todo.png",
                TargetType = typeof(CreateCoursePage)
            });
            masterPageItems.Add(new RootPageMenuItem
            {
                Title = "View User Profile",
                IconSource = "reminders.png",
                TargetType = typeof(UserProfilePage)
            });
            masterPageItems.Add(new RootPageMenuItem
            {
                Title = "Settings",
                IconSource = "reminders.png",
                TargetType = typeof(SettingsPage)
            });

            listView.ItemsSource = masterPageItems;
        }

        void LogoutClicked(object sender, EventArgs e)
        {
            //Still need to clear user data once we have this set up.
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }

}