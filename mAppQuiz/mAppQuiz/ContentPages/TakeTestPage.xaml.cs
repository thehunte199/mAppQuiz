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
        private ListView Questions { get { return questions; } }
        private ObservableCollection<Question> choices;
		public TakeTestPage (Test testQuestions)
		{
			InitializeComponent ();
            this.BindingContext = testQuestions;
            choices = testQuestions.Questions;
            Questions.ItemsSource = choices;
            Questions.ItemSelected += QuestionSelected;
            System.Diagnostics.Debug.WriteLine(testQuestions.Questions.First().QPrompt);
		}

        private async void QuestionSelected(object sender, EventArgs e)
        {
            Question select = ((Question)((Button)sender).CommandParameter);
            System.Diagnostics.Debug.WriteLine(select.QPrompt);
            Page tierOneQuestionPage = (Page)new TierOneQuestionPage(select.QPrompt, select.Answers);
            await Navigation.PushAsync(tierOneQuestionPage);
        }
    }
}