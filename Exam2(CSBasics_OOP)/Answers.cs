using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_CSBasics_OOP_
{
    internal class Answers
    {
        public Answers()
        {
        }

        public Answers(int id)
        {
            Id = id;

        }
        public Answers( string text)
        {
            Text = text;
        }
        public Answers(int id, string text) : this(id)
        {
            Text = text;
        }


        public int Id { get; set; }
        public string Text { get; set; }
    }
}
