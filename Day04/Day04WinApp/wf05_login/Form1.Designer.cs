namespace wf05_login
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtPw = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "패스워드";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(90, 34);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(139, 21);
            this.TxtID.TabIndex = 1;
            this.TxtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // TxtPw
            // 
            this.TxtPw.Location = new System.Drawing.Point(90, 68);
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.Size = new System.Drawing.Size(139, 21);
            this.TxtPw.TabIndex = 2;
            this.TxtPw.TextChanged += new System.EventHandler(this.TxtPw_TextChanged);
            this.TxtPw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPw_KeyPress);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(154, 108);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(152, 149);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(109, 12);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "로그인 성공? 실패?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 209);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPw);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtPw;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label lblResult;
    }
}

