using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using wf13_bookrentalshop.Helpers;

namespace wf13_bookrentalshop
{
    public partial class FrmBooks : Form
    {
        bool isNew = false;     // false(UPDATE) / true(INSERT)

        #region < 생성자: Return이 없음>     
        public FrmBooks()
        {
            InitializeComponent();
        }
        #endregion

        #region < 이벤트 핸들러 : object sender, EventArgs e 포함>
        private void FrmGenre_Load(object sender, EventArgs e)
        {
            isNew = true;       // 신규부터 시작
            RefreshData();
            LoadCboData();  // 콤보박스에 들어갈 데이터 불러오는 함수

            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
        }

      

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation() != true) return;

            SaveData();     // 데이터 저장/수정

            RefreshData();  // 데이터 재조회
            ClearInputs();  // 입력창 클리어
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                MessageBox.Show("삭제할 데이터를 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // FK제약조건으로 지울수 없는 데이터인지 먼저 확인
            using (MySqlConnection conn = new MySqlConnection(Commons.ConnString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string strChkQuery = "SELECT COUNT(*) FROM rentaltbl WHERE bookIdx = @bookIdx";
                MySqlCommand chkCmd = new MySqlCommand(strChkQuery, conn);
                MySqlParameter prmBookIdx= new MySqlParameter("@bookIdx", TxtBookIdx.Text);
                chkCmd.Parameters.Add(prmBookIdx);

                var result = chkCmd.ExecuteScalar();

                if(result.ToString() != "0")
                {
                    MessageBox.Show("이미 대여중인 책입니다.", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }
            }

            if (MessageBox.Show(this, "삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return ;

            // Yes를 누르면 계속 진행
            DeleteData();
            RefreshData();
            ClearInputs();
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)    // 아무것도 선택 안했을때 -1
            {
                var selData = DgvResult.Rows[e.RowIndex];
                //MessageBox.Show(selData.ToString());
                //Debug.WriteLine(selData.ToString());
                Debug.WriteLine(selData.Cells[0].Value);
                Debug.WriteLine(selData.Cells[1].Value);
                TxtBookIdx.Text = selData.Cells[0].Value.ToString();
                TxtAuthor.Text = selData.Cells[1].Value.ToString();
                // TxtBookIdx.ReadOnly = true;        // PK는 수정하면 안됨
                CboDivision.SelectedValue = selData.Cells[2].Value;   //  B001 == B001
                // selData.cells[3] 사용 x
                TxtNames.Text = selData.Cells[4].Value.ToString();
                DtpReleaseDate.Value = (DateTime)selData.Cells[5].Value;
                TxtISBN.Text = selData.Cells[6].Value.ToString() ;
                NudPrice.Value = (decimal)selData.Cells[7].Value;

                isNew = false;      // 수정
            }
        }
        #endregion

        #region < 커스텀 메서드 >

        private void RefreshData()
        {
            // DB divtbl 데이터 조회 DgvResult 뿌림
            try
            {
                //string connectionString = "Server = localhost;Port=3306;Database=bookrentalshop;Uid=root;Pwd=12345";
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // 쿼리 작성
                    var selQuery = @"SELECT b.bookIdx,
	                                        b.Author,
                                            b.Division,
                                            d.Names AS DivNames,
                                            b.Names,
                                            b.ReleaseDate,
                                            b.ISBN,
                                            b.Price
                                    FROM bookstbl AS b
                                    INNER JOIN divtbl AS d
	                                    ON b.Division = d.Division
                                    ORDER BY b.bookIdx ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(selQuery, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "divtbl");     // divtbl로 DataSet 접근가능

                    //DgvResult.DataSource = ds.Tables[0];      // 밑에와 같은 방법임.
                    DgvResult.DataSource = ds;
                    DgvResult.DataMember = "divtbl";
                    // 데이터그리드뷰 컬럼 헤더 제목
                    DgvResult.Columns[0].HeaderText = "번호";
                    DgvResult.Columns[1].HeaderText = "저자명";
                    DgvResult.Columns[2].HeaderText = "책장르";
                    DgvResult.Columns[3].HeaderText = "책장르";
                    DgvResult.Columns[4].HeaderText = "책제목";
                    DgvResult.Columns[5].HeaderText = "출판일자";
                    DgvResult.Columns[6].HeaderText = "ISBN";
                    DgvResult.Columns[7].HeaderText = "책가격";
                    // 컬럼 넓이 또는 보이기
                    DgvResult.Columns[0].Width = 55;
                    DgvResult.Columns[2].Visible = false;   // B001 코드영역 보일필요 없음
                    DgvResult.Columns[5].Width = 78;
                    DgvResult.Columns[7].Width = 80;
                    // 컬럼 정렬
                    DgvResult.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DgvResult.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DgvResult.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"RefreshData() 비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCboData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commons.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) { conn.Open(); }
                    var query = "SELECT Division, Names FROM divtbl";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    var temp = new Dictionary<string, string>();
                    while (reader.Read())
                    {
                        temp.Add(reader[0].ToString(), reader[1].ToString());   // (key)B001, (value)공포/스릴러
                    }
                    // 콤보박스 할당
                    CboDivision.DataSource = new BindingSource(temp, null);
                    CboDivision.DisplayMember = "Value";
                    CboDivision.ValueMember = "Key";
                    CboDivision.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"LoadCboData() 비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ClearInputs()
        {
            TxtBookIdx.Text = TxtAuthor.Text = string.Empty;
            // TxtBookIdx.ReadOnly = false;   // 신규일땐 입력가능
            TxtNames.Text = TxtISBN.Text = string.Empty;
            CboDivision.SelectedIndex = -1;
            DtpReleaseDate.Value = DateTime.Now;    // 오늘 날짜 초기화
            NudPrice.Value = 0;
            TxtBookIdx.Focus(); // 번호는 입력안함
            isNew = true;    // 신규

        }
        private bool CheckValidation()
        {
            var result = true;
            var errorMsg = string.Empty;

            if (string.IsNullOrEmpty(TxtAuthor.Text))
            {
                result = false;
                errorMsg += "● 저자명을 입력하세요.\r\n";

            }

            if (CboDivision.SelectedIndex < 0)
            {
                result = false;
                errorMsg += "● 장르를 선택하세요.\r\n";

            }

            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                result = false;
                errorMsg += "● 책제목을 입력하세요.\r\n";

            }

            if (DtpReleaseDate.Value == null)
            {
                result = false;
                errorMsg += "● 출판일자를 입력하세요.\r\n";

            }

            if (result == false)
            {
                MessageBox.Show(errorMsg, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            else
            {
                return result;
            }

            return true;
        }

        private void SaveData()
        {
            // INSERT부터 시작
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = "";

                    if (isNew)
                    {
                        query = @"INSERT INTO bookstbl
                                            (Author,
                                             Division,
                                             Names,
                                             ReleaseDate,
                                             ISBN,
                                             Price)
                                            VALUES
                                            (@Author,
                                             @Division,
                                             @Names,
                                             @ReleaseDate,
                                             @ISBN,
                                             @Price); ";
                    }
                    else
                    {
                        query = @"UPDATE bookstbl
                                     SET Author = @Author,
                                         Division = @Division,
	                                     Names = @Names,
	                                     ReleaseDate = @ReleaseDate,
	                                     ISBN = @ISBN,
	                                     Price = @Price
                                    WHERE bookIdx = @bookIdx ";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlParameter prmAuthor = new MySqlParameter("@Author", TxtAuthor.Text);
                    MySqlParameter prmDivision = new MySqlParameter("@Division", CboDivision.SelectedValue.ToString());
                    MySqlParameter prmNames = new MySqlParameter("@Names", TxtNames.Text);
                    MySqlParameter prmReleaseDate = new MySqlParameter("@ReleaseDate", DtpReleaseDate.Value);
                    MySqlParameter prmISBN = new MySqlParameter("@ISBN", TxtISBN.Text);
                    MySqlParameter prmPrice = new MySqlParameter("@Price", NudPrice.Value);

                    cmd.Parameters.Add(prmAuthor);
                    cmd.Parameters.Add(prmDivision);
                    cmd.Parameters.Add(prmNames);
                    cmd.Parameters.Add(prmReleaseDate);
                    cmd.Parameters.Add(prmISBN);
                    cmd.Parameters.Add(prmPrice);

                    if (isNew == false)     // update할때는 bookIdx 파라미터를 추가!
                    {
                        MySqlParameter prmBookIdx = new MySqlParameter("@BookIdx", TxtBookIdx.Text);
                        cmd.Parameters.Add(prmBookIdx);
                    }

                    var result = cmd.ExecuteNonQuery();     // INSERT, UPDATE, DELETE 전부다 ExecuteNonQuery사용

                    if (result != 0)
                    {
                        // 저장성공
                        MessageBox.Show("저장성공!!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // 저장실패
                        MessageBox.Show("저장실패!!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void DeleteData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"DELETE FROM bookstbl
                                  WHERE bookIdx = @bookIdx";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlParameter prmBookIdx = new MySqlParameter("@bookIdx", TxtBookIdx.Text);
                    cmd.Parameters.Add(prmBookIdx);

                    var result = cmd.ExecuteNonQuery();     // INSERT, UPDATE, DELETE 전부다 ExecuteNonQuery사용

                    if (result != 0)
                    {
                        // 저장성공
                        MessageBox.Show("삭제성공!!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // 저장실패
                        MessageBox.Show("삭제실패!!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CboDivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        #endregion

        // isNew = true : INSERT / false : UPDATE
        // 그리드뷰 클릭하면 발생하는 이벤트
    }
}
