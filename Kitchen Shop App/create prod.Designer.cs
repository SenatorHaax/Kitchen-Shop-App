namespace Kitchen_staff_app
{
    partial class create_prod
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
            this.Product_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.Product_cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Finalize_prod = new System.Windows.Forms.Button();
            this.Product_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Product_name
            // 
            this.Product_name.Location = new System.Drawing.Point(100, 27);
            this.Product_name.Name = "Product_name";
            this.Product_name.Size = new System.Drawing.Size(100, 23);
            this.Product_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Navn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.categoryBox);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.Product_cost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Finalize_prod);
            this.panel1.Controls.Add(this.Product_price);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Product_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 393);
            this.panel1.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(14, 116);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(55, 15);
            this.categoryLabel.TabIndex = 9;
            this.categoryLabel.Text = "Category";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(99, 113);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(121, 23);
            this.categoryBox.TabIndex = 8;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(47, 175);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(123, 23);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Product_cost
            // 
            this.Product_cost.Location = new System.Drawing.Point(100, 84);
            this.Product_cost.Name = "Product_cost";
            this.Product_cost.Size = new System.Drawing.Size(100, 23);
            this.Product_cost.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Cost";
            // 
            // Finalize_prod
            // 
            this.Finalize_prod.Location = new System.Drawing.Point(47, 355);
            this.Finalize_prod.Name = "Finalize_prod";
            this.Finalize_prod.Size = new System.Drawing.Size(123, 23);
            this.Finalize_prod.TabIndex = 4;
            this.Finalize_prod.Text = "Create Product";
            this.Finalize_prod.UseVisualStyleBackColor = true;
            this.Finalize_prod.Click += new System.EventHandler(this.Finalize_prod_Click);
            // 
            // Product_price
            // 
            this.Product_price.Location = new System.Drawing.Point(100, 56);
            this.Product_price.Name = "Product_price";
            this.Product_price.Size = new System.Drawing.Size(100, 23);
            this.Product_price.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Pris";
            // 
            // create_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 507);
            this.Controls.Add(this.panel1);
            this.Name = "create_prod";
            this.Text = "create_prod";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox Product_name;
        private Label label1;
        private Panel panel1;
        private TextBox Product_price;
        private Label label2;
        private Button Finalize_prod;
        private TextBox Product_cost;
        private Label label3;
        private Button btnUpload;
        private Label categoryLabel;
        private ComboBox categoryBox;
    }
}