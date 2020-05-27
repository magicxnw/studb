namespace MySchool.AdminForm
{
    partial class FrmAddResult
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
            this.lblSubject = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.lblExamDate = new System.Windows.Forms.Label();
            this.dtpExamTime = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(204, 27);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(35, 12);
            this.lblSubject.TabIndex = 8;
            this.lblSubject.Text = "科 目";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.dtpExamTime);
            this.gbResult.Controls.Add(this.lblSubject);
            this.gbResult.Controls.Add(this.cboGrade);
            this.gbResult.Controls.Add(this.lblGrade);
            this.gbResult.Controls.Add(this.txtResult);
            this.gbResult.Controls.Add(this.lblResult);
            this.gbResult.Controls.Add(this.cboSubject);
            this.gbResult.Controls.Add(this.btnReturn);
            this.gbResult.Controls.Add(this.btnAddResult);
            this.gbResult.Controls.Add(this.lblExamDate);
            this.gbResult.Location = new System.Drawing.Point(25, 14);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(407, 156);
            this.gbResult.TabIndex = 11;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "输入成绩";
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(62, 23);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(108, 20);
            this.cboGrade.TabIndex = 8;
            this.cboGrade.DropDownClosed += new System.EventHandler(this.cboGrade_DropDownClosed);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(19, 26);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(35, 12);
            this.lblGrade.TabIndex = 7;
            this.lblGrade.Text = "年 级";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(62, 61);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(108, 21);
            this.txtResult.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(19, 64);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 12);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "成 绩";
            // 
            // cboSubject
            // 
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(274, 23);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(105, 20);
            this.cboSubject.TabIndex = 0;
            // 
            // btnAddResult
            // 
            this.btnAddResult.Location = new System.Drawing.Point(106, 108);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(64, 23);
            this.btnAddResult.TabIndex = 4;
            this.btnAddResult.Text = "添 加";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // lblExamDate
            // 
            this.lblExamDate.AutoSize = true;
            this.lblExamDate.Location = new System.Drawing.Point(194, 64);
            this.lblExamDate.Name = "lblExamDate";
            this.lblExamDate.Size = new System.Drawing.Size(53, 12);
            this.lblExamDate.TabIndex = 2;
            this.lblExamDate.Text = "考试时间";
            // 
            // dtpExamTime
            // 
            this.dtpExamTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExamTime.Location = new System.Drawing.Point(253, 64);
            this.dtpExamTime.Name = "dtpExamTime";
            this.dtpExamTime.Size = new System.Drawing.Size(126, 21);
            this.dtpExamTime.TabIndex = 9;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(206, 108);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(64, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "返  回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmAddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 205);
            this.Controls.Add(this.gbResult);
            this.Name = "FrmAddResult";
            this.Text = "添加学生成绩";
            this.Load += new System.EventHandler(this.FrmAddResult_Load);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.Label lblExamDate;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.DateTimePicker dtpExamTime;
        private System.Windows.Forms.Button btnReturn;
    }
}