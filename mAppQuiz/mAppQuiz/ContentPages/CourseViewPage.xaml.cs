using mAppQuiz.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mAppQuiz.ContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseViewPage : ContentPage
    {
        ListView Tests { get { return tests; } }
        public CourseViewPage(Course course)
        {
            InitializeComponent();
            Tests.ItemsSource = course.Tests;
            this.BindingContext = course;
        }
    }
}