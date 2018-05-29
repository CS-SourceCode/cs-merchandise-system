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

        //MySqlConnection conn;
        private DatabaseConn conn = new DatabaseConn();

        public Main()
        {
            InitializeComponent();
            btnDashboard_active.Show();
            btnSales_active.Hide();
            btnSell_active.Hide();
            btnOrders_active.Hide();
            btnMerch_active.Hide();
            btnReports_active.Hide();
            btnUsers_active.Hide();
            this.Size = new Size(1918 , 1030);
            this.CenterToScreen();

            setMerchandise();
            setCustomerlist();
            selectedCustIDTxt.Enabled = false;
            selectedCustNameTxt.Enabled = false;

        }

        public Login Login { get; internal set; }

        private void setMerchandise()
        {

            var merch_dt = conn.Select("merchandise", "*")
                        .GetQueryData();

            sell_merchandise.DataSource = merch_dt;
            sell_merchandise.Columns["merch_id"].Visible = false;
            sell_merchandise.Columns["merch_name"].HeaderText = "Description";
            sell_merchandise.Columns["merch_price"].HeaderText = "Price";   
        }

        private void setOrderNo()
        {
            //get latest and increment but is temporary
        }

        private void setOrderline()
        {
            orderline.ColumnCount = 4;
            orderline.ColumnHeadersVisible = true;

            orderline.Columns[0].Name = "#";
            orderline.Columns[1].Name = "Description";
            orderline.Columns[2].Name = "Quantity";
            orderline.Columns[3].Name = "Price";

        }

        public void setCustomerlist()
        {
            var cust_dt = conn.Select("customer", "*")
                        .GetQueryData();

            customer_list.DataSource = cust_dt;
            customer_list.Columns["customer_id"].HeaderText = "ID";
            customer_list.Columns["firstname"].HeaderText = "First Name";
            customer_list.Columns["lastname"].HeaderText = "Last Name";
            customer_list.Columns["contact"].HeaderText = "Contact";
            customer_list.Columns["cluster"].HeaderText = "Cluster";
        }

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
        private void btnAdditem_Click(object sender, EventArgs e)
        {
            temp_qty = Convert.ToInt32(item_quantity.Text);
            // Create a new row first as it will include the columns you've created at design-time.
            bool Found = false;

            if (orderline.Rows.Count > 0)
            {
                foreach (DataGridViewRow row1 in orderline.Rows)
                {
                    if (Convert.ToString(row1.Cells[0].Value) == temp_merchname)
                    {
                        //Update the Quantity of the found row
                        row1.Cells[1].Value = temp_qty;
                        row1.Cells[2].Value = temp_price * temp_qty;
                        Found = true;
                    }

                }
                if (!Found)
                {
                    int rowId = orderline.Rows.Add();

                    // Grab the new row!
                    DataGridViewRow row = orderline.Rows[rowId];

                    // Add the data
                    row.Cells["merch_name"].Value = temp_merchname;
                    row.Cells["merch_quantity"].Value = temp_qty;
                    row.Cells["merch_price"].Value = temp_price * temp_qty;
                }
            }
            else
            {
                int rowId = orderline.Rows.Add();

                // Grab the new row!
                DataGridViewRow row = orderline.Rows[rowId];

                // Add the data
                row.Cells["merch_name"].Value = temp_merchname;
                row.Cells["merch_quantity"].Value = temp_qty;
                row.Cells["merch_price"].Value = temp_price * temp_qty;
            }

            price_total.Text = (from DataGridViewRow row in orderline.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToDecimal(row.Cells[2].FormattedValue)).Sum().ToString();

            /*
            foreach (DataGridViewRow row1 in orderline.Rows)
            {
                total_price += Convert.ToDecimal(row1.Cells["merch_price"].Value);
            }

            price_total.Text = total_price.ToString();

            decimal total = 0;
            foreach (DataGridViewRow row1 in orderline.Rows)
            {
                total += Convert.ToDecimal(row1.Cells["merch_price"].Value) * Convert.ToDecimal(row1.Cells["merch_qty"].Value);
            }

            txtTotalprice.Text = total.ToString();

            
            string[] row = new string[] { "test", "test1", "test2", "test3" };
            object[] rows = new object[] { row };

            foreach(string[] rowArray in rows)
            {
                orderline.Rows.Add(rowArray);
            }
            */
            //orderline.DataSource=GetSelectedRows(sell_merchandise);
        }

        string temp_merchname;
        int temp_qty = 0;
        decimal temp_price;
        decimal merch_total;
        decimal total_price;

        private void sell_merchandise_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                temp_merchname = sell_merchandise.Rows[e.RowIndex].Cells["merch_name"].Value.ToString();
                temp_price = Convert.ToDecimal(sell_merchandise.Rows[e.RowIndex].Cells["merch_price"].Value);
                merch_total = Convert.ToDecimal(temp_price) * Convert.ToDecimal(temp_qty);
            }
        }

        private void orderline_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void remove_merch_Click(object sender, EventArgs e)
        {
            if(orderline.Rows.Count > 0)
            {
                orderline.Rows.RemoveAt(orderline.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("No Item in Orderline");

            }
            price_total.Text = (from DataGridViewRow row in orderline.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToDecimal(row.Cells[2].FormattedValue)).Sum().ToString();
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            addcustomer addcust = new addcustomer(this);
            addcust.main = this;
            addcust.Show();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_Leave(object sender, EventArgs e)
        {

        }



        private void btnCheckout_Click(object sender, EventArgs e)
        {
            checkout chkout = new checkout();
            chkout.checkoutform = this;
            chkout.Show();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            //order_no.Text = 
        }

        /*
        DataGridView GetSelectedRows(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count-1];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.Selected) continue;

                for (int i = 0; i < row.Cells.Count - 1; i++)
                {

                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
                
            }
            DataGridView x=orderline;
            x.Rows.Add(dt);
            return x;
        }
        */
    }
}
