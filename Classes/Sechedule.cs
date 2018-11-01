using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses;

namespace Sech
{
    class Sechedule
    {
        List<Course> coursesList;
        public Sechedule()
        {
            this.coursesList = new List<Course>();
        }
        public void addCourse(Course cors)
        {
            this.coursesList.Add(cors);
        }
        public Course getCourse(int index)
        {
            return this.coursesList[index];
        }
        public List<Course> getAllCourses()
        {
            return this.coursesList;
        }
    }
}
