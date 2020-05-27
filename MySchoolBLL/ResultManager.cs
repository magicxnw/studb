using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySchool.DAL;
using MySchool.Models;
using System.Data;
/*************************************
 * 类名：ResultManager
 * 功能描述：提供成绩业务逻辑操作
 * ************************************/
namespace MySchool.BLL
{
    public class ResultManager
    {
        #region 成员变量的定义
        private StudentService studentService = new StudentService();//实例化学员访问对象
        private ResultService resultService = new ResultService();//实例化成绩数据访问对象
        #endregion

        #region 添加学员成绩
        /// <summary>
        /// 添加学员成绩
        /// </summary>
        /// <param name="result">成绩实体</param>
        /// <returns>受影响的行数</returns>
        public int AddStudentResult(Result result)
        {
            try
            {
                //调用数据访问层的添加学员成绩
                return resultService.AddStudentResult(result);
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

        #region 查询学员成绩
        /// <summary>
        /// 查询学员成绩
        /// </summary>
        /// <param name="stuName">学生姓名</param>
        /// <param name="subjectNo">科目编号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewStudentResult(string stuName, string subjectNo)
        {
            try
            {
                List<Result> resultList = resultService.ReviewStudentResultEx(subjectNo, stuName);
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

        }
        #endregion

        #region 根据学号查询学员成绩信息
        /// <summary>
        /// 根据学号查询学员成绩信息
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewStudentResultByStuNo(int stuNo)
        {
            try
            {
                //根据学号查询学员成绩信息
                return resultService.ReviewStudentResultByStuNo(Convert.ToString(stuNo));
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

        #region 根据科目编号和学号查询学员成绩
        /// <summary>
        /// 根据科目编号和学号查询学员成绩
        /// </summary>
        /// <param name="subjectNo">科目编号</param>
        /// <param name="stuNo">学号</param>
        /// <returns>成绩集合</returns>
        public List<Result> ReviewStudentResultBySubjectNoAndStuNo(string subjectNo, string stuNo)
        {
            try
            {
                return resultService.ReviewStudentResultBySubjectNoAndStuNo(subjectNo, stuNo);
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

        #region 更新学员成绩
        /// <summary>
        /// 更新学员成绩
        /// </summary>
        /// <param name="result">成绩实体</param>
        /// <returns>受影响行数</returns>
        public int UpdateStudentResult(Result result)
        {
            try
            {
                int iRet = studentService.CheckGradeId(result.SubjectNo);
                if (iRet <= 0)
                {
                    return -2;
                }
                else
                {
                    //调用数据访问层的更新学员成绩表
                    return resultService.UpdateStudentResult(result);
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

        }
        #endregion
        Random rand = new Random();
        public string GetExamNo(string gradeId, string subjectId, DateTime examTime)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(examTime.Month.ToString().PadLeft(2, '0'));
            builder.Append(examTime.Day.ToString().PadLeft(2, '0'));
            builder.Append(gradeId.PadLeft(2, '0'));
            builder.Append(subjectId.PadLeft(2, '0'));
            builder.Append(rand.Next(1, 1000).ToString().PadLeft(3, '0'));
            return builder.ToString();
        }

        #region  删除学员成绩
        /// <summary>
        /// 删除学员成绩
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <param name="subjectNo">科目编号</param>
        /// <returns>受影响的行数</returns>
        public int DeleteStudentResult(int stuNo, int subjectNo)
        {
            try
            {
                //调用数据访问层的添加学员成绩
                return resultService.DeleteStudentResult(stuNo, subjectNo);
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

        /// <summary>
        /// 将Excel中的数据添加到数据库中
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns>是否成功添加</returns>
        public static bool InsertByExcelData(DataTable dt)
        {
            return ResultService.InsertByExcelData(dt);
        }
    }
}
