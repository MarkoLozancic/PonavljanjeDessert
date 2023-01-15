using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PonavljanjeDessert
{
   class Student:Person
    {
        private String studentId;
        private short academicYear;

        public Student(string name, string surname, int age, String studentId, short academicYear) : base(name, surname, age)
        {
            this.studentId = studentId;
            this.academicYear = academicYear;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public short AcademicYear { get => academicYear; set => academicYear = value; }

        public override string ToString()
        {
            return "Name - " + Name + ", Surname - " + Surname + ", Age - " + Age+ ", Student ID - " + studentId + ", Academic Year - " + academicYear + ".";
        }

      /*  public override bool Equals(Student p,Student s)
        {
            //string name1, string surname1,
            //int age1, string name2, string surname2, int age2

            if ()
                return true;
            else
                return false;

        }
      */

    }
}
