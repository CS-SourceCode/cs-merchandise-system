﻿namespace cs_merchandise
{
    partial class checkout
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
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.checkout_totaldue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cash_amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRecordOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(0, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 10);
            this.panel3.TabIndex = 12;
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
            this.login_close.Location = new System.Drawing.Point(444, 9);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(24, 23);
            this.login_close.TabIndex = 13;
            this.login_close.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 37);
            this.label4.TabIndex = 27;
            this.label4.Text = "Checkout";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.checkout_totaldue;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // checkout_totaldue
            // 
            this.checkout_totaldue.BackColor = System.Drawing.Color.Gainsboro;
            this.checkout_totaldue.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_totaldue.Location = new System.Drawing.Point(134, 87);
            this.checkout_totaldue.Name = "checkout_totaldue";
            this.checkout_totaldue.Size = new System.Drawing.Size(307, 39);
            this.checkout_totaldue.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(25, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 37);
            this.label5.TabIndex = 35;
            this.label5.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(30, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 37);
            this.label6.TabIndex = 36;
            this.label6.Text = "CASH AMOUNT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnRecordOrder);
            this.panel1.Controls.Add(this.cash_amount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-5, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 248);
            this.panel1.TabIndex = 38;
            // 
            // cash_amount
            // 
            this.cash_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cash_amount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cash_amount.HintForeColor = System.Drawing.Color.Empty;
            this.cash_amount.HintText = "Enter Cash";
            this.cash_amount.isPassword = false;
            this.cash_amount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cash_amount.LineIdleColor = System.Drawing.Color.Purple;
            this.cash_amount.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cash_amount.LineThickness = 4;
            this.cash_amount.Location = new System.Drawing.Point(37, 64);
            this.cash_amount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cash_amount.Name = "cash_amount";
            this.cash_amount.Size = new System.Drawing.Size(409, 58);
            this.cash_amount.TabIndex = 37;
            this.cash_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnRecordOrder
            // 
            this.btnRecordOrder.BackColor = System.Drawing.Color.Green;
            this.btnRecordOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordOrder.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordOrder.ForeColor = System.Drawing.Color.White;
            this.btnRecordOrder.Location = new System.Drawing.Point(17, 166);
            this.btnRecordOrder.Name = "btnRecordOrder";
            this.btnRecordOrder.Size = new System.Drawing.Size(456, 67);
            this.btnRecordOrder.TabIndex = 38;
            this.btnRecordOrder.Text = "Record Order";
            this.btnRecordOrder.UseVisualStyleBackColor = false;
            this.btnRecordOrder.Click += new System.EventHandler(this.btnRecordOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(478, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 387);
            this.panel2.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(-9, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 387);
            this.panel4.TabIndex = 40;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Location = new System.Drawing.Point(-3, 242);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(537, 10);
            this.panel7.TabIndex = 39;
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(480, 390);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login_close);
            this.Controls.Add(this.checkout_totaldue);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "checkout";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse roundedCorners;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox checkout_totaldue;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cash_amount;
        private System.Windows.Forms.Button btnRecordOrder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
    }
}