using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySchool.BLL;
using MySchool.Models;

namespace MySchool
{
    public  delegate void QueryDelegate();
    public partial class FrmAddOrUpDateTeacher : Form
    {
        public QueryDelegate queryDelegate;
        private GradeManager grade = new GradeManager();
        public FrmAddOrUpDateTeacher()
        {
            InitializeComponent();
            this.cboGrade.DataSource = grade.GetGradeData();
            this.cboGrade.DisplayMember = "GradeName";
            this.cboGrade.ValueMember = "GradeId";
        }
        //public string UpDateId
        //{
        //    set;
        //    get;
        //}

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (txtAge.Text.Trim() == "")
            {
                MessageBox.Show("年龄不能为空");
                return;
            }
            if (txtTeachYear.Text.Trim() == "")
            {
                MessageBox.Show("任教时间不能为空");
                return;
            }

            Teacher teacher=new Teacher();
            teacher.Name=txtName .Text ;
            teacher.Age =Convert .ToInt32(txtAge .Text);
            teacher.GradeId=Convert .ToInt32(cboGrade.SelectedValue);
            teacher.TeachYear = Convert.ToInt32(txtTeachYear.Text);
            TeacherManager manager = new TeacherManager();
            manager.AddTeacher(teacher);
            queryDelegate();
            MessageBox.Show("添加教师成功！");
        }
       
    }
}
