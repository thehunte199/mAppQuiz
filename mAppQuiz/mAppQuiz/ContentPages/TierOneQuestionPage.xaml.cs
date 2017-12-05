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
    public partial class TierOneQuestionPage : ContentPage
    {
        private ListView Answers { get { return AnswersList; } }
        private ObservableCollection<Answer> answers;
        public TierOneQuestionPage(string prompt, ObservableCollection<Answer> answers)
        {
            InitializeComponent();
            Answers.Header = prompt;
            this.answers = answers;
            Answers.ItemsSource = this.answers;
            Answers.ItemSelected += AnswerSelected;

        }

        private async void AnswerSelected(object sender, EventArgs e)
        {
            Answer select = ((Answer)((Button)sender).CommandParameter);
            Page tierTwoQuestionPage = (Page)new TierTwoQuestionPage(select.SubPrompt, select.SubChoices);
            await Navigation.PushAsync(tierTwoQuestionPage);
        }
    }
}