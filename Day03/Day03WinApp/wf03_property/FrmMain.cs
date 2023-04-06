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
        Random rnd = new Random();

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
            if (CboFontfamily.SelectedIndex < 0)
            {
                CboFontfamily.SelectedIndex = 257;  // 디폴트는 나눔고딕 지정!
            }

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

        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PgbDummy.Value = TrbDummy.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form() {     // 모달 폼 닫힐때까지 아무것도 못함
                Text = "Modal Form",
                Width = 300,
                Height = 200,
                Left = 10,
                Top = 20,
                BackColor = Color.Crimson,
                StartPosition = FormStartPosition.CenterParent,
            };
            frm.ShowDialog();   // 자식창 띄우기
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form()       // 모달리스 폼 안닫혀도 접근 가능
            {
                Text = "Mdaless Form",
                Width = 300,
                Height = 200,
                StartPosition = FormStartPosition.CenterParent,     // Modaless는 Centerparent 안먹힘
                BackColor = Color.GreenYellow
                
            };

            frm.Show();

        }

        // 기본적으로 MessageBox는 모달.
        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(txtResult.Text);  // 기본
            // MessageBox.Show(txtResult.Text, caption: "메시지창");   // 캡션 사용방법
            // MessageBox.Show(txtResult.Text, "메시지창", MessageBoxButtons.YesNo);   // 버튼추가
            // MessageBox.Show(txtResult.Text, "메시지창", MessageBoxButtons.YesNo, MessageBoxIcon.Question);   // 아이콘 추가
            // MessageBox.Show(txtResult.Text, "메시지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                               // MessageBoxDefaultButton.Button2);
            // 여기까지는 알아야함!

            MessageBox.Show(txtResult.Text, "메시지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                               MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);  // 글자 오른쪽 정렬

            //MessageBox.Show(text: txtResult.Text, caption: "커스텀", icon : MessageBoxIcon.Asterisk,
            //                options: MessageBoxOptions.DefaultDesktopOnly);
        }

        void ChangeIndent()
        {
            if (RdoNormal.Checked)      // 라디오버튼 추가의 이벤트
            {
                txtResult.Text = txtResult.Text.Trim();
            }
            else if (RdoIndent.Checked)
            {
                txtResult.Text = "    " + txtResult.Text;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(rnd.Next(50).ToString());
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode != null)
            {
                TrvDummy.SelectedNode.Nodes.Add(rnd.Next(50, 100).ToString());
                TrvDummy.SelectedNode.Expand();     // 트리노드 하위것 펼쳐주기 , 반대 .Collapse
                TreeToList();
            }
        }

        void TreeToList()
        {
            LsvDummy.Items.Clear();     // 리스트뷰, 트리뷰 모든 아이템을 제거 초기화메서드
            foreach (TreeNode item in TrvDummy.Nodes)
            {
                TreeToList(item);
            }
        }

        private void TreeToList(TreeNode item)
        {
            LsvDummy.Items.Add(new ListViewItem(new[] { item.Text, item.FullPath.ToString() }));

            foreach (TreeNode node in item.Nodes)
            {
                TreeToList(node);       // 재귀호출 : 본인이 본인을 다시부름
            }
        }

        private void RdeNormal_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIndent();
        }

        private void RdoIndent_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIndent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            PcbDummy.Image = Bitmap.FromFile("yattong.png");
        }

        private void PcbDummy_Click(object sender, EventArgs e)
        {
            if (PcbDummy.SizeMode == PictureBoxSizeMode.Normal)
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
