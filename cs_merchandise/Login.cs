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

        MySqlConnection conn;

        public Login()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cs_merchandise; UID=root; PWD=");
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string chkuser = "SELECT * FROM users WHERE username ='" + username + "' AND password = '" + password + "'";

            conn.Open();
            MySqlCommand chkuser_comm = new MySqlCommand(chkuser, conn);
            MySqlDataAdapter chkuser_adp = new MySqlDataAdapter(chkuser_comm);
            conn.Close();
            DataTable users_dt = new DataTable();
            chkuser_adp.Fill(users_dt);

            if (users_dt.Rows.Count == 1)
            {
                string userid = users_dt.Rows[0][0].ToString();
                string fn = users_dt.Rows[0][3].ToString();
                string ln = users_dt.Rows[0][4].ToString();
                Main main = new Main(username, fn, ln, userid);
                main.Login = this;
                main.Show();
                this.Hide();
            }
        }

        
    }
}
