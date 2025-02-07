using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_CSBasics_OOP_
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeInMinutes, int numOfQn, List<Question> Qtns) : base(timeInMinutes, numOfQn, Qtns) { }
           public override void ShowExam()
        {
            double totalScore = 0;
            double myScore = 0;

            foreach (var question in Questions)
            {
                Console.Clear();
                Console.WriteLine(question);
                Console.WriteLine("\n***************************************************************\n");

                // Get the correct answer
                Answers correctAnswer = question.AnswerList.Values.First();
                bool check = false;
                int userAnswer;
                do
                {
                    Console.Write("Enter your answer (by number): ");
                    check = int.TryParse(Console.ReadLine(), out userAnswer);

                } while (!check);

                // calc the score 
                if (check && correctAnswer.Id == userAnswer)
                {
                    myScore += question.Mark;
                }
                totalScore += question.Mark;
            }

            Console.Clear();
            int i = 1;
            foreach (Question q in Questions)
            {
                Console.WriteLine($"Q{i} {q.ToStringWithoutChoices()}");
                Answers correctAnswer = q.AnswerList.Values.First();
                Console.WriteLine(".............................................................");
                i++;
            }
            Console.WriteLine($"your Grade is {myScore} from {totalScore}");
        }


    }
}

