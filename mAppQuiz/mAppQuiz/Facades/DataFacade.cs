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
                 * Answers for Question 1 Test 1 Course 1 (Software Engineering)
                 * Contains:    1   test    with    3   questions
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
                Answer answer2at1c1 = new Answer("insertion… deletion", "Name a pattern that closely follows this principle.",
                    "Strategy", "Decorator", "Memento");
                Answer answer2bt1c1 = new Answer("inheritance… interfacing", "Name a pattern that closely follows this principle.",
                    "Strategy", "Decorator", "Memento");
                Answer answer2ct1c1 = new Answer("patterns… principles", "Name a pattern that closely follows this principle.",
                    "Strategy", "Decorator", "Memento");
                Answer answer2dt1c1 = new Answer("extension… modification", "Name a pattern that closely follows this principle.",
                    "Strategy", "Decorator", "Memento");
                ObservableCollection<Answer> C1T1Q2Answers = new ObservableCollection<Answer>();
                C1T1Q1Answers.Add(answer2at1c1);
                C1T1Q1Answers.Add(answer2bt1c1);
                C1T1Q1Answers.Add(answer2ct1c1);
                C1T1Q1Answers.Add(answer2dt1c1);
                int C1T1Q2TIER1ANSWER = 3;
                int C1T1Q2TIER2ANSWER = 1;

                //Answers for Question 3 Test 1
                Answer answer3at1c1 = new Answer("Builder", "What is the intent of this pattern?",
                    "Defines an instance for creating an object but letting subclasses decide which class to instantiate", "Ensure that only one instance of a class is created", "None of these");
                Answer answer3bt1c1 = new Answer("Singleton", "What is the intent of this pattern?",
                    "Defines an instance for creating an object but letting subclasses decide which class to instantiate", "Ensure that only one instance of a class is created", "None of these");
                Answer answer3ct1c1 = new Answer("Simple Factory", "What is the intent of this pattern?",
                    "Creates objects without exposing the instantiation logic to the client.", "Ensure that only one instance of a class is created", "None of these");
                Answer answer3dt1c1 = new Answer("Factory Method", "What is the intent of this pattern?",
                    "Defines an interface for creating objects, but let subclasses to decide which class to instantiate", "Ensure that only one instance of a class is created", "None of these");
                ObservableCollection<Answer> C1T1Q3Answers = new ObservableCollection<Answer>();
                C1T1Q1Answers.Add(answer2at1c1);
                C1T1Q1Answers.Add(answer2bt1c1);
                C1T1Q1Answers.Add(answer2ct1c1);
                C1T1Q1Answers.Add(answer2dt1c1);
                int C1T1Q3TIER1ANSWER = 2;
                int C1T1Q3TIER2ANSWER = 0;

                //Questions for Test 1
                Question question1t1c1 = new Question("_______________ patterns are concerned with how classes and objects interact and distribute responsibility.", C1T1Q1Answers, C1T1Q1TIER1ANSWER, C1T1Q1TIER2ANSWER);
                Question question2t1c1 = new Question("Following the OPEN-CLOSED principle, application designs should be open to ___________, but closed to ___________.", C1T1Q2Answers, C1T1Q2TIER1ANSWER, C1T1Q2TIER2ANSWER);
                Question question3t1c1 = new Question("The __________, while not a bona fide design pattern, is a simple way to decouple your clients from concrete classes.", C1T1Q3Answers, C1T1Q3TIER1ANSWER, C1T1Q3TIER2ANSWER);
                ObservableCollection<Question> Test1C1Questions = new ObservableCollection<Question>();
                Test1C1Questions.Add(question1t1c1);
                Test1C1Questions.Add(question2t1c1);
                Test1C1Questions.Add(question3t1c1);

                //Tests for Software Engineering Course
                Test test1c1 = new Test(Test1C1Questions, "Example Test1", "This is an example test", null);
                ObservableCollection<Test> SoftwareEngineeringTests = new ObservableCollection<Test>();
                SoftwareEngineeringTests.Add(test1c1);
                //Course 1
                Course softwareEngineering = new Course(SoftwareEngineeringTests, "Software Engineering", "Smith", "Learn all about Design Patterns and how to apply them in real life situations.");

                /** ------------------------------------  Course 2  -------------------------------------------------------
                 * Answers for Question 1 Test 1 Course 2 (Linear Algebra)
                 * Contains:    2   test    with    3   questions   each
                 */
                Answer answer1at1c2 = new Answer("Orthogonal", "Define this term farther.",
                    "W' is a subspace of R^n", "The number of vectors in any basis of H; the zero subspace's dimension is 0", "None of these");
                Answer answer1bt1c2 = new Answer("Onto", "Define this term farther.",
                    "W' is a subspace of R^n", "consistent for any b; pivots in all rows", "None of these");
                Answer answer1ct1c2 = new Answer("Rank", "Define this term farther.",
                    "consistent for any b; pivots in all rows", "The dimension of the column space", "None of these");
                Answer answer1dt1c2 = new Answer("Dimension", "Define this term farther.",
                    "The number of vectors in any basis of H; the zero subspace's dimension is 0", "The dimension of the column space", "None of these");
                ObservableCollection<Answer> C2T1Q1Answers = new ObservableCollection<Answer>();
                C2T1Q1Answers.Add(answer1at1c2);
                C2T1Q1Answers.Add(answer1bt1c2);
                C2T1Q1Answers.Add(answer1ct1c2);
                C2T1Q1Answers.Add(answer1dt1c2);
                int C2T1Q1TIER1ANSWER = 0;
                int C2T1Q1TIER2ANSWER = 0;

                //Answers for Question 2 Test 1 Course 2
                Answer answer2at1c2 = new Answer("Homogeneous", "Define this term farther.",
                    "the x = 0 solution is a TRIVIAL solution", "flips rows and columns", "None of these");
                Answer answer2bt1c2 = new Answer("Independent", "Define this term farther.",
                    "the columns of A are independent if only the trivial solution exists", "If non-zero weights that satisfy the equation exist", "None of these");
                Answer answer2ct1c2 = new Answer("Dependent", "Define this term farther.",
                    "assigns each vector x in R^n a vector T(x) in R^m", "If non-zero weights that satisfy the equation exist", "None of these");
                Answer answer2dt1c2 = new Answer("Transformation", "Define this term farther.",
                    "assigns each vector x in R^n a vector T(x) in R^m", "flips rows and columns", "None of these");
                ObservableCollection<Answer> C2T1Q2Answers = new ObservableCollection<Answer>();
                C2T1Q1Answers.Add(answer2at1c2);
                C2T1Q1Answers.Add(answer2bt1c2);
                C2T1Q1Answers.Add(answer2ct1c2);
                C2T1Q1Answers.Add(answer2dt1c2);
                int C2T1Q2TIER1ANSWER = 0;
                int C2T1Q2TIER2ANSWER = 0;

                //Answers for Question 3 Test 1 Course 2
                Answer answer3at1c2 = new Answer("Basis", "Define this term farther.",
                    "the pivot columns of A form a basis for A's column space", "A transformation that assigns a vector y in R^m for each x in R^n", "None of these");
                Answer answer3bt1c2 = new Answer("One-to-one", "Define this term farther.",
                    "A transformation that assigns a vector y in R^m for each x in R^n", "Set of all solution to Ax = 0", "None of these");
                Answer answer3ct1c2 = new Answer("Null space", "Define this term farther.",
                    "Set of all solution to Ax = 0", "Set of all the linear combinations of the columns of A", "None of these");
                Answer answer3dt1c2 = new Answer("Column space", "Define this term farther.",
                    "Set of all solution to Ax = 0", "Set of all the linear combinations of the columns of A", "None of these");
                ObservableCollection<Answer> C2T1Q3Answers = new ObservableCollection<Answer>();
                C2T1Q1Answers.Add(answer2at1c2);
                C2T1Q1Answers.Add(answer2bt1c2);
                C2T1Q1Answers.Add(answer2ct1c2);
                C2T1Q1Answers.Add(answer2dt1c2);
                int C2T1Q3TIER1ANSWER = 0;
                int C2T1Q3TIER2ANSWER = 0;

                //Questions for Test 1 Course 2
                Question question1t1c2 = new Question("x is in W' if x is perpendicular to every vector that spans W. What term describes this?", C2T1Q1Answers, C2T1Q1TIER1ANSWER, C2T1Q1TIER2ANSWER);
                Question question2t1c2 = new Question("What is a system that can be written as Ax = 0 called?", C2T1Q2Answers, C2T1Q2TIER1ANSWER, C2T1Q2TIER2ANSWER);
                Question question3t1c2 = new Question("What term describes a linearly independent set in H that spans H?", C2T1Q3Answers, C2T1Q3TIER1ANSWER, C2T1Q3TIER2ANSWER);
                ObservableCollection<Question> Test1C2Questions = new ObservableCollection<Question>();
                Test1C2Questions.Add(question1t1c2);
                Test1C2Questions.Add(question2t1c2);
                Test1C2Questions.Add(question3t1c2);

                /**
                 * Answers for Question 1 Test 2 Course 2 (Linear Algebra)
                 */
                Answer answer1at2c2 = new Answer("Dimension", "Define this term farther.",
                    "the zero subspace's dimension is 0", "The dimension of the column space", "None of these");
                Answer answer1bt2c2 = new Answer("Onto", "Define this term farther.",
                    "the zero subspace's dimension is 0", "consistent for any b; pivots in all rows", "None of these");
                Answer answer1ct2c2 = new Answer("Rank", "Define this term farther.",
                    "The dimension of the column space", "Set of all solution to Ax = 0", "None of these");
                Answer answer1dt2c2 = new Answer("Null Space", "Define this term farther.",
                    "Set of all solution to Ax = 0", "The dimension of the column space", "None of these");
                ObservableCollection<Answer> C2T2Q1Answers = new ObservableCollection<Answer>();
                C2T1Q1Answers.Add(answer1at2c2);
                C2T1Q1Answers.Add(answer1bt2c2);
                C2T1Q1Answers.Add(answer1ct2c2);
                C2T1Q1Answers.Add(answer1dt2c2);
                int C2T2Q1TIER1ANSWER = 0;
                int C2T2Q1TIER2ANSWER = 0;

                //Answers for Question 2 Test 2 Course 2
                Answer answer2at2c2 = new Answer("Inner Product", "Define this term farther.",
                    "if U . V = 0, u and v are orthogonal", "x = Cx + d", "None of these");
                Answer answer2bt2c2 = new Answer("Leontief input-output model", "Define this term farther.",
                    "Leftmost non-zero entry in a non-zero row", "x = Cx + d", "None of these");
                Answer answer2ct2c2 = new Answer("leading entry", "Define this term farther.",
                    "Leftmost non-zero entry in a non-zero row", "Has no solution", "None of these");
                Answer answer2dt2c2 = new Answer("inconsistent system", "Define this term farther.",
                    "x = Cx + d", "Has no solution", "None of these");
                ObservableCollection<Answer> C2T2Q2Answers = new ObservableCollection<Answer>();
                C2T1Q1Answers.Add(answer2at2c2);
                C2T1Q1Answers.Add(answer2bt2c2);
                C2T1Q1Answers.Add(answer2ct2c2);
                C2T1Q1Answers.Add(answer2dt2c2);
                int C2T2Q2TIER1ANSWER = 0;
                int C2T2Q2TIER2ANSWER = 0;

                //Answers for Question 3 Test 2 Course 2
                Answer answer3at2c2 = new Answer("Dependent", "Define this term farther.",
                    "if there are more vectors than there are entries", "If only the trivial solution exists for a linear equation", "None of these");
                Answer answer3bt2c2 = new Answer("Independent", "Define this term farther.",
                    "If only the trivial solution exists for a linear equation", "flips rows and columns", "None of these");
                Answer answer3ct2c2 = new Answer("Transposition", "Define this term farther.",
                    "assigns each vector x in R^n a vector T(x) in R^m", "flips rows and columns", "None of these");
                Answer answer3dt2c2 = new Answer("Transformation", "Define this term farther.",
                    "assigns each vector x in R^n a vector T(x) in R^m", "flips rows and columns", "None of these");
                ObservableCollection<Answer> C2T2Q3Answers = new ObservableCollection<Answer>();
                C2T1Q1Answers.Add(answer2at2c2);
                C2T1Q1Answers.Add(answer2bt2c2);
                C2T1Q1Answers.Add(answer2ct2c2);
                C2T1Q1Answers.Add(answer2dt2c2);
                int C2T2Q3TIER1ANSWER = 0;
                int C2T2Q3TIER2ANSWER = 0;

                //Questions for Test 2 Course 2
                Question question1t2c2 = new Question("What term defines the number of vectors in any basis of H?", C2T2Q1Answers, C2T2Q1TIER1ANSWER, C2T2Q1TIER2ANSWER);
                Question question2t2c2 = new Question("What is defined by a matrix product u^Tv or u . v where u and v are vectors?", C2T2Q2Answers, C2T2Q2TIER1ANSWER, C2T2Q2TIER2ANSWER);
                Question question3t2c2 = new Question("If non-zero weights that satisfy the equation exist then it is _______.", C2T2Q3Answers, C2T2Q3TIER1ANSWER, C2T2Q3TIER2ANSWER);
                ObservableCollection<Question> Test2C2Questions = new ObservableCollection<Question>();
                Test2C2Questions.Add(question1t2c2);
                Test2C2Questions.Add(question2t2c2);
                Test2C2Questions.Add(question3t2c2);

                //Tests for Linear Algebra Course
                Test test1c2 = new Test(Test1C2Questions, "Example Test1", "This is an example test", null);
                Test test2c2 = new Test(Test2C2Questions, "Example Test2", "This is an example test", null);
                ObservableCollection<Test> LinearAlgebraTests = new ObservableCollection<Test>();
                LinearAlgebraTests.Add(test1c2);
                LinearAlgebraTests.Add(test2c2);
                //Course 2
                Course linearAlgebra = new Course(LinearAlgebraTests, "Linear Algebra", "Johnson", "Learn about linear transformations and how they are applied in the real world.");

                /** ------------------------------------  Course 3  -------------------------------------------------------
                 * Answers for Question 1 Test 1 Course 3 (Comp Sci)
                 * Contains:    1   test    with    3   questions
                 */
                Answer answer1at1c3 = new Answer("Casting", "Define this term farther.",
                    "Referred to as type conversion.", "Logical expression determined to be true or false - if true execution continues.", "None of these");
                Answer answer1bt1c3 = new Answer("Condition", "Define this term farther.",
                    "Logical expression determined to be true or false - if true execution continues.", "Allows a program to proceed in a non-sequential matter.", "None of these");
                Answer answer1ct1c3 = new Answer("Control Statement", "Define this term farther.",
                    "Allows a program to proceed in a non-sequential matter.", "Data that lies outside the expected limits.", "None of these");
                Answer answer1dt1c3 = new Answer("Encapsulation", "Define this term farther.",
                    "Allows a program to proceed in a non-sequential matter.", "Is used to protect (hide) data or methods which prevents access.", "None of these");
                ObservableCollection<Answer> C3T1Q1Answers = new ObservableCollection<Answer>();
                C3T1Q1Answers.Add(answer1at1c3);
                C3T1Q1Answers.Add(answer1bt1c3);
                C3T1Q1Answers.Add(answer1ct1c3);
                C3T1Q1Answers.Add(answer1dt1c3);
                int C3T1Q1TIER1ANSWER = 0;
                int C3T1Q1TIER2ANSWER = 0;

                //Answers for Question 2 Test 1 Course 3
                Answer answer2at1c3 = new Answer("Mutator", "Define this term farther.",
                    "Method that alters the attributes of an object.", "Problem broken down into smaller components.", "None of these");
                Answer answer2bt1c3 = new Answer("Modifiers", "Define this term farther.",
                    "Consist of public, private, static, final, and abstract", "Method that alters the attributes of an object.", "None of these");
                Answer answer2ct1c3 = new Answer("Modularity", "Define this term farther.",
                    "Method that alters the attributes of an object.", "Problem broken down into smaller components.", "None of these");
                Answer answer2dt1c3 = new Answer("Nesting", "Define this term farther.",
                    "Placing one control statements inside another.", "Consist of public, private, static, final, and abstract", "None of these");
                ObservableCollection<Answer> C3T1Q2Answers = new ObservableCollection<Answer>();
                C3T1Q1Answers.Add(answer2at1c3);
                C3T1Q1Answers.Add(answer2bt1c3);
                C3T1Q1Answers.Add(answer2ct1c3);
                C3T1Q1Answers.Add(answer2dt1c3);
                int C3T1Q2TIER1ANSWER = 1;
                int C3T1Q2TIER2ANSWER = 0;

                //Answers for Question 3 Test 1 Course 3
                Answer answer3at1c3 = new Answer("Tree", "Define this term farther.",
                    "Nodes have max of 2 sub-nodes.", "Data structure that accesses data in a First In - First Out method", "None of these");
                Answer answer3bt1c3 = new Answer("Queue", "Define this term farther.",
                    "Data structure that accesses data in a First In - First Out method", "Nodes have max of 2 sub-nodes.", "None of these");
                Answer answer3ct1c3 = new Answer("Array", "Define this term farther.",
                    "Type of object used to store groups of similar elements.", "Nodes have max of 2 sub-nodes.", "None of these");
                Answer answer3dt1c3 = new Answer("Buffer", "Define this term farther.",
                    "Data structure that accesses data in a First In - First Out method", "Temporary storage location of limited size.", "None of these");
                ObservableCollection<Answer> C3T1Q3Answers = new ObservableCollection<Answer>();
                C3T1Q1Answers.Add(answer2at1c3);
                C3T1Q1Answers.Add(answer2bt1c3);
                C3T1Q1Answers.Add(answer2ct1c3);
                C3T1Q1Answers.Add(answer2dt1c3);
                int C3T1Q3TIER1ANSWER = 0;
                int C3T1Q3TIER2ANSWER = 0;

                //Questions for Test 1 Course 3
                Question question1t1c3 = new Question("What term defines a changing of data type? Ex: int value into a double.", C3T1Q1Answers, C3T1Q1TIER1ANSWER, C3T1Q1TIER2ANSWER);
                Question question2t1c3 = new Question("What creates levels of access?", C3T1Q2Answers, C3T1Q2TIER1ANSWER, C3T1Q2TIER2ANSWER);
                Question question3t1c3 = new Question("What structure contains a series of nodes with left (<) and right (>) pointers?", C3T1Q3Answers, C3T1Q3TIER1ANSWER, C3T1Q3TIER2ANSWER);
                ObservableCollection<Question> Test1C3Questions = new ObservableCollection<Question>();
                Test1C3Questions.Add(question1t1c3);
                Test1C3Questions.Add(question2t1c3);
                Test1C3Questions.Add(question3t1c3);

                //Tests for Computer Science Course
                Test test1c3 = new Test(Test1C3Questions, "Example Test1", "This is an example test", null);
                ObservableCollection<Test> CompSciTests = new ObservableCollection<Test>();
                CompSciTests.Add(test1c3);
                //Course 3
                Course compSci = new Course(CompSciTests, "Computer Science", "Wright", "Learn about everything relating to Comp Sci!");

                //All Example Courses
                ObservableCollection<Course> exampleCourses = new ObservableCollection<Course>
                {
                    softwareEngineering,
                    linearAlgebra,
                    compSci
                };
                return exampleCourses;
            }
            return null;
        }
    }
}
