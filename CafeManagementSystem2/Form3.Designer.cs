namespace CafeManagementSystem2
{
    partial class Form3
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
            this.Staffbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addStaffbtn = new System.Windows.Forms.Button();
            this.deleteStaffbtn = new System.Windows.Forms.Button();
            this.UpdateStaffBtn = new System.Windows.Forms.Button();
            this.StaffIDtext = new System.Windows.Forms.TextBox();
            this.StaffFirstNametext = new System.Windows.Forms.TextBox();
            this.StaffLastNametext = new System.Windows.Forms.TextBox();
            this.StaffIDlabel = new System.Windows.Forms.Label();
            this.StaffFirstNamelabel = new System.Windows.Forms.Label();
            this.StaffLastNamelabel = new System.Windows.Forms.Label();
            this.StaffLastNameUpdateLabel = new System.Windows.Forms.Label();
            this.StaffFirstNameUpdateLabel = new System.Windows.Forms.Label();
            this.StaffIDUpdateLabel = new System.Windows.Forms.Label();
            this.StaffLastNameUpdateText = new System.Windows.Forms.TextBox();
            this.StaffFirstNameUpdateText = new System.Windows.Forms.TextBox();
            this.StaffIDUpdateText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffIDDeleteText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Staffbtn
            // 
            this.Staffbtn.Location = new System.Drawing.Point(348, 12);
            this.Staffbtn.Name = "Staffbtn";
            this.Staffbtn.Size = new System.Drawing.Size(135, 42);
            this.Staffbtn.TabIndex = 3;
            this.Staffbtn.Text = "Show Staff";
            this.Staffbtn.UseVisualStyleBackColor = true;
            this.Staffbtn.Click += new System.EventHandler(this.Staffbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addStaffbtn
            // 
            this.addStaffbtn.Location = new System.Drawing.Point(348, 70);
            this.addStaffbtn.Name = "addStaffbtn";
            this.addStaffbtn.Size = new System.Drawing.Size(135, 42);
            this.addStaffbtn.TabIndex = 5;
            this.addStaffbtn.Text = "Add Staff";
            this.addStaffbtn.UseVisualStyleBackColor = true;
            // 
            // deleteStaffbtn
            // 
            this.deleteStaffbtn.Location = new System.Drawing.Point(522, 70);
            this.deleteStaffbtn.Name = "deleteStaffbtn";
            this.deleteStaffbtn.Size = new System.Drawing.Size(135, 42);
            this.deleteStaffbtn.TabIndex = 6;
            this.deleteStaffbtn.Text = "Remove Staff";
            this.deleteStaffbtn.UseVisualStyleBackColor = true;
            this.deleteStaffbtn.Click += new System.EventHandler(this.deleteStaffbtn_Click);
            // 
            // UpdateStaffBtn
            // 
            this.UpdateStaffBtn.Location = new System.Drawing.Point(176, 70);
            this.UpdateStaffBtn.Name = "UpdateStaffBtn";
            this.UpdateStaffBtn.Size = new System.Drawing.Size(135, 42);
            this.UpdateStaffBtn.TabIndex = 7;
            this.UpdateStaffBtn.Text = "Update Staff";
            this.UpdateStaffBtn.UseVisualStyleBackColor = true;
            this.UpdateStaffBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // StaffIDtext
            // 
            this.StaffIDtext.Location = new System.Drawing.Point(348, 159);
            this.StaffIDtext.Name = "StaffIDtext";
            this.StaffIDtext.Size = new System.Drawing.Size(135, 22);
            this.StaffIDtext.TabIndex = 8;
            // 
            // StaffFirstNametext
            // 
            this.StaffFirstNametext.Location = new System.Drawing.Point(348, 239);
            this.StaffFirstNametext.Name = "StaffFirstNametext";
            this.StaffFirstNametext.Size = new System.Drawing.Size(135, 22);
            this.StaffFirstNametext.TabIndex = 9;
            // 
            // StaffLastNametext
            // 
            this.StaffLastNametext.Location = new System.Drawing.Point(348, 340);
            this.StaffLastNametext.Name = "StaffLastNametext";
            this.StaffLastNametext.Size = new System.Drawing.Size(135, 22);
            this.StaffLastNametext.TabIndex = 10;
            this.StaffLastNametext.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // StaffIDlabel
            // 
            this.StaffIDlabel.AutoSize = true;
            this.StaffIDlabel.Location = new System.Drawing.Point(392, 129);
            this.StaffIDlabel.Name = "StaffIDlabel";
            this.StaffIDlabel.Size = new System.Drawing.Size(46, 16);
            this.StaffIDlabel.TabIndex = 11;
            this.StaffIDlabel.Text = "StaffID";
            this.StaffIDlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StaffFirstNamelabel
            // 
            this.StaffFirstNamelabel.AutoSize = true;
            this.StaffFirstNamelabel.Location = new System.Drawing.Point(365, 193);
            this.StaffFirstNamelabel.Name = "StaffFirstNamelabel";
            this.StaffFirstNamelabel.Size = new System.Drawing.Size(101, 16);
            this.StaffFirstNamelabel.TabIndex = 12;
            this.StaffFirstNamelabel.Text = "Staff First Name";
            this.StaffFirstNamelabel.Click += new System.EventHandler(this.StaffFirstNamelabel_Click);
            // 
            // StaffLastNamelabel
            // 
            this.StaffLastNamelabel.AutoSize = true;
            this.StaffLastNamelabel.Location = new System.Drawing.Point(365, 293);
            this.StaffLastNamelabel.Name = "StaffLastNamelabel";
            this.StaffLastNamelabel.Size = new System.Drawing.Size(101, 16);
            this.StaffLastNamelabel.TabIndex = 13;
            this.StaffLastNamelabel.Text = "Staff Last Name";
            this.StaffLastNamelabel.Click += new System.EventHandler(this.StaffLastNamelabel_Click);
            // 
            // StaffLastNameUpdateLabel
            // 
            this.StaffLastNameUpdateLabel.AutoSize = true;
            this.StaffLastNameUpdateLabel.Location = new System.Drawing.Point(193, 293);
            this.StaffLastNameUpdateLabel.Name = "StaffLastNameUpdateLabel";
            this.StaffLastNameUpdateLabel.Size = new System.Drawing.Size(101, 16);
            this.StaffLastNameUpdateLabel.TabIndex = 19;
            this.StaffLastNameUpdateLabel.Text = "Staff Last Name";
            // 
            // StaffFirstNameUpdateLabel
            // 
            this.StaffFirstNameUpdateLabel.AutoSize = true;
            this.StaffFirstNameUpdateLabel.Location = new System.Drawing.Point(193, 193);
            this.StaffFirstNameUpdateLabel.Name = "StaffFirstNameUpdateLabel";
            this.StaffFirstNameUpdateLabel.Size = new System.Drawing.Size(101, 16);
            this.StaffFirstNameUpdateLabel.TabIndex = 18;
            this.StaffFirstNameUpdateLabel.Text = "Staff First Name";
            // 
            // StaffIDUpdateLabel
            // 
            this.StaffIDUpdateLabel.AutoSize = true;
            this.StaffIDUpdateLabel.Location = new System.Drawing.Point(220, 129);
            this.StaffIDUpdateLabel.Name = "StaffIDUpdateLabel";
            this.StaffIDUpdateLabel.Size = new System.Drawing.Size(46, 16);
            this.StaffIDUpdateLabel.TabIndex = 17;
            this.StaffIDUpdateLabel.Text = "StaffID";
            // 
            // StaffLastNameUpdateText
            // 
            this.StaffLastNameUpdateText.Location = new System.Drawing.Point(176, 340);
            this.StaffLastNameUpdateText.Name = "StaffLastNameUpdateText";
            this.StaffLastNameUpdateText.Size = new System.Drawing.Size(135, 22);
            this.StaffLastNameUpdateText.TabIndex = 16;
            // 
            // StaffFirstNameUpdateText
            // 
            this.StaffFirstNameUpdateText.Location = new System.Drawing.Point(176, 239);
            this.StaffFirstNameUpdateText.Name = "StaffFirstNameUpdateText";
            this.StaffFirstNameUpdateText.Size = new System.Drawing.Size(135, 22);
            this.StaffFirstNameUpdateText.TabIndex = 15;
            // 
            // StaffIDUpdateText
            // 
            this.StaffIDUpdateText.Location = new System.Drawing.Point(176, 159);
            this.StaffIDUpdateText.Name = "StaffIDUpdateText";
            this.StaffIDUpdateText.Size = new System.Drawing.Size(135, 22);
            this.StaffIDUpdateText.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "StaffID";
            // 
            // StaffIDDeleteText
            // 
            this.StaffIDDeleteText.Location = new System.Drawing.Point(522, 159);
            this.StaffIDDeleteText.Name = "StaffIDDeleteText";
            this.StaffIDDeleteText.Size = new System.Drawing.Size(135, 22);
            this.StaffIDDeleteText.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StaffIDDeleteText);
            this.Controls.Add(this.StaffLastNameUpdateLabel);
            this.Controls.Add(this.StaffFirstNameUpdateLabel);
            this.Controls.Add(this.StaffIDUpdateLabel);
            this.Controls.Add(this.StaffLastNameUpdateText);
            this.Controls.Add(this.StaffFirstNameUpdateText);
            this.Controls.Add(this.StaffIDUpdateText);
            this.Controls.Add(this.StaffLastNamelabel);
            this.Controls.Add(this.StaffFirstNamelabel);
            this.Controls.Add(this.StaffIDlabel);
            this.Controls.Add(this.StaffLastNametext);
            this.Controls.Add(this.StaffFirstNametext);
            this.Controls.Add(this.StaffIDtext);
            this.Controls.Add(this.UpdateStaffBtn);
            this.Controls.Add(this.deleteStaffbtn);
            this.Controls.Add(this.addStaffbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Staffbtn);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Staffbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addStaffbtn;
        private System.Windows.Forms.Button deleteStaffbtn;
        private System.Windows.Forms.Button UpdateStaffBtn;
        private System.Windows.Forms.TextBox StaffIDtext;
        private System.Windows.Forms.TextBox StaffFirstNametext;
        private System.Windows.Forms.TextBox StaffLastNametext;
        private System.Windows.Forms.Label StaffIDlabel;
        private System.Windows.Forms.Label StaffFirstNamelabel;
        private System.Windows.Forms.Label StaffLastNamelabel;
        private System.Windows.Forms.Label StaffLastNameUpdateLabel;
        private System.Windows.Forms.Label StaffFirstNameUpdateLabel;
        private System.Windows.Forms.Label StaffIDUpdateLabel;
        private System.Windows.Forms.TextBox StaffLastNameUpdateText;
        private System.Windows.Forms.TextBox StaffFirstNameUpdateText;
        private System.Windows.Forms.TextBox StaffIDUpdateText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StaffIDDeleteText;
    }
}