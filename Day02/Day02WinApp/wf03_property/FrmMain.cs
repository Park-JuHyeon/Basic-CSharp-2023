using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf03_property
{
    public partial class FrmMain : Form
    {
        public FrmMain()        // 생성자에는 되도록 값 설정부분 넣지말것
        {                       // Form_Load() 이벤트 핸들러에 작성할 것
            InitializeComponent();

            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            GbxMain.Text = "컨트롤 학습";
            var fonts = FontFamily.Families.ToList();   // 내 OS에 있는 모든 폰트이름 가져오기
            foreach (var font in fonts)
            {
                CboFontfamily.Items.Add(font.Name);
            }
            // 글자크기 최소값, 최대값지정
            NudFondSize.Minimum = 5;
            NudFondSize.Maximum = 40;
            // 텍스트박스 초기화
            txtResult.Text = "안녕 윈폼즈";

            NudFondSize.Value = 9;
            
        }
        /// <summary>
        /// 글자 스타일, 크기, 글자체를 변경해주는 메서드
        /// </summary>
        private void ChangeFontStyle()
        {
            if (CboFontfamily.SelectedIndex < 0) return;

            FontStyle style = FontStyle.Regular;    // 폰트스타일 기본
            if (ChkBold.Checked == true) 
            {
                style |= FontStyle.Bold;    // Bit연산자 OR 사용
            }

            if (ChkItalic.Checked == true)
            {
                style |= FontStyle.Italic;
            }

            decimal fontSize = NudFondSize.Value;

            txtResult.Font = new Font((string)CboFontfamily.SelectedItem, (float)fontSize, style);
        }

        private void CboFontfamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void NudFondSize_ValueChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        
    }
}
