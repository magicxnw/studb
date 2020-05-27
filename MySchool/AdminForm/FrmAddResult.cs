using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySchool.Models;
using MySchool.DAL;
/*************************************
 * 类名：FrmAddResult
 * 功能描述：提供添加学生成绩界面

 * ************************************/
namespace MySchool.AdminForm
{
    public partial class FrmAddResult : Form
    {
        #region 常量定义
        public const string INPUTWARN = "输入提示";
        private const string OPERATIOFAILED = "操作错误";
        private const string SELECTSUBJECT = "请选择科目";
        private const string INPUTRESULT = "请输入成绩";
        private const string EXAMDATE = "请输入考试时间";
        private const string INPUTDATEWRONG1 = "输入的时间格式有误";
        private const string INPUTDATEWRONG2 = "请输入数字！";
        private const string INPUTDATEWRONG3 = "请输的成绩不在0~100之间！";
        private const string ADDFAILED = "添加失败！";
        private const string ADDSUCCESS = "添加成功！";
        #endregion
        private ResultService resultService = new ResultService();
        private GradeService gradeService = new GradeService();

        #region 属性

        public int StudentNo { get; set; }

        #endregion

        private SubjectService subjectService = new SubjectService();

        public FrmAddResult()
        {
            InitializeComponent();
        }

        #region 事件处理
        /// <summary>
        /// 窗体初期化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddResult_Load(object sender, EventArgs e)
        {
            //年级信息的绑定

            GradeDataBind();

            //实现科目信息的绑定

            SubjectDataBind();
        }

        /// <summary>
        /// 当选择年级时

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboGrade_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                //根据年级取得科目信息并绑定

                this.cboSubject.DataSource = subjectService.GetSubjectDataByGradeId(Int32.Parse(this.cboGrade.SelectedValue.ToString()));
                this.cboSubject.ValueMember = "SubjectNo";
                this.cboSubject.DisplayMember = "SubjectName";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// 点击“添加”按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddResult_Click(object sender, EventArgs e)
        {
            try
            {
                //非空检查

                if (!CheckInputNotEmpty())
                {
                    return;
                }



                //判断输入的成绩格式是否正确

                if (!CheckExamResult(this.txtResult.Text.Trim()))
                {
                    return;
                }

                //构建实体类添加学生成绩
                Result result = new Result();
                result.StudentNo = this.StudentNo;
                result.SubjectNo = Convert.ToInt32(this.cboSubject.SelectedValue.ToString());
                result.StudentResult = Convert.ToInt32(this.txtResult.Text);
                result.ExamDate = dtpExamTime.Value;
                int iResult = resultService.AddStudentResult(result);

                //添加成功
                MessageBox.Show(ADDSUCCESS, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// 点击“返回”按钮时
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
            try
            {
                //取得所有年级信息

                List<Grade> gradeList = gradeService.GetGradeData();
                //将年级信息绑定到combobox上

                this.cboGrade.DataSource = gradeList;
                this.cboGrade.ValueMember = "GradeId";
                this.cboGrade.DisplayMember = "GradeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// 实现科目信息的绑定

        /// </summary>
        public void SubjectDataBind()
        {
            try
            {
                //取得所有年级信息

                List<Subject> subjectList = subjectService.GetSubjectData();
                //将科目信息绑定到combobox上

                this.cboSubject.DataSource = subjectList;
                this.cboSubject.ValueMember = "SubjectNo";
                this.cboSubject.DisplayMember = "SubjectName";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
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
            if (this.cboSubject.Text.Equals(string.Empty))
            {
                MessageBox.Show(SELECTSUBJECT, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSubject.Focus();
                return false;
            }
            //成绩输入不得为空
            else if (this.txtResult.Text.Equals(string.Empty))
            {
                MessageBox.Show(INPUTRESULT, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtResult.Focus();
                return false;
            }

            else
            {
                return true;
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
