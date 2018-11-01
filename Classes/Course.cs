using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    public class ComboboxItem
    {
        public ComboboxItem() { }
        public ComboboxItem(string text,object value)
        {
            this.Text = text;
            this.Value = value;
        }
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    public enum CourseType
    {
        Lecture,Practice,Laboratory
    }
    public enum Semester
    {
        A1,A2,A3,B1,B2,B3,C1,C2,C3,D1,D2,D3
    }
    public class Course
    {
        private int id;
        private string name;
        private int passScore;
        private int blockCourseId;
        private double points;
        private CourseType type;
        private int teacherId;
        private string semester;
        private string time;
        private string day;
        
        public void setId(int id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setPassScore(int pass)
        {
            this.passScore = pass;
        }

        public void setBlockCourse(int blockCourseId)
        {
            this.blockCourseId = blockCourseId;
        }

        public void setPoints(double points)
        {
            this.points = points;
        }
        public void setType(CourseType type)
        {
            this.type = type;
        }

        public void setTeacherId(int id)
        {
            this.teacherId = id;
        }
        public void setSemester(string sem)
        {
            this.semester = sem;
        }

        public int getId()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }
        public CourseType getType()
        {
            return this.type;
        }
        public string getSemester()
        {
            return this.semester;
        }
        public int getTeacherId()
        {
            return this.teacherId;
        }
        public double getPoints()
        {
            return this.points;
        }
        public int getPassScore()
        {
            return this.passScore;
        }
        public int getBlockCourseId()
        {
            return this.blockCourseId;
        }
        public void setDay(string day)
        {
            this.day = day;
        }
        public string getDay()
        {
            return this.day;
        }

        public void setTime(string time)
        {
            this.time = time;
        }
        public string getTime()
        {
            return this.time;
        }
        
    }

    class CourseDes
    {
        public Course cors;
        static public CourseDes ins;
        public CourseDes()
        {
            if(ins == null)
            {
                ins = this;
            }
        }
    }
}
