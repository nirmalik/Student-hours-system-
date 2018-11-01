using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_19
{
    public class GiveGrades
    {
        public int Id { set; get; }
        public int studentId { set; get; }
        public int CourseId { set; get; }
        public int score { set; get; }

        public void setId(int name)
        {
            Id = name;
        }
        public int getId()
        {
            return Id;
        }
        public void setstudentId(int name)
        {
            studentId = name;
        }
        public int getstudentId()
        {
            return studentId;
        }
        public void setCourseId(int name)
        {
            CourseId = name;
        }
        public int getCourseId()
        {
            return CourseId;
        }
        public void setscore(int name)
        {
            score = name;
        }
        public int getscore()
        {
            return score;
        }



    }
}
