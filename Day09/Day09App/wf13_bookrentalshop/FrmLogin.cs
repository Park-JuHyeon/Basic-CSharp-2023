using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace wf13_bookrentalshop
{
    public partial class FrmLogin : Form
    {
        private bool IsLogined = false;     // 로그인 성공했는지 변수

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            IsLogined = LoginProcess();     // 로그인을 성공해야만 true가 됨

            if (IsLogined)
            {
                this.Close();
            }

        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Environment.Exit(0);     // 가장 완벽하게 프로그램 종료시키는 메서드
        }

        // 이게 없으면 X버튼이나 Alt+F4 했을때 메인폼 나타남..
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsLogined != true)
            {
                //로그인안되어있을때 창을 닫으면 프로그램 모두 종료
                Environment.Exit(0);
            }

        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)      // 엔터키를 누르면
            {
                BtnLogin_Click(sender, e);  // 버튼클릭 이벤트 핸들러 호출
            }
        }

        // DB Usertbl에서 정보확인 로그인처리
        private bool LoginProcess()
        {
            // Validation check
            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("유저아이디를 입력하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("패스워드를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string strUserId = "";
            string strPassword = "";

            try
            {
                //string connectionString = "Server = localhost;Port=3306;Database=bookrentalshop;Uid=root;Pwd=12345";
                // DB처리
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    conn.Open();

                    #region < DB쿼리를 위한 구성 >
                    string selQuery = @"SELECT userId
	                                         , password
                                        FROM usertbl
                                        WHERE userID = @userID
                                        AND password = @password";

                    MySqlCommand selCmd = new MySqlCommand(selQuery, conn);
                    // @userID, @password 파라미터 할당
                    MySqlParameter prmUserID = new MySqlParameter("@userID", TxtUserId.Text);
                    MySqlParameter prmPassword = new MySqlParameter("@password", TxtPassword.Text);
                    selCmd.Parameters.Add(prmUserID);
                    selCmd.Parameters.Add(prmPassword);
                    #endregion

                    MySqlDataReader reader = selCmd.ExecuteReader();    // 실행한 다음에 userId, password
                    if (reader.Read())
                    {
                        strUserId = reader["userId"] != null ? reader["userId"].ToString() : "-";
                        strPassword = reader["password"] != null ? reader["password"].ToString() : "--";

                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"로그인 정보가 없습니다!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }



                }   // conn.Close();

                MessageBox.Show($"{strUserId} / {strPassword}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적인 오류! : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return false;
        }

        // 유저아이디 텍스트박스에서 엔터를 치면 패스워드 텍스트박스로 포커스 이동
        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
