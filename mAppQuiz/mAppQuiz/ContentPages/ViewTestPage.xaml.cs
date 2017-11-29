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
	public partial class ViewTestPage : ContentPage
	{
        	public Test CurrentTest { get; set; }
        	//need to access test grades somehow
		public ViewTestPage (Test selectedTest)
		{
			InitializeComponent ();
        		CurrentTest = selectedTest;
		}

        	private async void TakeTest(object sender, EventArgs e)
       		{
            		Page InProgressTest = (Page)new TakeTestPage(CurrentTest.Questions);
            		await Navigation.PushAsync(InProgressTest);
       		}
    }
}
