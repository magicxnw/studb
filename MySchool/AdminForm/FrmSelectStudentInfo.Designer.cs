namespace MySchool.AdminForm
{
    partial class FrmSelectStudentInfo
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvStuInfor = new System.Windows.Forms.DataGridView();
            this.StudentNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BornDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtStuPwd = new System.Windows.Forms.TextBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.lblStuNumber = new System.Windows.Forms.Label();
            this.txtStuEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.txtStuAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtStuPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cboStuGrade = new System.Windows.Forms.ComboBox();
            this.lblStuGrade = new System.Windows.Forms.Label();
            this.rbStuBoy = new System.Windows.Forms.RadioButton();
            this.rbStuGirl = new System.Windows.Forms.RadioButton();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuInfor)).BeginInit();
            this.cmsDelete.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(555, 445);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvStuInfor
            // 
            this.dgvStuInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNO,
            this.LoginPwd,
            this.StudentName,
            this.Gender,
            this.GradeId,
            this.Phone,
            this.Address,
            this.BornDate,
            this.Email,
            this.IdentityCard});
            this.dgvStuInfor.ContextMenuStrip = this.cmsDelete;
            this.dgvStuInfor.Location = new System.Drawing.Point(12, 82);
            this.dgvStuInfor.Name = "dgvStuInfor";
            this.dgvStuInfor.RowTemplate.Height = 23;
            this.dgvStuInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStuInfor.Size = new System.Drawing.Size(649, 240);
            this.dgvStuInfor.TabIndex = 6;
            this.dgvStuInfor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStuInfor_CellClick);
            // 
            // StudentNO
            // 
            this.StudentNO.DataPropertyName = "StudentNO";
            this.StudentNO.HeaderText = "学号";
            this.StudentNO.Name = "StudentNO";
            // 
            // LoginPwd
            // 
            this.LoginPwd.DataPropertyName = "LoginPwd";
            this.LoginPwd.HeaderText = "密码";
            this.LoginPwd.Name = "LoginPwd";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            // 
            // GradeId
            // 
            this.GradeId.DataPropertyName = "GradeId";
            this.GradeId.HeaderText = "年级";
            this.GradeId.Name = "GradeId";
            this.GradeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GradeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "电话";
            this.Phone.Name = "Phone";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            // 
            // BornDate
            // 
            this.BornDate.DataPropertyName = "BornDate";
            this.BornDate.HeaderText = "出生年月日";
            this.BornDate.Name = "BornDate";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "邮箱";
            this.Email.Name = "Email";
            // 
            // IdentityCard
            // 
            this.IdentityCard.DataPropertyName = "IdentityCard";
            this.IdentityCard.HeaderText = "身份证号";
            this.IdentityCard.Name = "IdentityCard";
            // 
            // cmsDelete
            // 
            this.cmsDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.xToolStripMenuItem});
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(119, 48);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(118, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.xToolStripMenuItem.Text = "新增成绩";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(551, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "修 改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.btnSelect);
            this.gbSelect.Controls.Add(this.txtName);
            this.gbSelect.Controls.Add(this.lblName);
            this.gbSelect.Controls.Add(this.cboGrade);
            this.gbSelect.Controls.Add(this.lblGrade);
            this.gbSelect.Location = new System.Drawing.Point(12, 12);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(649, 53);
            this.gbSelect.TabIndex = 5;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "查询";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(407, 17);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "查 询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(101, 21);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(173, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(43, 18);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(107, 20);
            this.cboGrade.TabIndex = 1;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(7, 21);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(29, 12);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "年级";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(121, 345);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(29, 12);
            this.lblPwd.TabIndex = 9;
            this.lblPwd.Text = "密码";
            // 
            // txtStuPwd
            // 
            this.txtStuPwd.Location = new System.Drawing.Point(159, 340);
            this.txtStuPwd.Name = "txtStuPwd";
            this.txtStuPwd.Size = new System.Drawing.Size(77, 21);
            this.txtStuPwd.TabIndex = 10;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(249, 345);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(29, 12);
            this.lblStuName.TabIndex = 11;
            this.lblStuName.Text = "姓名";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(288, 341);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(80, 21);
            this.txtStuName.TabIndex = 12;
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.dtpBornDate);
            this.gbUpdate.Controls.Add(this.lblStuNo);
            this.gbUpdate.Controls.Add(this.lblStuNumber);
            this.gbUpdate.Controls.Add(this.txtStuEmail);
            this.gbUpdate.Controls.Add(this.lblEmail);
            this.gbUpdate.Controls.Add(this.lblBornDate);
            this.gbUpdate.Controls.Add(this.txtStuAddress);
            this.gbUpdate.Controls.Add(this.lblAddress);
            this.gbUpdate.Controls.Add(this.txtStuPhone);
            this.gbUpdate.Controls.Add(this.lblPhone);
            this.gbUpdate.Controls.Add(this.cboStuGrade);
            this.gbUpdate.Controls.Add(this.lblStuGrade);
            this.gbUpdate.Controls.Add(this.rbStuBoy);
            this.gbUpdate.Controls.Add(this.rbStuGirl);
            this.gbUpdate.Location = new System.Drawing.Point(14, 328);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(647, 106);
            this.gbUpdate.TabIndex = 13;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "修改";
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBornDate.Location = new System.Drawing.Point(350, 47);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(109, 21);
            this.dtpBornDate.TabIndex = 13;
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(63, 16);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(0, 12);
            this.lblStuNo.TabIndex = 12;
            // 
            // lblStuNumber
            // 
            this.lblStuNumber.AutoSize = true;
            this.lblStuNumber.Location = new System.Drawing.Point(19, 18);
            this.lblStuNumber.Name = "lblStuNumber";
            this.lblStuNumber.Size = new System.Drawing.Size(29, 12);
            this.lblStuNumber.TabIndex = 12;
            this.lblStuNumber.Text = "学号";
            // 
            // txtStuEmail
            // 
            this.txtStuEmail.Location = new System.Drawing.Point(507, 46);
            this.txtStuEmail.Name = "txtStuEmail";
            this.txtStuEmail.Size = new System.Drawing.Size(113, 21);
            this.txtStuEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(472, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 12);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Location = new System.Drawing.Point(279, 53);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(65, 12);
            this.lblBornDate.TabIndex = 8;
            this.lblBornDate.Text = "出生年月日";
            // 
            // txtStuAddress
            // 
            this.txtStuAddress.Location = new System.Drawing.Point(173, 48);
            this.txtStuAddress.Name = "txtStuAddress";
            this.txtStuAddress.Size = new System.Drawing.Size(100, 21);
            this.txtStuAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(142, 51);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "地址";
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Location = new System.Drawing.Point(52, 46);
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.Size = new System.Drawing.Size(77, 21);
            this.txtStuPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(17, 52);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(29, 12);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "电话";
            // 
            // cboStuGrade
            // 
            this.cboStuGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStuGrade.FormattingEnabled = true;
            this.cboStuGrade.Location = new System.Drawing.Point(507, 16);
            this.cboStuGrade.Name = "cboStuGrade";
            this.cboStuGrade.Size = new System.Drawing.Size(113, 20);
            this.cboStuGrade.TabIndex = 3;
            // 
            // lblStuGrade
            // 
            this.lblStuGrade.AutoSize = true;
            this.lblStuGrade.Location = new System.Drawing.Point(472, 19);
            this.lblStuGrade.Name = "lblStuGrade";
            this.lblStuGrade.Size = new System.Drawing.Size(29, 12);
            this.lblStuGrade.TabIndex = 2;
            this.lblStuGrade.Text = "年级";
            // 
            // rbStuBoy
            // 
            this.rbStuBoy.AutoSize = true;
            this.rbStuBoy.Location = new System.Drawing.Point(413, 18);
            this.rbStuBoy.Name = "rbStuBoy";
            this.rbStuBoy.Size = new System.Drawing.Size(35, 16);
            this.rbStuBoy.TabIndex = 1;
            this.rbStuBoy.Text = "男";
            this.rbStuBoy.UseVisualStyleBackColor = true;
            // 
            // rbStuGirl
            // 
            this.rbStuGirl.AutoSize = true;
            this.rbStuGirl.Checked = true;
            this.rbStuGirl.Location = new System.Drawing.Point(371, 18);
            this.rbStuGirl.Name = "rbStuGirl";
            this.rbStuGirl.Size = new System.Drawing.Size(35, 16);
            this.rbStuGirl.TabIndex = 0;
            this.rbStuGirl.TabStop = true;
            this.rbStuGirl.Text = "女";
            this.rbStuGirl.UseVisualStyleBackColor = true;
            // 
            // txtIdentityCard
            // 
            this.txtIdentityCard.Location = new System.Drawing.Point(89, 408);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(198, 21);
            this.txtIdentityCard.TabIndex = 19;
            // 
            // lblIdentityCard
            // 
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Location = new System.Drawing.Point(31, 411);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(41, 12);
            this.lblIdentityCard.TabIndex = 18;
            this.lblIdentityCard.Text = "身份证";
            // 
            // FrmSelectStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 473);
            this.Controls.Add(this.txtIdentityCard);
            this.Controls.Add(this.lblIdentityCard);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.txtStuPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvStuInfor);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.gbUpdate);
            this.Name = "FrmSelectStudentInfo";
            this.Text = "学生信息列表";
            this.Load += new System.EventHandler(this.FrmSelectStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuInfor)).EndInit();
            this.cmsDelete.ResumeLayout(false);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvStuInfor;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtStuPwd;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.RadioButton rbStuBoy;
        private System.Windows.Forms.RadioButton rbStuGirl;
        private System.Windows.Forms.TextBox txtStuAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtStuPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cboStuGrade;
        private System.Windows.Forms.Label lblStuGrade;
        private System.Windows.Forms.TextBox txtStuEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.TextBox txtIdentityCard;
        private System.Windows.Forms.Label lblIdentityCard;
        private System.Windows.Forms.Label lblStuNumber;
        private System.Windows.Forms.ContextMenuStrip cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpBornDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewComboBoxColumn GradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn BornDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityCard;
    }
}