using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C____OOP.Exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(DateTime examTime, int duration) : base(examTime, duration) { }

        public override void ShowExam()
        {
            Console.WriteLine($"Practical Exam: {ExamTime}, Duration: {Duration} minutes");
            foreach (var question in Questions)
            {
                question.Display();
                Console.WriteLine($"Correct Answer: {question.AnswerList[question.CorrectAnswerId - 1].AnswerText}");
            }
        }
    }
}
