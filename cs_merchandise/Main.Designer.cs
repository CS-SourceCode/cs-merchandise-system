namespace cs_merchandise
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.roundedCorners_Main = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.main_browser = new System.Windows.Forms.TabControl();
            this.browser_dashboard = new System.Windows.Forms.TabPage();
            this.panel_orders2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel_orders1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.browser_sales = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sales_pos = new System.Windows.Forms.TabPage();
            this.sales_Orders = new System.Windows.Forms.TabPage();
            this.browser_merchandise = new System.Windows.Forms.TabPage();
            this.browser_reports = new System.Windows.Forms.TabPage();
            this.browser_users = new System.Windows.Forms.TabPage();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.admin_panel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.main_close = new System.Windows.Forms.Label();
            this.roundedCorners_Orders1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.roundedCorners_Orders2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.main_browser.SuspendLayout();
            this.browser_dashboard.SuspendLayout();
            this.panel_orders2.SuspendLayout();
            this.panel_orders1.SuspendLayout();
            this.browser_sales.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.browser_merchandise.SuspendLayout();
            this.admin_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedCorners_Main
            // 
            this.roundedCorners_Main.ElipseRadius = 5;
            this.roundedCorners_Main.TargetControl = this;
            // 
            // main_browser
            // 
            this.main_browser.Controls.Add(this.browser_dashboard);
            this.main_browser.Controls.Add(this.browser_sales);
            this.main_browser.Controls.Add(this.browser_merchandise);
            this.main_browser.Controls.Add(this.browser_reports);
            this.main_browser.Controls.Add(this.browser_users);
            this.main_browser.Location = new System.Drawing.Point(299, 35);
            this.main_browser.Name = "main_browser";
            this.main_browser.SelectedIndex = 0;
            this.main_browser.Size = new System.Drawing.Size(1930, 1049);
            this.main_browser.TabIndex = 0;
            // 
            // browser_dashboard
            // 
            this.browser_dashboard.Controls.Add(this.panel_orders2);
            this.browser_dashboard.Controls.Add(this.button7);
            this.browser_dashboard.Controls.Add(this.panel_orders1);
            this.browser_dashboard.Location = new System.Drawing.Point(4, 25);
            this.browser_dashboard.Name = "browser_dashboard";
            this.browser_dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.browser_dashboard.Size = new System.Drawing.Size(1922, 1020);
            this.browser_dashboard.TabIndex = 0;
            this.browser_dashboard.Text = "Dashboard";
            this.browser_dashboard.UseVisualStyleBackColor = true;
            // 
            // panel_orders2
            // 
            this.panel_orders2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_orders2.Controls.Add(this.label2);
            this.panel_orders2.Controls.Add(this.label3);
            this.panel_orders2.Location = new System.Drawing.Point(423, 48);
            this.panel_orders2.Name = "panel_orders2";
            this.panel_orders2.Size = new System.Drawing.Size(340, 250);
            this.panel_orders2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(73, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 141);
            this.label2.TabIndex = 10;
            this.label2.Text = "28";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(76, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pending Orders";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1900, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel_orders1
            // 
            this.panel_orders1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_orders1.Controls.Add(this.label1);
            this.panel_orders1.Controls.Add(this.label4);
            this.panel_orders1.Location = new System.Drawing.Point(47, 48);
            this.panel_orders1.Name = "panel_orders1";
            this.panel_orders1.Size = new System.Drawing.Size(340, 250);
            this.panel_orders1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 141);
            this.label1.TabIndex = 10;
            this.label1.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(54, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Completed Orders";
            // 
            // browser_sales
            // 
            this.browser_sales.Controls.Add(this.tabControl1);
            this.browser_sales.Location = new System.Drawing.Point(4, 25);
            this.browser_sales.Name = "browser_sales";
            this.browser_sales.Padding = new System.Windows.Forms.Padding(3);
            this.browser_sales.Size = new System.Drawing.Size(1922, 1020);
            this.browser_sales.TabIndex = 1;
            this.browser_sales.Text = "Sales";
            this.browser_sales.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sales_pos);
            this.tabControl1.Controls.Add(this.sales_Orders);
            this.tabControl1.Location = new System.Drawing.Point(-4, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1558, 918);
            this.tabControl1.TabIndex = 0;
            // 
            // sales_pos
            // 
            this.sales_pos.Location = new System.Drawing.Point(4, 25);
            this.sales_pos.Name = "sales_pos";
            this.sales_pos.Padding = new System.Windows.Forms.Padding(3);
            this.sales_pos.Size = new System.Drawing.Size(1550, 889);
            this.sales_pos.TabIndex = 0;
            this.sales_pos.Text = "POS";
            this.sales_pos.UseVisualStyleBackColor = true;
            // 
            // sales_Orders
            // 
            this.sales_Orders.Location = new System.Drawing.Point(4, 25);
            this.sales_Orders.Name = "sales_Orders";
            this.sales_Orders.Padding = new System.Windows.Forms.Padding(3);
            this.sales_Orders.Size = new System.Drawing.Size(1550, 889);
            this.sales_Orders.TabIndex = 1;
            this.sales_Orders.Text = "Orders";
            this.sales_Orders.UseVisualStyleBackColor = true;
            // 
            // browser_merchandise
            // 
            this.browser_merchandise.Controls.Add(this.panel4);
            this.browser_merchandise.Controls.Add(this.panel1);
            this.browser_merchandise.Location = new System.Drawing.Point(4, 25);
            this.browser_merchandise.Name = "browser_merchandise";
            this.browser_merchandise.Size = new System.Drawing.Size(1922, 1020);
            this.browser_merchandise.TabIndex = 2;
            this.browser_merchandise.Text = "Merchandise";
            this.browser_merchandise.UseVisualStyleBackColor = true;
            // 
            // browser_reports
            // 
            this.browser_reports.Location = new System.Drawing.Point(4, 25);
            this.browser_reports.Name = "browser_reports";
            this.browser_reports.Size = new System.Drawing.Size(1922, 1020);
            this.browser_reports.TabIndex = 3;
            this.browser_reports.Text = "Reports";
            this.browser_reports.UseVisualStyleBackColor = true;
            // 
            // browser_users
            // 
            this.browser_users.Location = new System.Drawing.Point(4, 25);
            this.browser_users.Name = "browser_users";
            this.browser_users.Size = new System.Drawing.Size(1922, 1020);
            this.browser_users.TabIndex = 4;
            this.browser_users.Text = "Users";
            this.browser_users.UseVisualStyleBackColor = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // admin_panel
            // 
            this.admin_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.admin_panel.Controls.Add(this.panel8);
            this.admin_panel.Controls.Add(this.panel5);
            this.admin_panel.Controls.Add(this.panel6);
            this.admin_panel.Controls.Add(this.panel2);
            this.admin_panel.Controls.Add(this.button6);
            this.admin_panel.Controls.Add(this.button5);
            this.admin_panel.Controls.Add(this.button4);
            this.admin_panel.Controls.Add(this.button3);
            this.admin_panel.Controls.Add(this.button2);
            this.admin_panel.Controls.Add(this.button1);
            this.admin_panel.Controls.Add(this.btnLogin);
            this.admin_panel.Location = new System.Drawing.Point(0, -1);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(303, 1081);
            this.admin_panel.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Purple;
            this.button6.Location = new System.Drawing.Point(-9, 548);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(325, 48);
            this.button6.TabIndex = 10;
            this.button6.Text = "   | Reports";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Purple;
            this.button5.Location = new System.Drawing.Point(-9, 602);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(325, 48);
            this.button5.TabIndex = 9;
            this.button5.Text = "   | Users";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(-9, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(325, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "        | Orders";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.Location = new System.Drawing.Point(-9, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(325, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "        | Point of Sale";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(-9, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(325, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "   | Merchandise";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(-9, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "   | Sales";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Purple;
            this.btnLogin.Location = new System.Drawing.Point(-9, 274);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(325, 48);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "   | Dashboard";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // main_close
            // 
            this.main_close.AutoSize = true;
            this.main_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_close.ForeColor = System.Drawing.Color.Purple;
            this.main_close.Location = new System.Drawing.Point(1884, 9);
            this.main_close.Name = "main_close";
            this.main_close.Size = new System.Drawing.Size(24, 23);
            this.main_close.TabIndex = 8;
            this.main_close.Text = "X";
            this.main_close.Click += new System.EventHandler(this.main_close_Click);
            this.main_close.MouseEnter += new System.EventHandler(this.main_close_MouseEnter);
            this.main_close.MouseLeave += new System.EventHandler(this.main_close_MouseLeave);
            this.main_close.MouseHover += new System.EventHandler(this.main_close_MouseHover);
            // 
            // roundedCorners_Orders1
            // 
            this.roundedCorners_Orders1.ElipseRadius = 5;
            this.roundedCorners_Orders1.TargetControl = this.panel_orders1;
            // 
            // roundedCorners_Orders2
            // 
            this.roundedCorners_Orders2.ElipseRadius = 5;
            this.roundedCorners_Orders2.TargetControl = this.panel_orders2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(38, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 440);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 10);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(303, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1617, 10);
            this.panel3.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Location = new System.Drawing.Point(0, 979);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(303, 10);
            this.panel6.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(0, 916);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1617, 10);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(-9, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 980);
            this.panel5.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Location = new System.Drawing.Point(1918, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 980);
            this.panel7.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGray;
            this.panel8.Location = new System.Drawing.Point(302, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 980);
            this.panel8.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1918, 980);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.main_close);
            this.Controls.Add(this.admin_panel);
            this.Controls.Add(this.main_browser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 980);
            this.MinimumSize = new System.Drawing.Size(1918, 980);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.main_browser.ResumeLayout(false);
            this.browser_dashboard.ResumeLayout(false);
            this.panel_orders2.ResumeLayout(false);
            this.panel_orders2.PerformLayout();
            this.panel_orders1.ResumeLayout(false);
            this.panel_orders1.PerformLayout();
            this.browser_sales.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.browser_merchandise.ResumeLayout(false);
            this.admin_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse roundedCorners_Main;
        private System.Windows.Forms.TabControl main_browser;
        private System.Windows.Forms.TabPage browser_dashboard;
        private System.Windows.Forms.TabPage browser_sales;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel admin_panel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label main_close;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage browser_merchandise;
        private System.Windows.Forms.TabPage browser_reports;
        private System.Windows.Forms.TabPage browser_users;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sales_pos;
        private System.Windows.Forms.TabPage sales_Orders;
        private System.Windows.Forms.Panel panel_orders1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse roundedCorners_Orders1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel_orders2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse roundedCorners_Orders2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
    }
}