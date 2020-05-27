using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchool
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
            btnShow = false;
        }
        public String ShowInfo
        {
            set
            {
                this.lbInfo.Text = value;
            }
        }
        public bool btnShow
        {
            set
            {
                this.btnOk.Visible = value;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
