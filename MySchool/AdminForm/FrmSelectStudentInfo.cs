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
using MySchool.DAL;
using MySchool.Models;

/*************************************
 * 类名：FrmSelectStudentInfo
 * 功能描述：提供查询学生信息用户界面

 * ************************************/
namespace MySchool.AdminForm
{
    public partial class FrmSelectStudentInfo : Form
    {

        #region 常量定义
        public const string OPERATIOFAILED = "操作错误";
        public const string INPUTWARN = "输入提示";
        public const string INPUTPWD = "请输入密码";
        public const string INPUTNAME = "请输入姓名";
        public const string INPUTSTUNO = "请输入学号";
        public const string INPUTSEX = "请选择性别";
        public const string INPUTGRADENO = "请选择年级";
        public const string INPUTIDENTITYCARD = "请输入身份证号";
        public const string INPUTDATEWRONG = "输入的出生年月日格式有误";
        public const string INPUTEMAILWRONG = "输入的Email格式有误";
        public const string OPERATIONWARN = "操作提示";
        public const string UPDATEFAILED = "更新失败";
        public const string UPDATESUCCESS = "更新成功";
        public const string INSERTSUCCESS = "插入成功";
        public const string INSERTFAILED = "插入失败";
        public const string DELETESUCCESS = "删除成功";
        public const string DELETEFAILED = "删除失败";
        public const string STUDENTNOISEXIST = "学号已存在";
        public const string ISDELETE = "确定要删除该用户吗？";
        public const string NOEXPORT = "无数据导出！";
        #endregion

        #region 成员变量的定义

        List<Grade> gradeList = new List<Grade>();
        private StudentManager studentManager = new StudentManager();//实例化学生业务逻辑层对象

        private GradeManager gradeManager = new GradeManager();//实例化年级业务逻辑层对象

        #endregion

        #region 构造函数

        public FrmSelectStudentInfo()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件处理
        /// <summary>
        /// 窗体初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSelectStudentInfo_Load(object sender, EventArgs e)
        {
            try
            {
                 
                //年级信息的绑定
                GradeDataBind();

                //学生全部信息的绑定
                StudentDataBind();

                //实体类实现学生表和年级表的关联显示
                SetGradeName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// 点击"查询"按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                //根据检索条件取得学生信息并绑定
                StudentDataBindByName();

                //实体类实现学生表和年级表的关联显示
                SetGradeName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// 点击"返回"按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 点击"导出"按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// 点击单元格时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStuInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //将选定行的数据更新到修改GroupBox中

                SetModifyData(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        /// <summary>
        /// 点击“修改”按钮后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //非空验证
                if (!CheckInputNotEmpty())
                {
                    return;
                }

                //格式验证
                if (!CheckFormat())
                {
                    return;
                }

                //获取性别输入
                string strSex = "";
                if (this.rbStuGirl.Checked)
                {
                    strSex = "女";
                }
                else if (this.rbStuBoy.Checked)
                {
                    strSex = "男";
                }
                else
                {
                    return;
                }

                //更新学生信息表
                Student student = new Student();
                student.StudentNo = Convert.ToInt32(this.lblStuNo.Text.Trim());
                student.LoginPwd = this.txtStuPwd.Text.Trim();
                student.StudentName = this.txtStuName.Text.Trim();
                student.Gender = strSex;
                student.GradeId = Convert.ToInt32(this.cboStuGrade.SelectedValue);
                student.Phone = this.txtStuPhone.Text.Trim();
                student.Address = this.txtStuAddress.Text.Trim();
                student.BornDate = this.dtpBornDate.Value;
                student.Email = this.txtStuEmail.Text.Trim();
                student.IdentityCard = this.txtIdentityCard.Text.Trim();

                int iRet = studentManager.UpdateStudentInfo(student);

                //更新失败
                if (iRet < 0)
                {
                    MessageBox.Show(UPDATEFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //更新成功
                else
                {
                    MessageBox.Show(UPDATESUCCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //刷新学生信息
                StudentDataBind();

                SetGradeName();

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
        /// 右键点击“删除”按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // 为防止误删除，要先询问
                DialogResult choice = MessageBox.Show(ISDELETE, OPERATIONWARN, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                // 如果确定删除，则执行删除操作
                if (choice == DialogResult.Yes)
                {
                    //取得当前单元格值
                    string iCellValue = this.dgvStuInfor.CurrentRow.Cells[0].Value.ToString().Trim();
                    //学生信息表的删除
                    int iRet = studentManager.DeleteStudentInfo(iCellValue);
                    if (iRet <= 0)
                    {
                        MessageBox.Show(DELETEFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(DELETESUCCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //学生全部信息的重新绑定
                        StudentDataBind();

                        return;
                    }
                }
                //取消操作
                else
                {
                    return;
                }
            }
            catch (CustomerException ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
        #endregion

        #region 数据的绑定
        /// <summary>
        /// 实现年级信息的绑定
        /// </summary>
        public void GradeDataBind()
        {
            //取得所有年级信息
            gradeList = gradeManager.GetGradeData();
            //实现年级信息的分别绑定
            this.cboGrade.DataSource = gradeList;
            this.cboGrade.ValueMember = "GradeId";
            this.cboGrade.DisplayMember = "GradeName";

            this.cboStuGrade.DataSource = gradeList;
            this.cboStuGrade.ValueMember = "GradeId";
            this.cboStuGrade.DisplayMember = "GradeName";

             
        }

        /// <summary>
        /// 学生全部信息的绑定
        /// </summary>
        public void StudentDataBind()
        {
            //取得所有学生信息
            List<Student> studentList = studentManager.GetStudentData();
            //将取得的学生信息绑定到DataGridView上
            this.dgvStuInfor.DataSource = studentList;
        }

        /// <summary>
        /// 根据检索条件取得学生信息并绑定
        /// </summary>
        public void StudentDataBindByName()
        {
            //根据输入条件取得学生信息
            List<Student> studentList = studentManager.GetStudentDataByNameAndGrade(this.txtName.Text.Trim(), this.cboGrade.SelectedValue.ToString());
            this.dgvStuInfor.DataSource = studentList;
        }

        /// <summary>
        /// 实体类实现学生表和年级表的关联显示
        /// </summary>
        public void SetGradeName()
        {
            //===========方法1：将DataGridView的列设置成ComboBox并绑定==================//
            DataGridViewComboBoxColumn cbo = (DataGridViewComboBoxColumn)this.dgvStuInfor.Columns["GradeId"];
            cbo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            cbo.DataSource = gradeManager.GetGradeData();
            cbo.DisplayMember = "GradeName";
            cbo.ValueMember = "GradeId";
            //========================end========================================//

            //===========方法2：遍历列中的cell并赋值=================================//        
            //foreach (DataGridViewRow row in this.dgvStuInfor.Rows)
            //{
            //    int id = (int)(row.Cells["GradeId"].Value); 
            //    row.Cells["GradeName"].Value  = gradeManager.GetGradeDataById(id).GradeName;
            //}
            //=========================end=======================================//
        }
        #endregion

        #region 更新groupBox“修改”中的数据
        /// <summary>
        /// 更新groupBox“修改”中的数据
        /// </summary>
        /// <param name="e"></param>
        public void SetModifyData(DataGridViewCellEventArgs e)
        {
            //取得当前行

            DataGridViewRow dgvr = this.dgvStuInfor.CurrentRow;
            //设置学号
            this.lblStuNo.Text = dgvr.Cells[0].Value.ToString().Trim();
            //设置密码
            this.txtStuPwd.Text = dgvr.Cells[1].Value.ToString().Trim();
            //设置姓名
            this.txtStuName.Text = dgvr.Cells[2].Value.ToString().Trim();
            //设置性别
            if (dgvr.Cells[3].Value.ToString().Trim().Equals("女"))
            {
                this.rbStuGirl.Checked = true;
            }
            else
            {
                this.rbStuBoy.Checked = true;
            }
            //设置年级
            this.cboStuGrade.Text = gradeList[Convert.ToInt32(dgvr.Cells[4].Value) - 1].GradeName.ToString();
            //设置电话
            this.txtStuPhone.Text = dgvr.Cells[5].Value.ToString().Trim();
            //设置地址
            this.txtStuAddress.Text = dgvr.Cells[6].Value.ToString().Trim();
            //设置出生年月日
            this.dtpBornDate.Text = dgvr.Cells[7].Value.ToString().Trim();
            //设置Email
            this.txtStuEmail.Text = dgvr.Cells[8].Value.ToString().Trim();
            //设置身份证号
            this.txtIdentityCard.Text = dgvr.Cells[9].Value.ToString().Trim();

        }
        #endregion

        #region 输入验证
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns>验证通过返回True，验证失败返回False</returns>
        public bool CheckInputNotEmpty()
        {
            //验证密码非空
            if (this.txtStuPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTPWD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuPwd.Focus();
                return false;
            }
            //验证姓名非空
            else if (this.txtStuName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuName.Focus();
                return false;
            }
            //性别非空
            else if (!this.rbStuBoy.Checked && !this.rbStuGirl.Checked)
            {
                MessageBox.Show(INPUTSEX, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.rbStuBoy.Focus();
                return false;
            }
            //验证年级非空
            else if (this.cboStuGrade.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTGRADENO, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboStuGrade.Focus();
                return false;
            }
            //验证身份证非空

            else if (this.txtIdentityCard.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTIDENTITYCARD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdentityCard.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 验证日期和Email格式是否有效
        /// </summary>
        /// <returns>true:有效，false：无效</returns>
        public bool CheckFormat()
        {


            //Email输入非空验证格式是否包含“@”
            if (!this.txtStuEmail.Text.Trim().Equals(string.Empty))
            {
                if (!this.txtStuEmail.Text.Contains("@"))
                {
                    MessageBox.Show(INPUTEMAILWRONG, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtStuEmail.Focus();
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region 取得用户选择的Excel文件
        /// <summary>
        /// 取得用户选择的Excel文件
        /// </summary>
        /// <returns>用户选择的文件名</returns>
        public string GetUserSelectFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "Microsoft Excel files (*.xls)|*.xls";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileDialog.OpenFile()) != null)
                {
                    return fileDialog.FileName;
                }
            }
            return string.Empty;
        }
        #endregion

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //取得当前行的隐藏列中的学号
            string strValue = this.dgvStuInfor.CurrentRow.Cells["StudentNo"].Value.ToString();
            //实例化添加成绩窗体

            FrmAddResult frmAddResult = new FrmAddResult();
            //隐藏当前窗体
            this.Hide();
            frmAddResult.StudentNo = Convert.ToInt32(strValue);
            frmAddResult.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddStudent frmAddStudent = new FrmAddStudent();
            frmAddStudent.Show();
        }

    }
}
