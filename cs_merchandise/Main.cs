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
    public partial class Main : Form
    {

        MySqlConnection conn;


        public Main(string username, string fn, string ln, string userid)
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cs_merchandise; UID=root; PWD=");
            this.Size = new Size(1918 , 1030);
            this.CenterToScreen();  
        }

        public Login Login { get; internal set; }

        private void main_close_Click(object sender, EventArgs e)
        {
           // Prompt to Logout //
        }

        private void main_close_MouseEnter(object sender, EventArgs e)
        {
            main_close.BackColor = Color.Silver;
        }

        private void main_close_MouseHover(object sender, EventArgs e)
        {
            main_close.BackColor = Color.Silver;
        }

        private void main_close_MouseLeave(object sender, EventArgs e)
        {
            main_close.BackColor = Color.White;
        }
    }
}
