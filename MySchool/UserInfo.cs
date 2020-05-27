using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*************************************
 * 类名：UserInfo
 * 功能描述：该类用以存放登录的用户名和类型，

 *                      便于窗体间的数据传递

 * ************************************/
namespace MySchool
{
   public  class UserInfo
    {
        public static string loginId = "";  // 用户名或学号
        public static string loginPwd = "";//登录密码
        public static string loginType = "";  // 登录类型
    }
}
