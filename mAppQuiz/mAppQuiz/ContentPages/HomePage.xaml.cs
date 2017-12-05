using mAppQuiz.Facades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            ObservableCollection<Data.Course> myCourses = DataFacade.getCourses("test");
            Page viewCoursesPage = (Page)new ViewCoursesPage(myCourses);
            await Navigation.PushAsync(viewCoursesPage);
        }
	
	    async void CreateCourse(object sender, EventArgs e)
	    {
	     await DisplayAlert("I", "AM", "THE", "WALRUS");
	    }
    }
}
