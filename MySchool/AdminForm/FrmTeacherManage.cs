using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySchool.BLL;


namespace MySchool
{
    public partial class FrmTeacherManage : Form
    {
        private TeacherManager teacherManager = new TeacherManager();
        public FrmTeacherManage()
        {
            InitializeComponent();
            this.dgvTeacher.AutoGenerateColumns = false;
            //this.dgvTeacher.Columns["ch"].DisplayIndex = this.dgvTeacher.Columns.Count - 1;
        }

        private void FrmTeacherManage_Load(object sender, EventArgs e)
        {
            this.LoadTeacher();
        }
        private void LoadTeacher()
        {
            this.dgvTeacher.DataSource = teacherManager.GetAllTeacher();
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddOrUpDateTeacher frm = new FrmAddOrUpDateTeacher();
            frm.queryDelegate = this.LoadTeacher;
            frm.ShowDialog();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTeacher.Rows)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["ch"];
                bool flag = Convert.ToBoolean(cell.Value);
                if (flag)
                {
                    int teacherId = Convert.ToInt32(row.Cells[4].Value);
                    new TeacherManager().DelTeacher(teacherId);
                }
            }
            this.LoadTeacher();
        }

       


    }
}
