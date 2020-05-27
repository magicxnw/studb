using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySchool.DAL;
using MySchool.Models;
/*************************************
 * 类名：SubjectManager
 * 功能描述：提供科目业务逻辑操作
 * ************************************/
namespace MySchool.BLL
{
    public class SubjectManager
    {
        #region 成员变量的定义
        private SubjectService subjectService = new SubjectService();//实例化科目数据访问对象
        #endregion

        #region 取得全部科目信息
        /// <summary>
        /// 取得全部科目信息
        /// </summary>
        /// <returns>科目集合</returns>
        public List<Subject> GetSubjectData()
        {
            try
            {
                //取得全部科目信息
                return subjectService.GetSubjectData();
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

        #region 根据年级编号取得科目信息
        /// <summary>
        /// 根据年级编号取得科目信息
        /// </summary>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        public List<Subject> GetSubjectDataByGradeId(string gradeId)
        {
            try
            {
                 return subjectService.GetSubjectDataByGradeId(Convert.ToInt32(gradeId));
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

        #region 根据科目编号取得科目信息
        /// <summary>
        /// 根据科目编号取得科目信息
        /// </summary>
        /// <param name="subjectNo">科目编号</param>
        /// <returns></returns>
        public  Subject  GetSubjectDataBySubjectId(int subjectNo)
        {
            try
            {
                return subjectService.GetSubjectDataBySubjectNo(subjectNo);
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
