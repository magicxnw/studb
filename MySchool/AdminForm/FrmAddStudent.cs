using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySchool.BLL;
using MySchool.Models;
/*************************************
 * 类名：FrmAddStudent
 * 功能描述：提供新建学生用户界面

 * ************************************/
namespace MySchool.AdminForm
{
    public partial class FrmAddStudent : Form
    {
        #region 常量定义
        public const string INPUTWARN = "输入提示";
        public const string INPUTPWD = "请输入密码";
        public const string INPUTNAME = "请输入姓名";
        public const string INPUTSTUNO = "请输入学号";
        public const string INPUTSEX = "请选择性别";
        public const string INPUTGRADENO = "请选择年级";
        public const string INPUTIDENTITYCARD = "请输入身份证号";
        public const string INPUTPWDNOTSAME = "两次输入的密码不一致";
        public const string INPUTDATEWRONG = "输入的出生年月日格式有误";
        public const string INPUTEMAILWRONG = "输入的Email格式有误";
        public const string INSERTFAILED = "添加失败！";
        public const string INSERTSUCESS = "添加成功！";
        public const string OPERATIONWARN = "操作提示";
        public const string STUDENTNOISEXIST = "学号已存在";
        public const string IDCARDISEXIST = "身份证号已存在";
        public const string OPERATIOFAILED = "操作错误";
        #endregion

        #region 构造函数

        public FrmAddStudent()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件处理
        /// <summary>
        /// 学号输入框失去焦点时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStuNo_Validated(object sender, EventArgs e)
        {
            try
            {
                //检查该学号是否存在
                bool bIsExit = StudentManager.CheckStuNoIsExist(this.txtStuNo.Text.Trim());
                if (bIsExit)
                {
                    MessageBox.Show(STUDENTNOISEXIST, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// 窗体初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            //年级信息的绑定

            GradeDataBind();
        }

        /// <summary>
        /// 点击"添加"按钮时 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //非空验证
                if (!CheckInputNotEmpty())
                {
                    return;
                }

                //密码验证
                if (!CheckPwd())
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
                if (this.rbGirl.Checked)
                {
                    strSex = "1";
                }
                else if (this.rbBoy.Checked)
                {
                    strSex = "0";
                }
                else
                {
                    return;
                }

                //构建student实体类,将输入数据插入学生表中
                Student student = new Student();
                student.StudentNo = Convert.ToInt32(this.txtStuNo.Text.Trim());
                student.LoginPwd = this.txtPwd.Text.Trim();
                student.StudentName = this.txtName.Text.Trim();
                student.Gender = strSex;
                student.GradeId = Convert.ToInt32(this.cboGrade.SelectedValue.ToString());
                student.Phone = this.txtPhone.Text.Trim();
                student.Address =  this.txtAddress.Text.Trim();
                student.BornDate = Convert.ToDateTime(this.txtBornDate.Text.Trim());
                student.Email = this.txtEmail.Text.Trim();
                student.IdentityCard = this.txtIdentityCard.Text.Trim ();

                int iRet =new StudentManager().AddStudent(student);

              //插入失败 
             if ( iRet == -2 )
              {
                  MessageBox.Show(IDCARDISEXIST, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                  return;                
              }
              else if (iRet < 0)
              {
                  MessageBox.Show(INSERTFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                  return;                
              }
               //插入成功
              else
              {
                  MessageBox.Show(INSERTSUCESS, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                  return;
              }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        #region 年级信息的绑定

        /// <summary>
        /// 实现年级信息的绑定

        /// </summary>
        public void GradeDataBind()
        {
            try
            {
                //取得所有年级信息

                List<Grade> gradeList =new  GradeManager().GetGradeData();
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
        #endregion

        #region 输入验证
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns>验证通过返回True，验证失败返回False</returns>
        public bool CheckInputNotEmpty()
        {
            //验证学号非空
            if (this.txtStuNo.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTSTUNO, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuNo.Focus();
                return false;
            }
            //验证密码非空
            else if (this.txtPwd.Text.Trim().Equals(string.Empty) || this.txtRePwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTPWD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
                return false;
            }
            //验证姓名非空
            else if (this.txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return false;
            }
            //性别非空
            else if (!this.rbBoy.Checked && !this.rbGirl.Checked)
            {
                MessageBox.Show(INPUTSEX, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.rbGirl.Focus();
                return false;
            }
            //验证年级非空
            else if (this.cboGrade.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTGRADENO, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboGrade.Focus();
                return false;
            }
            //验证身份证非空

            else if (this.txtIdentityCard .Text .Trim ().Equals (string.Empty ))
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
        /// 验证两次输入的密码是否一致

        /// </summary>
        /// <returns>true:一致，false：不一致</returns>
        public bool CheckPwd()
        {
            if (this.txtPwd.Text.Trim().Equals(this.txtRePwd.Text.Trim()))
            {
                return true;
            }
            else
            {
                MessageBox.Show(INPUTPWDNOTSAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
                return false;
            }
        }

        /// <summary>
        /// 验证日期和Email格式是否有效
        /// </summary>
        /// <returns>true:有效，false：无效</returns>
        public bool CheckFormat()
        {
            //出生日期非空验证格式
            if (!this.txtBornDate.Text.Trim().Equals(string.Empty))
            {
                try
                {
                    DateTime dt = Convert.ToDateTime(this.txtBornDate.Text.Trim());
                }
                catch (Exception)
                {
                    MessageBox.Show(INPUTDATEWRONG, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtBornDate.Focus();
                    return false;
                }
            }

            //Email输入非空验证格式是否包含“@”

            if (!this.txtEmail.Text.Trim().Equals(string.Empty))
            {
                if (!this.txtEmail.Text.Contains("@"))
                {
                    MessageBox.Show(INPUTEMAILWRONG, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtEmail.Focus();
                    return false;
                }
            }

            return true;

        }

        #endregion
    }
}
