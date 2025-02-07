using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exam2_CSBasics_OOP_.Program;



namespace Exam2_CSBasics_OOP_
{
    enum QuestionType
    {
        True_False_Question=1,MCQ_Question
            
    }
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Exam Exam { get; set; }

        public ExamType ExamType { get; set; }
        public QuestionType QuestionType { get; private set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

       
    public void CreateExam()
        {

            bool check;
            int examChoice;
            // Select Exam Type
            do
            {
                Console.Write("Choose Exam Type: (1 => Final, 2 => Practical) ");
                check = int.TryParse(Console.ReadLine(), out examChoice) && (examChoice == 1 || examChoice == 2);
            } while (!check);

            ExamType = (ExamType)examChoice;

            if (ExamType == ExamType.Final)
                    {   int time;
                        int num;
                        string? qBody;
                Dictionary<Answers[], Answers> dict;
                       check =false;
                        do
                        {
                            Console.Write($"enter the Exam Period in Minutes: ");
                            check = int.TryParse(Console.ReadLine(),out time);
                        } while (!check);

                        check = false;
                        do
                        {
                            Console.Write($"enter the Number of Questions: ");
                            check = int.TryParse(Console.ReadLine(),out num);
                        } while (!check);
                        Console.Clear();
                       List<Question> qtns = new List<Question>(num);

                       check = false;
                        double mark;
                        for (int i = 0;i<num;i++) 
                        {
                            check=false;
                            int questionChoice;
                            // Select question Type
                            do
                            {
                                Console.Write($"enter type of question{i+1} ( 1 => T/F , 2 => MCQ) ");
                                check = int.TryParse(Console.ReadLine(), out questionChoice) && (questionChoice == 1 || questionChoice == 2);
                            } while (!check);

                           QuestionType = (QuestionType)questionChoice;

                        //  ********************************* T/F ***********************************
                    if (QuestionType==QuestionType.True_False_Question)
                            {
                                Console.WriteLine($"enter the body of question {i + 1}: ");
                                qBody = Console.ReadLine();
                        
                                check = false;
                                do
                                {
                                    Console.Write($"enter the mark of Question {1+i}: ");
                                    check = double.TryParse(Console.ReadLine(), out mark);
                                } while (!check);

                                Answers[] answersList = new Answers[2] 
                                    { new Answers(1, "True"),
                                    new Answers(2, "False") };
                                Answers rightAnswer = new Answers(i+1);

                                check = false;
                                int x;
                                do
                                {
                                    Console.WriteLine($"enter the index of correct answer( 1=>True || 2=>False ) of question {i + 1}: ");
                                    check = int.TryParse(Console.ReadLine(), out x) && x >= 1 && x <= 3;
                                } while (!check);

                                rightAnswer = answersList.FirstOrDefault(a => a.Id == x);

                                 dict = new Dictionary<Answers[], Answers>
                                    {
                                        { answersList, rightAnswer }
                                    };

                                TFQuestion TFQ = new TFQuestion($"{QuestionType}",qBody,mark,dict);
                                  qtns.Add(TFQ);
                              }
                      
                    
                    //     ********************************* MCQ ***********************************
                            else if(QuestionType == QuestionType.MCQ_Question)
                            {
                                Console.WriteLine($"enter the body of question {i + 1}: ");
                                 qBody = Console.ReadLine();

                                check = false;
                                do
                                {
                                    Console.Write($"enter the mark of Question {1 + i}: ");
                                    check = double.TryParse(Console.ReadLine(), out mark);
                                } while (!check);

                                Console.Write($"enter the Options of Answers :\nOption 1 : ");
                                string op1 = Console.ReadLine();
                                Console.Write($"\nOption 2 : ");
                                string op2 = Console.ReadLine();
                                Console.Write($"\nOption 3 : ");
                                string op3 = Console.ReadLine();

                                Answers[] answersList = new Answers[3]
                                    { new Answers(1,op1),
                                    new Answers(2, op2) ,
                                    new Answers(3,op3)
                                    };
                                Answers rightAnswer ;

                                check = false;
                                int x;
                                do
                                {
                                    Console.WriteLine($"enter the index of correct answer(1,2,3) of question {i + 1}: ");
                                    check = int.TryParse(Console.ReadLine(), out x)&& x>=1 && x<=3;
                                } while (!check);

                                rightAnswer = answersList.FirstOrDefault(a => a.Id == x);
                                  dict = new Dictionary<Answers[], Answers>
                                    {
                                        { answersList, rightAnswer }
                                    };

                        MCQ_Question mcqQuestionf = new MCQ_Question($"{QuestionType}", qBody, mark, dict);
                        qtns.Add(mcqQuestionf);

                    }


                }

                FinalExam fExam = new FinalExam(time, num, qtns);
                this.Exam = fExam;

            }
          
            // ##########################################   Pactical Exam  ##########################################
          
            else if(ExamType == ExamType.Practical)
            {
                QuestionType = QuestionType.MCQ_Question;
                    int time;
                    int num;
                    check = false;
                    do
                    {
                        Console.Write($"enter the Exam Period in Minutes: ");
                        check = int.TryParse(Console.ReadLine(), out time);
                    } while (!check);

                    check = false;
                    do
                    {
                        Console.Write($"enter the Number of Questions: ");
                        check = int.TryParse(Console.ReadLine(), out num);
                    } while (!check);
                    Console.Clear();
                List<Question> qtns = new List<Question>(num);


                check = false;
                    double mark;
                    for (int i = 0; i < num; i++)
                    {

                        Console.WriteLine($"enter the body of question {i + 1}: ");
                        string qBody = Console.ReadLine();

                        check = false;
                        do
                        {
                            Console.Write($"enter the mark of Question {1 + i}: ");
                            check = double.TryParse(Console.ReadLine(), out mark);
                        } while (!check);
                   

                        Console.Write($"enter the Options of Answers :\nOption 1 : ");
                        string op1 = Console.ReadLine();
                        Console.Write($"\nOption 2 : ");
                        string op2 = Console.ReadLine();
                        Console.Write($"\nOption 3 : ");
                        string op3 = Console.ReadLine();

                        Answers[] answersList = new Answers[3]
                            { new Answers(1,op1),
                                new Answers(2, op2) ,
                                new Answers(3,op3)
                            };
                        Answers rightAnswer;

                        check = false;
                        int x;
                        do
                        {
                            Console.WriteLine($"enter the index of correct answer(1,2,3) of question {i + 1}: ");
                            check = int.TryParse(Console.ReadLine(), out x) && x >= 1 && x <= 3;
                        } while (!check);

                        rightAnswer = answersList.FirstOrDefault(a => a.Id == x);

                        Dictionary<Answers[], Answers> dict = new Dictionary<Answers[], Answers>
                                {
                                    { answersList, rightAnswer }
                                };

                    MCQ_Question mcqQuestion = new MCQ_Question($"{QuestionType}", qBody, mark,dict);
                    qtns.Add(mcqQuestion);


                }

                   PracticalExam pExam =new  PracticalExam(time, num,qtns);
                this.Exam = pExam;

            }








        }
    }
}
