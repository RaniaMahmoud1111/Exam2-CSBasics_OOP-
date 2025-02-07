using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_CSBasics_OOP_
{
    internal abstract class Exam
    {

         
        public  DateTime Time { get; set; }
        public int NumOfQn { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(int timeInMinutes, int numOfQn, List<Question> Qtns)
        {
            int h, m, s;

            h = timeInMinutes / 60;
            timeInMinutes %= 60;
            m = timeInMinutes / 60;
            timeInMinutes %= 60;
            s = timeInMinutes;

            Time = new DateTime().AddHours(h);
            Time.AddMinutes(m);
            Time.AddSeconds(s);
            NumOfQn = numOfQn;
            Questions = Qtns;


        }


       public  abstract void ShowExam();


    }
}
