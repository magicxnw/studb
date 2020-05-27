using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchool.Models
{
    [Serializable]
    public class ResultBusiness : Result
    {
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
    }

}
