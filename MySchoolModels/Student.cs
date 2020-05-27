using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*************************************
 * 类名：Student
 * 功能描述：提供学员实体类
 * ************************************/
namespace MySchool.Models
{
    [Serializable]
    public class Student
    {
        private int _studentNo=0;
        private string _loginPwd=string.Empty ;
        private string _studentName = string.Empty;
        private string _gender = string.Empty;
        private int _gradeId=0;
        private string _phone = string.Empty;
        private string _address = string.Empty;
        private DateTime _bornDate;
        private string _email = string.Empty;
        private string _identityCard = string.Empty;

        /// <summary>
        /// 学号
        /// </summary>
        public int StudentNo
        {
            get { return _studentNo; }
            set { _studentNo = value; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string LoginPwd
        {
            get { return _loginPwd; }
            set { _loginPwd = value; }
        }
        /// <summary>
        /// 姓名
        /// </summary>
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        /// <summary>
        /// 年级编号
        /// </summary>
        public int GradeId
        {
            get { return _gradeId; }
            set { _gradeId = value; }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        /// <summary>
        /// 出生年月日
        /// </summary>
        public DateTime BornDate
        {
            get { return _bornDate; }
            set { _bornDate = value; }
        }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// 身份证
        /// </summary>
        public string IdentityCard
        {
            get { return _identityCard; }
            set { _identityCard = value; }
        }
    }
}
