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
                /** ------------------------------------  Course 1  -------------------------------------------------------
                 * Answers for Question 1 Test 1
                 */
                Answer answer1at1c1 = new Answer("Behavioral", "Name a pattern that fits in this category.",
                   "Template", "Decorator", "None of these");
                Answer answer1bt1c1 = new Answer("Creational", "Name a pattern that fits in this category.",
                    "Prototype", "Decorator", "None of these");
                Answer answer1ct1c1 = new Answer("Structural", "Name a pattern that fits in this category.",
                    "Bridge", "Factory Method", "None of these");
                Answer answer1dt1c1 = new Answer("Conventional", "Name a pattern that fits in this category.",
                    "Template", "State", "None of these");
                ObservableCollection<Answer> C1T1Q1Answers = new ObservableCollection<Answer>();
                C1T1Q1Answers.Add(answer1at1c1);
                C1T1Q1Answers.Add(answer1bt1c1);
                C1T1Q1Answers.Add(answer1ct1c1);
                C1T1Q1Answers.Add(answer1dt1c1);
                int C1T1Q1TIER1ANSWER = 0;
                int C1T1Q1TIER2ANSWER = 0;

                //Answers for Question 2 Test 1
                Answer answer2at1c1 = new Answer("", "",
                    "", "", "None of these");
                Answer answer2bt1c1 = new Answer("", "",
                    "", "", "None of these");
                Answer answer2ct1c1 = new Answer("", "",
                    "", "", "None of these");
                Answer answer2dt1c1 = new Answer("", "",
                    "", "", "None of these");
                ObservableCollection<Answer> C1T1Q2Answers = new ObservableCollection<Answer>();
                C1T1Q1Answers.Add(answer2at1c1);
                C1T1Q1Answers.Add(answer2bt1c1);
                C1T1Q1Answers.Add(answer2ct1c1);
                C1T1Q1Answers.Add(answer2dt1c1);
                int C1T1Q2TIER1ANSWER = 0;
                int C1T1Q2TIER2ANSWER = 0;

                //Answers for Question 3 Test 1
                Answer answer3at1c1 = new Answer("", "",
                    "", "", "None of these");
                Answer answer3bt1c1 = new Answer("", "",
                    "", "", "None of these");
                Answer answer3ct1c1 = new Answer("", "",
                    "", "", "None of these");
                Answer answer3dt1c1 = new Answer("", "",
                    "", "", "None of these");
                ObservableCollection<Answer> C1T1Q3Answers = new ObservableCollection<Answer>();
                C1T1Q1Answers.Add(answer2at1c1);
                C1T1Q1Answers.Add(answer2bt1c1);
                C1T1Q1Answers.Add(answer2ct1c1);
                C1T1Q1Answers.Add(answer2dt1c1);
                int C1T1Q3TIER1ANSWER = 0;
                int C1T1Q3TIER2ANSWER = 0;

                //Questions for Test 1
                Question question1t1c1 = new Question("_______________ patterns are concerned with how classes and objects interact and distribute responsibility.", C1T1Q1Answers, C1T1Q1TIER1ANSWER, C1T1Q1TIER2ANSWER);
                Question question2t1c1 = new Question("Example Question 2 prompt: ", C1T1Q2Answers, C1T1Q2TIER1ANSWER, C1T1Q2TIER2ANSWER);
                Question question3t1c1 = new Question("Example Question 3 prompt: ", C1T1Q3Answers, C1T1Q3TIER1ANSWER, C1T1Q3TIER2ANSWER);
                ObservableCollection<Question> Test1C1Questions = new ObservableCollection<Question>();
                Test1C1Questions.Add(question1t1c1);
                Test1C1Questions.Add(question2t1c1);
                Test1C1Questions.Add(question3t1c1);

                //Tests for Software Engineering Course
                Test test1c1 = new Test(Test1C1Questions, "Example Test1", "This is an example test", null);
                Test test2c1 = new Test(Test1C1Questions, "Example Test2", "This is an example test", null);
                ObservableCollection<Test> SoftwareEngineeringTests = new ObservableCollection<Test>();
                SoftwareEngineeringTests.Add(test1c1);
                SoftwareEngineeringTests.Add(test2c1);
                //Course 1
                Course softwareEngineering = new Course(SoftwareEngineeringTests, "Software Engineering", "Smith", "Learn about Design Patterns.");

                /** ------------------------------------  Course 2  -------------------------------------------------------
                 * Answers for Question 1 Test 1 Course 2
                 */
                Answer answer1at1c2 = new Answer("", "",
                    "", "", "None of these");
                Answer answer1bt1c2 = new Answer("", "",
                    "", "", "None of these");
                Answer answer1ct1c2 = new Answer("", "",
                    "", "", "None of these");
                Answer answer1dt1c2 = new Answer("", "",
                    "", "", "None of these");
                ObservableCollection<Answer> C2T1Q1Answers = new ObservableCollection<Answer>();
                C2T1Q1Answers.Add(answer1at1c2);
                C2T1Q1Answers.Add(answer1bt1c2);
                C2T1Q1Answers.Add(answer1ct1c2);
                C2T1Q1Answers.Add(answer1dt1c2);
                int C2T1Q1TIER1ANSWER = 0;
                int C2T1Q1TIER2ANSWER = 0;

                //Answers for Question 2 Test 1 Course 2
                Answer answer2at1c2 = new Answer("", "",
                    "", "", "None of these");
                Answer answer2bt1c2 = new Answer("", "",
                    "", "", "None of these");
                Answer answer2ct1c2 = new Answer("", "",
                    "", "", "None of these");
                Answer answer2dt1c2 = new Answer("", "",
                    "", "", "None of these");
                ObservableCollection<Answer> C2T1Q2Answers = new ObservableCollection<Answer>();
                C2T1Q1Answers.Add(answer2at1c2);
                C2T1Q1Answers.Add(answer2bt1c2);
                C2T1Q1Answers.Add(answer2ct1c2);
                C2T1Q1Answers.Add(answer2dt1c2);
                int C2T1Q2TIER1ANSWER = 0;
                int C2T1Q2TIER2ANSWER = 0;

                //Answers for Question 3 Test 1 Course 2
                Answer answer3at1c2 = new Answer("", "",
                    "", "", "None of these");
                Answer answer3bt1c2 = new Answer("", "",
                    "", "", "None of these");
                Answer answer3ct1c2 = new Answer("", "",
                    "", "", "None of these");
                Answer answer3dt1c2 = new Answer("", "",
                    "", "", "None of these");
                ObservableCollection<Answer> C2T1Q3Answers = new ObservableCollection<Answer>();
                C2T1Q1Answers.Add(answer2at1c2);
                C2T1Q1Answers.Add(answer2bt1c2);
                C2T1Q1Answers.Add(answer2ct1c2);
                C2T1Q1Answers.Add(answer2dt1c2);
                int C2T1Q3TIER1ANSWER = 0;
                int C2T1Q3TIER2ANSWER = 0;

                //Questions for Test 1 Course 2
                Question question1t1c2 = new Question("_______________ patterns are concerned with how classes and objects interact and distribute responsibility.", C2T1Q1Answers, C2T1Q1TIER1ANSWER, C2T1Q1TIER2ANSWER);
                Question question2t1c2 = new Question("Example Question 2 prompt: ", C2T1Q2Answers, C2T1Q2TIER1ANSWER, C2T1Q2TIER2ANSWER);
                Question question3t1c2 = new Question("Example Question 3 prompt: ", C2T1Q3Answers, C2T1Q3TIER1ANSWER, C2T1Q3TIER2ANSWER);
                ObservableCollection<Question> Test1C2Questions = new ObservableCollection<Question>();
                Test1C2Questions.Add(question1t1c1);
                Test1C2Questions.Add(question2t1c1);
                Test1C2Questions.Add(question3t1c1);

                //Tests for Software Engineering Course
                Test test1c2 = new Test(Test1C2Questions, "Example Test1", "This is an example test", null);
                Test test2c2 = new Test(Test1C2Questions, "Example Test2", "This is an example test", null);
                ObservableCollection<Test> Course2Tests = new ObservableCollection<Test>();
                SoftwareEngineeringTests.Add(test1c2);
                SoftwareEngineeringTests.Add(test2c2);
                //Course 2
                Course course2 = new Course(Course2Tests, "Course 2", "Johnson", "Learn about...");

                /** ------------------------------------  Course 3  -------------------------------------------------------
                 * Answers for Question 1 Test 1 Course 3
                 */
                Answer answer1at1c3 = new Answer("", "",
                    "", "", "None of these");
                Answer answer1bt1c3 = new Answer("", "",
                    "", "", "None of these");
                Answer answer1ct1c3 = new Answer("", "",
                    "", "", "None of these");
                Answer answer1dt1c3 = new Answer("", "",
                    "", "", "None of these");
                ObservableCollection<Answer> C3T1Q1Answers = new ObservableCollection<Answer>();
                C3T1Q1Answers.Add(answer1at1c3);
                C3T1Q1Answers.Add(answer1bt1c3);
                C3T1Q1Answers.Add(answer1ct1c3);
                C3T1Q1Answers.Add(answer1dt1c3);
                int C3T1Q1TIER1ANSWER = 0;
                int C3T1Q1TIER2ANSWER = 0;

                //Answers for Question 2 Test 1 Course 3
                Answer answer2at1c3 = new Answer("", "",
                    "", "", "None of these");
                Answer answer2bt1c3 = new Answer("", "",
                    "", "", "None of these");
                Answer answer2ct1c3 = new Answer("", "",
                    "", "", "None of these");
                Answer answer2dt1c3 = new Answer("", "",
                    "", "", "None of these");
                ObservableCollection<Answer> C3T1Q2Answers = new ObservableCollection<Answer>();
                C3T1Q1Answers.Add(answer2at1c3);
                C3T1Q1Answers.Add(answer2bt1c3);
                C3T1Q1Answers.Add(answer2ct1c3);
                C3T1Q1Answers.Add(answer2dt1c3);
                int C3T1Q2TIER1ANSWER = 0;
                int C3T1Q2TIER2ANSWER = 0;

                //Answers for Question 3 Test 1 Course 3
                Answer answer3at1c3 = new Answer("", "",
                    "", "", "None of these");
                Answer answer3bt1c3 = new Answer("", "",
                    "", "", "None of these");
                Answer answer3ct1c3 = new Answer("", "",
                    "", "", "None of these");
                Answer answer3dt1c3 = new Answer("", "",
                    "", "", "None of these");
                ObservableCollection<Answer> C3T1Q3Answers = new ObservableCollection<Answer>();
                C3T1Q1Answers.Add(answer2at1c3);
                C3T1Q1Answers.Add(answer2bt1c3);
                C3T1Q1Answers.Add(answer2ct1c3);
                C3T1Q1Answers.Add(answer2dt1c3);
                int C3T1Q3TIER1ANSWER = 0;
                int C3T1Q3TIER2ANSWER = 0;

                //Questions for Test 1 Course 3
                Question question1t1c3 = new Question("_______________ patterns are concerned with how classes and objects interact and distribute responsibility.", C3T1Q1Answers, C3T1Q1TIER1ANSWER, C3T1Q1TIER2ANSWER);
                Question question2t1c3 = new Question("Example Question 2 prompt: ", C3T1Q2Answers, C3T1Q2TIER1ANSWER, C3T1Q2TIER2ANSWER);
                Question question3t1c3 = new Question("Example Question 3 prompt: ", C3T1Q3Answers, C3T1Q3TIER1ANSWER, C3T1Q3TIER2ANSWER);
                ObservableCollection<Question> Test1C3Questions = new ObservableCollection<Question>();
                Test1C3Questions.Add(question1t1c3);
                Test1C3Questions.Add(question2t1c3);
                Test1C3Questions.Add(question3t1c3);

                //Tests for Software Engineering Course
                Test test1c3 = new Test(Test1C3Questions, "Example Test1", "This is an example test", null);
                Test test2c3 = new Test(Test1C3Questions, "Example Test2", "This is an example test", null);
                ObservableCollection<Test> Course3Tests = new ObservableCollection<Test>();
                SoftwareEngineeringTests.Add(test1c3);
                SoftwareEngineeringTests.Add(test2c3);
                //Course 3
                Course course3 = new Course(Course3Tests, "Course 3", "Wright", "Learn about....");

                //All Example Courses
                ObservableCollection<Course> exampleCourses = new ObservableCollection<Course>
                {
                    softwareEngineering,
                    course2,
                    course3
                };
                return exampleCourses;
            }
            return null;
        }
    }
}
