using mAppQuiz.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mAppQuiz.ContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewCoursesPage : ContentPage
    {
        public ListView Courses { get { return courses; } }
        public ViewCoursesPage(ObservableCollection<Course> dbCourses)
        {
            InitializeComponent();
            Courses.ItemsSource = dbCourses;
            Courses.ItemSelected += OnSelection;
        }

        async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            Course myCourse = e.SelectedItem as Course;
            Page viewCourse = new CourseViewPage(myCourse);
            await Navigation.PushAsync(viewCourse);
            //await DisplayAlert(myCourse.Name, e.SelectedItem.ToString(), "Ok");
            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
        }
    }
}