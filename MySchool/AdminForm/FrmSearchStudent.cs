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
/*************************************
 * 类名：FrmSearchStudent
 * 功能描述：提供查询学生姓名用户界面

 * ************************************/
namespace MySchool.AdminForm
{
    public partial class FrmSearchStudent : Form
    {
        #region 常量定义
        public const string OPERATIOFAILED = "操作错误";
        #endregion

        #region 成员变量的定义

        private StudentManager studentManager = new StudentManager();//实例化学生业务逻辑层对象

        #endregion

        #region 构造函数

        public FrmSearchStudent()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件处理
        /// <summary>
        /// 查询按钮按下时

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //根据输入姓名检索学生信息表并绑定
                this.dgvStuName.DataSource = studentManager.GetStudentDataByName(this.txtStuName.Text.Trim().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIOFAILED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// 点击添加成绩菜单按钮时

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAddResult_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 返回按钮按下时

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
