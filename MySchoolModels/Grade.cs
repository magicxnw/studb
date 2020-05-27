using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*************************************
 * 类名：Grade
 * 功能描述：提供年级实体类
 * ************************************/
namespace MySchool.Models
{
    [Serializable ]
   public  class Grade
    {
        private int _gradeId = 0;
        private string _gradeName = string.Empty;

       /// <summary>
       /// 年级编号
       /// </summary>
        public int GradeId
        {
            get { return _gradeId; }
            set { _gradeId = value; }
        }
        public string GradeName
        {
            get { return _gradeName; }
            set { _gradeName = value; }
        }
    }
}
