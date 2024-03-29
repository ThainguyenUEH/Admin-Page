using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    internal class DBQuery
    {
        public delegate void SqlError(Exception ex);

        public static event SqlError Error;
        public const string ConnectionString = @"Data Source=localhost;Initial Catalog=TREASUREGAME;Integrated Security = True;Max Pool Size = 200;";

        public const string QuestionsTable = "QUESTION";
        public const string QuestionIdColumn = "ID";
        public const string QuestionColumn = "QUESTION";
        public const string QuestionAnswerColumn = "ANSWER";
        public const string QuestionChoice1Column = "CHOICE1";
        public const string QuestionChoice2Column = "CHOICE2";
        public const string QuestionChoice3Column = "CHOICE3";

        public const string StudentTableName = "PLAYER";
        public const string StudentIdColumn = "STUDENTID";
        public const string StudentNameColumn = "NAME";
        public const string StudentScoreColumn = "SCORES";
        public const string StudentAttendanceColumn = "ATTENDANCE";

        public const string AccountsTableName = "ACCOUNT";
        public const string AccountIdColumn = "STUDENTID";
        public const string AccountNameColumn = "NAME";
        public const string AccountEmailColumn = "EMAIL";
        public const string AccountPasswordColumn = "PASSWORD";

        public static DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {
                   // Error?.Invoke(ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return table;
        }

        public static DataTable ExecuteQuery(string query, string[] parameters, string[] values)
        {
            if (parameters.Length != values.Length) throw new Exception("Số lượng tham số và giá trị không bằng nhau!");
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        for (int i = 0; i < parameters.Length; i++)
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);

                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Error?.Invoke(ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return table;
        }

        public static object ExecuteScalar(string query)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        return cmd.ExecuteScalar();
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Error?.Invoke(ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return null;
        }
    }
}
