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
	public partial class TierTwoQuestionPage : ContentPage
	{
        private ListView SubAnswers { get { return SubList; } }
        private ObservableCollection<SubAnswer> subAnswers;
		public TierTwoQuestionPage (string subPrompt, ObservableCollection<SubAnswer> subAnswers)
		{
			InitializeComponent ();
            SubAnswers.Header = subPrompt;
            this.subAnswers = subAnswers;
            SubAnswers.ItemsSource = this.subAnswers;
            SubAnswers.ItemSelected += SubSelected;
		}

        private async void SubSelected(object sender, EventArgs e)
        {
            //here is where you would use a facade to send off subanswer selected information
            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
            await Navigation.PopAsync();
        }
    }
}