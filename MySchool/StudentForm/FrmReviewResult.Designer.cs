namespace MySchool.StudentForm
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
            this.gbReview = new System.Windows.Forms.GroupBox();
            this.lblGradeName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.StudentNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReview
            // 
            this.gbReview.Controls.Add(this.lblGradeName);
            this.gbReview.Controls.Add(this.lblGrade);
            this.gbReview.Controls.Add(this.cboSubject);
            this.gbReview.Controls.Add(this.lblSubject);
            this.gbReview.Location = new System.Drawing.Point(25, 7);
            this.gbReview.Name = "gbReview";
            this.gbReview.Size = new System.Drawing.Size(430, 97);
            this.gbReview.TabIndex = 1;
            this.gbReview.TabStop = false;
            this.gbReview.Text = "查询条件";
            // 
            // lblGradeName
            // 
            this.lblGradeName.AutoSize = true;
            this.lblGradeName.Location = new System.Drawing.Point(62, 26);
            this.lblGradeName.Name = "lblGradeName";
            this.lblGradeName.Size = new System.Drawing.Size(77, 12);
            this.lblGradeName.TabIndex = 3;
            this.lblGradeName.Text = "lblGradeName";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(15, 26);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(35, 12);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "年 级";
            // 
            // cboSubject
            // 
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(62, 62);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(121, 20);
            this.cboSubject.TabIndex = 1;
            this.cboSubject.DropDownClosed += new System.EventHandler(this.cboSubject_DropDownClosed);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(18, 65);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(29, 12);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "科目";
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
            this.dgvResult.Location = new System.Drawing.Point(13, 125);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(442, 241);
            this.dgvResult.TabIndex = 5;
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(380, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "返 回";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmReviewResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 425);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.gbReview);
            this.Name = "FrmReviewResult";
            this.Text = "FrmReviewResult";
            this.Load += new System.EventHandler(this.FrmReviewResult_Load);
            this.gbReview.ResumeLayout(false);
            this.gbReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReview;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewComboBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblGradeName;
    }
}