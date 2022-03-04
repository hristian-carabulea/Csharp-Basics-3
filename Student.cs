using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_3
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        // constructor
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public string HasHonors()
        {
            if (gpa > 3.5)
            {
                return ("Student has honors with a GPA of " + gpa);
            }
            else
            {
                return ("Student does not have honors with a GPA of " + gpa); ;
            }
        }
    }
}
