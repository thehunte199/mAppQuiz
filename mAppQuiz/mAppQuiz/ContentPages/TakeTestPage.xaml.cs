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
		public TakeTestPage (Test testQuestions)
		{
			InitializeComponent ();
            this.BindingContext = testQuestions;
            Questions.ItemsSource = testQuestions.Questions;
            Questions.ItemSelected += AnswerSelected;
            System.Diagnostics.Debug.WriteLine(testQuestions.Questions.First().QPrompt);
		}

        private async void AnswerSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Page tierTwoQuestionPage = (Page)new TierTwoQuestionPage();
            await Navigation.PushAsync(tierTwoQuestionPage);
        }
    }
}