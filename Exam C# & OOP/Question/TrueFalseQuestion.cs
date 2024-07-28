using Exam_C____OOP.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C____OOP.Question
{
    using Exam_C____OOP.Answers;[Serializable]

    public class TrueFalseQuestion : Question
    {

        public TrueFalseQuestion(string header, string body, int mark, int correctAnswerId) : base(header, body, mark)
        {
            CorrectAnswerId = correctAnswerId;
            AnswerList.Add(new Answers(1, "True"));
            AnswerList.Add(new Answers(2, "False"));
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}: {Body}");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }
    }
}
