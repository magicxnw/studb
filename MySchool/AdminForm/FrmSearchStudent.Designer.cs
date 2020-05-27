namespace MySchool.AdminForm
{
    partial class FrmSearchStudent
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStuName = new System.Windows.Forms.Label();
            this.dgvStuName = new System.Windows.Forms.DataGridView();
            this.StudentNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStuName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(173, 314);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "返 回";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(13, 22);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(53, 12);
            this.lblStuName.TabIndex = 9;
            this.lblStuName.Text = "学生姓名";
            // 
            // dgvStuName
            // 
            this.dgvStuName.AllowUserToAddRows = false;
            this.dgvStuName.AllowUserToDeleteRows = false;
            this.dgvStuName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNO,
            this.StudentName});
            this.dgvStuName.Location = new System.Drawing.Point(28, 63);
            this.dgvStuName.Name = "dgvStuName";
            this.dgvStuName.ReadOnly = true;
            this.dgvStuName.RowTemplate.Height = 23;
            this.dgvStuName.Size = new System.Drawing.Size(239, 231);
            this.dgvStuName.TabIndex = 7;
            // 
            // StudentNO
            // 
            this.StudentNO.DataPropertyName = "StudentNO";
            this.StudentNO.HeaderText = "学生学号";
            this.StudentNO.Name = "StudentNO";
            this.StudentNO.ReadOnly = true;
            this.StudentNO.Visible = false;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "学生姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 300;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(202, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查 找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(71, 18);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(106, 21);
            this.txtStuName.TabIndex = 5;
            // 
            // FrmSearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 355);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.dgvStuName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtStuName);
            this.Name = "FrmSearchStudent";
            this.Text = "查询学生";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.DataGridView dgvStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtStuName;
    }
}