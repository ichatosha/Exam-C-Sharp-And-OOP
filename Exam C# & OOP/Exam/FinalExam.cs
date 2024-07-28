using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C____OOP.Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(DateTime examTime, int duration) : base(examTime, duration) { }

        public override void ShowExam()
        {
            Console.WriteLine($"Final Exam: {ExamTime}, Duration: {Duration} minutes");
            foreach (var question in Questions)
            {
                question.Display();
                Console.WriteLine();
            }
        }
    }
}
