using System;
using System.Windows.Forms;

namespace Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //string[] lines = File.ReadAllLines(@"C:\Users\tranh\OneDrive\Tài liệu\Desktop Application Development\TreasureAdmin.txt");
            //if (lines.Length >= 3 && lines[2] == AdminPassword.Text)
            //{
            //    Admin admin = new Admin();
            //    admin.Show();
            //}

            if ("admin" == AdminPassword.Text)
            {
                Admin admin = new Admin();
                admin.Show();
            }
        }
    }
}
