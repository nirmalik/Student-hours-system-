using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using THEUSERS;
using StudentSpace;
using SecretarySpace;
using Courses;
using PROJECT_19.Classes;


namespace Connections{
    public class DBConnect
    {
        private static SqlConnectionStringBuilder builder;
        public static SqlConnection connection;
        static public void connect()
        {
            //This function to creat initial connection it should be called first
            builder = new SqlConnectionStringBuilder();
            builder.DataSource = "scedata.database.windows.net";
            builder.UserID = "scedata";
            builder.Password = "Shadi1234";
            builder.InitialCatalog = "Branch_B";
            connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
        }

        static public User selectUser(String colum, String value)
        {
            //This function will return a new User of the raw values 'rawName' : 'value'
            String sql = "SELECT * FROM Users WHERE " + colum + " = '" + value + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            User newUser = null;
            //Try to get results from database
            try
            {
                if (reader.Read())
                {
                    //Check that the user on of the 4 user we have
                    if (reader[8].ToString() == "student")
                    {
                        newUser = new Student();
                        ((Student)newUser).setSemester(reader[9].ToString());
                    }
                    else if (reader[8].ToString() == "secretary")
                    {
                        newUser = new Secretary();
                    }else if(reader[8].ToString() == "Secretery department")
                    {
                        newUser = new Secretary();
                        newUser.forA = true;
                        newUser.j = reader[8].ToString();
                    }
                    else if (reader[8].ToString() == "secretaryAdministration")
                    {
                        newUser = new SecretaryManager();
                    }
                    else if (reader[8].ToString() == "association")
                    {
                        newUser = new AssociationMember();
                    }else
                    {
                        newUser = new User();
                        newUser.j = reader[8].ToString();
                    }
                    
                    if (newUser != null)
                    {
                        newUser.setId(int.Parse((reader[0].ToString())));
                        newUser.setFirstName(reader[1].ToString());
                        newUser.setLastName(reader[2].ToString());
                        newUser.setUserName(reader[3].ToString());
                        newUser.setPassword(reader[4].ToString());
                        newUser.setMail(reader[5].ToString());
                        newUser.setAddress(reader[6].ToString());
                        Console.WriteLine(reader[7].ToString());
                        if (reader[7].ToString() != "")
                            newUser.setPhoneNumber(int.Parse(reader[7].ToString()));
                    }
                }
            }
            finally
            {
                reader.Close();
            }
        return newUser;
        }

        static public void updatePassword(String username,String password)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Users SET password = @pass Where userName = @un";
            command.Parameters.AddWithValue("@pass", password);
            command.Parameters.AddWithValue("@un", username);
            command.ExecuteNonQuery();
        }

        static public List<Course> getCourses(string colum,string value)
        {
            String sql = "SELECT * FROM Courses WHERE " + colum + " = '" + value +"'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Course> aList = new List<Course>();
            //Try to get results from database
            try
            {
                while(reader.Read())
                {
                    Course newCourse = new Course();
                    newCourse.setId(int.Parse(reader[0].ToString()));
                    newCourse.setName(reader[1].ToString());
                    if (reader[2].ToString() != string.Empty)
                    {
                        newCourse.setPassScore(int.Parse(reader[2].ToString()));
                    }
                    else
                    {
                        newCourse.setPassScore(-1);
                    }
                    if (reader[3].ToString() != string.Empty)
                        newCourse.setBlockCourse(int.Parse(reader[3].ToString()));
                    if (reader[4].ToString() != string.Empty)
                        newCourse.setPoints(double.Parse(reader[4].ToString()));
                    if (reader[5].ToString() == "lecture")
                        newCourse.setType(CourseType.Lecture);
                    else if (reader[5].ToString() == "practice")
                        newCourse.setType(CourseType.Practice);
                    else
                        newCourse.setType(CourseType.Laboratory);
                    newCourse.setTeacherId(int.Parse(reader[6].ToString()));
                    newCourse.setSemester(reader[7].ToString());
                    if (reader[5].ToString() == "practice" || reader[5].ToString() == "lecture")
                        aList.Add(newCourse);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public List<string> getRecHourse()
        {
            String sql = "SELECT * FROM RecHours";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string> aList = new List<string>();
            //Try to get results from database
            try
            {
                while (reader.Read())
                {
                    string str = reader[1].ToString() + " ";
                    str += reader[2].ToString() + " ";
                    str += reader[3].ToString();
                    aList.Add(str);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public List<Course> getAllCourses()
        {
            //This function will return a new User of the raw values 'rawName' : 'value'
            String sql = "SELECT * FROM Courses";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Course> aList = new List<Course>();
            //Try to get results from database
            try
            {
                while (reader.Read())
                {
                    Course newCourse = new Course();
                    newCourse.setId(int.Parse(reader[0].ToString()));
                    newCourse.setName(reader[1].ToString());
                    if (reader[2].ToString() != string.Empty)
                    {
                        newCourse.setPassScore(int.Parse(reader[2].ToString()));
                    }
                    else
                    {
                        newCourse.setPassScore(-1);
                    }
                    if (reader[3].ToString() != string.Empty)
                        newCourse.setBlockCourse(int.Parse(reader[3].ToString()));
                    if (reader[4].ToString() != string.Empty)
                        newCourse.setPoints(double.Parse(reader[4].ToString()));
                    if (reader[5].ToString() == "lecture")
                        newCourse.setType(CourseType.Lecture);
                    else if (reader[5].ToString() == "practice")
                        newCourse.setType(CourseType.Practice);
                    else
                        newCourse.setType(CourseType.Laboratory);

                    newCourse.setTeacherId(int.Parse(reader[6].ToString()));
                    newCourse.setSemester(reader[7].ToString());
                    if(reader[5].ToString() == "practice" || reader[5].ToString() == "lecture")
                        aList.Add(newCourse);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public List<string[]> getLessonTimes(int id)
        {
            //This function will return a new User of the raw values 'rawName' : 'value'
            String sql = "SELECT * FROM Scheduling";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> aList = new List<string[]>();

            //Try to get results from database
            try
            {
                while (reader.Read())
                {
                    if (id == Int32.Parse(reader[1].ToString()))
                    {
                        string[] a = new string[3];
                        a[0] = reader[1].ToString();
                        a[1] = reader[2].ToString();
                        a[2] = reader[3].ToString();
                        aList.Add(a);
                    }
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public void updateSemester(int courseId, String semester)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Courses SET semester = @semester Where id = @id";
            command.Parameters.AddWithValue("@semester", semester);
            command.Parameters.AddWithValue("@id", courseId);
            command.ExecuteNonQuery();
        }

        static public Course getOneCourse(string colum,string value)
        {
            String sql = "SELECT * FROM Courses WHERE " + colum + " = '" + value + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            Course newCourse = null;
            //Try to get results from database
            try
            {
                if(reader.Read())
                {
                    newCourse = new Course();
                    newCourse.setId(int.Parse(reader[0].ToString()));
                    newCourse.setName(reader[1].ToString());
                    if (reader[2].ToString() != string.Empty)
                    {
                        newCourse.setPassScore(int.Parse(reader[2].ToString()));
                    }
                    else
                    {
                        newCourse.setPassScore(-1);
                    }
                    if (reader[3].ToString() != string.Empty)
                        newCourse.setBlockCourse(int.Parse(reader[3].ToString()));
                    if (reader[4].ToString() != string.Empty)
                        newCourse.setPoints(double.Parse(reader[4].ToString()));
                    if (reader[5].ToString() == "lecture")
                        newCourse.setType(CourseType.Lecture);
                    else if (reader[5].ToString() == "practice")
                        newCourse.setType(CourseType.Practice);
                    else
                        newCourse.setType(CourseType.Laboratory);
                    newCourse.setTeacherId(int.Parse(reader[6].ToString()));
                    newCourse.setSemester(reader[7].ToString());
                }
            }
            finally
            {
                reader.Close();
            }
            return newCourse;
        }
        //Get Data from scheduling
        static public List<List<string>> getSechedule(string colum,string value)
        {
            String sql = "SELECT * FROM Schedule WHERE " + colum + " = '" + value + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<List<string>> aList = new List<List<string>>();
            //Try to get results from database ;;
            try
            {
                while (reader.Read())
                {
                    List<string> lis = new List<string>();
                    lis.Add(reader[2].ToString());
                    lis.Add(reader[3].ToString());
                    lis.Add(reader[4].ToString());
                    aList.Add(lis);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public List<List<string>> getFromScheduilngOneCourseDetails(string colum, string value)
        {
            String sql = "SELECT * FROM Scheduling WHERE " + colum + " = '" + value + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<List<string>> aList = new List<List<string>>();
            //Try to get results from database
            try
            {
                if(reader.Read())
                {
                    List<string> lis = new List<string>();
                    lis.Add(reader[0].ToString());
                    lis.Add(reader[1].ToString());
                    lis.Add(reader[2].ToString());
                    lis.Add(reader[3].ToString());
                    lis.Add(reader[4].ToString());
                    aList.Add(lis);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public List<List<string>> getFromScheduling(string colum, string value)
        {
            String sql = "SELECT * FROM Scheduling WHERE " + colum + " = '" + value + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<List<string>> aList = new List<List<string>>();
            //Try to get results from database
            try
            {
                while (reader.Read())
                {
                    List<string> lis = new List<string>();
                    lis.Add(reader[0].ToString());
                    lis.Add(reader[1].ToString());
                    lis.Add(reader[2].ToString());
                    lis.Add(reader[3].ToString());
                    lis.Add(reader[4].ToString());
                    aList.Add(lis);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public void insetCourseToSchedule(int studentId,int courseId,string time,string day,int room)
        {
            SqlCommand command = connection.CreateCommand();
            
            command.CommandText = "INSERT into schedule (studentId,couseId,time,day,room) VALUES (@studentId,@courseId,@time,@day,@room)";
            command.Parameters.AddWithValue("@studentId", studentId);
            command.Parameters.AddWithValue("@courseId", courseId);
            command.Parameters.AddWithValue("@time", time);
            command.Parameters.AddWithValue("@day", day);
            command.Parameters.AddWithValue("@room", room);
            command.ExecuteNonQuery();

        }

        static public void insetSecretary(int id, string fName, string lName, string uName,string pass,string mail,string address,int phone)
        {
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "INSERT into Users (id,firstName,lastName,userName,password,mail,address,phone,job) VALUES (@id,@fn,@ln,@un,@ps,@mail,@ad,@ph,@job)";
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@fn",fName);
            command.Parameters.AddWithValue("@ln", lName);
            command.Parameters.AddWithValue("@un", uName);
            command.Parameters.AddWithValue("@ps", pass);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@ad", address);
            command.Parameters.AddWithValue("@ph", phone);
            command.Parameters.AddWithValue("@job", "secretary");
            command.ExecuteNonQuery();

        }

        static public void updateSchedule(int studentId,int courseId,string time,string day,int room)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Schedule SET time = @time ,day = @day ,room = @room Where studentId = @sId AND couseId = @cId";
            command.Parameters.AddWithValue("@time", time);
            command.Parameters.AddWithValue("@day", day);
            command.Parameters.AddWithValue("@sId", studentId);
            command.Parameters.AddWithValue("@cId", courseId);
            command.Parameters.AddWithValue("@room", room);
            command.ExecuteNonQuery();
        }

        static public List<List<string>> getEmptyClasses()
        {
            //This function will return a new User of the raw values 'rawName' : 'value'
            String sql = "SELECT * FROM Classes";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<List<string>> aList = new List<List<string>>();
            //Try to get results from database
            try
            {
                while (reader.Read())
                {
                    List<string> lis = new List<string>();
                    lis.Add(reader[0].ToString());
                    lis.Add(reader[1].ToString());
                    lis.Add(reader[2].ToString());
                    lis.Add(reader[3].ToString());
                    lis.Add(reader[4].ToString());
                    aList.Add(lis);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public List<List<string>> getHolidays()
        {
            //This function will return a new User of the raw values 'rawName' : 'value'
            String sql = "SELECT * FROM Holidays";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<List<string>> aList = new List<List<string>>();
            //Try to get results from database
            try
            {
                while (reader.Read())
                {
                    List<string> lis = new List<string>();
                    lis.Add(reader[1].ToString());
                    lis.Add(reader[2].ToString());
                    aList.Add(lis);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public List<List<string>> getExams(string sem)
        {
            //This function will return a new User of the raw values 'rawName' : 'value'
            String sql = "SELECT * FROM Exams WHERE semester = @sem";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@sem", sem);
            SqlDataReader reader = command.ExecuteReader();
            List<List<string>> aList = new List<List<string>>();
            //Try to get results from database
            try
            {
                while (reader.Read())
                {
                    List<string> lis = new List<string>();
                    lis.Add(reader[1].ToString());
                    lis.Add(reader[2].ToString());
                    lis.Add(reader[3].ToString());
                    lis.Add(reader[5].ToString());
                    aList.Add(lis);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public void addCourse(int id,string name,string semester,string type,int point,int passGrade)
        {
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "INSERT into Courses (Id,name,passScore,blockCourseId,points,type,teacherId,semester) VALUES (@i,@n,@p,@b,@po,@t,@ti,@s)";
            
     
            command.Parameters.AddWithValue("@i", id);
            command.Parameters.AddWithValue("@n", name);
            command.Parameters.AddWithValue("@p", passGrade);
            command.Parameters.AddWithValue("@po", point);
            command.Parameters.AddWithValue("@s", semester);
            command.Parameters.AddWithValue("@t", type);
            command.Parameters.AddWithValue("@b", "000");
            command.Parameters.AddWithValue("@ti", "0");
            command.ExecuteNonQuery();
        }

        static public List<Course> getAllCoursesPlus()
        {
            //This function will return a new User of the raw values 'rawName' : 'value'
            String sql = "SELECT * FROM Courses";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Course> aList = new List<Course>();
            //Try to get results from database
            try
            {
                while (reader.Read())
                {
                    Course newCourse = new Course();
                    newCourse.setId(int.Parse(reader[0].ToString()));
                    newCourse.setName(reader[1].ToString());
                    if (reader[2].ToString() != string.Empty)
                    {
                        newCourse.setPassScore(int.Parse(reader[2].ToString()));
                    }
                    else
                    {
                        newCourse.setPassScore(-1);
                    }
                    if (reader[3].ToString() != string.Empty)
                        newCourse.setBlockCourse(int.Parse(reader[3].ToString()));
                    if (reader[4].ToString() != string.Empty)
                        newCourse.setPoints(double.Parse(reader[4].ToString()));
                    if (reader[5].ToString() == "lecture")
                        newCourse.setType(CourseType.Lecture);
                    else if (reader[5].ToString() == "practice")
                        newCourse.setType(CourseType.Practice);
                    else
                        newCourse.setType(CourseType.Laboratory);

                    newCourse.setTeacherId(int.Parse(reader[6].ToString()));
                    newCourse.setSemester(reader[7].ToString());
                    aList.Add(newCourse);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }

        static public void setCreatingDate(string[] startDate,string[] endDate)
        {
            string a = "creatSchedule";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Dates SET startDate = @startDate,endDate=@endDate Where event = @ev";
            command.Parameters.AddWithValue("@ev", a);
            command.Parameters.AddWithValue("@startDate", startDate[1]+"/"+startDate[0]);
            command.Parameters.AddWithValue("@endDate", endDate[1] + "/" + endDate[0]);
           
           command.ExecuteNonQuery();  
        }

        public static Boolean canCreatShedule()
        {
            Boolean flag=false ;
            string startDate="", endDate="";

            String sql = "SELECT * FROM Dates WHERE " + "event" + " = '" + "creatSchedule" + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<List<string>> aList = new List<List<string>>();
            //Try to get results from database
            try
            {
                if (reader.Read())
                {
                    startDate = (reader[2].ToString());
                    endDate = (reader[3].ToString());
                }
            }
            finally
            {
                reader.Close();
            }
            
            if(startDate != "" && endDate != "")
            {
                List<string> sd = new List<string>(startDate.Split(new string[] { "/" }, StringSplitOptions.None));
                List<string> ed = new List<string>(endDate.Split(new string[] { "/" }, StringSplitOptions.None));
                List<string> currentDate = new List<string>((DateTime.Today.ToString()).Split(new string[] { "/" }, StringSplitOptions.None));

                if (int.Parse(currentDate[0]) == int.Parse(sd[1]))
                {
                    if (int.Parse(currentDate[1]) >= int.Parse(sd[0]) && int.Parse(currentDate[1]) <= int.Parse(ed[0]))
                        flag = true;
                }
             
            }

            return flag;
        }

        public static string whenCan()
        {
            string startDate="";

            String sql = "SELECT * FROM Dates WHERE " + "event" + " = '" + "creatSchedule" + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<List<string>> aList = new List<List<string>>();
            //Try to get results from database
            try
            {
                if (reader.Read())
                {
                    startDate = (reader[2].ToString());
                }
            }
            finally
            {
                reader.Close();
            }

            return startDate;
        }

        static public void insetRequest(int studentId, string studentName, string msg)
        {
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "INSERT into Requests (studentId,studentName,msg) VALUES (@id,@name,@msg)";
            command.Parameters.AddWithValue("@id", studentId);
            command.Parameters.AddWithValue("@name", studentName);
            command.Parameters.AddWithValue("@msg", msg);
            command.ExecuteNonQuery();

        }

        static public List<string> getRequests()
        {
            String sql = "SELECT * FROM Requests";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string> aList = new List<string>();
            //Try to get results from database
            try
            {
                while (reader.Read())
                {
                    string str = reader[1].ToString() + "\t";
                    str += reader[2].ToString() + "\t";
                    str += reader[3].ToString();
                    aList.Add(str);
                }
            }
            finally
            {
                reader.Close();
            }
            return aList;
        }
    }
}//End of workspace
