using Exam_C____OOP.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C____OOP.Question
{
    using Exam_C____OOP.Answers;

    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, int correctAnswerId, List<Answers> answerList)
        : base(header, body, mark)
        {
            CorrectAnswerId = correctAnswerId;
            AnswerList = answerList;
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}: {Body}");
            for (int i = 0; i < AnswerList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {AnswerList[i].AnswerText}");
            }
        }
    }
}
