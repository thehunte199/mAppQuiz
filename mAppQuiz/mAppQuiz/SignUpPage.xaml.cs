using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mAppQuiz
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage()
		{
			InitializeComponent ();
		}

        async void OnSignUp(object sender, EventArgs e)
        {
            if (isValidEmail(this.Email.Text.Trim())) {
                this.Email.BackgroundColor = Color.Transparent;
                await this.DisplayAlert("Signed up", "You have clicked Sign Up", "Ok", "Cancel");
            } else {
                this.Email.BackgroundColor = Color.Red;
            }
        }

        public bool isValidEmail(string value)
        {
            if (value == null)
            {
                return false;
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(value);

            return match.Success;
        }
    }
}