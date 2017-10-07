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
#pragma warning disable CS0618 // Type or member is obsolete
            logo.Source = Device.OnPlatform(
                iOS: ImageSource.FromResource("appealing_logo.png"),
                Android: ImageSource.FromFile("appealing_logo.png"),
                WinPhone: ImageSource.FromFile("Images/logical_logo.png"));
#pragma warning restore CS0618 // Type or member is obsolete
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
