using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C____OOP.Answers
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answers(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }


    }
}
