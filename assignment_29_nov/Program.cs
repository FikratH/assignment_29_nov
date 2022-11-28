namespace assignment_29_nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the student's name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please, enter the student's surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Please, enter the student's group:");
            string group = Console.ReadLine();
            Console.WriteLine("Please, enter the student's score: (0-100)");
            byte score;
            bool res = byte.TryParse(Console.ReadLine(), out score);
            Console.WriteLine("Please, enter the student's graduation status: (true/false)");
            bool isGraduate;
            bool result = bool.TryParse(Console.ReadLine(),out isGraduate);
            Console.WriteLine("");
            Student student = new Student(firstName, surname, group, score, isGraduate);
            Console.WriteLine(student.ReturnFullName());
            student.AllInfo();
            student.isValidForTheExam();
        }
    }
}