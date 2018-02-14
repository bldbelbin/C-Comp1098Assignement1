using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Belbin.Assignment1
{
    class Program
    {
        static void Main(string[] args)

        {
            // Variables in Program.Main method

            // define two variables that would represent the First Name and Last Name of a student also combined with assigning values of my first and last name
            // to hold the value of my name
            String FirstName = "Bethany";
            String LastName = "Belbin";
            String StudentName = FirstName + LastName;

            // Integer variable to hold student number and define a variable that represents an unsigned number
            int StudentNumber = 200232303;

            /*
            * Writes Student name on one line and writes student number on the next
            * Readkey allows for the name and number to stay on the screen
            */

            Console.WriteLine(String.Format("Student Name {0}\nStudent Number {1}", StudentName, StudentNumber));

            // initiate object Student
            Student student = new Student();
            student.AcceptDetails();

            // variable that represents a string data type
            String birthMonth = "April";

            // define a variable that would represent the Age of a student
            int ageOfStudent;

            Console.WriteLine($"Birth Month: { birthMonth}");
            Console.WriteLine(student.ToString());
            Console.ReadKey(true);


        }

    }
}


