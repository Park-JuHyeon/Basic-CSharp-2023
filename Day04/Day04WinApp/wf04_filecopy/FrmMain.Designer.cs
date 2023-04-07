namespace wf04_filecopy
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.btnFindSource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTarget = new System.Windows.Forms.TextBox();
            this.btnFindTarget = new System.Windows.Forms.Button();
            this.BtnAsyncCopy = new System.Windows.Forms.Button();
            this.BtnSyncCopy = new System.Windows.Forms.Button();
            this.PgbCopy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source : ";
            // 
            // TxtSource
            // 
            this.TxtSource.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtSource.Location = new System.Drawing.Point(76, 14);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.ReadOnly = true;
            this.TxtSource.Size = new System.Drawing.Size(321, 21);
            this.TxtSource.TabIndex = 1;
            this.TxtSource.TabStop = false;
            // 
            // btnFindSource
            // 
            this.btnFindSource.Location = new System.Drawing.Point(403, 14);
            this.btnFindSource.Name = "btnFindSource";
            this.btnFindSource.Size = new System.Drawing.Size(39, 23);
            this.btnFindSource.TabIndex = 2;
            this.btnFindSource.Text = "...";
            this.btnFindSource.UseVisualStyleBackColor = true;
            this.btnFindSource.Click += new System.EventHandler(this.btnFindSource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Target :";
            // 
            // TxtTarget
            // 
            this.TxtTarget.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtTarget.Location = new System.Drawing.Point(76, 52);
            this.TxtTarget.Name = "TxtTarget";
            this.TxtTarget.ReadOnly = true;
            this.TxtTarget.Size = new System.Drawing.Size(321, 21);
            this.TxtTarget.TabIndex = 3;
            this.TxtTarget.TabStop = false;
            // 
            // btnFindTarget
            // 
            this.btnFindTarget.Location = new System.Drawing.Point(403, 52);
            this.btnFindTarget.Name = "btnFindTarget";
            this.btnFindTarget.Size = new System.Drawing.Size(39, 23);
            this.btnFindTarget.TabIndex = 4;
            this.btnFindTarget.Text = "...";
            this.btnFindTarget.UseVisualStyleBackColor = true;
            this.btnFindTarget.Click += new System.EventHandler(this.btnFindTarget_Click);
            // 
            // BtnAsyncCopy
            // 
            this.BtnAsyncCopy.Location = new System.Drawing.Point(117, 89);
            this.BtnAsyncCopy.Name = "BtnAsyncCopy";
            this.BtnAsyncCopy.Size = new System.Drawing.Size(98, 23);
            this.BtnAsyncCopy.TabIndex = 5;
            this.BtnAsyncCopy.Text = "Async Copy";
            this.BtnAsyncCopy.UseVisualStyleBackColor = true;
            this.BtnAsyncCopy.Click += new System.EventHandler(this.BtnAsyncCopy_Click);
            // 
            // BtnSyncCopy
            // 
            this.BtnSyncCopy.Location = new System.Drawing.Point(253, 89);
            this.BtnSyncCopy.Name = "BtnSyncCopy";
            this.BtnSyncCopy.Size = new System.Drawing.Size(100, 23);
            this.BtnSyncCopy.TabIndex = 6;
            this.BtnSyncCopy.Text = "Sync Copy";
            this.BtnSyncCopy.UseVisualStyleBackColor = true;
            this.BtnSyncCopy.Click += new System.EventHandler(this.BtnSyncCopy_Click);
            // 
            // PgbCopy
            // 
            this.PgbCopy.Location = new System.Drawing.Point(22, 131);
            this.PgbCopy.Name = "PgbCopy";
            this.PgbCopy.Size = new System.Drawing.Size(420, 25);
            this.PgbCopy.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 168);
            this.Controls.Add(this.PgbCopy);
            this.Controls.Add(this.BtnSyncCopy);
            this.Controls.Add(this.BtnAsyncCopy);
            this.Controls.Add(this.btnFindTarget);
            this.Controls.Add(this.btnFindSource);
            this.Controls.Add(this.TxtTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSource);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async File Copy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Button btnFindSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTarget;
        private System.Windows.Forms.Button btnFindTarget;
        private System.Windows.Forms.Button BtnAsyncCopy;
        private System.Windows.Forms.Button BtnSyncCopy;
        private System.Windows.Forms.ProgressBar PgbCopy;
    }
}

