using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf04_filecopy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnFindSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();   // 모달창
            if (result == DialogResult.OK)
            {
                TxtSource.Text = dialog.FileName;
            }
        }

        private void btnFindTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtTarget.Text = dialog.FileName;
            }
        }

        // 일반적인 동기식 파일복사
        private void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(TxtSource.Text, TxtTarget.Text);
        }

        private long CopySync(string fromFile, string toFile)
        {
            BtnAsyncCopy.Enabled = false;   // 비동기버튼(AsyncCopy) 일시 비활성화
            long totalCopied = 0;

            using (FileStream fromStream = new FileStream(fromFile, FileMode.Open))
            {   // 원본파일은 열고
                using (FileStream toStream = new FileStream(toFile, FileMode.Create))
                {   // 타겟파일은 생성
                    byte[] buffer = new byte[1024 * 1024];  // 1MB의 버퍼
                    int nRead = 0;
                    while ((nRead = fromStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        toStream.Write(buffer, 0, nRead);   // 버퍼를 0 부터 읽은 개수길이만큼
                        totalCopied += nRead;

                        // 프로그래스바에 표시
                        PgbCopy.Value = (int)((double)totalCopied / (double)fromStream.Length) * PgbCopy.Maximum;
                    }
                }
            }
            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }
        // 비동기는 호출할때는 await사용, 구현할때 async 사용, 둘은 항상 함께 사용
        private async Task<long> CopyASync(string fromFile, string toFile)
        {
            BtnSyncCopy.Enabled = false;        // 동기복사버튼 비활성화
            long totalCopied = 0;

            using (FileStream fromStream = new FileStream(fromFile, FileMode.Open))
            {   // 원본파일은 열고
                using (FileStream toStream = new FileStream(toFile, FileMode.Create))
                {   // 타겟파일은 생성
                    byte[] buffer = new byte[1024 * 1024];  // 1MB의 버퍼
                    int nRead = 0;
                    while ((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);  
                        totalCopied += nRead;

                        // 프로그래스바에 표시
                        PgbCopy.Value = (int)((double)totalCopied / (double)fromStream.Length) * PgbCopy.Maximum;
                    }
                }
            }
            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }

        private async void BtnAsyncCopy_Click(object sender, EventArgs e)   // async와 await는 한쌍이다 무조건 같이써야함!
        {
            long totalCopied = await CopyASync(TxtSource.Text, TxtTarget.Text);

        }

        
    }
}
