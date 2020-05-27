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
 * 类名：FrmReviewResult
 * 功能描述：提供查询学生成绩界面

 * ************************************/
namespace MySchool.AdminForm
{
    public partial class FrmReviewResult : Form
    {
        #region 常量定义
        public const string OPERATIOFAILED = "操作错误";
        public const string OPERATIOSUCCESS = "操作成功";
        public const string NOEXPORT = "无数据导出！";
        public const string INPUTWARN = "输入提示";
        public const string SELECTSUBJECT = "请选择科目";
        public const string INPUTRESULT = "请输入成绩";
        public const string EXAMDATE = "请输入考试时间";
        public const string INPUTDATEWRONG1 = "输入的时间格式有误";
        public const string INPUTDATEWRONG2 = "请输入数字！";
        public const string INPUTDATEWRONG3 = "请输的成绩不在0~100之间！";
        public const string UPDATESUCCESS = "更新成功！";
        public const string GRADEIDNOSAME = "年级编号不一致!";
        public const string UPDATEFAILED = "更新失败！";
        public const string DELETESUCCESS = "删除成功！";
        public const string DELETEFAILED = "删除失败！";
        #endregion

        #region 成员变量的定义
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
                //年级信息的绑定

                GradeDataBind();
                //科目信息的绑定

                SubjectDataBind();

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
        /// 当选择年级时 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cboGrade.SelectedIndex == 0)
                {
                    return;
                }
                //根据年级取得科目信息并绑定
                this.cboSubject.DataSource = subjectManager.GetSubjectDataByGradeId(this.cboGrade.SelectedValue.ToString().Trim());
                this.cboSubject.ValueMember = "SubjectNo";
                this.cboSubject.DisplayMember = "SubjectName";
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
        /// 查询按钮按下时 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
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
        /// 导出按钮按下时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvResult.Rows.Count <= 0)
                {
                    MessageBox.Show(NOEXPORT, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (IOException ex)
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
        /// DataGridView的单元格被单击时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int iRow = e.RowIndex;//当前行

                if (iRow < 0)
                {
                    return;
                }
                DataGridViewComboBoxCell dgvCbo = (DataGridViewComboBoxCell)this.dgvResult.Rows[iRow].Cells["StudentNo"];
                this.lblStuNo.Text = dgvCbo.Value.ToString();//存放学生学号
                //需要讲解“FormattedValue”：用户看到的显示描述
                this.lblStuName.Text = dgvCbo.FormattedValue.ToString();//设置学生姓名
                this.cboSubjectU.Text = this.dgvResult.Rows[iRow].Cells["SubjectName"].Value.ToString();//设置科目信息
                this.txtResult.Text = this.dgvResult.Rows[iRow].Cells["StudentResult"].Value.ToString();//设置成绩
                this.txtExamDateU.Text = this.dgvResult.Rows[iRow].Cells["ExamDate"].Value.ToString();//设置考试时间

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// 点击“修改”按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //非空检查
                if (!CheckInputNotEmpty())
                {
                    return;
                }
                //检查并格式化考试时间
                string strExamDate = CheckExamDate(this.txtExamDateU.Text.Trim());

                //判断输入的成绩格式是否正确
                if (!CheckExamResult(this.txtResult.Text.Trim()))
                {
                    return;
                }

                //实例化并构建成绩实体类,调用业务逻辑层的更新学生成绩方法
                Result result = new Result();
                result.StudentNo = Convert.ToInt32(this.lblStuNo.Text.Trim());
                result.SubjectNo = Convert.ToInt32(this.cboSubjectU.SelectedValue.ToString());
                result.StudentResult = Convert.ToInt32(this.txtResult.Text.Trim());
                result.ExamDate = Convert.ToDateTime(this.txtExamDateU.Text.Trim());
                int iRet = resultManager.UpdateStudentResult(result);

                if (iRet == -2)
                {
                    MessageBox.Show(GRADEIDNOSAME, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (iRet < 1)
                {
                    MessageBox.Show(UPDATEFAILED, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show(UPDATESUCCESS, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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
        /// 删除学生成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmsiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int iRow = this.dgvResult.CurrentRow.Index;//焦点行索引

                if (iRow < 0)
                {
                    return;
                }
                int iStuNo = 0;//初始化学生学号

                int iSubNo = 0;//初始化科目编号

                DataGridViewComboBoxCell dgvCbo = (DataGridViewComboBoxCell)this.dgvResult.Rows[iRow].Cells["StudentNo"];
                iStuNo = Convert.ToInt32(dgvCbo.Value);//取得学生学号
                iSubNo = Convert.ToInt32(this.dgvResult.Rows[iRow].Cells["SubjectNo"].Value);
                //调用业务逻辑层删除学生成绩方法

                int iRet = resultManager.DeleteStudentResult(iStuNo, iSubNo);
                if (iRet <= 0)
                {
                    MessageBox.Show(DELETESUCCESS, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(DELETEFAILED, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
        /// “返回”按钮按下时 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 信息的绑定

        /// <summary>
        /// 实现年级信息的绑定

        /// </summary>
        public void GradeDataBind()
        {
            //将年级信息绑定到combobox上
            List<Grade> gradeList = gradeManager.GetGradeData();
            gradeList.Insert(0, new Grade() { GradeId = -1, GradeName = "--全部--" });
            this.cboGrade.DataSource = gradeList;
            this.cboGrade.ValueMember = "GradeId";
            this.cboGrade.DisplayMember = "GradeName";
        }

        /// <summary>
        /// 实现科目信息的绑定
        /// </summary>
        public void SubjectDataBind()
        {
            //取得所有年级信息
            List<Subject> subjectList = subjectManager.GetSubjectData();
            //将科目信息绑定到combobox上
            subjectList.Insert(0, new Subject() { SubjectNo = -1, SubjectName = "--全部--" });
            this.cboSubject.DataSource = subjectList;
            this.cboSubject.ValueMember = "SubjectNo";
            this.cboSubject.DisplayMember = "SubjectName";

            this.cboSubjectU.DataSource = subjectList;
            this.cboSubjectU.ValueMember = "SubjectNo";
            this.cboSubjectU.DisplayMember = "SubjectName";
        }

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


        #region 输入数据的检查

        /// <summary>
        /// 非空检查

        /// </summary>
        /// <returns>true：成功；false：失败</returns>
        public bool CheckInputNotEmpty()
        {
            //科目选择不得为空
            if (this.cboSubjectU.Text.Equals(string.Empty))
            {
                MessageBox.Show(SELECTSUBJECT, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSubjectU.Focus();
                return false;
            }
            //成绩输入不得为空
            else if (this.txtResult.Text.Equals(string.Empty))
            {
                MessageBox.Show(INPUTRESULT, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtResult.Focus();
                return false;
            }
            //考试时间不得为空
            else if (this.txtExamDateU.Text.Equals(string.Empty))
            {
                MessageBox.Show(EXAMDATE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtExamDateU.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 检查并格式化考试时间
        /// </summary>
        /// <param name="examTime">需格式化的时间</param>
        /// <returns>格式后的时间</returns>
        public string CheckExamDate(string examDate)
        {
            try
            {
                if (examDate.Equals(string.Empty))
                {
                    return string.Empty;
                }
                DateTime dt = Convert.ToDateTime(examDate);
                return examDate;
            }
            catch (Exception)
            {
                MessageBox.Show(INPUTDATEWRONG1, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtExamDateU.Focus();
                return string.Empty;
            }
        }

        /// <summary>
        /// 输入成绩的检查

        /// </summary>
        /// <param name="examResult">输入成绩</param>
        /// <returns>成功</returns>
        public bool CheckExamResult(string examResult)
        {
            try
            {
                int iResult = int.Parse(examResult);
                if (iResult < 0 || iResult > 100)
                {
                    MessageBox.Show(INPUTDATEWRONG3, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(INPUTDATEWRONG2, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        #endregion

        #region 执行查询时的数据绑定
        /// <summary>
        /// 执行查询时的数据绑定
        /// </summary>
        public void ReviewDataBind()
        {
            string strStuName = this.txtName.Text.Trim().ToString();//用户输入的姓名
            string strSubjectNo = this.cboSubject.SelectedValue.ToString().Trim();//用户选择的科目编号
            //查询学生成绩
            this.dgvResult.DataSource = resultManager.ReviewStudentResult(strStuName, strSubjectNo);
            //实体类实现成绩表分别和科目表、学生表的关联显示

            SetStuNameAndGradeName();
        }
        #endregion

    }
}
