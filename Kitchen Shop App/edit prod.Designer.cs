namespace Kitchen_staff_app
{
    partial class edit_prod
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ProdCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.UpdateButton_Update);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(139, 11);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.UpdateButton);
            this.ProductPanel.Controls.Add(this.ProdCost);
            this.ProductPanel.Controls.Add(this.label3);
            this.ProductPanel.Controls.Add(this.ProdPrice);
            this.ProductPanel.Controls.Add(this.label2);
            this.ProductPanel.Controls.Add(this.ProdName);
            this.ProductPanel.Controls.Add(this.label1);
            this.ProductPanel.Location = new System.Drawing.Point(12, 41);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(204, 397);
            this.ProductPanel.TabIndex = 4;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(64, 371);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ProdCost
            // 
            this.ProdCost.Location = new System.Drawing.Point(101, 72);
            this.ProdCost.Name = "ProdCost";
            this.ProdCost.Size = new System.Drawing.Size(100, 23);
            this.ProdCost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Cost:";
            // 
            // ProdPrice
            // 
            this.ProdPrice.Location = new System.Drawing.Point(101, 43);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(100, 23);
            this.ProdPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Price:";
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(101, 14);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(100, 23);
            this.ProdName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // edit_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 450);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.comboBox1);
            this.Name = "edit_prod";
            this.Text = "edit_prod";
            this.Load += new System.EventHandler(this.edit_prod_Load);
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private Button Cancel_button;
        private Panel ProductPanel;
        private TextBox ProdCost;
        private Label label3;
        private TextBox ProdPrice;
        private Label label2;
        private TextBox ProdName;
        private Label label1;
        private Button UpdateButton;
    }
}