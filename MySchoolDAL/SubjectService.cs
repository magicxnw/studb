using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Models;
using System.Configuration;
using System.Data.SqlClient;
/*************************************
 * 类名：SubjectService
 * 功能描述：提供学科信息操作

 * ************************************/
namespace MySchool.DAL
{
   public class SubjectService
    {
        #region  常量、变量的定义
       private static readonly string connString = ConfigurationManager.ConnectionStrings["MySchoolConnectionString"].ToString();
       #endregion

        #region 执行Sql语句,取得科目信息
        /// <summary>
        /// 执行Sql语句,取得科目信息
        /// </summary>
        /// <returns>科目集合</returns>
        public List<Subject > GetSubjectData()
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("     *");
            sb.AppendLine("FROM");
            sb.AppendLine("     [Subject]");

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    conn.Open();
                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Subject> subjectList = new List<Subject>();
                    while (reader.Read())
                    {
                        Subject subject = new Subject();
                        subject.SubjectNo = Convert.ToInt16(reader["SubjectNo"]); ;
                        subject.SubjectName = Convert.ToString(reader["SubjectName"]);
                        subject.ClassHour = Convert.ToInt32(reader["ClassHour"]);
                        subject.GradeId = Convert.ToInt32(reader["GradeId"]);
                        
                        subjectList.Add(subject);
                    }

                    reader.Close();
                    return subjectList;
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

        #region 根据年级取得科目信息
        /// <summary>
       /// 根据年级取得科目信息
       /// </summary>
       /// <param name="iGradeId">年级编号</param>
       /// <returns>科目集合</returns>
        public List<Subject> GetSubjectDataByGradeId(int iGradeId)
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("     *");
            sb.AppendLine("FROM");
            sb.AppendLine("     [Subject]");
            sb.AppendLine("WHERE");
            sb.AppendLine("     [GradeId]=@GradeId");

            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@GradeId", iGradeId) };

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();
                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Subject> subjectList = new List<Subject>();
                    while (reader.Read())
                    {
                        Subject subject = new Subject();
                        subject.SubjectNo = Convert.ToInt16(reader["SubjectNo"]); ;
                        subject.SubjectName = Convert.ToString(reader["SubjectName"]);
                        subject.ClassHour = Convert.ToInt32(reader["ClassHour"]);
                        subject.GradeId = Convert.ToInt32(reader["GradeId"]);

                        subjectList.Add(subject);
                    }

                    reader.Close();
                    return subjectList;
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

        #region 根据科目编号取得科目信息
        /// <summary>
        /// 根据科目编号取得科目信息
        /// </summary>
        /// <param name="iSubjectNo">科目编号</param>
        /// <returns>科目集合</returns>
        public Subject GetSubjectDataBySubjectNo(int iSubjectNo)
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("     *");
            sb.AppendLine("FROM");
            sb.AppendLine("     [Subject]");
            sb.AppendLine("WHERE");
            sb.AppendLine("     [SubjectNo]=@SubjectNo");

            SqlParameter para = new SqlParameter("@SubjectNo", iSubjectNo);

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
                    Subject subject = new Subject();
                    if (reader.Read())
                    {
                        subject.SubjectNo = Convert.ToInt16(reader["SubjectNo"]); ;
                        subject.SubjectName = Convert.ToString(reader["SubjectName"]);
                        subject.ClassHour = Convert.ToInt32(reader["ClassHour"]);
                        subject.GradeId = Convert.ToInt32(reader["GradeId"]);
                    }
                    reader.Close();
                    return subject;
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

        #region 根据科目编号取得科目信息
        /// <summary>
        /// 获得科目ID
        /// </summary>
        /// <param name="subjectName">科目名称</param>
        /// <returns></returns>
        public static int GetSubjectNo(string subjectName)
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine(" SubjectNo");
            sb.AppendLine(" FROM");
            sb.AppendLine(" [Subject]");
            sb.AppendLine(" WHERE");
            sb.AppendLine(" [SubjectName]=@SubjectName");

            SqlParameter para = new SqlParameter("@SubjectName", subjectName);

            using (SqlConnection conn = new SqlConnection(connString))
            {

                // 创建Command命令
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.Add(para);
                conn.Open();
                // 执行查询语句
                object oResult = cmd.ExecuteScalar();
                if (oResult != null)
                    return Convert.ToInt32(oResult);

                return -1;

            }
        }


        #endregion
    }
}
