using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySchool.DAL;
using MySchool.Models;
using System.Data;
using MySchool.Common;
/*************************************
 * 类名：StudentManager
 * 功能描述：提供学员业务逻辑操作
 * ************************************/
namespace MySchool.BLL
{
    public class StudentManager
    {
        #region 成员变量的定义
        private StudentService studentService = new StudentService();//实例化学员数据访问对象
        #endregion

        #region 学员登录检查
        /// <summary>
        /// 学员登录检查
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <param name="loginPwd">密码</param>
        /// <returns>true:检索到;false:没有检索到</returns>
        public bool CheckStudentLogin(string studentNo, string loginPwd)
        {
            try
            {
                //调用数据访问层的执行学员登录检查Sql语句
                return studentService.CheckStudentLogin(Convert.ToInt16(studentNo), loginPwd);
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

        #region 检查输入的学号是否存在
        /// <summary>
        /// 检查输入的身份证是否存在
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <returns>true：该学号不存在；false：该学号已存在</returns>
        public static bool CheckStuNoIsExist(string studentNo)
        {

            //如果空输入则不做重复验证
            if (studentNo.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                int iStuNo = Convert.ToInt32(studentNo);
                return StudentService.CheckStuNoIsExist(iStuNo);

            }
        }




        /// <summary>
        /// 检查输入的学号，返回Student对象
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <returns>学员实体</returns>
        public Student GetStudentInfo(string studentNo)
        {
            try
            {
                return studentService.GetStudentByNo(Convert.ToInt16(studentNo));
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

        #region 添加学员
        /// <summary>
        /// 添加学员
        /// </summary>
        /// <param name="student">学生实体</param>       
        /// <returns>受影响行数</returns>
        public int AddStudent(Student student)
        {
            try
            {
                int ret = studentService.CheckIdentityCard(student.IdentityCard);
                if (ret > 0)
                {
                    return -2;//身份证号已存在
                }
                //Md5加密
                Md5 md5 = new Md5();
                student.LoginPwd = md5.GetMD5String(student.LoginPwd);
                //执行Sql语句,将学员信息添加到Student表
             
                return studentService.AddStudent(student);
            }
            catch (CustomerException ex)
            {
                throw ex;
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

        #region 取得学员全部信息
        /// <summary>
        /// 取得学员全部信息
        /// </summary>
        /// <returns>学员集合</returns>
        public List<Student> GetStudentData()
        {


            try
            {
                return studentService.GetStudentData();
            }
            catch (SqlException ex)
            {
                throw ;
            }
            catch (Exception )
            {
                throw ;
            }
        }
        #endregion

        #region 根据输入条件检索学员信息表
        /// <summary>
        /// 根据输入条件检索学员信息表
        /// </summary>
        /// <param name="name">查询条件</param>
        /// <returns>学员集合</returns>
        public List<Student> GetStudentDataByNameAndGrade(string name, string gradeId)
        {
            try
            {
                int iGradeId = Convert.ToInt16(gradeId);
                return studentService.GetStudentDataByNameAndGrade(name, iGradeId);
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

        /// <summary>
        /// 根据输入姓名检索学员信息表
        /// </summary>
        /// <param name="name">需要查询的姓名</param>
        /// <returns>学员集合</returns>
        public List<Student> GetStudentDataByName(string name)
        {
            try
            {
                return studentService.GetStudentDataByName(name);
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

        #region 更新学员信息表
        /// <summary>
        /// 更新学员信息表
        /// </summary>
        /// <param name="student">学生实体</param>
        /// <returns>1：成功；-1：失败</returns>
        public int UpdateStudentInfo(Student student)
        {
            return studentService.UpdateStudentInfo(student);

        }
        #endregion

        #region 删除学员信息
        /// <summary>
        /// 删除学员信息
        /// </summary>
        /// <param name="studentNo">学号</param>
        /// <returns>受影响的行数</returns>
        public int DeleteStudentInfo(string studentNo)
        {
            try
            {
                //调用数据访问层的删除学员信息
                return studentService.DeleteStudentInfo(Convert.ToInt16(studentNo));
            }
            catch (CustomerException ex)
            {
                throw ex;
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

        #region 根据录入的Exel数据添加学员
        /// <summary>
        /// 根据录入的Exel数据添加学员
        /// </summary>
        /// <param name="student">学生实体</param>       
        /// <returns>受影响行数</returns>
        public bool AddStudentByExcelData(DataTable dt)
        {
            try
            {
                return studentService.InsertByExcelData(dt);
            }
            catch (CustomerException ex)
            {
                throw ex;
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
