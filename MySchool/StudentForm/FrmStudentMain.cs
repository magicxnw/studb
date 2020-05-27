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
using MySchool.AdminForm;
/*************************************
 * 类名：FrmStudentMain
 * 功能描述：提供学生主菜单界面
 * ************************************/
namespace MySchool.StudentForm
{
    public partial class FrmStudentMain : Form
    {
        #region 常量的定义

        public const string ISEXIT = "确定要退出吗？";
        public const string EXITAPPLICATION = "退出系统";
        #endregion

        #region 属性

        private Student _student;

        public Student Student
        {
            get { return _student; }
            set { _student = value; }
        }
        #endregion

        #region 构造函数

        public FrmStudentMain()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件处理
        /// <summary>
        /// 当点击“查询成绩”菜单按钮时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tslSearchResult_Click(object sender, EventArgs e)
        {
            FrmReviewResult frmReviewResult = new FrmReviewResult();
            frmReviewResult.MdiParent = this;
            frmReviewResult.Show();
        }

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
        #endregion

    }
}
