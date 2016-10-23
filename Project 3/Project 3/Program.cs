

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor("John", "English");
            Instructor mike = new Instructor("Mike", "Math");

            Student jane = new Student("Jane", 0, john);
            Student joe = new Student("Joe", 0, john);
            Student melissa = new Student("Melissa", 0, mike);
            Student matt = new Student("Matt", 0, mike);

            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);

            john.PrintInformation();
            mike.PrintInformation();
            jane.PrintStudentInformation();
            joe.PrintStudentInformation();
            melissa.PrintStudentInformation();
            matt.PrintStudentInformation();

            System.Console.WriteLine("Press any key to continue .... ");
            System.Console.ReadKey();
        }
    }
}
