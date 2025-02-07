using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_CSBasics_OOP_
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int timeInMinutes, int numOfQn, List<Question> Qtns) : base(timeInMinutes, numOfQn, Qtns) { }
        
        public override void ShowExam()
        {
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
                    check = int.TryParse(Console.ReadLine(), out  userAnswer);

                } while (!check);

            }
            int i = 1;

            Console.Clear();
            foreach (Question q in Questions)
            {
                Console.WriteLine($"Q{i} {q.ToStringWithoutChoices()}");
                Answers correctAnswer = q.AnswerList.Values.First();
                Console.WriteLine(".............................................................");

                i++;
            }
        }

    }

       
}

