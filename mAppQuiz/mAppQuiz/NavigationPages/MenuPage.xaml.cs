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
		{InitializeComponent ();
            var masterPageItems = new List<RootPageMenuItem>();
            masterPageItems.Add(new RootPageMenuItem
            {
                Title = "Sign-up Page",
                IconSource = "contacts.png",
                TargetType = typeof(SignUpPage)
            });
            masterPageItems.Add(new RootPageMenuItem
            {
                Title = "Home Page",
                IconSource = "todo.png",
                TargetType = typeof(SignUpPage)
            });
            masterPageItems.Add(new RootPageMenuItem
            {
                Title = "Reminders",
                IconSource = "reminders.png",
                TargetType = typeof(SignUpPage)
            });

            listView.ItemsSource = masterPageItems;
        }
	}
}