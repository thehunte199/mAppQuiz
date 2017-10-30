using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace mAppQuiz
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
            InitializeComponent();
		}

        async void ViewClasses(object sender, EventArgs e)
        {
            await DisplayAlert("wee", "woo", "blah");
        }
	
	aync void CreateClass(object sender, EventArgs e)
	{
	    await DisplayAlert("I", "AM", "THE", "WALRUS");
	}

    }
}
