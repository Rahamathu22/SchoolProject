using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SchoolApplication
{
   public  class Repositories
    {
        public static void InsertStudDetails(int Class, string Section, string Year, string Name, string DateOfBirth, string Blood_Group, string AddressId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Data))
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into StudDetails(Class,Section,Year,Name,DateOfBirth,Blood_Group,AddressId) values('" + Class + "','" + Section + "','" + Year + "','" + Name + "','" + DateOfBirth + "','" + Blood_Group + "','" + AddressId + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void Insert_Address(string DoorNo, string Street, string Village, string City, string State, string Pin_Code, string Mobile_Number, string Mail_Id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Data))
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into _Address values('" + DoorNo + "','" + Street + "','" + Village + "','" + City + "','" + State + "','" + Pin_Code + "','" + Mobile_Number + "','" + Mail_Id + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void InsertClassDetails(int Class, string Section, int Class_Teacher)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Data))
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into ClassDetails values('" + Class + "','" + Section + "','" + Class_Teacher + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void InsertStaffDetails(string Name, int AddressId, string Qualification, string JoiningYear, string PreviousExperience)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Data))
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into StaffDetails values('" + Name + "','" + AddressId + "','" + Qualification + "','" + JoiningYear + "','" + PreviousExperience + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void InsertClass(int Class)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Data))
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into Class values('" + Class + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void InsertSubjectDetails(int Class, string SubjectName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Data))
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into SubjectDetails values('" + Class + "','" + SubjectName + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void InsertSubAndStaffRealation(int SubjectId, int Class, string Section, string Year, int StaffId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Data))
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into SubAndStaffRelation values('" + SubjectId + "','" + Class + "','" + Section + "','" + Year + "','" + StaffId + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void InsertExamType(string ExamType)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Data))
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into ExamType values('" + ExamType + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void InsertStudentMarks(int StudId, int Class, string Section, string Year, int SubjectId, int TypeOfExam, string Name, float Mark)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Data))
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into StudentMarks values('" + StudId + "','" + Class + "','" + Section + "','" + Year + "','" + SubjectId + "','" + TypeOfExam + "','" + Name + "','" + Mark + "')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
