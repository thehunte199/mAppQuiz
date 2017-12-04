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
        public string ParentChoice { get; set; }
        private readonly ObservableCollection<SubAnswer> _SubChoices = new ObservableCollection<SubAnswer>();
        public ObservableCollection<SubAnswer> SubChoices {
            get { return _SubChoices; }
        }

        public Answer (string choice, SubAnswer subChoice1, SubAnswer subChoice2, SubAnswer subChoice3)
        {
            ParentChoice = choice;
            SubChoices.Add(subChoice1);
            SubChoices.Add(subChoice2);
            SubChoices.Add(subChoice3);
        }
    }
}
