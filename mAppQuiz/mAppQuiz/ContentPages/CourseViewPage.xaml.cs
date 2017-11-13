using mAppQuiz.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}