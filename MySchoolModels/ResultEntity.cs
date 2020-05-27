using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchool.Models
{
    class ResultEntity
    {
        private string _studentName = string.Empty;
        private string _subjectName = string.Empty;
        private int _studentNo = 0;
        private int _subjectNo = 0;
        private int _studentResult = 0;
        private DateTime _examDate;

        /// <summary>
        /// 姓名
        /// </summary>
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
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
