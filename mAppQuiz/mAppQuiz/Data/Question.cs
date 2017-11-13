using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mAppQuiz.Data
{
    public class Question
    {
        public string Prompt { get; set; }
        //this private dummy is necessary for setting answers to entirely 
        //new collection while maintaining automatic view update functionality
        private ObservableCollection<Answer> _answers;
        public ObservableCollection<Answer> Answers {
            get { return _answers; }
            set { _answers = value; }
        }
        public bool Answered { get; set; }
        //NOTE: these could be used for indexing so will be initialized to -1
        public int ParentAnswer { get; set; }
        public int SubAnswer { get; set; }
        public Tuple<int, int> CorrectAnswers { get; set; }

        public Question (string prompt, ObservableCollection<Answer> answers, int correctParent, int correctSub)
        {
            Prompt = prompt;
            Answers = answers;
            CorrectAnswers = Tuple.Create<int, int>(correctParent, correctSub);
            Answered = false;
            ParentAnswer = -1;
            SubAnswer = -1;
        }

    }
}
