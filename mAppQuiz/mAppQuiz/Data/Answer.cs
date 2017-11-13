﻿using System;
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
        private readonly ObservableCollection<string> _SubChoices = new ObservableCollection<string>();
        public ObservableCollection<string> SubChoices {
            get { return _SubChoices; }
        }

        public Answer (string choice, string subChoice1, string subChoice2, string subChoice3)
        {
            ParentChoice = choice;
            SubChoices.Add(subChoice1);
            SubChoices.Add(subChoice2);
            SubChoices.Add(subChoice3);
        }
    }
}
