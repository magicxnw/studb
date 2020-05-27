namespace MySchool.AdminForm
{
    partial class FrmAdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdmin = new System.Windows.Forms.ToolStrip();
            this.tslAddStudent = new System.Windows.Forms.ToolStripLabel();
            this.tslSearchStuInfo = new System.Windows.Forms.ToolStripLabel();
            this.tslAddResult = new System.Windows.Forms.ToolStripLabel();
            this.tslSearchStuResult = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.msAdmin.SuspendLayout();
            this.tsAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp,
            this.tsmiExit});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(611, 24);
            this.msAdmin.TabIndex = 1;
            this.msAdmin.Text = "msAdmin";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(41, 20);
            this.tsmiHelp.Text = "帮助";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(41, 20);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsAdmin
            // 
            this.tsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAddStudent,
            this.tslSearchStuInfo,
            this.tslAddResult,
            this.tslSearchStuResult,
            this.toolStripLabel1});
            this.tsAdmin.Location = new System.Drawing.Point(0, 24);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(611, 25);
            this.tsAdmin.TabIndex = 2;
            this.tsAdmin.Text = "toolStrip1";
            // 
            // tslAddStudent
            // 
            this.tslAddStudent.Name = "tslAddStudent";
            this.tslAddStudent.Size = new System.Drawing.Size(77, 22);
            this.tslAddStudent.Text = "新建学生用户";
            this.tslAddStudent.Click += new System.EventHandler(this.tslAddStudent_Click);
            // 
            // tslSearchStuInfo
            // 
            this.tslSearchStuInfo.Name = "tslSearchStuInfo";
            this.tslSearchStuInfo.Size = new System.Drawing.Size(77, 22);
            this.tslSearchStuInfo.Text = "学生信息管理";
            this.tslSearchStuInfo.Click += new System.EventHandler(this.tslSearchStuInfo_Click);
            // 
            // tslAddResult
            // 
            this.tslAddResult.Name = "tslAddResult";
            this.tslAddResult.Size = new System.Drawing.Size(77, 22);
            this.tslAddResult.Text = "添加学生成绩";
            this.tslAddResult.Click += new System.EventHandler(this.tslAddResult_Click);
            // 
            // tslSearchStuResult
            // 
            this.tslSearchStuResult.Name = "tslSearchStuResult";
            this.tslSearchStuResult.Size = new System.Drawing.Size(77, 22);
            this.tslSearchStuResult.Text = "查询学生成绩";
            this.tslSearchStuResult.Click += new System.EventHandler(this.tslSearchStuResult_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "教师信息管理";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 400);
            this.Controls.Add(this.tsAdmin);
            this.Controls.Add(this.msAdmin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAdmin;
            this.Name = "FrmAdminMain";
            this.Text = "MySchool-管理员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.tsAdmin.ResumeLayout(false);
            this.tsAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStrip tsAdmin;
        private System.Windows.Forms.ToolStripLabel tslAddStudent;
        private System.Windows.Forms.ToolStripLabel tslSearchStuInfo;
        private System.Windows.Forms.ToolStripLabel tslAddResult;
        private System.Windows.Forms.ToolStripLabel tslSearchStuResult;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}