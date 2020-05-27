namespace MySchool.AdminForm
{
    partial class FrmAddStudent
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBornDate = new System.Windows.Forms.TextBox();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbUserLoginInfo = new System.Windows.Forms.GroupBox();
            this.txtRePwd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblRePwd = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.gbUserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbUserLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(303, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(29, 411);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "添 加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.txtIdentityCard);
            this.gbUserInfo.Controls.Add(this.lblIdentityCard);
            this.gbUserInfo.Controls.Add(this.txtEmail);
            this.gbUserInfo.Controls.Add(this.lblEmail);
            this.gbUserInfo.Controls.Add(this.txtBornDate);
            this.gbUserInfo.Controls.Add(this.lblBornDate);
            this.gbUserInfo.Controls.Add(this.txtAddress);
            this.gbUserInfo.Controls.Add(this.lblAddress);
            this.gbUserInfo.Controls.Add(this.txtPhone);
            this.gbUserInfo.Controls.Add(this.lblPhone);
            this.gbUserInfo.Controls.Add(this.lblGrade);
            this.gbUserInfo.Controls.Add(this.cboGrade);
            this.gbUserInfo.Controls.Add(this.panel1);
            this.gbUserInfo.Controls.Add(this.lblSex);
            this.gbUserInfo.Controls.Add(this.txtName);
            this.gbUserInfo.Controls.Add(this.lblName);
            this.gbUserInfo.Location = new System.Drawing.Point(29, 137);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(351, 268);
            this.gbUserInfo.TabIndex = 6;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "用户基本信息";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 202);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 21);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 12);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // txtBornDate
            // 
            this.txtBornDate.Location = new System.Drawing.Point(80, 169);
            this.txtBornDate.Name = "txtBornDate";
            this.txtBornDate.Size = new System.Drawing.Size(121, 21);
            this.txtBornDate.TabIndex = 13;
            this.txtBornDate.Text = "0000-00-00";
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Location = new System.Drawing.Point(13, 172);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(65, 12);
            this.lblBornDate.TabIndex = 12;
            this.lblBornDate.Text = "出生年月日";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(78, 141);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(232, 21);
            this.txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(22, 146);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "地址";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(78, 111);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 21);
            this.txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(22, 117);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(29, 12);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "电话";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(19, 85);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(29, 12);
            this.lblGrade.TabIndex = 7;
            this.lblGrade.Text = "年级";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(78, 80);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(123, 20);
            this.cboGrade.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbBoy);
            this.panel1.Controls.Add(this.rbGirl);
            this.panel1.Location = new System.Drawing.Point(80, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 27);
            this.panel1.TabIndex = 3;
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Location = new System.Drawing.Point(52, 5);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(35, 16);
            this.rbBoy.TabIndex = 1;
            this.rbBoy.Text = "男";
            this.rbBoy.UseVisualStyleBackColor = true;
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Checked = true;
            this.rbGirl.Location = new System.Drawing.Point(4, 4);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(35, 16);
            this.rbGirl.TabIndex = 0;
            this.rbGirl.TabStop = true;
            this.rbGirl.Text = "女";
            this.rbGirl.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(20, 51);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性别";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // gbUserLoginInfo
            // 
            this.gbUserLoginInfo.Controls.Add(this.txtRePwd);
            this.gbUserLoginInfo.Controls.Add(this.txtPwd);
            this.gbUserLoginInfo.Controls.Add(this.lblRePwd);
            this.gbUserLoginInfo.Controls.Add(this.lblPwd);
            this.gbUserLoginInfo.Controls.Add(this.lblStuNo);
            this.gbUserLoginInfo.Controls.Add(this.txtStuNo);
            this.gbUserLoginInfo.Location = new System.Drawing.Point(29, 30);
            this.gbUserLoginInfo.Name = "gbUserLoginInfo";
            this.gbUserLoginInfo.Size = new System.Drawing.Size(351, 101);
            this.gbUserLoginInfo.TabIndex = 5;
            this.gbUserLoginInfo.TabStop = false;
            this.gbUserLoginInfo.Text = "用户注册信息";
            // 
            // txtRePwd
            // 
            this.txtRePwd.Location = new System.Drawing.Point(80, 66);
            this.txtRePwd.Name = "txtRePwd";
            this.txtRePwd.Size = new System.Drawing.Size(169, 21);
            this.txtRePwd.TabIndex = 5;
            this.txtRePwd.UseSystemPasswordChar = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(80, 40);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(169, 21);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // lblRePwd
            // 
            this.lblRePwd.AutoSize = true;
            this.lblRePwd.Location = new System.Drawing.Point(18, 71);
            this.lblRePwd.Name = "lblRePwd";
            this.lblRePwd.Size = new System.Drawing.Size(53, 12);
            this.lblRePwd.TabIndex = 2;
            this.lblRePwd.Text = "确认密码";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(18, 45);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(29, 12);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密码";
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(18, 20);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(29, 12);
            this.lblStuNo.TabIndex = 4;
            this.lblStuNo.Text = "学号";
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(78, 13);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(123, 21);
            this.txtStuNo.TabIndex = 5;
            this.txtStuNo.Validated += new System.EventHandler(this.txtStuNo_Validated);
            // 
            // lblIdentityCard
            // 
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Location = new System.Drawing.Point(22, 236);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(41, 12);
            this.lblIdentityCard.TabIndex = 16;
            this.lblIdentityCard.Text = "身份证";
            // 
            // txtIdentityCard
            // 
            this.txtIdentityCard.Location = new System.Drawing.Point(80, 233);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(121, 21);
            this.txtIdentityCard.TabIndex = 17;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 447);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.gbUserLoginInfo);
            this.Name = "FrmAddStudent";
            this.Text = "创建学生用户";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbUserLoginInfo.ResumeLayout(false);
            this.gbUserLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBornDate;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbUserLoginInfo;
        private System.Windows.Forms.TextBox txtRePwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblRePwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.TextBox txtIdentityCard;
        private System.Windows.Forms.Label lblIdentityCard;
    }
}