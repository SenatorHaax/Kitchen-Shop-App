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
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.expiry_date = new System.Windows.Forms.DateTimePicker();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ProdCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.is_promotional = new System.Windows.Forms.CheckBox();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
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
            this.Cancel_button.Location = new System.Drawing.Point(198, 12);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.label5);
            this.ProductPanel.Controls.Add(this.is_promotional);
            this.ProductPanel.Controls.Add(this.previewPictureBox);
            this.ProductPanel.Controls.Add(this.label4);
            this.ProductPanel.Controls.Add(this.expiry_date);
            this.ProductPanel.Controls.Add(this.UpdateButton);
            this.ProductPanel.Controls.Add(this.ProdCost);
            this.ProductPanel.Controls.Add(this.label3);
            this.ProductPanel.Controls.Add(this.ProdPrice);
            this.ProductPanel.Controls.Add(this.label2);
            this.ProductPanel.Controls.Add(this.ProdName);
            this.ProductPanel.Controls.Add(this.label1);
            this.ProductPanel.Location = new System.Drawing.Point(12, 41);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(264, 290);
            this.ProductPanel.TabIndex = 4;
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Location = new System.Drawing.Point(80, 158);
            this.previewPictureBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(100, 100);
            this.previewPictureBox.TabIndex = 9;
            this.previewPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expiery Date:";
            // 
            // expiry_date
            // 
            this.expiry_date.Location = new System.Drawing.Point(127, 101);
            this.expiry_date.Name = "expiry_date";
            this.expiry_date.Size = new System.Drawing.Size(134, 23);
            this.expiry_date.TabIndex = 6;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(94, 264);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ProdCost
            // 
            this.ProdCost.Location = new System.Drawing.Point(161, 72);
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
            this.ProdPrice.Location = new System.Drawing.Point(161, 43);
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
            this.ProdName.Location = new System.Drawing.Point(161, 14);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Is Product Promotional:";
            // 
            // is_promotional
            // 
            this.is_promotional.AutoSize = true;
            this.is_promotional.Location = new System.Drawing.Point(223, 130);
            this.is_promotional.Name = "is_promotional";
            this.is_promotional.Size = new System.Drawing.Size(15, 14);
            this.is_promotional.TabIndex = 14;
            this.is_promotional.UseVisualStyleBackColor = true;
            // 
            // edit_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 425);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.comboBox1);
            this.Name = "edit_prod";
            this.Text = "edit_prod";
            this.Load += new System.EventHandler(this.edit_prod_Load);
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
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
        private Label label4;
        private DateTimePicker expiry_date;
        private PictureBox previewPictureBox;
        private Label label5;
        private CheckBox is_promotional;
    }
}