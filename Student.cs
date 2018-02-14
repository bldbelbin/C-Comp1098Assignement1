using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Belbin.Assignment1
{
    // define a Class that would represent a student
    /// <summary>
    /// To initiate an object as I did in Program.cs "Student student = new Student();"
    /// create a default constructor. First is the name of the class followed by the object name. 
    /// </summary>
    class Student
    {
      
            
            // Setting properties with get and set allows for the values to be assigned as well as give program.cs access to return the value

            // properties for the value FirstName
            public string FirstName { get; set; }

            // properties for the value LastName
            public string LastName { get; set; }

            // properties for the value Age
            public int Age { get; set; }
            public string Output { get; private set; }

            // A method to output the results from program.cs
            public void AcceptDetails()
            {
                FirstName = "Lauren";
                LastName = "Belbin";
                Age = 26;
            }

            // Returns a String that represents the Student object
            public override string ToString()
            {
                Output = String.Format("First Name: {0}\nLast Name: {1}\nAge: {2}", FirstName, LastName, Age);
                return Output;
            }
        }
    }


