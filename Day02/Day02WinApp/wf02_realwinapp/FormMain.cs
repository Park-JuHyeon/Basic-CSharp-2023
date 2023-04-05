﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf02_realwinapp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btnOK 클릭 이벤트에 대한 처리메서드 만듬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼클릭!!", "클릭", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            btnOK.Text = "뭘로바꿔";
            return;
        }

        private void btnOK_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("마우스만 올려도 이벤트가 발생해요!");
        }
    }
}
