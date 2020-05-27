using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySchool.DAL;
using MySchool.Models;
/*************************************
 * 类名：GradeManager
 * 功能描述：提供年级业务逻辑操作
 * ************************************/
namespace MySchool.BLL
{
   public  class GradeManager
    {
        #region 成员变量的定义

        private GradeService gradeService = new GradeService();//实例化系统管理员数据访问对象

        #endregion

        #region 取得年级全部信息
        /// <summary>
        /// 取得年级全部信息
       /// </summary>
       /// <returns></returns>
        public List<Grade> GetGradeData()
        {
            try
            {
                return gradeService.GetGradeData();
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


        #region 根据年级Id取得年级信息
        /// <summary>
        /// 根据年级Id取得年级信息
        /// </summary>
        /// <param name="gradeId">年级Id</param>
        /// <returns>年级</returns>
        public Grade GetGradeDataById(int gradeId)
        {
            try
            {
                return gradeService.GetGradeDataById(gradeId);
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
       #endregion

     

    }
}
