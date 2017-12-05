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
            Tests.ItemSelected += OnSelection;

        }

        private async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            Test selectedTest = e.SelectedItem as Test;
            Page viewTest = (Page) new ViewTestPage(selectedTest);
            await Navigation.PushAsync(viewTest);
            Tests.SelectedItem = null;
        }
    }
}