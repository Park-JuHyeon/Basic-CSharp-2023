﻿namespace wf03_property
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.GbxMain = new System.Windows.Forms.GroupBox();
            this.NudFondSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.ChkItalic = new System.Windows.Forms.CheckBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.CboFontfamily = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrbDummy = new System.Windows.Forms.TrackBar();
            this.PgbDummy = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnMsgBox = new System.Windows.Forms.Button();
            this.BtnModaless = new System.Windows.Forms.Button();
            this.BtnModal = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TrvDummy = new System.Windows.Forms.TreeView();
            this.LsvDummy = new System.Windows.Forms.ListView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnAddChild = new System.Windows.Forms.Button();
            this.RdoNormal = new System.Windows.Forms.RadioButton();
            this.RdoIndent = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PcbDummy = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.GbxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFondSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbDummy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDummy)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxMain
            // 
            this.GbxMain.Controls.Add(this.RdoIndent);
            this.GbxMain.Controls.Add(this.RdoNormal);
            this.GbxMain.Controls.Add(this.NudFondSize);
            this.GbxMain.Controls.Add(this.label2);
            this.GbxMain.Controls.Add(this.txtResult);
            this.GbxMain.Controls.Add(this.ChkItalic);
            this.GbxMain.Controls.Add(this.ChkBold);
            this.GbxMain.Controls.Add(this.CboFontfamily);
            this.GbxMain.Controls.Add(this.lblFont);
            this.GbxMain.Location = new System.Drawing.Point(12, 12);
            this.GbxMain.Name = "GbxMain";
            this.GbxMain.Size = new System.Drawing.Size(367, 202);
            this.GbxMain.TabIndex = 0;
            this.GbxMain.TabStop = false;
            this.GbxMain.Text = "컨트롤학습";
            // 
            // NudFondSize
            // 
            this.NudFondSize.Location = new System.Drawing.Point(101, 70);
            this.NudFondSize.Name = "NudFondSize";
            this.NudFondSize.Size = new System.Drawing.Size(120, 23);
            this.NudFondSize.TabIndex = 4;
            this.NudFondSize.ValueChanged += new System.EventHandler(this.NudFondSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "글자크기";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 103);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(355, 93);
            this.txtResult.TabIndex = 5;
            // 
            // ChkItalic
            // 
            this.ChkItalic.AutoSize = true;
            this.ChkItalic.Location = new System.Drawing.Point(286, 35);
            this.ChkItalic.Name = "ChkItalic";
            this.ChkItalic.Size = new System.Drawing.Size(62, 19);
            this.ChkItalic.TabIndex = 3;
            this.ChkItalic.Text = "이탤릭";
            this.ChkItalic.UseVisualStyleBackColor = true;
            this.ChkItalic.CheckedChanged += new System.EventHandler(this.ChkItalic_CheckedChanged);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Location = new System.Drawing.Point(230, 35);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(50, 19);
            this.ChkBold.TabIndex = 2;
            this.ChkBold.Text = "볼드";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // CboFontfamily
            // 
            this.CboFontfamily.FormattingEnabled = true;
            this.CboFontfamily.Location = new System.Drawing.Point(101, 34);
            this.CboFontfamily.Name = "CboFontfamily";
            this.CboFontfamily.Size = new System.Drawing.Size(121, 23);
            this.CboFontfamily.TabIndex = 1;
            this.CboFontfamily.SelectedIndexChanged += new System.EventHandler(this.CboFontfamily_SelectedIndexChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(38, 35);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(43, 15);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "글자체";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PgbDummy);
            this.groupBox1.Controls.Add(this.TrbDummy);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "트랙바 및 진행바";
            // 
            // TrbDummy
            // 
            this.TrbDummy.Location = new System.Drawing.Point(6, 22);
            this.TrbDummy.Maximum = 20;
            this.TrbDummy.Name = "TrbDummy";
            this.TrbDummy.Size = new System.Drawing.Size(352, 45);
            this.TrbDummy.TabIndex = 6;
            this.TrbDummy.Scroll += new System.EventHandler(this.TrbDummy_Scroll);
            // 
            // PgbDummy
            // 
            this.PgbDummy.Location = new System.Drawing.Point(6, 77);
            this.PgbDummy.Maximum = 20;
            this.PgbDummy.Name = "PgbDummy";
            this.PgbDummy.Size = new System.Drawing.Size(352, 30);
            this.PgbDummy.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnModal);
            this.groupBox2.Controls.Add(this.BtnModaless);
            this.groupBox2.Controls.Add(this.BtnMsgBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "모달/리스 와 메시지창";
            // 
            // BtnMsgBox
            // 
            this.BtnMsgBox.Location = new System.Drawing.Point(190, 33);
            this.BtnMsgBox.Name = "BtnMsgBox";
            this.BtnMsgBox.Size = new System.Drawing.Size(144, 30);
            this.BtnMsgBox.TabIndex = 10;
            this.BtnMsgBox.Text = "MessageBox";
            this.BtnMsgBox.UseVisualStyleBackColor = true;
            this.BtnMsgBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // BtnModaless
            // 
            this.BtnModaless.Location = new System.Drawing.Point(101, 33);
            this.BtnModaless.Name = "BtnModaless";
            this.BtnModaless.Size = new System.Drawing.Size(83, 30);
            this.BtnModaless.TabIndex = 9;
            this.BtnModaless.Text = "Modaless";
            this.BtnModaless.UseVisualStyleBackColor = true;
            this.BtnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // BtnModal
            // 
            this.BtnModal.Location = new System.Drawing.Point(20, 33);
            this.BtnModal.Name = "BtnModal";
            this.BtnModal.Size = new System.Drawing.Size(75, 30);
            this.BtnModal.TabIndex = 8;
            this.BtnModal.Text = "Modal";
            this.BtnModal.UseVisualStyleBackColor = true;
            this.BtnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAddChild);
            this.groupBox3.Controls.Add(this.BtnAdd);
            this.groupBox3.Controls.Add(this.LsvDummy);
            this.groupBox3.Controls.Add(this.TrvDummy);
            this.groupBox3.Location = new System.Drawing.Point(385, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 241);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "트리뷰/ 리스트뷰";
            // 
            // TrvDummy
            // 
            this.TrvDummy.Location = new System.Drawing.Point(6, 22);
            this.TrvDummy.Name = "TrvDummy";
            this.TrvDummy.Size = new System.Drawing.Size(178, 180);
            this.TrvDummy.TabIndex = 11;
            // 
            // LsvDummy
            // 
            this.LsvDummy.HideSelection = false;
            this.LsvDummy.Location = new System.Drawing.Point(190, 22);
            this.LsvDummy.Name = "LsvDummy";
            this.LsvDummy.Size = new System.Drawing.Size(177, 180);
            this.LsvDummy.TabIndex = 12;
            this.LsvDummy.UseCompatibleStateImageBehavior = false;
            this.LsvDummy.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(28, 208);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = "루트 추가";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnAddChild
            // 
            this.BtnAddChild.Location = new System.Drawing.Point(109, 208);
            this.BtnAddChild.Name = "BtnAddChild";
            this.BtnAddChild.Size = new System.Drawing.Size(75, 23);
            this.BtnAddChild.TabIndex = 14;
            this.BtnAddChild.Text = "자식 추가";
            this.BtnAddChild.UseVisualStyleBackColor = true;
            this.BtnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            // 
            // RdoNormal
            // 
            this.RdoNormal.AutoSize = true;
            this.RdoNormal.Checked = true;
            this.RdoNormal.Location = new System.Drawing.Point(227, 70);
            this.RdoNormal.Name = "RdoNormal";
            this.RdoNormal.Size = new System.Drawing.Size(49, 19);
            this.RdoNormal.TabIndex = 6;
            this.RdoNormal.TabStop = true;
            this.RdoNormal.Text = "일반";
            this.RdoNormal.UseVisualStyleBackColor = true;
            this.RdoNormal.CheckedChanged += new System.EventHandler(this.RdeNormal_CheckedChanged);
            // 
            // RdoIndent
            // 
            this.RdoIndent.AutoSize = true;
            this.RdoIndent.Location = new System.Drawing.Point(282, 70);
            this.RdoIndent.Name = "RdoIndent";
            this.RdoIndent.Size = new System.Drawing.Size(73, 19);
            this.RdoIndent.TabIndex = 6;
            this.RdoIndent.Text = "들여쓰기";
            this.RdoIndent.UseVisualStyleBackColor = true;
            this.RdoIndent.CheckedChanged += new System.EventHandler(this.RdoIndent_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnLoad);
            this.groupBox4.Controls.Add(this.PcbDummy);
            this.groupBox4.Location = new System.Drawing.Point(385, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 267);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "픽쳐박스";
            // 
            // PcbDummy
            // 
            this.PcbDummy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PcbDummy.Location = new System.Drawing.Point(12, 23);
            this.PcbDummy.Name = "PcbDummy";
            this.PcbDummy.Size = new System.Drawing.Size(290, 227);
            this.PcbDummy.TabIndex = 0;
            this.PcbDummy.TabStop = false;
            this.PcbDummy.Click += new System.EventHandler(this.PcbDummy_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(308, 23);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(74, 23);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "로드";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 538);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbxMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "속성확인";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GbxMain.ResumeLayout(false);
            this.GbxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFondSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbDummy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbDummy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxMain;
        private System.Windows.Forms.NumericUpDown NudFondSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox ChkItalic;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.ComboBox CboFontfamily;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar PgbDummy;
        private System.Windows.Forms.TrackBar TrbDummy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnModal;
        private System.Windows.Forms.Button BtnModaless;
        private System.Windows.Forms.Button BtnMsgBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView LsvDummy;
        private System.Windows.Forms.TreeView TrvDummy;
        private System.Windows.Forms.Button BtnAddChild;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.RadioButton RdoNormal;
        private System.Windows.Forms.RadioButton RdoIndent;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.PictureBox PcbDummy;
    }
}

