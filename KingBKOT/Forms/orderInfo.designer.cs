﻿namespace Cindy_Restaurant.Forms
{
    partial class orderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtWaiterName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtAdultNo = new System.Windows.Forms.TextBox();
            this.txtChild = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReceiptType = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbWaiter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waiter / User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtWaiterName
            // 
            this.txtWaiterName.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtWaiterName.Location = new System.Drawing.Point(20, 44);
            this.txtWaiterName.Name = "txtWaiterName";
            this.txtWaiterName.ReadOnly = true;
            this.txtWaiterName.Size = new System.Drawing.Size(146, 25);
            this.txtWaiterName.TabIndex = 3;
            this.txtWaiterName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table No.";
            // 
            // txtTableNo
            // 
            this.txtTableNo.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtTableNo.Location = new System.Drawing.Point(183, 141);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.ReadOnly = true;
            this.txtTableNo.Size = new System.Drawing.Size(462, 25);
            this.txtTableNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adult";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Children";
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtFirst.Location = new System.Drawing.Point(183, 252);
            this.txtFirst.MaxLength = 25;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(462, 25);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirst_KeyPress);
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtLast.Location = new System.Drawing.Point(183, 294);
            this.txtLast.MaxLength = 25;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(462, 25);
            this.txtLast.TabIndex = 1;
            this.txtLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLast_KeyPress);
            // 
            // txtAdultNo
            // 
            this.txtAdultNo.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtAdultNo.Location = new System.Drawing.Point(183, 382);
            this.txtAdultNo.MaxLength = 7;
            this.txtAdultNo.Name = "txtAdultNo";
            this.txtAdultNo.Size = new System.Drawing.Size(462, 25);
            this.txtAdultNo.TabIndex = 3;
            this.txtAdultNo.TextChanged += new System.EventHandler(this.txtAdultNo_TextChanged);
            this.txtAdultNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdultNo_KeyPress);
            this.txtAdultNo.Leave += new System.EventHandler(this.txtAdultNo_Leave);
            // 
            // txtChild
            // 
            this.txtChild.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtChild.Location = new System.Drawing.Point(183, 422);
            this.txtChild.MaxLength = 7;
            this.txtChild.Name = "txtChild";
            this.txtChild.Size = new System.Drawing.Size(462, 25);
            this.txtChild.TabIndex = 4;
            this.txtChild.TextChanged += new System.EventHandler(this.txtChild_TextChanged);
            this.txtChild.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChild_KeyPress);
            this.txtChild.Leave += new System.EventHandler(this.txtChild_Leave);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinish.Location = new System.Drawing.Point(183, 514);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(104, 45);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(541, 514);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 463);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(462, 25);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Receipt Type";
            // 
            // txtReceiptType
            // 
            this.txtReceiptType.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtReceiptType.Location = new System.Drawing.Point(183, 100);
            this.txtReceiptType.Name = "txtReceiptType";
            this.txtReceiptType.ReadOnly = true;
            this.txtReceiptType.Size = new System.Drawing.Size(462, 25);
            this.txtReceiptType.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(422, 514);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 45);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(178, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 3);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 3);
            this.panel1.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(172, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 34);
            this.label9.TabIndex = 30;
            this.label9.Text = "Order Information";
            // 
            // cmbWaiter
            // 
            this.cmbWaiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaiter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWaiter.FormattingEnabled = true;
            this.cmbWaiter.Location = new System.Drawing.Point(183, 183);
            this.cmbWaiter.Name = "cmbWaiter";
            this.cmbWaiter.Size = new System.Drawing.Size(462, 25);
            this.cmbWaiter.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(184, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(335, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Note: Select Logged User for Fast Cash/ Take Away";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKeyboard.FlatAppearance.BorderSize = 0;
            this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyboard.ForeColor = System.Drawing.Color.White;
            this.btnKeyboard.Location = new System.Drawing.Point(302, 514);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(104, 45);
            this.btnKeyboard.TabIndex = 72;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = false;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(44, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Contact No.";
            this.label11.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.txtMobile.Location = new System.Drawing.Point(183, 336);
            this.txtMobile.MaxLength = 10;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(462, 25);
            this.txtMobile.TabIndex = 2;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // orderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(696, 571);
            this.Controls.Add(this.btnKeyboard);
            this.Controls.Add(this.cmbWaiter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtReceiptType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txtChild);
            this.Controls.Add(this.txtAdultNo);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.txtWaiterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "orderInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Information - King Bar Beque Restaurant";
            this.Load += new System.EventHandler(this.orderInfo_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtWaiterName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtReceiptType;
        public System.Windows.Forms.TextBox txtFirst;
        public System.Windows.Forms.TextBox txtLast;
        public System.Windows.Forms.TextBox txtAdultNo;
        public System.Windows.Forms.TextBox txtChild;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbWaiter;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtMobile;
    }
}