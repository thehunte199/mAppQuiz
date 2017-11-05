using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace mAppQuiz.ContentPages
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
            InitializeComponent();
		}

        async void ViewCourses(object sender, EventArgs e)
        {
            await DisplayAlert("wee", "woo", "blah");
        }
	
	    async void CreateCourse(object sender, EventArgs e)
	    {
	     await DisplayAlert("I", "AM", "THE", "WALRUS");
	    }
    }
}
