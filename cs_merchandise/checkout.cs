using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_merchandise
{
    public partial class checkout : Form
    {
        Main parent = new Main();
        decimal totalprice;
        decimal cash;
        decimal cashchange;
        string payment_status;

        public checkout(Main main, decimal total)
        {
            InitializeComponent();
            parent = main;
            totalprice = total;
            checkout_totaldue.Text = totalprice.ToString();
        }

        public Main checkoutform { get; internal set; }

        private void btnRecordOrder_Click(object sender, EventArgs e)
        {
            cash = Convert.ToDecimal(cash_amount.Text);
            if(totalprice > cash)
            {
                cashchange = totalprice - cash;
                payment_status = "DOWN";
                MessageBox.Show("Insufficient Cash; this transaction will be recorded as DOWN Payment.");
            }
            else if(totalprice <= cash)
            {
                cashchange = totalprice - cash;
                payment_status = "FULLY PAID";
                MessageBox.Show("This transaction will be recorded as FULLY PAID.");
            }
            parent.checkoutOrder(cash, cashchange, payment_status);
        }

        private void btnCheckoutback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
