using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mAppQuiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnLoginClick(object sender, EventArgs e)
        {
            if (await this.DisplayAlert("Alert", "You have clicked Login", "Ok", "Cancel"))
            {

            }
        }
    }
}
