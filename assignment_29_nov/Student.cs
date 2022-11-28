using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_29_nov
{
    public class Student
    {
        public string FirstName;
        public string Surname;
        public string Group;
        public byte Score;
        public bool isGraduated;

        public Student(string firstName, string surname, string group, byte score, bool isGraduated)
        {
            FirstName = firstName;
            Surname = surname;
            Group = group;
            Score = score;
            this.isGraduated = isGraduated;
        }
        public string ReturnFullName()
        {
            return  FirstName + " " + Surname;
        }
        public void AllInfo()
        {
            Console.Write("Student's full name: " + ReturnFullName() + "\nStudent's group: " + Group + "\nStudent's score: " + Score);
            if (isGraduated)
            {
                Console.WriteLine("\nThe student is already graduated!");
            } else
            {
                Console.WriteLine("\nThe student did not graduate yet.");
            }
        }
        public void isValidForTheExam()
        {
            if (Score>80)
            {
                Console.WriteLine("The student " + FirstName + " " + Surname + " can participate at the exam!");
            } else
            {
                Console.WriteLine("The student " + FirstName + " " + Surname + " can NOT participate at the exam!");
            }
        }
   }
    
}
