using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySchool.Models;
using MySchool.DAL;

namespace MySchool.BLL
{
    public class TeacherManager
    {
        private TeacherService teacherService = new TeacherService();
        public List<TeacherBusiness> GetAllTeacher()
        {
            return teacherService.GetAll();
        }

        public bool AddTeacher(Teacher teacher)
        {
            return teacherService.AddTeacher(teacher);
        }

        public bool DelTeacher(int teacherId)
        {
            return teacherService.DelTeacher(teacherId);
        }

        public List<TeacherBusiness> GetAll()
        {
            return teacherService.GetAll();
        }
    }
}
