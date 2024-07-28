using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exam_C____OOP.Question
{

    using Exam_C____OOP.Answers;

    public abstract class Question
    {
        
        
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answers> AnswerList { get; set; }
        public int CorrectAnswerId { get; set; }

        protected Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new List<Answers>();
        }

        public abstract void Display();
    }
}

