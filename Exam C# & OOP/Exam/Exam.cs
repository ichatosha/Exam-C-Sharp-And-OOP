using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_C____OOP.Question;

namespace Exam_C____OOP.Exam
{
    using Exam_C____OOP.Question;

    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public DateTime ExamTime { get; set; }
        public int Duration { get; set; }  // Duration in minutes
        public int NumberOfQuestions => Questions.Count;
        public List<Question> Questions { get; set; }

        protected Exam(DateTime examTime, int duration)
        {
            ExamTime = examTime;
            Duration = duration;
            Questions = new List<Question>();
        }

        public abstract void ShowExam();

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Exam other)
        {
            return ExamTime.CompareTo(other.ExamTime);
        }

        public override string ToString()
        {
            return $"Exam at {ExamTime}, Duration: {Duration} minutes, {NumberOfQuestions} questions.";
        }
    }
}
