using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_CSBasics_OOP_
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }

        public Dictionary<Answers[], Answers> AnswerList { get; set; } = new Dictionary<Answers[], Answers>();

        public Question(string header, string body, double mark, Dictionary<Answers[], Answers> answerList)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Header}      Mark({Mark})");
            sb.AppendLine($"{Body}");

            sb.AppendLine("Choices:");
            foreach (var key in AnswerList.Keys)
            {
                foreach (var answer in key)
                {
                    sb.AppendLine($"{answer.Id}. {answer.Text}");
                }
            }

            return sb.ToString();
        }

        public string ToStringWithoutChoices()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" {Body}");

            Answers correctAnswer = AnswerList.Values.First();
            sb.AppendLine($"\nCorrect Answer: {correctAnswer.Text}");

            return sb.ToString();
        }



    }
}
