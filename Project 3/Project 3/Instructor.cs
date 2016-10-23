

namespace Project_3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor (string name, string courseName)
        {
           Name = name;
           CourseName = courseName;
        }

        public void SetStudentGrade(Student student, int score)
        {
            student.SetGrade(score);

        }

        public string GetName()
        {
            return Name;
        }
            
        public void PrintInformation()
        {
            System.Console.WriteLine("The Instructor of " + CourseName + " is " + Name);
        }
    }
}
