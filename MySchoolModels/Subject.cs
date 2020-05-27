using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*************************************
 * 类名：Subject
 * 功能描述：提供科目实体类
 * ************************************/
namespace MySchool.Models
{
   public class Subject
    {
        private int _subjectNo = 0;
        private string _subjectName = string.Empty;
        private int _classHour = 0;
        private int _gradeId = 0;

        /// <summary>
        /// 科目编号
        /// </summary>
        public int SubjectNo
        {
            get { return _subjectNo; }
            set { _subjectNo = value; }
        }

       /// <summary>
       /// 科目名称
       /// </summary>
        public string SubjectName
        {
            get { return _subjectName; }
            set { _subjectName = value; }
        }

        /// <summary>
        /// 学时
        /// </summary>
        public int ClassHour
        {
            get { return _classHour; }
            set { _classHour = value; }
        }

       /// <summary>
       /// 年级编号
       /// </summary>
        public int GradeId
        {
            get { return _gradeId; }
            set { _gradeId = value; }
        }
    }
}
