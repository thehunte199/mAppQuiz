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
	public partial class TakeTestPage : ContentPage
	{
        ListView Questions { get { return questions; } }
		public TakeTestPage (ObservableCollection<Question> testQuestions)
		{
			InitializeComponent ();
            Questions.ItemsSource = testQuestions;
            Questions.ItemSelected += AnswerSelected;
		}

        private async void AnswerSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Page tierTwoQuestionPage = (Page)new TierTwoQuestionPage();
            await Navigation.PushAsync(tierTwoQuestionPage);
        }
    }
}