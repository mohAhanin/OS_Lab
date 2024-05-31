namespace CafeManagementSystem2
{
    partial class Form1
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
            this.Customerbtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Staffbtn = new System.Windows.Forms.Button();
            this.InsertCustomerBtn = new System.Windows.Forms.Button();
            this.CustomerIDTxt = new System.Windows.Forms.TextBox();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteCustomerBtn = new System.Windows.Forms.Button();
            this.DeleteCustomerIDTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.UpdateCustomerBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.UpdateLastNameTxt = new System.Windows.Forms.TextBox();
            this.UpdateFirstNameTxt = new System.Windows.Forms.TextBox();
            this.UpdateCustomerIDTxt = new System.Windows.Forms.TextBox();
            this.OrderIDTxt = new System.Windows.Forms.TextBox();
            this.OrdersTxt = new System.Windows.Forms.TextBox();
            this.TotalPriceTxt = new System.Windows.Forms.TextBox();
            this.TimeTxt = new System.Windows.Forms.TextBox();
            this.DateTxt = new System.Windows.Forms.TextBox();
            this.TableNumberTxt = new System.Windows.Forms.TextBox();
            this.orderCustomerIDTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.InsertOrderBtn = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowOrdersBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Customerbtn
            // 
            this.Customerbtn.Location = new System.Drawing.Point(12, 12);
            this.Customerbtn.Name = "Customerbtn";
            this.Customerbtn.Size = new System.Drawing.Size(115, 42);
            this.Customerbtn.TabIndex = 0;
            this.Customerbtn.Text = "Show Customers";
            this.Customerbtn.UseVisualStyleBackColor = true;
            this.Customerbtn.Click += new System.EventHandler(this.Customerbtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 497);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(440, 150);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Staffbtn
            // 
            this.Staffbtn.Location = new System.Drawing.Point(795, 477);
            this.Staffbtn.Name = "Staffbtn";
            this.Staffbtn.Size = new System.Drawing.Size(135, 42);
            this.Staffbtn.TabIndex = 2;
            this.Staffbtn.Text = "Staff";
            this.Staffbtn.UseVisualStyleBackColor = true;
            this.Staffbtn.Click += new System.EventHandler(this.Staffbtn_Click);
            // 
            // InsertCustomerBtn
            // 
            this.InsertCustomerBtn.Location = new System.Drawing.Point(12, 81);
            this.InsertCustomerBtn.Name = "InsertCustomerBtn";
            this.InsertCustomerBtn.Size = new System.Drawing.Size(115, 43);
            this.InsertCustomerBtn.TabIndex = 4;
            this.InsertCustomerBtn.Text = "Insert Customer";
            this.InsertCustomerBtn.UseVisualStyleBackColor = true;
            this.InsertCustomerBtn.Click += new System.EventHandler(this.InsertCustomerBtn_Click);
            // 
            // CustomerIDTxt
            // 
            this.CustomerIDTxt.Location = new System.Drawing.Point(112, 139);
            this.CustomerIDTxt.Name = "CustomerIDTxt";
            this.CustomerIDTxt.Size = new System.Drawing.Size(107, 22);
            this.CustomerIDTxt.TabIndex = 8;
            this.CustomerIDTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(112, 167);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(107, 22);
            this.FirstNameTxt.TabIndex = 9;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(112, 195);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(107, 22);
            this.LastNameTxt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name:";
            // 
            // DeleteCustomerBtn
            // 
            this.DeleteCustomerBtn.Location = new System.Drawing.Point(12, 230);
            this.DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            this.DeleteCustomerBtn.Size = new System.Drawing.Size(115, 39);
            this.DeleteCustomerBtn.TabIndex = 14;
            this.DeleteCustomerBtn.Text = "Delete Customer";
            this.DeleteCustomerBtn.UseVisualStyleBackColor = true;
            this.DeleteCustomerBtn.Click += new System.EventHandler(this.DeleteCustomerBtn_Click);
            // 
            // DeleteCustomerIDTxt
            // 
            this.DeleteCustomerIDTxt.Location = new System.Drawing.Point(15, 303);
            this.DeleteCustomerIDTxt.Name = "DeleteCustomerIDTxt";
            this.DeleteCustomerIDTxt.Size = new System.Drawing.Size(84, 22);
            this.DeleteCustomerIDTxt.TabIndex = 15;
            this.DeleteCustomerIDTxt.TextChanged += new System.EventHandler(this.DeleteCustomerIDTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Customer ID to delete:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Location = new System.Drawing.Point(434, 396);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(194, 16);
            this.DateTimeLabel.TabIndex = 33;
            this.DateTimeLabel.Text = "Date and Time will appear here";
            this.DateTimeLabel.Click += new System.EventHandler(this.DateTimeLabel_Click);
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Interval = 1000;
            this.DateTimeTimer.Tick += new System.EventHandler(this.DateTimeTimer_Tick);
            // 
            // UpdateCustomerBtn
            // 
            this.UpdateCustomerBtn.Location = new System.Drawing.Point(12, 355);
            this.UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            this.UpdateCustomerBtn.Size = new System.Drawing.Size(115, 43);
            this.UpdateCustomerBtn.TabIndex = 35;
            this.UpdateCustomerBtn.Text = "Update Customer";
            this.UpdateCustomerBtn.UseVisualStyleBackColor = true;
            this.UpdateCustomerBtn.Click += new System.EventHandler(this.UpdateCustomerBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "Last Name:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "First Name:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "Customer ID:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // UpdateLastNameTxt
            // 
            this.UpdateLastNameTxt.Location = new System.Drawing.Point(120, 469);
            this.UpdateLastNameTxt.Name = "UpdateLastNameTxt";
            this.UpdateLastNameTxt.Size = new System.Drawing.Size(107, 22);
            this.UpdateLastNameTxt.TabIndex = 38;
            this.UpdateLastNameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UpdateFirstNameTxt
            // 
            this.UpdateFirstNameTxt.Location = new System.Drawing.Point(120, 441);
            this.UpdateFirstNameTxt.Name = "UpdateFirstNameTxt";
            this.UpdateFirstNameTxt.Size = new System.Drawing.Size(107, 22);
            this.UpdateFirstNameTxt.TabIndex = 37;
            this.UpdateFirstNameTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UpdateCustomerIDTxt
            // 
            this.UpdateCustomerIDTxt.Location = new System.Drawing.Point(120, 413);
            this.UpdateCustomerIDTxt.Name = "UpdateCustomerIDTxt";
            this.UpdateCustomerIDTxt.Size = new System.Drawing.Size(107, 22);
            this.UpdateCustomerIDTxt.TabIndex = 36;
            this.UpdateCustomerIDTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // OrderIDTxt
            // 
            this.OrderIDTxt.Location = new System.Drawing.Point(494, 146);
            this.OrderIDTxt.Name = "OrderIDTxt";
            this.OrderIDTxt.Size = new System.Drawing.Size(134, 22);
            this.OrderIDTxt.TabIndex = 17;
            // 
            // OrdersTxt
            // 
            this.OrdersTxt.Location = new System.Drawing.Point(494, 314);
            this.OrdersTxt.Name = "OrdersTxt";
            this.OrdersTxt.Size = new System.Drawing.Size(134, 22);
            this.OrdersTxt.TabIndex = 18;
            // 
            // TotalPriceTxt
            // 
            this.TotalPriceTxt.Location = new System.Drawing.Point(494, 286);
            this.TotalPriceTxt.Name = "TotalPriceTxt";
            this.TotalPriceTxt.Size = new System.Drawing.Size(134, 22);
            this.TotalPriceTxt.TabIndex = 19;
            // 
            // TimeTxt
            // 
            this.TimeTxt.Location = new System.Drawing.Point(494, 258);
            this.TimeTxt.Name = "TimeTxt";
            this.TimeTxt.Size = new System.Drawing.Size(134, 22);
            this.TimeTxt.TabIndex = 20;
            // 
            // DateTxt
            // 
            this.DateTxt.Location = new System.Drawing.Point(494, 230);
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.Size = new System.Drawing.Size(134, 22);
            this.DateTxt.TabIndex = 21;
            // 
            // TableNumberTxt
            // 
            this.TableNumberTxt.Location = new System.Drawing.Point(494, 202);
            this.TableNumberTxt.Name = "TableNumberTxt";
            this.TableNumberTxt.Size = new System.Drawing.Size(134, 22);
            this.TableNumberTxt.TabIndex = 22;
            // 
            // orderCustomerIDTxt
            // 
            this.orderCustomerIDTxt.Location = new System.Drawing.Point(494, 174);
            this.orderCustomerIDTxt.Name = "orderCustomerIDTxt";
            this.orderCustomerIDTxt.Size = new System.Drawing.Size(134, 22);
            this.orderCustomerIDTxt.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Order ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Customer ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Table Number:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Total Price:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Orders:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // InsertOrderBtn
            // 
            this.InsertOrderBtn.Location = new System.Drawing.Point(391, 82);
            this.InsertOrderBtn.Name = "InsertOrderBtn";
            this.InsertOrderBtn.Size = new System.Drawing.Size(135, 42);
            this.InsertOrderBtn.TabIndex = 31;
            this.InsertOrderBtn.Text = "Insert Order";
            this.InsertOrderBtn.UseVisualStyleBackColor = true;
            this.InsertOrderBtn.Click += new System.EventHandler(this.InsertOrderBtn_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(648, 12);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.Size = new System.Drawing.Size(508, 184);
            this.ordersDataGridView.TabIndex = 32;
            // 
            // ShowOrdersBtn
            // 
            this.ShowOrdersBtn.Location = new System.Drawing.Point(391, 12);
            this.ShowOrdersBtn.Name = "ShowOrdersBtn";
            this.ShowOrdersBtn.Size = new System.Drawing.Size(135, 40);
            this.ShowOrdersBtn.TabIndex = 34;
            this.ShowOrdersBtn.Text = "Show Orders";
            this.ShowOrdersBtn.UseVisualStyleBackColor = true;
            this.ShowOrdersBtn.Click += new System.EventHandler(this.ShowOrdersBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(798, 533);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Click to Manage Staff";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 687);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.UpdateLastNameTxt);
            this.Controls.Add(this.UpdateFirstNameTxt);
            this.Controls.Add(this.UpdateCustomerIDTxt);
            this.Controls.Add(this.UpdateCustomerBtn);
            this.Controls.Add(this.ShowOrdersBtn);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.InsertOrderBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderCustomerIDTxt);
            this.Controls.Add(this.TableNumberTxt);
            this.Controls.Add(this.DateTxt);
            this.Controls.Add(this.TimeTxt);
            this.Controls.Add(this.TotalPriceTxt);
            this.Controls.Add(this.OrdersTxt);
            this.Controls.Add(this.OrderIDTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteCustomerIDTxt);
            this.Controls.Add(this.DeleteCustomerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.CustomerIDTxt);
            this.Controls.Add(this.InsertCustomerBtn);
            this.Controls.Add(this.Staffbtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Customerbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Customerbtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Staffbtn;
        private System.Windows.Forms.Button InsertCustomerBtn;
        private System.Windows.Forms.TextBox CustomerIDTxt;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteCustomerBtn;
        private System.Windows.Forms.TextBox DeleteCustomerIDTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.Button UpdateCustomerBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox UpdateLastNameTxt;
        private System.Windows.Forms.TextBox UpdateFirstNameTxt;
        private System.Windows.Forms.TextBox UpdateCustomerIDTxt;
        private System.Windows.Forms.TextBox OrderIDTxt;
        private System.Windows.Forms.TextBox OrdersTxt;
        private System.Windows.Forms.TextBox TotalPriceTxt;
        private System.Windows.Forms.TextBox TimeTxt;
        private System.Windows.Forms.TextBox DateTxt;
        private System.Windows.Forms.TextBox TableNumberTxt;
        private System.Windows.Forms.TextBox orderCustomerIDTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button InsertOrderBtn;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button ShowOrdersBtn;
        private System.Windows.Forms.Label label15;
    }
}

