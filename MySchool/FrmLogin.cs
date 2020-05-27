using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySchool.BLL;
using MySchool.Models;
using MySchool.AdminForm;
using MySchool.StudentForm;

/*************************************
 * 类名：FrmLogin
 * 功能描述：提供用户登录入口

 * ************************************/
namespace MySchool
{
    public partial class FrmLogin : Form
    {
        #region  常量和变量的定义
        public const string INPUTUSERNAME = "请输入用户名";
        public const string INPUTWARN = "输入提示";
        public const string INPUTPWD = "请输入密码";
        public const string INPUTUSERTYPE = "请选择用户类型";
        public const string LOGINFAILED = "登录失败";
        public const string INPUTNOEXIST = "用户名或密码不存在！";

        private AdminManager adminManager = new AdminManager();//实例化系统管理员业务逻辑层对象

        private StudentManager studentMangager = new StudentManager();//实例化学生业务逻辑层对象

        #endregion

        #region 构造函数

        public FrmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件处理
        /// <summary>
        /// 点击“登录”按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //用户名、密码和用户类型都不为空
                if (!CheckInputNotEmpty())
                {
                    return;
                }

                //系统管理员

                if (this.cboLoginType.SelectedIndex == 0)
                {
                    //检索系统管理员用户名、密码是否存在

                    bool  bAdmin = adminManager.CheckAdminLogin(this.txtUserName.Text.Trim(), this.txtPwd.Text.Trim());
                   //没有检索到信息
                    if (!bAdmin )
                    {
                        MessageBox.Show(INPUTNOEXIST, LOGINFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        //实例化系统管理员主窗体

                        FrmAdminMain frmAdminMain = new FrmAdminMain();
                        //将输入的用户名、密码、登录类型保存到静态变量中
                        UserInfo.loginId = this.txtUserName.Text.Trim();
                        UserInfo.loginPwd = this.txtPwd.Text.Trim();
                        UserInfo.loginType = this.cboLoginType .Text .Trim ();
                        frmAdminMain.Show();
                    }
                }
                //学生
                else if (this.cboLoginType.SelectedIndex == 1)
                {
                    //检索学生用户名、密码是否存在

                    bool  bStudent = studentMangager.CheckStudentLogin(this.txtUserName.Text.Trim(), this.txtPwd.Text.Trim());
                    if (!bStudent)
                    {
                        MessageBox.Show(INPUTNOEXIST, LOGINFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        //实例化学生主窗体
                        FrmStudentMain frmStudentMain = new FrmStudentMain();
                        //将输入的学号、密码、登录类型保存到静态变量中
                        UserInfo.loginId = this.txtUserName.Text.Trim();
                        UserInfo.loginPwd = this.txtPwd.Text.Trim();
                        UserInfo.loginType = this.cboLoginType.Text.Trim();
                        frmStudentMain.Show();
                    }
                }
                else
                {
                    return;
                }
                //隐藏登录窗体
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, LOGINFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message ,LOGINFAILED ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        #endregion

        #region 输入验证
        /// <summary>
        /// 用户名、密码和用户类型的非空验证

        /// </summary>
        /// <returns>True都不为空，False其中一个为空</returns>
        public bool CheckInputNotEmpty()
        {
            //用户名为空

            if (this.txtUserName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTUSERNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUserName.Focus();
                return false;
            }
            //密码为空
            else if (this.txtPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTPWD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
                return false;
            }
            //用户类型为空
            else if (this.cboLoginType.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(INPUTUSERTYPE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboLoginType.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

    }
}
