using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mAppQuiz.Data
{
    public class Answer
    {
        public string Prompt { get; set; }
        public string ParentAnswer { get; set; }
        private readonly ObservableCollection<string> _SubChoices = new ObservableCollection<string>();
        public ObservableCollection<string> SubChoices {
            get { return _SubChoices; }
        }

        public Answer (string prompt, string parent, string choice1, string choice2, string choice3)
        {
            Prompt = prompt;
            ParentAnswer = parent;
            SubChoices.Add(choice1);
            SubChoices.Add(choice2);
            SubChoices.Add(choice3);
        }
    }
}
