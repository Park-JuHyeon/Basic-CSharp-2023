﻿namespace wf13_bookrentalshop
{
    partial class FrmBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBooks));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.DtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.CboDivision = new System.Windows.Forms.ComboBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.TxtNames = new System.Windows.Forms.TextBox();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBookIdx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DgvResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(574, 455);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // DgvResult
            // 
            this.DgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Location = new System.Drawing.Point(3, 3);
            this.DgvResult.MultiSelect = false;
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.ReadOnly = true;
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.Size = new System.Drawing.Size(226, 449);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.NudPrice);
            this.groupBox1.Controls.Add(this.DtpReleaseDate);
            this.groupBox1.Controls.Add(this.CboDivision);
            this.groupBox1.Controls.Add(this.BtnDel);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.TxtNames);
            this.groupBox1.Controls.Add(this.TxtISBN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtAuthor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtBookIdx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "책정보 입력";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NudPrice
            // 
            this.NudPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NudPrice.Location = new System.Drawing.Point(64, 240);
            this.NudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(246, 23);
            this.NudPrice.TabIndex = 7;
            this.NudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpReleaseDate.Location = new System.Drawing.Point(64, 172);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(246, 23);
            this.DtpReleaseDate.TabIndex = 5;
            this.DtpReleaseDate.ValueChanged += new System.EventHandler(this.DtpReleaseDate_ValueChanged);
            // 
            // CboDivision
            // 
            this.CboDivision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.Location = new System.Drawing.Point(64, 107);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.Size = new System.Drawing.Size(246, 23);
            this.CboDivision.TabIndex = 3;
            this.CboDivision.SelectedIndexChanged += new System.EventHandler(this.CboDivision_SelectedIndexChanged);
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDel.Location = new System.Drawing.Point(239, 279);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(72, 29);
            this.BtnDel.TabIndex = 10;
            this.BtnDel.Text = "삭제";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(161, 279);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(72, 29);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(83, 279);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(72, 29);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtNames
            // 
            this.TxtNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNames.Location = new System.Drawing.Point(64, 136);
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.Size = new System.Drawing.Size(246, 23);
            this.TxtNames.TabIndex = 4;
            // 
            // TxtISBN
            // 
            this.TxtISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtISBN.Location = new System.Drawing.Point(64, 201);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(246, 23);
            this.TxtISBN.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "책제목";
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAuthor.Location = new System.Drawing.Point(64, 69);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(246, 23);
            this.TxtAuthor.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "책가격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "저자명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "책장르";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "출판일";
            // 
            // TxtBookIdx
            // 
            this.TxtBookIdx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBookIdx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtBookIdx.Location = new System.Drawing.Point(64, 40);
            this.TxtBookIdx.Name = "TxtBookIdx";
            this.TxtBookIdx.ReadOnly = true;
            this.TxtBookIdx.Size = new System.Drawing.Size(246, 23);
            this.TxtBookIdx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "책번호";
            // 
            // FrmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 455);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(590, 360);
            this.Name = "FrmBooks";
            this.Text = "책정보 관리";
            this.Load += new System.EventHandler(this.FrmGenre_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBookIdx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNames;
        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboDivision;
        private System.Windows.Forms.DateTimePicker DtpReleaseDate;
        private System.Windows.Forms.NumericUpDown NudPrice;
    }
}