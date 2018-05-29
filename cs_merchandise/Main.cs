using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            getOrderId();

            /*
            ExtendedPanel panel = new ExtendedPanel();
            panel.BackColor = Color.Black;
            panel.Opacity = 10;
            this.Controls.Add(panel);
            */
        }
        public Login Login { get; internal set; }


        private void getOrderId()
        {
            order_no.Enabled = false;
            price_total.Enabled = false;
            var orders_dt = conn.Select("orders", "order_id").GetQueryData();

            if (orders_dt.Rows.Count == 0)
            {
                //Should not preemptively insert into the database
                //conn.Insert("orders", "order_id", "1").GetQueryData();
                order_no.Text = "1";
            }
            else
            {
                int order_id = orders_dt.Rows[orders_dt.Rows.Count - 1][0] + 1;
                order_no.Text = order_id.ToString();
            }

        }

        private void setMerchandise()
        {

            var merch_dt = conn.Select("merchandise", "*")
                        .GetQueryData();

            sell_merchandise.DataSource = merch_dt;
            sell_merchandise.Columns["merch_id"].Visible = false;
            sell_merchandise.Columns["merch_name"].HeaderText = "Description";
            sell_merchandise.Columns["merch_price"].HeaderText = "Price";

            //Default Selected
            temp_merchname = sell_merchandise.Rows[0].Cells["merch_name"].Value.ToString();
            temp_price = Convert.ToDecimal(sell_merchandise.Rows[0].Cells["merch_price"].Value);
            merch_total = Convert.ToDecimal(temp_price) * Convert.ToDecimal(temp_qty);
        }

        private void setOrderNo()
        {
            //get latest and increment but is temporary
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

            currCustomerNo = Convert.ToInt32(customer_list.Rows[0].Cells["customer_id"].Value);
            custfn = customer_list.Rows[0].Cells["firstname"].Value.ToString();
            custln = customer_list.Rows[0].Cells["lastname"].Value.ToString();
            selectedCustIDTxt.Text = currCustomerNo.ToString();
            selectedCustNameTxt.Text = custfn + " " + custln;


        }

        private void main_close_Click(object sender, EventArgs e)
        {
            Program.looper = false;
            this.Close();
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

            btnAdditem.Text = "Update";
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
                item_quantity.Text = "1";
            }
            bool Found = false;
            if (orderline.Rows.Count > 0)
            {
                foreach (DataGridViewRow row1 in orderline.Rows)
                {
                    if (Convert.ToString(row1.Cells[0].Value) == temp_merchname)
                    {
                        Found = true;
                        btnAdditem.Text = "Update";
                    }

                }
                if (!Found)
                {
                    btnAdditem.Text = "Add";
                }
            }
            else
            {
                btnAdditem.Text = "Add";
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

            using (Plexiglass p = new Plexiglass(this))
            {
                p.Location = new Point(0, 0);
                p.Size = this.ClientRectangle.Size;
                
                p.BringToFront();
                
                addcustomer addcust = new addcustomer(this);
                addcust.main = this;
                addcust.ShowDialog(this);
            }
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
            
        }

        private void removeall_merch_Click(object sender, EventArgs e)
        {
            orderline.Rows.Clear();
            orderline.Refresh();
            price_total.Text = "0.00";
        }

        int currCustomerNo = 0;
        string custfn;
        string custln;

        private void customer_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void select_customer_Click(object sender, EventArgs e)
        {
            currCustomerNo = Convert.ToInt32(customer_list.CurrentRow.Cells["customer_id"].Value);
            custfn = customer_list.CurrentRow.Cells["firstname"].Value.ToString();
            custln = customer_list.CurrentRow.Cells["lastname"].Value.ToString();
            selectedCustIDTxt.Text = currCustomerNo.ToString();
            selectedCustNameTxt.Text = custfn + " " + custln;
        }

        private void inactivepanel_Paint(object sender, PaintEventArgs e)
        {

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
