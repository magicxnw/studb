using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*************************************
 * 类名：Admin
 * 功能描述：提供管理员实体类
 * ************************************/
namespace MySchool.Models
{
    [Serializable]
    public class Admin
    {
        private string _loginId=string.Empty ;
        private string _loginPwd=string.Empty ;

        /// <summary>
        /// 用户ID
        /// </summary>
        public string LoginId
        {
            get { return _loginId; }
            set { _loginId = value; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string LoginPwd
        {
            get { return _loginPwd; }
            set { _loginPwd = value; }
        }
    }
}
