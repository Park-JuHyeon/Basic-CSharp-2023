﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf06_listview
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexVal = CboView.SelectedIndex;
            switch (indexVal)
            {
                case  0:   // Details
                    LsvFiles.View = View.Details;
                    break;
                case 1:
                    LsvFiles.View = View.List;
                    break;
                case 2:
                    LsvFiles.View = View.Tile;
                    break;    
                case 3:
                    LsvFiles.View = View.SmallIcon;
                    break;
                case 4:
                    LsvFiles.View= View.LargeIcon;
                    break;
                default:
                    LsvFiles.View = View.Details; 
                    break;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string currFolder = Environment.CurrentDirectory;       // 현재프로그램 실행되는 경로 .\bin\debug\
            DirectoryInfo di = new DirectoryInfo(currFolder);
            FileInfo[] files = di.GetFiles();       // 현재 디렉토리에 파일배열

            LsvFiles.BeginUpdate();     // 업데이트 완료전까지는 UI갱신 중지
            LsvFiles.View = View.Details;  // 리스트뷰 화면 자세히보기로
            CboView.SelectedIndex = 0;

            // ListView 사용할 아이콘 지정  // 코딩으로 넣어줘도 되고
            //LsvFiles.LargeImageList = ImgLargeIcon;
            //LsvFiles.SmallImageList = ImgSmallIcon;

            foreach ( FileInfo file in files )
            {
                // 각 파일별로 ListViewItem 객체를 만들어서 하나씩 지정
                ListViewItem lvi = new ListViewItem(file.Name);     // 리스트뷰 첫번째값
                lvi.SubItems.Add(file.LastWriteTime.ToString());

                var ext = Path.GetExtension(file.Name);
                var extName = "";
                switch (ext)
                {
                    case ".exe":
                        extName = "응용 프로그램";
                        break;
                    case ".config":
                        extName = "Configuation 원본 파일";
                        break;
                    case ".pdb":
                        extName = "Program Debug Database";
                        break;
                    default:
                        extName = "기타";
                        break;
                }

                if (ext == ".exe")
                {
                    lvi.ImageIndex = 0;
                }
                else
                {
                    lvi.ImageIndex = 1;
                }

                lvi.SubItems.Add(extName);
                var fileSize = file.Length / 1024;
                lvi.SubItems.Add(string.Format("{0} KB", fileSize));
                // 아이콘은 나중에..

                LsvFiles.Items.Add(lvi);
                
            }
            LsvFiles.EndUpdate();   // 업데이트 끝났으니 UI갱신
        }
    }
}
