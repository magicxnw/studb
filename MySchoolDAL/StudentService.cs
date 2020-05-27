using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySchool.Models;
/*************************************
 * 类名：StudentService
 * 功能描述：提供学员信息操作

 * ************************************/
namespace MySchool.DAL
{
    public class StudentService
    {
        #region  常量、变量的定义
        private static readonly string connString = ConfigurationManager.ConnectionStrings["MySchoolConnectionString"].ToString();
        #endregion

        public static bool CheckStuNoIsExist(int studentNo)
        {
            //创建Sql语句

            String sql = string.Format("SELECT COUNT(1) FROM [Student] WHERE [StudentNo]={0}", studentNo);
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                // 创建Command命令
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }

            }
            finally
            {
                //关闭数据库连接
                conn.Close();

            }
            return false;
        }

      

        #region 检查学员登录
        /// <summary>
        /// 执行Sql语句检查学员登录
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <param name="pwd">密码</param>
        /// <returns>true:检索到;false:没有检索到</returns>
        public bool CheckStudentLogin(int studentNo, string loginPwd)
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT");
            sb.Append("     *");
            sb.Append("FROM");
            sb.Append("     [Student]");
            sb.Append("WHERE");
            sb.Append("      [StudentNo]=@StudentNo");
            sb.Append(" AND");
            sb.Append("      [LoginPwd]=@LoginPwd");

            SqlParameter[] para = new SqlParameter[] {new SqlParameter ("@StudentNo",studentNo),
                                                                             new SqlParameter ("@LoginPwd",loginPwd)};

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
                    //如果检索到则返回管理员实体，否则返回null
                    if (reader.Read())
                    {
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        return false;
                    }
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

        public Student GetStudentByNo(int studentNo)
        {
            //创建Sql语句
            string sql = "SELECT * FROM [Student] WHERE [StudentNo] = @StudentNo";

            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@StudentNo", studentNo) };

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();
                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    //如果检索到则返回管理员实体，否则返回null
                    if (reader.Read())
                    {
                        Student student = new Student();
                        student.StudentNo = studentNo;
                        student.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                        student.StudentName = Convert.ToString(reader["StudentName"]);
                        student.Gender = Convert.ToString(reader["Gender"]);
                        student.GradeId = Convert.ToInt16(reader["GradeId"]);
                        student.Phone = Convert.ToString(reader["Phone"]);
                        student.Address = Convert.ToString(reader["Address"]);
                        student.BornDate = Convert.ToDateTime(reader["BornDate"]);
                        student.Email = Convert.ToString(reader["Email"]);
                        student.IdentityCard = Convert.ToString(reader["IdentityCard"]);

                        reader.Close();
                        return student;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (SqlException ex)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    //关闭数据库连接
                    conn.Close();
                }
            }
        }

        #region 检查身份证号是否存在
        /// <summary>
        /// 执行Sql语句检查身份证号是否存在
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <returns>学生实体</returns>
        public int CheckIdentityCard(string identityCard)
        {
            //创建Sql语句
            string sql = "SELECT count(1) FROM [Student] WHERE [IdentityCard] = @IdentityCard";

            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@IdentityCard", identityCard) };

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();
                    // 执行查询语句
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion

        #region 检查年级Id是否一致
        /// <summary>
        /// 检查年级Id是否一致
        /// </summary>
        /// <param name="subjectNo">科目编号</param>
        /// <returns>存在的行数</returns>
        public int CheckGradeId(int subjectNo)
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT");
            sb.Append("      Count(*)");
            sb.Append("FROM");
            sb.Append("     [Student]");
            sb.Append("WHERE");
            sb.Append("      [GradeId]=(select GradeId from Subject where SubjectNo=@SubjectNo)");

            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@SubjectNo", subjectNo) };

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();
                    // 执行查询语句
                    return (int)cmd.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion

        #region 将学员信息添加到学员表
        /// <summary>
        /// 执行Sql语句将学员信息添加到学员表
        /// </summary>
        /// <param name="student">Student实体</param>
        /// <returns>受影响行数</returns>
        public int AddStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    //创建Sql语句
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("INSERT [Student]");
                    sb.AppendLine("VALUES");
                    sb.AppendLine("     (@StudentNo,@LoginPwd,@StudentName,@Sex,@GradeId,@Phone,@Address,@BornDate,@Email,@IdentityCard)");

                    SqlParameter[] para = new SqlParameter[] { new SqlParameter("@StudentNo", student .StudentNo .ToString ()) ,
                                                                                      new SqlParameter("@LoginPwd", student .LoginPwd  .ToString ()) ,
                                                                                      new SqlParameter("@StudentName", student .StudentName  .ToString ()) ,
                                                                                      new SqlParameter("@Sex", student.Gender  .ToString ()) ,
                                                                                      new SqlParameter("@GradeId", student .GradeId  .ToString ()) ,
                                                                                      new SqlParameter("@Phone", student .Phone  .ToString ()) ,
                                                                                      new SqlParameter("@Address", student .Address  .ToString ()) ,
                                                                                      new SqlParameter("@BornDate", student .BornDate .ToString ()) ,
                                                                                      new SqlParameter("@Email", student .Email  .ToString ()) ,
                                                                                      new SqlParameter("@IdentityCard", student .IdentityCard .ToString ()) };

                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();
                    int iRet = cmd.ExecuteNonQuery();

                    return iRet;
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

        #region 更新学员信息表
        /// <summary>
        /// 更新学员信息表
        /// </summary>
        /// <param name="student">学员实体</param>
        /// <returns>1：成功；-1：失败</returns>
        public int UpdateStudentInfo(Student student)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    //初始化返回值
                    int iRet = -1;

                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand("sp_update_student", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //添加输入参
                    cmd.Parameters.Add("@StudentNo", SqlDbType.Int).Value = student.StudentNo;
                    cmd.Parameters.Add("@LoginPwd", SqlDbType.VarChar).Value = student.LoginPwd;
                    cmd.Parameters.Add("@StudentName", SqlDbType.VarChar).Value = student.StudentName;
                    cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = student.Gender == "男" ? 1 : 0;
                    cmd.Parameters.Add("@GradeId", SqlDbType.Int).Value = student.GradeId;
                    cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = student.Phone;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = student.Address;
                    cmd.Parameters.Add("@BornDate", SqlDbType.DateTime).Value = student.BornDate;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = student.Email;
                    cmd.Parameters.Add("@IdentityCard", SqlDbType.VarChar).Value = student.IdentityCard;

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

        #region 取得学员全部信息
        /// <summary>
        /// 取得学员全部信息
        /// </summary>
        /// <returns>学员集合</returns>
        public List<Student> GetStudentData()
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT");
            sb.Append("     *");
            sb.Append("FROM");
            sb.Append("     [Student]");

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    conn.Open();
                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Student> studentList = new List<Student>();
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.StudentNo = Convert.ToInt16(reader["StudentNo"]);
                        student.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                        student.StudentName = Convert.ToString(reader["StudentName"]);
                        student.Gender = Convert.ToInt16(reader["Gender"]) == 1 ? "男" : "女";
                        student.GradeId = Convert.ToInt16(reader["GradeId"]);
                        student.Phone = Convert.ToString(reader["Phone"]);
                        student.Address = Convert.ToString(reader["Address"]);
                        student.BornDate = Convert.ToDateTime(reader["BornDate"]);
                        student.Email = Convert.ToString(reader["Email"]);
                        student.IdentityCard = Convert.ToString(reader["IdentityCard"]);

                        studentList.Add(student);

                    }

                    reader.Close();
                    return studentList;
                }
                catch (SqlException ex)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    //关闭数据库连接
                    conn.Close();
                }
            }
        }
        #endregion

        #region 根据条件检索学员信息
        /// <summary>
        /// 根据输入姓名和年级条件检索学员信息
        /// </summary>
        /// <param name="name">查询条件:姓名</param>
        /// <param name="gradeId">查询条件:年级</param>
        /// <returns>学员集合</returns>
        public List<Student> GetStudentDataByNameAndGrade(string name, int gradeId)
        {
            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT");
            sb.Append("     *");
            sb.Append("FROM");
            sb.Append("     [Student]");
            sb.Append("WHERE");
            sb.Append("      [StudentName] like   '%");
            sb.Append(name);
            sb.Append("%'");
            sb.Append("AND");
            sb.Append("      [GradeId] =");
            sb.Append(gradeId.ToString());


            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    conn.Open();
                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Student> studentList = new List<Student>();
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.StudentNo = Convert.ToInt16(reader["StudentNo"]);
                        student.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                        student.StudentName = Convert.ToString(reader["StudentName"]);
                        student.Gender = Convert.ToInt16(reader["Gender"]) == 1 ? "男" : "女";
                        student.GradeId = Convert.ToInt16(reader["GradeId"]);
                        student.Phone = Convert.ToString(reader["Phone"]);
                        student.Address = Convert.ToString(reader["Address"]);
                        student.BornDate = Convert.ToDateTime(reader["BornDate"]);
                        student.Email = Convert.ToString(reader["Email"]);
                        student.IdentityCard = Convert.ToString(reader["IdentityCard"]);

                        studentList.Add(student);
                    }
                    reader.Close();
                    return studentList;
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

        /// <summary>
        /// 根据输入姓名条件检索学员信息
        /// </summary>
        /// <param name="name">查询条件:姓名</param>
        /// <returns>学员集合</returns>
        public List<Student> GetStudentDataByName(string name)
        {
            //创建Sql语句

            string sql = "SELECT   *  FROM [Student] WHERE [StudentName] like +  '%' + @StudentName +'%'";

            SqlParameter[] para = new SqlParameter[] { new SqlParameter("@StudentName", name) };

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();
                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Student> studentList = new List<Student>();
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.StudentNo = Convert.ToInt16(reader["StudentNo"]);
                        student.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                        student.StudentName = Convert.ToString(reader["StudentName"]);
                        student.Gender = Convert.ToString(reader["Gender"]);
                        student.GradeId = Convert.ToInt16(reader["GradeId"]);
                        student.Phone = Convert.ToString(reader["Phone"]);
                        student.Address = Convert.ToString(reader["Address"]);
                        student.BornDate = Convert.ToDateTime(reader["BornDate"]);
                        student.Email = Convert.ToString(reader["Email"]);
                        student.IdentityCard = Convert.ToString(reader["IdentityCard"]);

                        studentList.Add(student);
                    }
                    reader.Close();
                    return studentList;
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

        #region 删除学员信息
        /// <summary>
        /// 删除学员信息
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <returns>受影响行数</returns>
        public int DeleteStudentInfo(int stuNo)
        {
            //创建SqlConnection对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //初始化返回值
                int iRet = -1;

                // 创建Command命令
                SqlCommand cmd = new SqlCommand("sp_delete_student", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //添加输入参数
                cmd.Parameters.Add("@StudentNo", SqlDbType.Int).Value = stuNo;

                conn.Open();
                iRet = cmd.ExecuteNonQuery();

                return iRet;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new CustomerException("Student表外键约束!", ex);
                }
                else
                {
                    throw ex;
                }
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

        #region 将Excel中的数据添加到数据库中
        /// <summary>
        /// 将Excel中的数据添加到数据库中
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns>是否成功添加</returns>
        public bool InsertByExcelData(DataTable dt)
        {
            int nSucess = 0;//添加成功的行数
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                foreach (DataRow dr in dt.Rows)
                {
                    //获取年级Id
                    int gradeId = -1;
                    if (dr[3] != null)
                    {
                        gradeId = new GradeService().GetGradeId(dr[3].ToString());
                    }
                    //创建Sql语句
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT [Student]");
                    sb.Append(" VALUES");
                    sb.Append(" (@LoginPwd,@StudentName,@Gender,@GradeId,@Phone,@Address,@BornDate,@Email,@IdentityCard)");

                    SqlParameter[] para = new SqlParameter[] { 
                        new SqlParameter("@LoginPwd", dr[0]) ,
                        new SqlParameter("@StudentName", dr[1]) ,
                        new SqlParameter("@Gender", dr[2]) ,
                        new SqlParameter("@GradeId", gradeId) ,
                        new SqlParameter("@Phone", dr[4]) ,
                        new SqlParameter("@Address", dr[5]) ,
                        new SqlParameter("@BornDate", dr[6]) ,
                        new SqlParameter("@Email", dr[7]) ,
                        new SqlParameter("@IdentityCard",dr[8]) };

                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddRange(para);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        nSucess += 1;//添加成功的行数
                    }
                }
                return nSucess == dt.Rows.Count;//全部导入成功
            }
        }
    }
        #endregion


  

}


