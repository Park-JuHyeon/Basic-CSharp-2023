using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNumberApp
{
    public partial class Form1 : Form
    {

        private int findNumber = 0;
        private int Chance = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            findNumber = rand.Next(1, 21);
            Chance = 10;
            Display.Text = "맞출 숫자를 입력하세요";


        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            int inputNumber = Int32.Parse(TxtNum.Text);

            if(inputNumber == findNumber)
            {
                Display.Text = "You Win!!";
            }
            else
            {
                Chance--;
                Display.Text = "기회는" + Chance + "번 남았습니다.";
            }
            if (Chance <= 0)
            {
                Display.Text = "You Lose..";
            }
        }
    }
}
