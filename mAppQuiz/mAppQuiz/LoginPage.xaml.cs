using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mAppQuiz
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnLoginClick(object sender, EventArgs e)
        {
            if (await this.DisplayAlert("Alert", "You have clicked Login", "Ok", "Cancel"))
            {

            }
        }

        async void OnSignUpClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}
