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


        public Main()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cs_merchandise; UID=root; PWD=");
            btnDashboard_active.Show();
            btnSales_active.Hide();
            btnSell_active.Hide();
            btnOrders_active.Hide();
            btnMerch_active.Hide();
            btnReports_active.Hide();
            btnUsers_active.Hide();
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
            main_close.BackColor = Color.WhiteSmoke;
        }

        private void btnDashboard_Enter(object sender, EventArgs e)
        {
            btnDashboard_active.Show();

            btnMerch_active.Hide();
            btnSales_active.Hide();
            btnSell_active.Hide();
            btnOrders_active.Hide();
            btnReports_active.Hide();
            btnUsers_active.Hide();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard_active.Hide();
        }

        private void btnSales_Enter(object sender, EventArgs e)
        {
            btnSales_active.Show();
            btnSell_active.Show();

            btnDashboard_active.Hide();
            btnMerch_active.Hide();
            btnReports_active.Hide();
            btnUsers_active.Hide();
        }

        private void btnSales_Leave(object sender, EventArgs e)
        {
            btnSales_active.Hide();
            btnSell_active.Hide();
            btnOrders_active.Hide();
        }

        private void btnSell_Enter(object sender, EventArgs e)
        {
            btnSales_active.Show();
            btnSell_active.Show();

            btnDashboard_active.Hide();
            btnMerch_active.Hide();
            btnReports_active.Hide();
            btnUsers_active.Hide();
        }

        private void btnSell_Leave(object sender, EventArgs e)
        {
            btnSales_active.Hide();
            btnSell_active.Hide();
            btnOrders_active.Hide();
        }

        private void btnOrders_Enter(object sender, EventArgs e)
        {
            btnSales_active.Show();
            btnOrders_active.Show();

            btnDashboard_active.Hide();
            btnMerch_active.Hide();
            btnReports_active.Hide();
            btnUsers_active.Hide();
        }

        private void btnOrders_Leave(object sender, EventArgs e)
        {
            btnSales_active.Hide();
            btnSell_active.Hide();
            btnOrders_active.Hide();
        }

        private void btnMerch_Enter(object sender, EventArgs e)
        {
            btnMerch_active.Show();

            btnDashboard_active.Hide();
            btnSales_active.Hide();
            btnSell_active.Hide();
            btnOrders_active.Hide();
            btnReports_active.Hide();
            btnUsers_active.Hide();
        }

        private void btnMerch_Leave(object sender, EventArgs e)
        {
            btnMerch_active.Hide();
        }

        private void btnReports_Enter(object sender, EventArgs e)
        {
            btnReports_active.Show();

            btnDashboard_active.Hide();
            btnSales_active.Hide();
            btnSell_active.Hide();
            btnOrders_active.Hide();
            btnMerch_active.Hide();
            btnUsers_active.Hide();
        }

        private void btnReports_Leave(object sender, EventArgs e)
        {
            btnReports_active.Hide();
        }

        private void btnUsers_Enter(object sender, EventArgs e)
        {
            btnUsers_active.Show();

            btnDashboard_active.Hide();
            btnSales_active.Hide();
            btnSell_active.Hide();
            btnOrders_active.Hide();
            btnMerch_active.Hide();
            btnReports_active.Hide();
        }

        private void btnUsers_Leave(object sender, EventArgs e)
        {
            btnUsers_active.Hide();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            main_browser.SelectTab(1);
            sales_control.SelectTab(0);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            main_browser.SelectTab(1);
            sales_control.SelectTab(1);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            btnSell_Click(sender, e);
        }

        private void btnMerch_Click(object sender, EventArgs e)
        {
            main_browser.SelectTab(2);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            main_browser.SelectTab(3);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            main_browser.SelectTab(4);
        }
    }
}
