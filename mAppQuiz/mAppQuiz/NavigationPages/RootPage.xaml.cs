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
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;
            sideBar.ListView.ItemSelected += OnItemSelectedAsync;
        }

        async void OnItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as RootPageMenuItem;
            if (item != null)
            {
                Page displayPage = (Page)Activator.CreateInstance(item.TargetType);
                await Detail.Navigation.PushAsync(displayPage);
                //Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                sideBar.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }

    }
}