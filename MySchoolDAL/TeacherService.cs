using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MySchool.DAL
{
    public class TeacherService
    {
        private string connString = ConfigurationManager.ConnectionStrings["MySchoolConnectionString"].ToString();
        public bool AddTeacher(Teacher teacher)
        {
            string sql = @"INSERT Teacher(name,age,teachYear,gradeId)VALUES
                (@name,@age,@teachYear,@gradeId)";
            SqlParameter[] para = { new SqlParameter("@name",teacher.Name),
                                    new SqlParameter("@age",teacher.Age),
                                    new SqlParameter("@teachYear",teacher.TeachYear),
                                    new SqlParameter("@gradeId",teacher.GradeId),
                                  };
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(para);
                return cmd.ExecuteNonQuery() > 0;

            }

        }
        public bool DelTeacher(int teacherId)
        {
            string sql = "DELETE FROM Teacher WHERE id =@tid";
            SqlParameter para = new SqlParameter("@tid", teacherId);
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(para);
                return cmd.ExecuteNonQuery() > 0;


            }
        }
        public List<TeacherBusiness> GetAll()
        {
            string sql = "SELECT a.*,b.gradeName FROM Teacher a JOIN GRADE b ON a.gradeId = b.gradeId";
            List<TeacherBusiness> teacherList = new List<TeacherBusiness>();
            using (SqlConnection con = new SqlConnection(connString))
            {
                SqlDataReader dr = null;
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    TeacherBusiness tea = new TeacherBusiness();
                    tea.Age = Convert.ToInt32(dr["Age"]);
                    tea.Name = dr["name"].ToString();
                    tea.ID = dr["id"].ToString();
                    tea.TeachYear = Convert.ToInt32(dr["teachYear"]);
                    tea.GradeId = Convert.ToInt32(dr["gradeId"]);
                    tea.GradeName = dr["GradeName"].ToString();
                    teacherList.Add(tea);
                }
                dr.Close();
            }
            return teacherList;

        }
    }
}
