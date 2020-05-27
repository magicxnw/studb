using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using MySchool.Models;
/*************************************
 * 类名：GradeService
 * 功能描述：提供年级信息操作
 * ************************************/
namespace MySchool.DAL
{
    public class GradeService
    {
        #region  常量、变量的定义
        private readonly string connString = ConfigurationManager.ConnectionStrings["MySchoolConnectionString"].ToString();
        #endregion

        #region 执行Sql语句,取得年级信息
        /// <summary>
        /// 执行Sql语句,取得年级信息
        /// </summary>
        /// <returns>年级集合</returns>
        public List<Grade> GetGradeData()
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("     *");
            sb.AppendLine("FROM");
            sb.AppendLine("     [Grade]");

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    conn.Open();
                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Grade> gradeList = new List<Grade>();
                    while (reader.Read())
                    {
                        Grade grade = new Grade();
                        grade.GradeId = Convert.ToInt16(reader["GradeId"]); ;
                        grade.GradeName = Convert.ToString(reader["GradeName"]);
                        gradeList.Add(grade);
                    }
                    reader.Close();
                    return gradeList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    //关闭数据库连接

                    conn.Close();
                }
            }
        }
        #endregion

        #region 根据年级Id取得年级信息
        /// <summary>
        /// 根据年级Id取得年级信息
        /// </summary>
        /// <returns>年级</returns>
        public Grade GetGradeDataById(int gradeId)
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("     *");
            sb.AppendLine("FROM");
            sb.AppendLine("     [Grade]");
            sb.AppendLine("WHERE");
            sb.AppendLine("     [GradeId]=@GradeId");

            SqlParameter para = new SqlParameter("@GradeId", gradeId);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.Add(para);
                    conn.Open();

                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    Grade grade = new Grade();
                    if (reader.Read())
                    {
                        grade.GradeId = Convert.ToInt16(reader["GradeId"]); ;
                        grade.GradeName = Convert.ToString(reader["GradeName"]);
                    }
                    reader.Close();
                    return grade;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    //关闭数据库连接
                    conn.Close();
                }
            }
        }

        public int GetGradeId(string gradeName)
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("     GradeId");
            sb.AppendLine("FROM");
            sb.AppendLine("     [Grade]");
            sb.AppendLine("WHERE");
            sb.AppendLine("     [GradeName]=@GradeName");

            SqlParameter para = new SqlParameter("@GradeName", gradeName);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.Add(para);
                    conn.Open();

                    // 执行查询语句
                    object oId = cmd.ExecuteScalar();
                    if (oId != null && oId != DBNull.Value)
                    {
                        return Convert.ToInt32(oId);
                    }

                    return -1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    //关闭数据库连接
                    conn.Close();
                }
            }
        }
        #endregion
    }
}
