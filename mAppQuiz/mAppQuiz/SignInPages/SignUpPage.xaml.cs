using mAppQuiz.Data;
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
            string email = this.Email.Text.Trim();
            if (isValidEmail(email)) {
                this.Email.BackgroundColor = Color.Transparent;
                UserProfile newProfile = new UserProfile(this.FName.Text, this.LName.Text, email, new User(this.Username.Text, this.Password.Text));
                //TODO: Needs to create a JSON object using newProfile and send that to data store
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