using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySchool.Models;
/*************************************
 * 类名：ResultService
 * 功能描述：提供学员成绩操作

 * ************************************/
namespace MySchool.DAL
{
    public class ResultService
    {
        #region  常量、变量的定义
        private readonly static string connString = ConfigurationManager.ConnectionStrings["MySchoolConnectionString"].ToString();
        #endregion

        #region 将学员成绩添加到成绩表
        /// <summary>
        /// 将学员成绩添加到成绩表
        /// </summary>
        /// <param name="result">Result实体</param>
        /// <returns>受影响行数</returns>
        public int AddStudentResult(Result result)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    //创建Sql语句
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("INSERT [Result]");
                    sb.AppendLine("VALUES");
                    sb.AppendLine("     (@StudentNo,@SubjectNo,@StudentResult,@ExamDate)");

                    SqlParameter[] para = new SqlParameter[] { new SqlParameter("@StudentNo", result .StudentNo  .ToString ()) ,
                                                                                    new SqlParameter("@SubjectNo",  result.SubjectNo .ToString ()) ,
                                                                                    new SqlParameter("@StudentResult", result .StudentResult .ToString ()) ,
                                                                                    new SqlParameter("@ExamDate", result .ExamDate.ToString ())};

                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();
                    int iRet = Convert.ToInt32(cmd.ExecuteScalar());

                    return iRet;
                }
                catch (SqlException ex)
                {
                    throw ex;
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

        #region 查询学员成绩
        /// <summary>
        /// 查询学员成绩
        /// </summary>
        /// <param name="stuName">学生姓名</param>
        /// <param name="subjectNo">科目编号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewStudentResult(string stuName,string subjectNo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    //创建Sql语句
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" SELECT ");
                    sb.AppendLine("           A.[StudentNo] ");
                    sb.AppendLine("           ,A.[SubjectNo]");
                    sb.AppendLine("           ,A.[StudentResult]");
                    sb.AppendLine("           ,A.[ExamDate]");
                    sb.AppendLine(" FROM ");
                    sb.AppendLine("           [Result] as A,[Student] as B");
                    sb.AppendLine(" WHERE ");
                    sb.AppendLine("           A.[StudentNo]=B.[StudentNo]");
                    sb.AppendLine(" AND ");
                    sb.AppendLine("           A.[SubjectNo]= @SubjectNo");
                    sb.AppendLine(" AND ");
                    sb.AppendLine("           B.[StudentName] like +  '%' + @StudentName +'%'");

                    SqlParameter[] para = new SqlParameter[] { new SqlParameter("@StudentName", stuName) ,
                                                                                    new SqlParameter("@subjectNo", subjectNo) };
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();

                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Result> resultList = new List<Result>();
                    while (reader.Read())
                    {
                        Result result = new Result();
                        result.StudentNo = Convert.ToInt16(reader["StudentNo"]);
                        result.SubjectNo = Convert.ToInt16(reader["SubjectNo"]);
                        result.StudentResult = Convert.ToInt16(reader["StudentResult"]);
                        result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);

                        resultList.Add(result);
                    }
                    reader.Close();
                    return resultList;
                }
                catch (SqlException ex)
                {
                    throw ex;
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

        #region 将Excel中的数据添加到数据库中
        /// <summary>
        /// 将Excel中的数据添加到数据库中
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns>是否成功添加</returns>
        public static bool InsertByExcelData(DataTable dt)
        {
            int nSucess = 0;//添加成功的行数
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //创建Sql语句
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT [Result]");
                sb.Append(" VALUES");
                sb.Append(" (@StudentNo,@SubjectNo,@StudentResult,@ExamDate)");

                conn.Open();

                foreach (DataRow dr in dt.Rows)
                {
                    //获取年级Id
                    int subjectNo = -1;
                    if (dr[1] != null)
                    {
                        subjectNo = SubjectService.GetSubjectNo(dr[1].ToString());
                    }

                    if (subjectNo > 0)//如果科目有效
                    {
                        SqlParameter[] para = new SqlParameter[] { 
                        new SqlParameter("@StudentNo", dr[0]) ,
                        new SqlParameter("@SubjectNo", subjectNo) ,
                        new SqlParameter("@StudentResult", dr[2]) ,
                        new SqlParameter("@ExamDate", dr[3]) 
                        };

                        SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddRange(para);
                        //插入数据
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            nSucess += 1;//添加成功的行数
                        }
                    }
                }//End foreach

                return nSucess == dt.Rows.Count;//全部导入成功
            }
        }

        #endregion


        public List<Result> ReviewStudentResultEx(string subjectNo, string stuName)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    //创建Sql语句
                    StringBuilder sb = new StringBuilder();
                    sb.Append(@"	SELECT * FROM RESULT a JOIN student b
                        ON a.studentno = b.studentno
	                    WHERE 1=1 ");
                    if (subjectNo!="-1")
                    {
                        sb.Append(" AND  a.subjectNo = @SubjectNo");
                    }
                    if (!string.IsNullOrEmpty(stuName))
                    {
                        sb.Append(" AND b.studentName like '%@StudentName%'");
                    }
                    SqlParameter[] para = {
                         new SqlParameter("@SubjectNo", subjectNo),
                         new SqlParameter("@StudentName",stuName)};
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();

                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Result> resultList = new List<Result>();
                    while (reader.Read())
                    {
                        Result result = new Result();
                        result.StudentNo = Convert.ToInt16(reader["StudentNo"]);
                        result.SubjectNo = Convert.ToInt16(reader["SubjectNo"]);
                        result.StudentResult = Convert.ToInt16(reader["StudentResult"]);
                        result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);

                        resultList.Add(result);
                    }
                    reader.Close();
                    return resultList;
                }
                catch (SqlException ex)
                {
                    throw ex;
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
        #region 根据科目编号查询学员成绩
        /// <summary>
        /// 只根据科目编号查询学员成绩
        /// </summary>
        /// <param name="subjectNo">科目编号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewStudentResultBySubjectNo(string subjectNo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    //创建Sql语句
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" SELECT ");
                    sb.AppendLine("           * ");
                    sb.AppendLine(" FROM ");
                    sb.AppendLine("           [Result] ");
                    sb.AppendLine(" WHERE ");
                    sb.AppendLine("           [SubjectNo]= @SubjectNo");

                    SqlParameter para = new SqlParameter("@SubjectNo", subjectNo);                                                                       
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.Add (para);
                    conn.Open();

                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Result> resultList = new List<Result>();
                    while (reader.Read())
                    {
                        Result result = new Result();
                        result.StudentNo = Convert.ToInt16(reader["StudentNo"]);
                        result.SubjectNo = Convert.ToInt16(reader["SubjectNo"]);
                        result.StudentResult = Convert.ToInt16(reader["StudentResult"]);
                        result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);

                        resultList.Add(result);
                    }
                    reader.Close();
                    return resultList;
                }
                catch (SqlException ex)
                {
                    throw ex;
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

        #region 根据科目编号和学号查询学员成绩
        /// <summary>
        /// 根据科目编号和学号查询学员成绩
        /// </summary>
        /// <param name="subjectNo">科目编号</param>
        /// <param name="stuNo">学号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewStudentResultBySubjectNoAndStuNo(string subjectNo,string stuNo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    //创建Sql语句
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" SELECT ");
                    sb.AppendLine("           * ");
                    sb.AppendLine(" FROM ");
                    sb.AppendLine("           [Result] ");
                    sb.AppendLine(" WHERE ");
                    sb.AppendLine("           [StudentNo]=@StudentNo");
                    sb.AppendLine(" AND ");
                    sb.AppendLine("           [SubjectNo]= @SubjectNo");

                    SqlParameter[]  para =new  SqlParameter []{ new SqlParameter("@subjectNo", subjectNo),
                                                                                       new SqlParameter ("@StudentNo",stuNo)};
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();

                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Result> resultList = new List<Result>();
                    while (reader.Read())
                    {
                        Result result = new Result();
                        result.StudentNo = Convert.ToInt16(reader["StudentNo"]);
                        result.SubjectNo = Convert.ToInt16(reader["SubjectNo"]);
                        result.StudentResult = Convert.ToInt16(reader["StudentResult"]);
                        result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);

                        resultList.Add(result);
                    }
                    reader.Close();
                    return resultList;
                }
                catch (SqlException ex)
                {
                    throw ex;
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

        #region 根据学号查询学员成绩
        /// <summary>
        /// 只根据学号查询学员成绩
        /// </summary>
        /// <param name="stutNo">学号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewStudentResultByStuNo(string stuNo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    //创建Sql语句
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(" SELECT ");
                    sb.AppendLine("           * ");
                    sb.AppendLine(" FROM ");
                    sb.AppendLine("           [Result] ");
                    sb.AppendLine(" WHERE ");
                    sb.AppendLine("           [StudentNo]=@StudentNo");

                    SqlParameter para = new SqlParameter("@StudentNo", stuNo);
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.Add(para);
                    conn.Open();

                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Result> resultList = new List<Result>();
                    while (reader.Read())
                    {
                        Result result = new Result();
                        result.StudentNo = Convert.ToInt16(reader["StudentNo"]);
                        result.SubjectNo = Convert.ToInt16(reader["SubjectNo"]);
                        result.StudentResult = Convert.ToInt16(reader["StudentResult"]);
                        result.ExamDate = Convert.ToDateTime(reader["ExamDate"]);

                        resultList.Add(result);
                    }
                    reader.Close();
                    return resultList;
                }
                catch (SqlException ex)
                {
                    throw ex;
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

        #region 更新学员成绩表
        /// <summary>
        /// 更新学员成绩表
        /// </summary>
        /// <param name="result">学员成绩实体</param>
        /// <returns>受影响行数</returns>
        public int UpdateStudentResult(Result result)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    //初始化返回值
                    int iRet = -1;

                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand("sp_update_result", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //添加输入参数
                    cmd.Parameters.Add("@StudentNo", SqlDbType.Int).Value = result.StudentNo;
                    cmd.Parameters.Add("@SubjectNo", SqlDbType.Int).Value = result.SubjectNo;
                    cmd.Parameters.Add("@StudentResult", SqlDbType.Int).Value = result.StudentResult ;
                    cmd.Parameters.Add("@ExamDate", SqlDbType.DateTime ).Value = result.ExamDate ;

                    conn.Open();
                    iRet = cmd.ExecuteNonQuery();

                    return iRet;
                }
                catch (SqlException ex)
                {
                    throw ex;
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

        #region 删除学员成绩
        /// <summary>
        /// 删除学员成绩
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <param name="subjectNo">科目编号</param>
        /// <returns>受影响行数</returns>
        public int DeleteStudentResult(int stuNo,int subjectNo)
        {
            //创建SqlConnection对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建Sql语句
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("DELETE  FROM [Result]");
                sb.AppendLine("WHERE");
                sb.AppendLine("          [StudentNo]=@StudentNo");
                sb.AppendLine("AND");
                sb.AppendLine("          [SubjectNo]=@SubjectNo");

                SqlParameter[] para =new SqlParameter []{ new SqlParameter("@StudentNo", stuNo),
                                                                                  new SqlParameter("@SubjectNo", subjectNo)};
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.AddRange(para);
                conn.Open();
                int iRet = Convert.ToInt32(cmd.ExecuteScalar());

                return iRet;
            }
            catch (SqlException ex)
            {
                throw ex;
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
        #endregion
    }
}
