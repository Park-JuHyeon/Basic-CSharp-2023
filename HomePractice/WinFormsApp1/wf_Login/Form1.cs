using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string UserID = textBox1.Text;
            string UserPW = textBox2.Text;

            if(UserID == "aaaa" &&  UserPW == "1234")
            {
                MessageBox.Show("로그인 성공!", "로그인");
            }
            else
            {
                MessageBox.Show("로그인 실패!", "로그인");
            }


        }
    }
}
