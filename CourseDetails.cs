using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_19
{
    public class CourseDetails
    {
        public string start;
        public string end;
        public string name;
        public string type;
        public string day;
        public string index;
        public string approved;
        public string semester;
        public int courseid;
        public int blocked;

        public void setSetStart(string name)
        {
            start = name;
        }
        public string setGetStart()
        {
            return start;
        }
        public void setSetend(string name)
        {
            end = name;
        }
        public string setGetend()
        {
            return end;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public string setGetname()
        {
            return name;
        }
        public void setSettype(string name)
        {
            this.type = name;
        }
        public string setGettype()
        {
            return type;
        }
        public void setSetday(string name)
        {
            this.day = name;
        }
        public string setGetday()
        {
            return day;
        }
        public void setSetapproved(string name)
        {
            this.approved = name;
        }
        public string setGetapproved()
        {
            return approved;
        }
        public void setSetsemester(string name)
        {
            this.semester = name;
        }
        public string setGetsemester()
        {
            return semester;
        }
        public void setSetcourseid(int name)
        {
            this.courseid = name;
        }
        public int setGetcourseid()
        {
            return courseid;
        }
        public void setSetindex(string name)
        {
            this.index = name;
        }
        public string setGetindex()
        {
            return index;
        }
        public void setSetblocked(int name)
        {
            this.blocked = name;
        }
        public int setGetblocked()
        {
            return blocked;
        }
    }
}
