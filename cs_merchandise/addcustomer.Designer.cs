namespace cs_merchandise
{
    partial class addcustomer
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.roundedCorners = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.login_close = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cluster_select = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCloseNewCust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(72)))));
            this.panel3.Location = new System.Drawing.Point(-3, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 10);
            this.panel3.TabIndex = 11;
            // 
            // roundedCorners
            // 
            this.roundedCorners.ElipseRadius = 5;
            this.roundedCorners.TargetControl = this;
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.ForeColor = System.Drawing.Color.Purple;
            this.login_close.Location = new System.Drawing.Point(498, 10);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(24, 23);
            this.login_close.TabIndex = 12;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(18, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "First Name:";
            // 
            // btnNewCust
            // 
            this.btnNewCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(72)))));
            this.btnNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCust.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCust.ForeColor = System.Drawing.Color.White;
            this.btnNewCust.Location = new System.Drawing.Point(22, 295);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(370, 59);
            this.btnNewCust.TabIndex = 17;
            this.btnNewCust.Text = "Save";
            this.btnNewCust.UseVisualStyleBackColor = false;
            this.btnNewCust.Click += new System.EventHandler(this.btnNewCust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(18, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Contact:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(272, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(272, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cluster:";
            // 
            // cluster_select
            // 
            this.cluster_select.BackColor = System.Drawing.Color.Transparent;
            this.cluster_select.BorderRadius = 3;
            this.cluster_select.DisabledColor = System.Drawing.Color.Gray;
            this.cluster_select.ForeColor = System.Drawing.Color.White;
            this.cluster_select.Items = new string[] {
        "CS",
        "HUMLET",
        "EA",
        "ACC"};
            this.cluster_select.Location = new System.Drawing.Point(276, 214);
            this.cluster_select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cluster_select.Name = "cluster_select";
            this.cluster_select.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(72)))));
            this.cluster_select.onHoverColor = System.Drawing.Color.Purple;
            this.cluster_select.selectedIndex = -1;
            this.cluster_select.Size = new System.Drawing.Size(234, 43);
            this.cluster_select.TabIndex = 22;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(-9, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 364);
            this.panel5.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(531, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 364);
            this.panel1.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Location = new System.Drawing.Point(-3, 363);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(537, 10);
            this.panel7.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(18, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "New Customer";
            // 
            // lname
            // 
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lname.HintForeColor = System.Drawing.Color.Empty;
            this.lname.HintText = "Enter Last Name";
            this.lname.isPassword = false;
            this.lname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lname.LineIdleColor = System.Drawing.Color.Purple;
            this.lname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lname.LineThickness = 3;
            this.lname.Location = new System.Drawing.Point(276, 129);
            this.lname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(234, 45);
            this.lname.TabIndex = 27;
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fname
            // 
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fname.HintForeColor = System.Drawing.Color.Empty;
            this.fname.HintText = "Enter First Name";
            this.fname.isPassword = false;
            this.fname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.fname.LineIdleColor = System.Drawing.Color.Purple;
            this.fname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.fname.LineThickness = 3;
            this.fname.Location = new System.Drawing.Point(22, 129);
            this.fname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(234, 45);
            this.fname.TabIndex = 28;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contact
            // 
            this.contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contact.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contact.HintForeColor = System.Drawing.Color.Empty;
            this.contact.HintText = "Enter Contact";
            this.contact.isPassword = false;
            this.contact.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.contact.LineIdleColor = System.Drawing.Color.Purple;
            this.contact.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.contact.LineThickness = 3;
            this.contact.Location = new System.Drawing.Point(22, 214);
            this.contact.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(234, 45);
            this.contact.TabIndex = 29;
            this.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCloseNewCust
            // 
            this.btnCloseNewCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(72)))));
            this.btnCloseNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseNewCust.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseNewCust.ForeColor = System.Drawing.Color.White;
            this.btnCloseNewCust.Location = new System.Drawing.Point(398, 295);
            this.btnCloseNewCust.Name = "btnCloseNewCust";
            this.btnCloseNewCust.Size = new System.Drawing.Size(112, 59);
            this.btnCloseNewCust.TabIndex = 30;
            this.btnCloseNewCust.Text = "Close";
            this.btnCloseNewCust.UseVisualStyleBackColor = false;
            this.btnCloseNewCust.Click += new System.EventHandler(this.btnCloseNewCust_Click);
            // 
            // addcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(533, 366);
            this.Controls.Add(this.btnCloseNewCust);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cluster_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewCust);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.login_close);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addcustomer";
            this.Load += new System.EventHandler(this.addcustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse roundedCorners;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewCust;
        private Bunifu.Framework.UI.BunifuDropdown cluster_select;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contact;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lname;
        private System.Windows.Forms.Button btnCloseNewCust;
    }
}