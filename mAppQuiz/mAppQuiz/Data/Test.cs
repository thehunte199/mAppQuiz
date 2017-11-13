using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mAppQuiz.Data
{
    public class Test
    {
        private ObservableCollection<Question> _questions;
        public ObservableCollection<Question> Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        //This is similar to a hashmap, seemed a short term decent way to store and access test scores
        public Dictionary<string, int> Scores;

        public Test(ObservableCollection<Question> questions, string name, 
            string description, Dictionary<string, int> scores)
        {
            Questions = questions;
            Name = name;
            Description = description;
            Scores = scores;
        }
        
    }
}
