using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mAppQuiz.Data
{
    public class Course
    {
        private ObservableCollection<Test> _tests;
        public ObservableCollection<Test> Tests
        {
            get { return _tests; }
            set { _tests = value; }
        }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Description { get; set; }

        public Course(ObservableCollection<Test> tests, string courseName, 
            string teacherName, string description)
        {
            Tests = tests;
            Name = courseName;
            Teacher = teacherName;
            Description = description;
        }
    }
}
