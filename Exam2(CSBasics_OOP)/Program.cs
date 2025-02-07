using System.Diagnostics;

namespace Exam2_CSBasics_OOP_
{
    internal class Program
    {

       public enum ExamType
        {
            Final = 1, Practical
        }
        static void Main(string[] args)
        {
            Console.WriteLine("* Welcome To our Examination System *\n");

            Subject sub1 = new Subject(11,"c#");

            sub1.CreateExam();
            Console.Clear();
            Console.WriteLine("Are you ready to do the exam(y | n)");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch sw= new Stopwatch();
                sw.Start();
                sub1.Exam.ShowExam();
                
                Console.WriteLine($"The Elapsed Time={sw.Elapsed}\n\n");
            }









        }
    }
}
