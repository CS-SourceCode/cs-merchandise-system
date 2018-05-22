using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cs_merchandise
{
    public partial class Login : Form
    {

        private DatabaseConn conn = new DatabaseConn();
        public string username, fn, ln, userid;

        public Login()
        {
            InitializeComponent();
        }

        // CLOSE BUTTON //
        private void login_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_close_MouseHover(object sender, EventArgs e)
        {
            login_close.BackColor = Color.Silver;
        }
        private void login_close_MouseEnter(object sender, EventArgs e)
        {
            login_close.BackColor = Color.Silver;
        }
        private void login_close_MouseLeave(object sender, EventArgs e)
        {
            login_close.BackColor = Color.White;
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            string password = txtPassword.Text;
            var users_dt  = conn.Select("users", "*")
                        .Where("username", username, "password", password)
                        .GetQueryData();
            chkuser_adp.Fill(users_dt);

            if (users_dt.Rows.Count == 1)
            {
                userid = users_dt.Rows[0][0].ToString();
                fn = users_dt.Rows[0][3].ToString();
                ln = users_dt.Rows[0][4].ToString();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        
    }
}
