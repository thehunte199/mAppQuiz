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
                Answer exampleAnswer0 = new Answer("example Tier1 answer A", "A",
                    new SubAnswer("Example Tier2Answer A0"), new SubAnswer("Example Tier2Answer A1"), new SubAnswer("Example Tier2Answer A2"));
                Answer exampleAnswer1 = new Answer("example Tier1 answer B", "B",
                    new SubAnswer("Example Tier2Answer B0"), new SubAnswer("Example Tier2Answer B1"), new SubAnswer("Example Tier2Answer B2"));
                Answer exampleAnswer2 = new Answer("example Tier1 answer C", "C",
                    new SubAnswer("Example Tier2Answer C0"), new SubAnswer("Example Tier2Answer C1"), new SubAnswer("Example Tier2Answer C2"));
                Answer exampleAnswer3 = new Answer("example Tier1 answer D", "D",
                    new SubAnswer("Example Tier2Answer D0"), new SubAnswer("Example Tier2Answer D1"), new SubAnswer("Example Tier2Answer D2"));
                ObservableCollection<Answer> T1Q1Answers = new ObservableCollection<Answer>();
                T1Q1Answers.Add(exampleAnswer0);
                T1Q1Answers.Add(exampleAnswer1);
                T1Q1Answers.Add(exampleAnswer2);
                T1Q1Answers.Add(exampleAnswer3);
                int TIER1ANSWER = 0;
                int TIER2ANSWER = 0;
                Question exampleQuestion1 = new Question("Example Question 1 prompt: ", T1Q1Answers, TIER1ANSWER, TIER2ANSWER);
                Question exampleQuestion2 = new Question("Example Question 2 prompt: ", T1Q1Answers, TIER1ANSWER, TIER2ANSWER);
                Question exampleQuestion3 = new Question("Example Question 3 prompt: ", T1Q1Answers, TIER1ANSWER, TIER2ANSWER);
                Question exampleQuestion4 = new Question("Example Question 4 prompt: ", T1Q1Answers, TIER1ANSWER, TIER2ANSWER);
                ObservableCollection<Question> Test1Questions = new ObservableCollection<Question>();
                Test1Questions.Add(exampleQuestion1);
                Test1Questions.Add(exampleQuestion2);
                Test1Questions.Add(exampleQuestion3);
                Test1Questions.Add(exampleQuestion4);
                Test exampleTest = new Test(Test1Questions, "Example Test1", "This is an example test", null);
                Test exampleTest1 = new Test(Test1Questions, "Example Test2", "This is an example test", null);
                Test exampleTest2 = new Test(Test1Questions, "Example Test3", "This is an example test", null);
                ObservableCollection<Test> Course1Tests = new ObservableCollection<Test>();
                Course1Tests.Add(exampleTest);
                Course1Tests.Add(exampleTest1);
                Course1Tests.Add(exampleTest2);
                Course exampleCourse1 = new Course(Course1Tests, "Example Course1", "James Ward", "example course description");

                ObservableCollection<Answer> T2Q1Answers = new ObservableCollection<Answer>
                {
                    exampleAnswer0,
                    exampleAnswer1,
                    exampleAnswer2,
                    exampleAnswer3
                };
                int T2TIER1ANSWER = 1;
                int T2TIER2ANSWER = 1;
                Question T2exampleQuestion1 = new Question("Example Question 1 prompt: ", T2Q1Answers, T2TIER1ANSWER, T2TIER2ANSWER);
                ObservableCollection<Question> Test2Questions = new ObservableCollection<Question>
                {
                    T2exampleQuestion1
                };
                Test exampleTest3 = new Test(Test2Questions, "Example Test4", "This is an example test", null);
                ObservableCollection<Test> Course2Tests = new ObservableCollection<Test>
                {
                    exampleTest,
                    exampleTest2,
                    exampleTest2,
                    exampleTest3
                };
                Course exampleCourse2 = new Course(Course2Tests, "Example Course2", "Jay Fenwick", "this is an example course");
                Course exampleCourse3 = new Course(Course1Tests, "Example Course3", "Yoda", "example course, this is");

                ObservableCollection<Course> exampleCourses = new ObservableCollection<Course>
                {
                    exampleCourse1,
                    exampleCourse2,
                    exampleCourse3
                };
                return exampleCourses;
            }
            return null;
        }
    }
}
