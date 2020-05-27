using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*************************************
 * 类名：Result
 * 功能描述：提供学员成绩类
 * ************************************/
namespace MySchool.Models
{
    [Serializable]
   public  class Result
    {
        private int _studentNo = 0;
        private int _subjectNo = 0;
        private int _studentResult = 0;
        private DateTime _examDate; 

        /// <summary>
        /// 学号
        /// </summary>
        public int StudentNo
        {
            get { return _studentNo; }
            set { _studentNo = value; }
        }

        /// <summary>
        /// 科目编号
        /// </summary>
        public int SubjectNo
        {
            get { return _subjectNo; }
            set { _subjectNo = value; }
        }

        /// <summary>
        /// 成绩
        /// </summary>
        public int StudentResult
        {
            get { return _studentResult; }
            set { _studentResult = value; }
        }

        /// <summary>
        /// 考试时间
        /// </summary>
        public DateTime ExamDate
        {
            get { return _examDate; }
            set { _examDate = value; }
        }
    }
}
