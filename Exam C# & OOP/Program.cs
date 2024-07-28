using Exam_C____OOP.Answers;
using Exam_C____OOP.Exam;
using Exam_C____OOP.Question;
using Exam_C____OOP.Subject;

class Program
{
    static void Main(string[] args)
    {
        // Create a subject
        Subject math = new Subject(1, "Mathematics");
        
        // Create a final exam
        FinalExam finalExam = new FinalExam(DateTime.Now, 120);  // Duration set to 120 minutes
        finalExam.Questions.Add(new TrueFalseQuestion("Q1", "do the bird is flying ?", 5, 1));
        finalExam.Questions.Add(new MCQQuestion("Q2", "where is mansoura located ?", 5, 1, new List<Answers>
        {
            new Answers(1, "Egypt"),
            new Answers(2, "France"),
            new Answers(3, "Libya")
        }));

        // Assign the exam to the subject
        math.CreateExam(finalExam);

        // Show the exam details
        math.SubjectExam.ShowExam();

        // Create a practical exam
        PracticalExam practicalExam = new PracticalExam(DateTime.Now, 60);  // Duration set to 60 minutes
        practicalExam.Questions.Add  (new MCQQuestion("Q1", "what of these cities is the capital of Egypt?", 10, 1, new List<Answers>
        {
            new Answers(1, "cairo"),
            new Answers(2, "alexandria"),
            new Answers(3, "mansoura")
        }));

        // Assign the exam to the subject
        math.CreateExam(practicalExam);

        // Show the practical exam details
        math.SubjectExam.ShowExam();
    }
}
