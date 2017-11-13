using mAppQuiz.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mAppQuiz.Facades
{
    static class DataFacade
    {
        public static ObservableCollection<Course> getCourses(string input)
        {
            //This is for testing purposes until we get our database running
            if (input == "test")
            {
                Answer exampleAnswer0 = new Answer("example Tier1 answer A", 
                    "Example Tier2Answer A0", "Example Tier2Answer A1", "Example Tier2Answer A2");
                Answer exampleAnswer1 = new Answer("example Tier1 answer B",
                    "Example Tier2Answer B0", "Example Tier2Answer B1", "Example Tier2Answer B2");
                Answer exampleAnswer2 = new Answer("example Tier1 answer C",
                    "Example Tier2Answer C0", "Example Tier2Answer C1", "Example Tier2Answer C2");
                Answer exampleAnswer3 = new Answer("example Tier1 answer D",
                    "Example Tier2Answer D0", "Example Tier2Answer D1", "Example Tier2Answer D2");
                ObservableCollection<Answer> Q1Answers = new ObservableCollection<Answer>();
                Q1Answers.Add(exampleAnswer0);
                Q1Answers.Add(exampleAnswer1);
                Q1Answers.Add(exampleAnswer2);
                Q1Answers.Add(exampleAnswer3);
                int TIER1ANSWER = 0;
                int TIER2ANSWER = 0;
                Question exampleQuestion1 = new Question("Example Question 1 prompt: ", Q1Answers, TIER1ANSWER, TIER2ANSWER);
                ObservableCollection<Question> Test1Questions = new ObservableCollection<Question>();
                Test1Questions.Add(exampleQuestion1);
                Test exampleTest = new Test(Test1Questions, "Example Test1", "This is an example test", null);
                ObservableCollection<Test> Course1Tests = new ObservableCollection<Test>();
                Course1Tests.Add(exampleTest);
                Course exampleCourse = new Course(Course1Tests, "Example Course1", "James Ward", "example course description");
                ObservableCollection<Course> exampleCourses = new ObservableCollection<Course>();
                exampleCourses.Add(exampleCourse);
                return exampleCourses;
            }
            return null;
        }
    }
}
