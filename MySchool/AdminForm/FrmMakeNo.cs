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
    public partial class FrmMakeNo : Form
    {
        public FrmMakeNo()
        {
            InitializeComponent();
        }

        private void FrmMakeNo_Load(object sender, EventArgs e)
        {
            this.dgvStudent.AutoGenerateColumns = false;
            StudentManager stu = new StudentManager();
            this.dgvStudent.DataSource = stu.GetStudentData();
            SubjectManager subject = new SubjectManager();
            this.comboBox1.ValueMember = "SubjectNo";
            this.comboBox1.DisplayMember = "SubjectName";
            this.comboBox1.DataSource = subject.GetSubjectData();
        }
        FrmInfo frm = new FrmInfo();
        private void btnMakeExamNo_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow dr in dgvStudent.Rows)
            //{
            //    dr.Cells["examNo"].Value = re.GetExamNo(dr.Cells["gradeNo"].Value.ToString(), 
            //        this.comboBox1.SelectedValue.ToString(), 
            //        DateTime.Now
            //        );
            //}

            this.timer.Enabled = true;
            
            this.timer.Start();
              frm.ShowDialog();
        }
        private int count  = 0;
        ResultManager re = new ResultManager();
        private void timer_Tick(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvStudent.Rows[count];
            dr.Cells["examNo"].Value = re.GetExamNo(dr.Cells["gradeNo"].Value.ToString(),
                    this.comboBox1.SelectedValue.ToString(),
                    dtpExamDate.Value
                    );
            count++;
            frm.ShowInfo = "正在生成第"+count+"/"+dgvStudent.Rows.Count+"条数据";
            if (count >= dgvStudent.Rows.Count)
            {
                this.timer.Stop();
                this.timer.Enabled = false;
                count = 0;
                frm.btnShow = true;
               frm.ShowInfo =  "已经生成所有的准考证号!" ;
            }
        }

    }
}
