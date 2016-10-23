

namespace Project_3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

       public Student (string name, int grade, Instructor teacher)
        {
            Name = name;
            Grade = grade;
            Teacher = teacher;
        }

        public void SetGrade(int g)
        {
            Grade = g;
        }
         
        public void PrintStudentInformation()
        {
            System.Console.WriteLine(Name + " received a grade of " + Grade + " from " + Teacher.GetName());
        }

        
    }
}
