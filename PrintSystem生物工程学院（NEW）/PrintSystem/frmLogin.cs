using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms; 

namespace PrintSystem
{
    public partial class frmLogin : Form
    {

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                Main f = new Main(textBox2.Text.Trim(), textBox3.Text.Trim());
                CRD.WinUI.Shared.MainForm = f;
                this.Hide();
                f.Show();
               
            }
            else
            {
                Main f = new Main(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());
                CRD.WinUI.Shared.MainForm = f;
                this.Hide();
                f.Show();
            }
        }

        public frmLogin()
        { 
            InitializeComponent();
        }
    }
}