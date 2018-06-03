using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
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
            //this.Size = new Size(1918 , 1030);
            this.Size = new Size(1918 , 980);
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


        decimal payment;
        int order_status;
        decimal change;
        int customer_id;
        string paystatus;


        public void checkoutOrder(decimal payment, decimal change, string paystatus)
        {

            DateTime date = DateTime.Now;
            var order_date = date.Date;

            order_status = 1;
            customer_id = int.Parse(selectedCustIDTxt.Text);
            this.paystatus = paystatus;
            this.payment = payment;
            this.change = change;

            conn.Insert("orders", "order_date", DateTime.Now.ToString("yyyy-MM-dd"), "order_status", "1", "customer_id", customer_id.ToString(), "payment_status", paystatus).GetQueryData();
            conn.Insert("order_payment", "order_id", conn.lastID, "payment", payment.ToString(), "payment_date",
                DateTime.Now.ToString("yyyy-MM-dd")).GetQueryData();
            //orderline.ColumnCount = 5;
            string temp_orderid;
            temp_orderid = conn.lastID;
            foreach (DataGridViewRow rows in orderline.Rows)
            {
                MessageBox.Show(rows.Cells[0].Value.ToString());
                conn.Insert("orderline", "order_id", temp_orderid, "merch_id", rows.Cells[3].Value.ToString(), "quantity", rows.Cells[1].Value.ToString(), "total_price", rows.Cells[2].Value.ToString()).GetQueryData();
            }


        }

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
                    row.Cells["merch_id"].Value = temp_merchid;
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
                row.Cells["merch_id"].Value = temp_merchid;
            }

            price_total.Text = (from DataGridViewRow row in orderline.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToDecimal(row.Cells[2].FormattedValue)).Sum().ToString();
            total_price = (from DataGridViewRow row in orderline.Rows
                           where row.Cells[2].FormattedValue.ToString() != string.Empty
                           select Convert.ToDecimal(row.Cells[2].FormattedValue)).Sum();

            btnAdditem.Text = "Update";
        }

        string temp_merchname;
        int temp_qty = 0;
        int temp_merchid = 0;
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
                temp_merchid = Convert.ToInt32(sell_merchandise.Rows[e.RowIndex].Cells["merch_id"].Value);
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
            if (orderline.Rows.Count > 0)
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
            total_price = (from DataGridViewRow row in orderline.Rows
                           where row.Cells[2].FormattedValue.ToString() != string.Empty
                           select Convert.ToDecimal(row.Cells[2].FormattedValue)).Sum();
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {

            using (Plexiglass p = new Plexiglass(this))
            {
                //p.Location = new Point(48, 15);
                //p.Location = new Point(0, 0);
                p.Size = this.ClientRectangle.Size;
                p.StartPosition = FormStartPosition.CenterScreen;
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

            using (Plexiglass p = new Plexiglass(this))
            {
                //p.Location = new Point(48, 15);
                //p.Location = new Point(0, 0);
                p.Size = this.ClientRectangle.Size;
                p.StartPosition = FormStartPosition.CenterScreen;
                p.BringToFront();

                checkout chkout = new checkout(this,total_price);
                chkout.checkoutform = this;
                chkout.ShowDialog(this);
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void removeall_merch_Click(object sender, EventArgs e)
        {
            btnAdditem.Text = "Add";
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

        private void sales_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sales_control.SelectedIndex == 1)
                reloadOrders();
        }

        private void reloadOrders()
        {
            dataGridView2.DataSource = conn.Select("orders=o", "o.order_id", "op.payment_date AS 'Order Date'", "o.order_status", "CONCAT(c.lastname, ', ', c.firstname) as customer")
                .NJoin("order_payment=op")
                .NJoin("customer=c")
                .Group("order_id")
                .GetQueryData();
        }

        private void showOrderDetails()
        {
            string selectedOrder = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            var customerDetails = conn.Select("orders=o", "CONCAT(c.firstname,' ',c.lastname) as name", "c.contact", "c.cluster", "op.payment_date", "o.payment_status", "SUM(op.payment)", "o.order_status ")
                                    .NJoin("customer=c")
                                    .NJoin("order_payment=op")
                                    .Where("o.order_id", selectedOrder)
                                    .Group("order_id")
                                    .GetQueryData();
            orderCname.Text = customerDetails.Rows[0][0].ToString();
            orderCcontact.Text = customerDetails.Rows[0][1].ToString();
            orderCcluster.Text = customerDetails.Rows[0][2].ToString();
            orderOdate.Text = customerDetails.Rows[0][3].ToString();
            orderOpstatus.Text = customerDetails.Rows[0][4].ToString();
            orderOcdate.Text = customerDetails.Rows[0][5].ToString();
            orderOstatus.Text = customerDetails.Rows[0][6].ToString();
            payOrder(selectedOrder, 200);
            dataGridView3.DataSource = conn.Select("orderline=ol", "m.merch_name", "ol.quantity", "ol.quantity_claimed")
                                        .NJoin("merchandise=m")
                                        .NJoin("orders=o")
                                        .Where("o.order_id", selectedOrder)
                                        .GetQueryData();     
        }

        public void claimOrder(string olID, string quantity)
        {
            var quantityClaimed = conn.Select("orderline", "quantity_claimed")
                .Where("orderlineID", olID)
                .GetQueryData();
            quantityClaimed += int.Parse(quantity);
            conn.Update("orderline", "quantity_claimed", quantityClaimed)
                .Where("orderline_id", olID)
                .GetQueryData();
            conn.Insert("order_claim", "orderline_id", olID, "quantity_no", quantity, "date_claimed",
                    DateTime.Now.ToString("yyyy-MM-dd"))
                .GetQueryData();

        }

        public void payOrder(string oID, string payment) => payOrder(oID, Convert.ToInt32(payment));

        public void payOrder(string oID, int payment)
        {
            // toDo: 1 insert for payment
            var present_pay = conn.Select("order_payment", "SUM(payment)")
                                    .NJoin("orders")
                                    .Where("order_id", oID)
                                    .Group("order_id")
                                    .GetQueryData()
                                    .Rows[0][0];
            int total_pay =  Convert.ToInt32(present_pay) + payment;
            MessageBox.Show(total_pay.ToString());
            conn.Insert("order_payment", "order_id", oID, "payment", payment.ToString(), "payment_date",
                DateTime.Now.ToString("yyyy-MM-dd"))
                .GetQueryData();
            var total_price = conn.Select("orderline", "SUM(total_price)")
                .Where("order_id", oID)
                .Group("order_id")
                .GetQueryData()
                .Rows[0][0];
            if(total_pay >= total_price)
                conn.Update("orders", "payment_status", "1")
                    .Where("order_id",oID)
                    .GetQueryData();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
                showOrderDetails();
        }

        private void sell_merchandise_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    row.Cells["merch_id"].Value = temp_merchid;
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
                row.Cells["merch_id"].Value = temp_merchid;
            }

            price_total.Text = (from DataGridViewRow row in orderline.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToDecimal(row.Cells[2].FormattedValue)).Sum().ToString();
            total_price = (from DataGridViewRow row in orderline.Rows
                           where row.Cells[2].FormattedValue.ToString() != string.Empty
                           select Convert.ToDecimal(row.Cells[2].FormattedValue)).Sum();

            btnAdditem.Text = "Update";
        }

        private void panel_allorders_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}
