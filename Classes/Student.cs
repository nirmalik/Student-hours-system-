using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THEUSERS;
namespace StudentSpace
{
    public class Student:User{
        private string semester;

        public Student() :base()
        {

        }
        override public Job getJob()
        {
            return Job.Student;
        }
        override public string getJobString()
        {
            return "Student";
        }
        public void setSemester(string str)
        {
            this.semester = str;
        }
        public string getSemester()
        {
            return this.semester;
        }
    }
}
