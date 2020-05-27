using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*************************************
 * 类名：FrmAdminMain
 * 功能描述：提供系统管理员主菜单界面

 * ************************************/
namespace MySchool.AdminForm
{
    public partial class FrmAdminMain : Form
    {
        #region 常量的定义

        public const string ISEXIT = "确定要退出吗？";
        public const string EXITAPPLICATION = "退出系统";
        #endregion

       

        #region 构造函数

        public FrmAdminMain()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件处理
        /// <summary>
        /// 点击“退出”菜单按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult drChoice;　　// 用户的选择
            drChoice = MessageBox.Show(ISEXIT, EXITAPPLICATION, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (drChoice == DialogResult.OK)
            {
                // 退出应用程序

                Application.Exit();
            }
            else
            {
                //取消
                return;
            }
        }

        /// <summary>
        /// 点击“新建学生用户”菜单按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tslAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddStudent frmAddStu = new FrmAddStudent();
            frmAddStu.MdiParent = this;
            frmAddStu.Show();
        }

        /// <summary>
        /// 点击"查询学生信息"菜单按钮时

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tslSearchStuInfo_Click(object sender, EventArgs e)
        {
            FrmSelectStudentInfo frmSelectStudentInfo = new FrmSelectStudentInfo();
            frmSelectStudentInfo.MdiParent = this;
            frmSelectStudentInfo.Show();
        }

        /// <summary>
        /// 点击添加成绩菜单按钮时

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tslAddResult_Click(object sender, EventArgs e)
        {
            FrmSearchStudent frmSearch = new FrmSearchStudent();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        /// <summary>
        /// 点击查询学生成绩菜单按钮时

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tslSearchStuResult_Click(object sender, EventArgs e)
        {
            FrmReviewResult frmDlg = new FrmReviewResult();
            frmDlg.MdiParent = this;
            frmDlg.Show();
        }
        #endregion

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FrmTeacherManage frm = new FrmTeacherManage();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
