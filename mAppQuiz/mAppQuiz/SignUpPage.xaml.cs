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
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage()
		{
			InitializeComponent ();
		}

        async void OnSignUp(object sender, EventArgs e)
        {
            UserInfo entered = new UserInfo((String) FName, (String) LName, 
            
            await this.DisplayAlert("Signed up", "", "", "");
        }
	}
}