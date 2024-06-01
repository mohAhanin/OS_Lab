namespace CafeManagementSystem2
{
    partial class MenuForm
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
            this.insertMenuItemBtn = new System.Windows.Forms.Button();
            this.updateMenuItemBtn = new System.Windows.Forms.Button();
            this.deleteMenuItemBtn = new System.Windows.Forms.Button();
            this.menuItemIdLabel = new System.Windows.Forms.Label();
            this.menuItemNameLabel = new System.Windows.Forms.Label();
            this.menuItemDescriptionLabel = new System.Windows.Forms.Label();
            this.menuItemPriceLabel = new System.Windows.Forms.Label();
            this.menuItemIdTxtBox = new System.Windows.Forms.TextBox();
            this.menuItemNameTxtBox = new System.Windows.Forms.TextBox();
            this.menuItemDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.menuItemPriceTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // insertMenuItemBtn
            // 
            this.insertMenuItemBtn.Location = new System.Drawing.Point(143, 47);
            this.insertMenuItemBtn.Name = "insertMenuItemBtn";
            this.insertMenuItemBtn.Size = new System.Drawing.Size(178, 53);
            this.insertMenuItemBtn.TabIndex = 0;
            this.insertMenuItemBtn.Text = "Insert Menu Item";
            this.insertMenuItemBtn.UseVisualStyleBackColor = true;
            this.insertMenuItemBtn.Click += new System.EventHandler(this.insertMenuItemBtn_Click);
            // 
            // updateMenuItemBtn
            // 
            this.updateMenuItemBtn.Location = new System.Drawing.Point(357, 47);
            this.updateMenuItemBtn.Name = "updateMenuItemBtn";
            this.updateMenuItemBtn.Size = new System.Drawing.Size(178, 53);
            this.updateMenuItemBtn.TabIndex = 1;
            this.updateMenuItemBtn.Text = "Update Menu Item";
            this.updateMenuItemBtn.UseVisualStyleBackColor = true;
            this.updateMenuItemBtn.Click += new System.EventHandler(this.updateMenuItemBtn_Click);
            // 
            // deleteMenuItemBtn
            // 
            this.deleteMenuItemBtn.Location = new System.Drawing.Point(571, 47);
            this.deleteMenuItemBtn.Name = "deleteMenuItemBtn";
            this.deleteMenuItemBtn.Size = new System.Drawing.Size(178, 53);
            this.deleteMenuItemBtn.TabIndex = 2;
            this.deleteMenuItemBtn.Text = "Delete Menu Item";
            this.deleteMenuItemBtn.UseVisualStyleBackColor = true;
            this.deleteMenuItemBtn.Click += new System.EventHandler(this.deleteMenuItemBtn_Click);
            // 
            // menuItemIdLabel
            // 
            this.menuItemIdLabel.AutoSize = true;
            this.menuItemIdLabel.Location = new System.Drawing.Point(12, 122);
            this.menuItemIdLabel.Name = "menuItemIdLabel";
            this.menuItemIdLabel.Size = new System.Drawing.Size(87, 16);
            this.menuItemIdLabel.TabIndex = 3;
            this.menuItemIdLabel.Text = "Menu Item ID:";
            // 
            // menuItemNameLabel
            // 
            this.menuItemNameLabel.AutoSize = true;
            this.menuItemNameLabel.Location = new System.Drawing.Point(12, 168);
            this.menuItemNameLabel.Name = "menuItemNameLabel";
            this.menuItemNameLabel.Size = new System.Drawing.Size(111, 16);
            this.menuItemNameLabel.TabIndex = 4;
            this.menuItemNameLabel.Text = "Menu Item Name:";
            // 
            // menuItemDescriptionLabel
            // 
            this.menuItemDescriptionLabel.AutoSize = true;
            this.menuItemDescriptionLabel.Location = new System.Drawing.Point(12, 216);
            this.menuItemDescriptionLabel.Name = "menuItemDescriptionLabel";
            this.menuItemDescriptionLabel.Size = new System.Drawing.Size(142, 16);
            this.menuItemDescriptionLabel.TabIndex = 5;
            this.menuItemDescriptionLabel.Text = "Menu Item Description:";
            // 
            // menuItemPriceLabel
            // 
            this.menuItemPriceLabel.AutoSize = true;
            this.menuItemPriceLabel.Location = new System.Drawing.Point(12, 277);
            this.menuItemPriceLabel.Name = "menuItemPriceLabel";
            this.menuItemPriceLabel.Size = new System.Drawing.Size(105, 16);
            this.menuItemPriceLabel.TabIndex = 6;
            this.menuItemPriceLabel.Text = "Menu Item Price:";
            // 
            // menuItemIdTxtBox
            // 
            this.menuItemIdTxtBox.Location = new System.Drawing.Point(254, 127);
            this.menuItemIdTxtBox.Name = "menuItemIdTxtBox";
            this.menuItemIdTxtBox.Size = new System.Drawing.Size(100, 22);
            this.menuItemIdTxtBox.TabIndex = 7;
            this.menuItemIdTxtBox.TextChanged += new System.EventHandler(this.menuItemIdTxtBox_TextChanged);
            // 
            // menuItemNameTxtBox
            // 
            this.menuItemNameTxtBox.Location = new System.Drawing.Point(254, 168);
            this.menuItemNameTxtBox.Name = "menuItemNameTxtBox";
            this.menuItemNameTxtBox.Size = new System.Drawing.Size(100, 22);
            this.menuItemNameTxtBox.TabIndex = 8;
            this.menuItemNameTxtBox.TextChanged += new System.EventHandler(this.menuItemNameTxtBox_TextChanged);
            // 
            // menuItemDescriptionTxtBox
            // 
            this.menuItemDescriptionTxtBox.Location = new System.Drawing.Point(254, 216);
            this.menuItemDescriptionTxtBox.Name = "menuItemDescriptionTxtBox";
            this.menuItemDescriptionTxtBox.Size = new System.Drawing.Size(100, 22);
            this.menuItemDescriptionTxtBox.TabIndex = 9;
            this.menuItemDescriptionTxtBox.TextChanged += new System.EventHandler(this.menuItemDescriptionTxtBox_TextChanged);
            // 
            // menuItemPriceTxtBox
            // 
            this.menuItemPriceTxtBox.Location = new System.Drawing.Point(254, 271);
            this.menuItemPriceTxtBox.Name = "menuItemPriceTxtBox";
            this.menuItemPriceTxtBox.Size = new System.Drawing.Size(100, 22);
            this.menuItemPriceTxtBox.TabIndex = 10;
            this.menuItemPriceTxtBox.TextChanged += new System.EventHandler(this.menuItemPriceTxtBox_TextChanged);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuItemPriceTxtBox);
            this.Controls.Add(this.menuItemDescriptionTxtBox);
            this.Controls.Add(this.menuItemNameTxtBox);
            this.Controls.Add(this.menuItemIdTxtBox);
            this.Controls.Add(this.menuItemPriceLabel);
            this.Controls.Add(this.menuItemDescriptionLabel);
            this.Controls.Add(this.menuItemNameLabel);
            this.Controls.Add(this.menuItemIdLabel);
            this.Controls.Add(this.deleteMenuItemBtn);
            this.Controls.Add(this.updateMenuItemBtn);
            this.Controls.Add(this.insertMenuItemBtn);
            this.Name = "MenuForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertMenuItemBtn;
        private System.Windows.Forms.Button updateMenuItemBtn;
        private System.Windows.Forms.Button deleteMenuItemBtn;
        private System.Windows.Forms.Label menuItemIdLabel;
        private System.Windows.Forms.Label menuItemNameLabel;
        private System.Windows.Forms.Label menuItemDescriptionLabel;
        private System.Windows.Forms.Label menuItemPriceLabel;
        private System.Windows.Forms.TextBox menuItemIdTxtBox;
        private System.Windows.Forms.TextBox menuItemNameTxtBox;
        private System.Windows.Forms.TextBox menuItemDescriptionTxtBox;
        private System.Windows.Forms.TextBox menuItemPriceTxtBox;
    }
}