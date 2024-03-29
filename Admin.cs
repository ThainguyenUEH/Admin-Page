using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            DBQuery.Error += QuestionDatabaseFailedConnect;
            QuestionsDataView.ForeColor = System.Drawing.Color.Black;
            StudentsDataView.ForeColor = System.Drawing.Color.Black;
            AccountsDataView.ForeColor = System.Drawing.Color.Black;
        }

        private readonly int ConnectionTime = 1000;
        private bool IsCellsChanged;

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataTable table = QuestionsDataView.DataSource as DataTable;
            table.Rows.Add(null, null, null, null, null, null);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            QuestionDBLoad();
            StudentsDBLoad();
            AccountsDBLoad();

            if (QuestionsDataView.RowCount == 0)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuestionDBLoad()
        {
            DataTable tb;
            for (int i = 0; i < ConnectionTime; i++)
            {
                QuestionsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tb = DBQuery.ExecuteQuery($"SELECT * FROM {DBQuery.QuestionsTable}");
                QuestionsDataView.DataSource = tb;
                if (tb != null) break;
            }
        }

        private void StudentsDBLoad()
        {
            DataTable tb;
            for (int i = 0; i < ConnectionTime; i++)
            {
                StudentsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tb = DBQuery.ExecuteQuery($"SELECT * FROM {DBQuery.StudentTableName}");
                StudentsDataView.DataSource = tb;
                if (tb != null) break;
            }
        }

        private void AccountsDBLoad()
        {
            DataTable tb;
            for (int i = 0; i < ConnectionTime; i++)
            {
                AccountsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tb = DBQuery.ExecuteQuery($"SELECT * FROM {DBQuery.AccountsTableName}");
                AccountsDataView.DataSource = tb;
                if (tb != null) break;
            }
        }

        private void QuestionDatabaseFailedConnect(Exception ex)
        {
            MessageBox.Show($"Lỗi SQL! {ex.Message}", "Lỗi SQL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConnectButtonQ_Click(object sender, EventArgs e)
        {
            QuestionDBLoad();
        }

        private void RemoveButtonQ_Click(object sender, EventArgs e)
        {
            if (QuestionsDataView.SelectedRows.Count > 0)
            {
                int selectedIndex = QuestionsDataView.SelectedRows[0].Index;
                QuestionsDataView.Rows.RemoveAt(selectedIndex);
            }
        }

        private void StartServerBut_Click(object sender, EventArgs e)
        {
            if (GamePasswordTxtBox.Text == "" || PlayingTimeTxtBox.Text == "")
            {
                MessageBox.Show("Mật khẩu phòng và thời gian chơi không thể để trống!", "Lỗi chưa nhập đầy đủ thông tin cài đặt game!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string adminConfig = $"{GamePasswordTxtBox.Text}\n{PlayingTimeTxtBox.Text}";
            File.WriteAllText(@"C:\Users\ACER\Desktop\Programs\Doan\TreasureAdmin.txt", adminConfig);
        }

        private void GamePasswordTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void PlayingTimeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ConnectButtonS_Click(object sender, EventArgs e)
        {
            StudentsDBLoad();
        }

        private void ConnectButtonA_Click(object sender, EventArgs e)
        {
            AccountsDBLoad();
        }

        private void SaveButtonQ_Click(object sender, EventArgs e)
        {
        }

        private void QuestionsDataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IsCellsChanged = true;
        }

        private void StudentsDataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IsCellsChanged = true;
        }

        private void AccountsDataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IsCellsChanged = true;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            if (IsCellsChanged && MessageBox.Show("Dữ liệu của các bảng đã bị thay đổi bạn có muốn lưu lại không?", "Dữ liệu chưa được lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Save_Click(sender, e);
            }
            else Application.Exit();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Admin_Load(sender, e);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DBSet set = new DBSet();
            set.ErrorSave += CannotSave;


            if (set.QuestionTableSave(QuestionsDataView)
            && set.StudentTableSave(StudentsDataView)
            && set.AccountTableSave(AccountsDataView))
                CompleteSave();
        }

        private void CompleteSave()
        {
            IsCellsChanged = false;
            MessageBox.Show("Dữ liệu được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void CannotSave(string message)
        {
            MessageBox.Show(message, "Lỗi khi lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (QuestionsDataView.SelectedRows.Count > 0)
            {
                DeleteSelectedRow(QuestionsDataView, "QUESTION");
            }
            else if (StudentsDataView.SelectedRows.Count > 0)
            {
                DeleteSelectedRow(StudentsDataView, "PLAYER");
            }
            else if (AccountsDataView.SelectedRows.Count > 0)
            {
                DeleteSelectedRow(AccountsDataView, "ACCOUNT");
            }
        }

        private void DeleteSelectedRow(DataGridView dataGridView, string tableName)
        {
            int selectedIndex = dataGridView.SelectedRows[0].Index;

            string idColumnName = dataGridView.Columns[0].Name;

            if (dataGridView.Name == DBQuery.StudentTableName || dataGridView.Name == DBQuery.AccountsTableName)
            {
                idColumnName = "STUDENTID";
            }

            string ID = dataGridView.Rows[selectedIndex].Cells[idColumnName].Value.ToString();

            dataGridView.Rows.RemoveAt(selectedIndex);


            if (!string.IsNullOrEmpty(ID))
            {
                DeleteFromDatabase(tableName, ID);
            }
        }


        private void DeleteFromDatabase(string tableName, string ID)
        {
            using (SqlConnection con = new SqlConnection(DBQuery.ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    con.Open();
                    cmd.Connection = con;

                    string deleteQuery;
                    if (tableName == DBQuery.QuestionsTable)
                    {
                        deleteQuery = $"DELETE FROM {tableName} WHERE ID = @ID";
                    }
                    else
                    {
                        deleteQuery = $"DELETE FROM {tableName} WHERE STUDENTID = @ID";
                    }
                    cmd.CommandText = deleteQuery;
                    cmd.Parameters.AddWithValue("@ID", ID);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Lỗi SQL! {ex.Message}", "Lỗi SQL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

    }
}
