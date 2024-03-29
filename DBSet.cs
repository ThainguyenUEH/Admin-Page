using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Admin
{
    internal class DBSet
    {
        public delegate void CannotSave(string message);
        public event CannotSave ErrorSave;

        public bool QuestionTableSave(DataGridView questions)
        {
            if (DoDataGridViewHaveAnyEmptyCells(questions, "Question"))
            {
                ErrorSave?.Invoke("Có trường dữ liệu ô bị trống!");
                ErrorSave = null;
                return false;
            }

            using (SqlConnection con = new SqlConnection(DBQuery.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    SqlTransaction transaction = con.BeginTransaction();
                    cmd.Transaction = transaction;
                    try
                    {
                        foreach (DataGridViewRow row in questions.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string question = row.Cells[DBQuery.QuestionColumn].Value.ToString();
                                string answer = row.Cells[DBQuery.QuestionAnswerColumn].Value.ToString();
                                string choice1 = row.Cells[DBQuery.QuestionChoice1Column].Value.ToString();
                                string choice2 = row.Cells[DBQuery.QuestionChoice2Column].Value.ToString();
                                string choice3 = row.Cells[DBQuery.QuestionChoice3Column].Value.ToString();

                                string checkExistQuery = $"SELECT COUNT(*) FROM {DBQuery.QuestionsTable} WHERE Question = @question";
                                cmd.CommandText = checkExistQuery;
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@question", question);
                                int existingCount = (int)cmd.ExecuteScalar();

                                if (existingCount == 0)
                                {
                                    string query = $"INSERT INTO {DBQuery.QuestionsTable} (Question, Answer, Choice1, Choice2, Choice3) VALUES (@question, @answer, @choice1, @choice2, @choice3)";
                                    cmd.CommandText = query;
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@question", question);
                                    cmd.Parameters.AddWithValue("@answer", answer);
                                    cmd.Parameters.AddWithValue("@choice1", choice1);
                                    cmd.Parameters.AddWithValue("@choice2", choice2);
                                    cmd.Parameters.AddWithValue("@choice3", choice3);

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        ErrorSave?.Invoke(ex.Message);
                        return false;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        public bool StudentTableSave(DataGridView students)
        {
            if (DoDataGridViewHaveAnyEmptyCells(students, "Student"))
            {
                ErrorSave?.Invoke("Có trường dữ liệu ô bị trống!");
                ErrorSave = null;
                return false;
            }

            using (SqlConnection con = new SqlConnection(DBQuery.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    SqlTransaction transaction = con.BeginTransaction();
                    cmd.Transaction = transaction;
                    try
                    {
                        foreach (DataGridViewRow row in students.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string name = row.Cells[DBQuery.StudentNameColumn].Value.ToString();
                                int scores = DBNull.Value.Equals(row.Cells[DBQuery.StudentScoreColumn].Value) ? 0 : Convert.ToInt32(row.Cells[DBQuery.StudentScoreColumn].Value);
                                string attendance = row.Cells[DBQuery.StudentAttendanceColumn].Value?.ToString() ?? string.Empty;

                                string query = $"INSERT INTO {DBQuery.StudentTableName} (Name, Scores, Attendance) VALUES (@name, @scores, @attendance); SELECT SCOPE_IDENTITY();";

                                cmd.CommandText = query;
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@name", name);
                                cmd.Parameters.AddWithValue("@scores", scores);
                                cmd.Parameters.AddWithValue("@attendance", attendance);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        ErrorSave?.Invoke(ex.Message);
                        return false;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        public bool AccountTableSave(DataGridView accounts)
        {
            if (DoDataGridViewHaveAnyEmptyCells(accounts, "Account"))
            {
                ErrorSave?.Invoke("Có trường dữ liệu ô bị trống!");
                ErrorSave = null;
                return false;
            }

            using (SqlConnection con = new SqlConnection(DBQuery.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    SqlTransaction transaction = con.BeginTransaction();
                    cmd.Transaction = transaction;
                    try
                    {
                        foreach (DataGridViewRow row in accounts.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string name = row.Cells[DBQuery.AccountNameColumn].Value.ToString();
                                string email = row.Cells[DBQuery.AccountEmailColumn].Value?.ToString() ?? string.Empty;
                                string password = row.Cells[DBQuery.AccountPasswordColumn].Value?.ToString() ?? string.Empty;

                                string query = $"INSERT INTO {DBQuery.AccountsTableName} (Name, Email, Password) VALUES (@name, @email, @password)";

                                cmd.CommandText = query;
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@name", name);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@password", password);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        ErrorSave?.Invoke(ex.Message);
                        return false;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }

        public bool DoDataGridViewHaveAnyEmptyCells(DataGridView grid, string tableName)
        {
            if (grid.Rows.Count == 0) return true;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.OwningColumn.Name == "STUDENTID")
                        {
                            continue;
                        }
                        else if (cell.OwningColumn.Name == "ID")
                        {
                            continue;
                        }
                        else
                        {
                            if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }
    }
}
