using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROJECT_19;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AunitTest
{
    [TestClass]
    public class UnitTest1
    {
        Users user = new Users();
        List<CourseDetails> course = new List<CourseDetails>();
        //users
        public int id=304801467;
        public string firstName="barak";
        public string lastName="avasker";
        public string userName="barakav1";
        public string password="123456";
        public string mail="barakav1@asd.co.il";
        public string address="dimona";
        public int phone=123456;
        public string job="student";
        [TestMethod]
        public void A_Testbuildcourse()
        {
           
            Tools tool = new Tools(user);
            Assert.IsTrue(tool.buildCourse(course));

        }
        [TestMethod]
        public void A_testSetFirstName()
        {
            user.set_first_name(firstName);
            Assert.IsTrue(firstName == user.get_first_name());
        }
        [TestMethod]
        public void A_testSetLastName()
        {
            user.set_last_name(lastName);
            Assert.IsTrue(lastName == user.get_last_name());
        }
        [TestMethod]
        public void A_testSetPassword()
        {
            user.set_Password(password);
            Assert.IsTrue(password == user.get_Password());
        }
        [TestMethod]
        public void A_testSetmail()
        {
            user.set_mail(mail);
            Assert.IsTrue(mail == user.get_mail());
        }
        [TestMethod]
        public void A_testSetaddress()
        {
            user.set_address(address);
            Assert.IsTrue(address == user.get_address());
        }
        [TestMethod]
        public void A_testSetphone()
        {
            user.set_phone(phone);
            Assert.IsTrue(phone == user.get_phone());
        }
        [TestMethod]
        public void A_testSetjob()
        {
            user.set_job(job);
            Assert.IsTrue(job == user.get_job());
        }
        //courses
        CourseDetails courses = new CourseDetails();
        public string start="08:00";
        public string end="10:00";
        public string name= "C language";
        public string type= "lecture";
        public string day= "Tuesday   ";
        public string index="1";
        public string approved="true";
        public string semester="A1";
        public int courseid=1000;
        public int blocked=1006;
        [TestMethod]
        public void A_testSetstart()
        {
            courses.setSetStart(start);
            Assert.IsTrue(start == courses.setGetStart());
        }
        [TestMethod]
        public void A_testSetEnd()
        {
            courses.setSetend(end);
            Assert.IsTrue(end == courses.setGetend());
        }
        [TestMethod]
        public void A_testSetCoursename()
        {
            courses.setname(name);
            Assert.IsTrue(name == courses.setGetname());
        }
        [TestMethod]
        public void A_testSettype()
        {
            courses.setSettype(type);
            Assert.IsTrue(type == courses.setGettype());
        }
        [TestMethod]
        public void A_testSetday()
        {
            courses.setSetday(day);
            Assert.IsTrue(day == courses.setGetday());
        }
        [TestMethod]
        public void A_testSetindex()
        {
            courses.setSetindex(index);
            Assert.IsTrue(index == courses.setGetindex());
        }
        [TestMethod]
        public void A_testSetapproved()
        {
            courses.setSetapproved(approved);
            Assert.IsTrue(approved == courses.setGetapproved());
        }
        [TestMethod]
        public void A_testSetsemester()
        {
            courses.setSetsemester(semester);
            Assert.IsTrue(semester == courses.setGetsemester());
        }
        [TestMethod]
        public void A_testSetcourseid()
        {
            courses.setSetcourseid(courseid);
            Assert.IsTrue(courseid == courses.setGetcourseid());
        }
        [TestMethod]
        public void A_testSetblocked()
        {
            courses.setSetblocked(blocked);
            Assert.IsTrue(blocked == courses.setGetblocked());
        }

        //getGrades

        public int Id = 1;
        public int studentId = 323602345;
        public int CourseId = 1000;
        public int score = 56;
        GiveGrades grades = new GiveGrades();

        [TestMethod]
        public void A_testSetId()
        {
            grades.setId(Id);
            Assert.IsTrue(Id == grades.getId());
        }
        [TestMethod]
        public void A_testSetstudentId()
        {
            grades.setstudentId(studentId);
            Assert.IsTrue(studentId == grades.getstudentId());
        }
        [TestMethod]
        public void A_testSetCourseId()
        {
            grades.setCourseId(CourseId);
            Assert.IsTrue(CourseId == grades.getCourseId());
        }
        [TestMethod]
        public void A_testSetscore()
        {
            grades.setscore(score);
            Assert.IsTrue(score == grades.getscore());
        }

    }
    
}
