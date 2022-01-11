using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using AdminAPP.Models;
namespace AdminAPP
{
    public partial class Authorization : Form
    {
        string connectionString = AppSettings.Instance.getConnectionString(1);
        public User user;
        public Authorization()
        {
            InitializeComponent();
        }


        private bool loginAction()
        {
            bool error = true;
            user = User.getPermissionInfoUser(new SqlConnection(connectionString), textBoxLogin.Text);
            if (user == null)
            {
                error = false;
            }
            else
            {
                if (user.Password.Trim() != textBoxpassword.Text)
                    error = false;
            }
            return error;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (loginAction())
            {
                buttonLogin.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Логин или пароль неверный");
            }
        }
    }
}
