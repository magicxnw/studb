using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration ;
using MySchool.Models;
/*************************************
 * 类名：AdminService
 * 功能描述：提供管理员信息操作
 * ************************************/
namespace MySchool.DAL
{
    public class AdminService
    {
        #region  常量、变量的定义
        private readonly string connString = ConfigurationManager.ConnectionStrings["MySchoolConnectionString"].ConnectionString;
        #endregion

        #region 执行管理员登录检查Sql语句
        /// <summary>
        /// 执行管理员登录检查Sql语句
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>true:检索到;false:没有检索到</returns>
        public bool  CheckAdminLogin(string loginId, string loginPwd)
        {
            

            //创建Sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine("     *");
            sb.AppendLine("FROM");
            sb.AppendLine("     [Admin]");
            sb.AppendLine("WHERE");
            sb.AppendLine("      [LoginId]=@LoginId");
            sb.AppendLine("AND");
            sb.AppendLine("      [LoginPwd]=@LoginPwd");

            SqlParameter[] para = new SqlParameter[] {new SqlParameter ("@LoginId",loginId),
                                                                             new SqlParameter ("@LoginPwd",loginPwd)};
            //创建Connection对象
            SqlConnection conn = new SqlConnection(connString);
            try
                {
                    // 创建Command命令
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    cmd.Parameters.AddRange(para);
                    conn.Open();
                    // 执行查询语句
                    SqlDataReader reader = cmd.ExecuteReader();
                    //如果检索到则返回true，否则返回false
                    if (reader.Read())
                    {
                        reader.Close();
                        return true ;
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
        #endregion
    }
}
