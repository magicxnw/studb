namespace MySchool.AdminForm
{
    partial class FrmReviewResult
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.StudentNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gbReview = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.gbUpdateInfo = new System.Windows.Forms.GroupBox();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtExamDateU = new System.Windows.Forms.TextBox();
            this.lblExamDateN = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResultN = new System.Windows.Forms.Label();
            this.cboSubjectU = new System.Windows.Forms.ComboBox();
            this.lblSubjectN = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuNameN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.cmsDelete.SuspendLayout();
            this.gbReview.SuspendLayout();
            this.gbUpdateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(455, 491);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "返 回";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNo,
            this.SubjectName,
            this.StudentResult,
            this.ExamDate,
            this.SubjectId});
            this.dgvResult.ContextMenuStrip = this.cmsDelete;
            this.dgvResult.Location = new System.Drawing.Point(15, 129);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(515, 241);
            this.dgvResult.TabIndex = 4;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // StudentNo
            // 
            this.StudentNo.DataPropertyName = "StudentNo";
            this.StudentNo.HeaderText = "学生姓名";
            this.StudentNo.Name = "StudentNo";
            this.StudentNo.ReadOnly = true;
            this.StudentNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "科目";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // StudentResult
            // 
            this.StudentResult.DataPropertyName = "StudentResult";
            this.StudentResult.HeaderText = "成绩";
            this.StudentResult.Name = "StudentResult";
            this.StudentResult.ReadOnly = true;
            // 
            // ExamDate
            // 
            this.ExamDate.DataPropertyName = "ExamDate";
            this.ExamDate.HeaderText = "考试时间";
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.ReadOnly = true;
            // 
            // SubjectId
            // 
            this.SubjectId.DataPropertyName = "SubjectId";
            this.SubjectId.HeaderText = "科目编号";
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.ReadOnly = true;
            this.SubjectId.Visible = false;
            // 
            // cmsDelete
            // 
            this.cmsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiDelete});
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(95, 26);
            // 
            // tmsiDelete
            // 
            this.tmsiDelete.Name = "tmsiDelete";
            this.tmsiDelete.Size = new System.Drawing.Size(94, 22);
            this.tmsiDelete.Text = "删除";
            this.tmsiDelete.Click += new System.EventHandler(this.tmsiDelete_Click);
            // 
            // gbReview
            // 
            this.gbReview.Controls.Add(this.lblName);
            this.gbReview.Controls.Add(this.txtName);
            this.gbReview.Controls.Add(this.btnSearch);
            this.gbReview.Controls.Add(this.cboSubject);
            this.gbReview.Controls.Add(this.lblSubject);
            this.gbReview.Controls.Add(this.cboGrade);
            this.gbReview.Controls.Add(this.lblGrade);
            this.gbReview.Location = new System.Drawing.Point(12, 12);
            this.gbReview.Name = "gbReview";
            this.gbReview.Size = new System.Drawing.Size(518, 102);
            this.gbReview.TabIndex = 3;
            this.gbReview.TabStop = false;
            this.gbReview.Text = "查询条件";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓 名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 21);
            this.txtName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(223, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查 询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSubject
            // 
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Items.AddRange(new object[] {
            "及格",
            "不及格"});
            this.cboSubject.Location = new System.Drawing.Point(295, 26);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(142, 20);
            this.cboSubject.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(231, 29);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(35, 12);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "科 目";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(66, 26);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(142, 20);
            this.cboGrade.TabIndex = 1;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(18, 29);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(35, 12);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "年 级";
            // 
            // gbUpdateInfo
            // 
            this.gbUpdateInfo.Controls.Add(this.lblStuNo);
            this.gbUpdateInfo.Controls.Add(this.btnUpdate);
            this.gbUpdateInfo.Controls.Add(this.txtExamDateU);
            this.gbUpdateInfo.Controls.Add(this.lblExamDateN);
            this.gbUpdateInfo.Controls.Add(this.txtResult);
            this.gbUpdateInfo.Controls.Add(this.lblResultN);
            this.gbUpdateInfo.Controls.Add(this.cboSubjectU);
            this.gbUpdateInfo.Controls.Add(this.lblSubjectN);
            this.gbUpdateInfo.Controls.Add(this.lblStuName);
            this.gbUpdateInfo.Controls.Add(this.lblStuNameN);
            this.gbUpdateInfo.Location = new System.Drawing.Point(17, 385);
            this.gbUpdateInfo.Name = "gbUpdateInfo";
            this.gbUpdateInfo.Size = new System.Drawing.Size(513, 100);
            this.gbUpdateInfo.TabIndex = 6;
            this.gbUpdateInfo.TabStop = false;
            this.gbUpdateInfo.Text = "修改信息";
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(383, 29);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(53, 12);
            this.lblStuNo.TabIndex = 11;
            this.lblStuNo.Text = "lblStuNo";
            this.lblStuNo.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(361, 58);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "修 改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtExamDateU
            // 
            this.txtExamDateU.Location = new System.Drawing.Point(232, 58);
            this.txtExamDateU.Name = "txtExamDateU";
            this.txtExamDateU.Size = new System.Drawing.Size(100, 21);
            this.txtExamDateU.TabIndex = 9;
            // 
            // lblExamDateN
            // 
            this.lblExamDateN.AutoSize = true;
            this.lblExamDateN.Location = new System.Drawing.Point(170, 66);
            this.lblExamDateN.Name = "lblExamDateN";
            this.lblExamDateN.Size = new System.Drawing.Size(65, 12);
            this.lblExamDateN.TabIndex = 8;
            this.lblExamDateN.Text = "考试时间：";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(66, 61);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(41, 21);
            this.txtResult.TabIndex = 7;
            // 
            // lblResultN
            // 
            this.lblResultN.AutoSize = true;
            this.lblResultN.Location = new System.Drawing.Point(22, 64);
            this.lblResultN.Name = "lblResultN";
            this.lblResultN.Size = new System.Drawing.Size(47, 12);
            this.lblResultN.TabIndex = 6;
            this.lblResultN.Text = "成 绩：";
            // 
            // cboSubjectU
            // 
            this.cboSubjectU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubjectU.FormattingEnabled = true;
            this.cboSubjectU.Items.AddRange(new object[] {
            "及格",
            "不及格"});
            this.cboSubjectU.Location = new System.Drawing.Point(218, 26);
            this.cboSubjectU.Name = "cboSubjectU";
            this.cboSubjectU.Size = new System.Drawing.Size(142, 20);
            this.cboSubjectU.TabIndex = 5;
            // 
            // lblSubjectN
            // 
            this.lblSubjectN.AutoSize = true;
            this.lblSubjectN.Location = new System.Drawing.Point(171, 30);
            this.lblSubjectN.Name = "lblSubjectN";
            this.lblSubjectN.Size = new System.Drawing.Size(47, 12);
            this.lblSubjectN.TabIndex = 4;
            this.lblSubjectN.Text = "科 目：";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(81, 29);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(23, 12);
            this.lblStuName.TabIndex = 1;
            this.lblStuName.Text = "   ";
            // 
            // lblStuNameN
            // 
            this.lblStuNameN.AutoSize = true;
            this.lblStuNameN.Location = new System.Drawing.Point(21, 29);
            this.lblStuNameN.Name = "lblStuNameN";
            this.lblStuNameN.Size = new System.Drawing.Size(65, 12);
            this.lblStuNameN.TabIndex = 0;
            this.lblStuNameN.Text = "学生姓名：";
            // 
            // FrmReviewResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 525);
            this.Controls.Add(this.gbUpdateInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbReview);
            this.Controls.Add(this.dgvResult);
            this.Name = "FrmReviewResult";
            this.Text = "查看成绩信息";
            this.Load += new System.EventHandler(this.FrmReviewResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.cmsDelete.ResumeLayout(false);
            this.gbReview.ResumeLayout(false);
            this.gbReview.PerformLayout();
            this.gbUpdateInfo.ResumeLayout(false);
            this.gbUpdateInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.GroupBox gbReview;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewComboBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.GroupBox gbUpdateInfo;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblStuNameN;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtExamDateU;
        private System.Windows.Forms.Label lblExamDateN;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResultN;
        private System.Windows.Forms.ComboBox cboSubjectU;
        private System.Windows.Forms.Label lblSubjectN;
        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.ContextMenuStrip cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem tmsiDelete;
    }
}