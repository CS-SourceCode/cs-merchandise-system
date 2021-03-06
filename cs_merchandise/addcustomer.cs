﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace cs_merchandise
{
    public partial class addcustomer : Form
    {
        public Form main { get; set; }
        private DatabaseConn conn = new DatabaseConn();
        private Main mainMenu;
        public addcustomer(Main x)
        {
            mainMenu = x;
            InitializeComponent();
            cluster_select.selectedIndex = 0;
        }

        private void addcustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            int parse;
            if (fname.Text == "" || lname.Text == "" || cluster_select.selectedValue == "" || (contact.Text == "" || !int.TryParse(contact.Text, out parse)))
            {
                MessageBox.Show("Please make sure all fields are filled in correctly.");

            }
            else
            {
                string firstname = fname.Text;
                string lastname = lname.Text;
                
                var tempcust_dt = conn.Select("customer", "*")
                            .Where("firstname", firstname, "lastname", lastname)
                            .GetQueryData();

                if (tempcust_dt.Rows.Count == 1)
                {
                    MessageBox.Show("Customer already exists!");
                }
                else
                {
                    conn.Insert("customer", "firstname", fname.Text, "lastname", lname.Text, "contact", contact.Text, "cluster", cluster_select.selectedValue).GetQueryData();
                }
                mainMenu.setCustomerlist();
            }
        }

        private void btnCloseNewCust_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
