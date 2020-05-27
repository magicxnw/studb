using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySchool.BLL;
using MySchool.Models;

/*************************************
 * 类名：FrmSelectStudentInfo
 * 功能描述：提供学生查询信息用户界面
 * ************************************/
namespace MySchool.StudentForm
{
    public partial class FrmReviewResult : Form
    {
        #region 常量定义
        public const string OPERATIOFAILED = "操作错误";
        public const string NOEXPORT = "无数据导出！";
        #endregion

        #region 成员变量的定义
        Student _student = new Student();//实例化并保存Student对象
        private StudentManager studentManager = new StudentManager();//实例化学生业务逻辑层对象
        private GradeManager gradeManager = new GradeManager();//实例化年级业务逻辑层对象
        private SubjectManager subjectManager = new SubjectManager();//实例化科目业务逻辑层对象 
        private ResultManager resultManager = new ResultManager();//实例化学生成绩业务逻辑层对象
        #endregion

        #region 构造函数
        public FrmReviewResult()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        /// <summary>
        /// 窗体初期化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReviewResult_Load(object sender, EventArgs e)
        {
            try
            {
                //获取学生信息
                _student = studentManager.GetStudentInfo(UserInfo.loginId);
               
                //年级信息的绑定
                GradeDataBind();
              
                //科目信息的绑定
                SubjectDataBind();
                               //成绩信息的绑定
                ResultDataBind();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// ComboBox选择时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSubject_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                //执行查询时的数据绑定
                ReviewDataBind();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        /// <summary>
        /// "返回"按钮按下时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 数据绑定
        /// <summary>
        ///  年级信息的绑定
        /// </summary>
        public void GradeDataBind()
        {
            //取得该学生的年级信息并赋值
            this.lblGradeName .Text  = gradeManager.GetGradeDataById(_student.GradeId).GradeName ;
        }

        /// <summary>
        /// 科目信息的绑定
        /// </summary>
        public void SubjectDataBind()
        {
            //根据年级编号取得科目信息并绑定到ComboBox上
            this.cboSubject .DataSource =subjectManager.GetSubjectDataByGradeId(Convert.ToString (_student.GradeId));
            this.cboSubject.ValueMember = "SubjectNo";
            this.cboSubject.DisplayMember  = "SubjectName";
        }

        /// <summary>
        /// 成绩信息的绑定        /// </summary>
        public void ResultDataBind()
        {
            //取得该学生所有科目成绩信息并绑定
            this.dgvResult.DataSource = resultManager.ReviewStudentResultByStuNo(_student.StudentNo);
            //实体类实现成绩表分别和科目表、学生表的关联显示            SetStuNameAndGradeName();
        }
        #endregion

        #region 执行查询时的数据绑定
        /// <summary>
        /// 执行查询时的数据绑定
        /// </summary>
        public void ReviewDataBind()
        {
            this.dgvResult.DataSource = resultManager.ReviewStudentResultBySubjectNoAndStuNo(this.cboSubject.SelectedValue.ToString(), Convert.ToString(_student.StudentNo));
            
            //实体类实现成绩表分别和科目表、学生表的关联显示
            SetStuNameAndGradeName();
        }
        #endregion

        #region 实体类实现成绩表分别和科目表、学生表的关联显示
        /// <summary>
        /// 实体类实现成绩表分别和科目表、学生表的关联显示
        /// </summary>
        public void SetStuNameAndGradeName()
        {
            //===========方法1：将DataGridView的列设置成ComboBox并绑定==================//
            DataGridViewComboBoxColumn cbo = (DataGridViewComboBoxColumn)this.dgvResult.Columns["StudentNo"];
            cbo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            cbo.DataSource = studentManager.GetStudentData();
            cbo.DisplayMember = "StudentName";
            cbo.ValueMember = "StudentNo";
            //========================end========================================//

            //===========方法2：遍历列中的cell并赋值=================================//        
            foreach (DataGridViewRow row in this.dgvResult.Rows)
            {
                int id = (int)(row.Cells["SubjectNo"].Value);
                row.Cells["SubjectName"].Value = subjectManager.GetSubjectDataBySubjectId(id).SubjectName;
            }
            //=========================end=======================================//

            //设置科目编号列不可见
            DataGridViewColumn colum = (DataGridViewColumn)this.dgvResult.Columns["SubjectNo"];
            colum.Visible = false;
        }
        #endregion

    }
}
