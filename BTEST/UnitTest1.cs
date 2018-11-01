using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using PROJECT_19;
using THEUSERS;
using StudentSpace;
using Courses;
using Connections;
using System.Collections.Generic;

namespace BTEST
{
    [TestClass]
    public class UnitTest1
    {
        string firstName = "abed";
        string lastName = "assa";
        string password = "123456";
        string userName = "abed12";
        string address = "B12";
        string mail = "abedab1@ac.sce.ac.il";
        int phone = 0547957951;
        Student student = new Student();
        [TestMethod]
        public void Test_Instance()
        {

            Assert.IsNotNull(Student.ins);
        }

        [TestMethod]
        public void Test_firstName()
        {
        
            student.setFirstName(firstName);
            Assert.IsTrue(firstName == student.getFirstName());
        }

        [TestMethod]
        public void Test_lastName()
        {
            student.setLastName(lastName);
            Assert.IsTrue(lastName == student.getLastName());
        }

        [TestMethod]
        public void Test_Password()
        {
            student.setPassword(password);
            Assert.IsTrue(password == student.getPassword());
        }
        [TestMethod]
        public void Test_UserName()
        {
            student.setUserName(userName);
            Assert.IsTrue(userName == student.getUserName());
        }

        [TestMethod]
        public void Test_Address()
        {
            student.setAddress(address);
            Assert.IsTrue(address == student.getAddress());
        }

        [TestMethod]
        public void Test_Phone()
        {
            student.setPhoneNumber(phone);
            Assert.IsTrue(phone == student.getPhoneNumber());
        }
        [TestMethod]
        public void Test_mail()
        {
            student.setMail(mail);
            Assert.IsTrue(mail == student.getMail());
        }

        [TestMethod]
        public void Test_Job()
        {

            Assert.IsTrue(Job.Student == student.getJob());
        }

        [TestMethod]
        public void Test_getJobString()
        {

            Assert.IsTrue("Student" == student.getJobString());
        }
        [TestMethod]
        public void Test_Symester()
        {
            student.setSemester("A");
            Assert.IsTrue("A" == student.getSemester());
        }

        //Courses
        Course cors = new Course();
        int id = 1000;
        string name = "Project";
        int passScore = 56;
        int blockCourseId = 1001;
        double points = 3.5;
        CourseType type = CourseType.Lecture;
        int teacherId = 308306216;
        string semester = "A";
        string time = "10:12";
        string day = "Sunday";

        [TestMethod]
        public void Test_courseId()
        {
            cors.setId(id);
            Assert.IsTrue(id == cors.getId());

        }

        [TestMethod]
        public void Test_courseName()
        {
            cors.setName(name);
            Assert.IsTrue(name == cors.getName());

        }

        [TestMethod]
        public void Test_passScore()
        {
            cors.setPassScore(passScore);
            Assert.IsTrue(passScore == cors.getPassScore());

        }

        [TestMethod]
        public void Test_blockCourse()
        {
            cors.setBlockCourse(blockCourseId);
            Assert.IsTrue(blockCourseId == cors.getBlockCourseId());

        }

        [TestMethod]
        public void Test_point()
        {
            cors.setPoints(points);
            Assert.IsTrue(points == cors.getPoints());

        }

        [TestMethod]
        public void Test_type()
        {
            cors.setType(type);
            Assert.IsTrue(type == cors.getType());

        }

        [TestMethod]
        public void Test_teacherId()
        {
            cors.setTeacherId(teacherId);
            Assert.IsTrue(teacherId == cors.getTeacherId());

        }

        [TestMethod]
        public void Test_courseSemester()
        {
            cors.setSemester(semester);
            Assert.IsTrue(semester == cors.getSemester());

        }

        [TestMethod]
        public void Test_time()
        {
            cors.setTime(time);
            Assert.IsTrue(time == cors.getTime());

        }
        [TestMethod]
        public void Test_courseDay()
        {
            cors.setDay(day);
            Assert.IsTrue(day == cors.getDay());

        }

        //DataBases
        string value = "abedab1";
        string coulmn = "userName";

        [TestMethod]
        public void Test_getUser()
        {
            DBConnect.connect();
            User s = DBConnect.selectUser(coulmn, value);
            Assert.IsNotNull(s);
        }

        [TestMethod]
        public void Test_getUserNameCheck()
        {
            DBConnect.connect();
            User s = DBConnect.selectUser(coulmn, value);
            Assert.IsTrue("Abed" == s.getFirstName());
        }
        [TestMethod]
        public void Test_coursesList()
        {
            DBConnect.connect();
            List<Course> s = DBConnect.getAllCourses();
            Assert.IsNotNull(s);
        }

    }
}
