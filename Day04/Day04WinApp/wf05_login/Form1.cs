using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf05_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           if (TxtID.Text == "abcd" && TxtPw.Text == "1234")
            {
                lblResult.Text = "로그인 성공";
            }
            else
            {
                lblResult.Text = "로그인 실패!";
            }
         
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPw_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
