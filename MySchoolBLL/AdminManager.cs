using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySchool.DAL;
using MySchool.Models;
/*************************************
 * 类名：AdminManager
 * 功能描述：提供系统管理员业务逻辑操作
 * ************************************/
namespace MySchool.BLL
{
    public class AdminManager
    {
        #region 成员变量的定义

        private AdminService adminService = new AdminService();//实例化系统管理员数据访问对象
       
        #endregion

        #region 管理员登录检查
        /// <summary>
        /// 管理员登录检查
        /// </summary>
        /// <param name="loginId">用户名</param>
        /// <param name="loginPwd">密码</param>
        /// <returns>true:检索到;false:没有检索到</returns>
        public bool  CheckAdminLogin(string loginId, string loginPwd)
        {
            try
            {
                //调用数据访问层的执行管理员登录检查Sql语句
                return adminService.CheckAdminLogin(loginId, loginPwd);
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
        #endregion

    }
}
