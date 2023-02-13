namespace Kitchen_staff_app
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Create_Product = new System.Windows.Forms.Button();
            this.Remove_Product = new System.Windows.Forms.Button();
            this.Edit_Product = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.genStats = new System.Windows.Forms.Button();
            this.busyHoursBtn = new System.Windows.Forms.Button();
            this.profChartBtn = new System.Windows.Forms.Button();
            this.soldStatBtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Create_Category = new System.Windows.Forms.Button();
            this.Remove_Category = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Create_Product);
            this.groupBox1.Controls.Add(this.Remove_Product);
            this.groupBox1.Controls.Add(this.Edit_Product);
            this.groupBox1.Location = new System.Drawing.Point(173, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Create_Product
            // 
            this.Create_Product.Location = new System.Drawing.Point(235, 22);
            this.Create_Product.Name = "Create_Product";
            this.Create_Product.Size = new System.Drawing.Size(95, 59);
            this.Create_Product.TabIndex = 2;
            this.Create_Product.Text = "Create Product";
            this.Create_Product.UseVisualStyleBackColor = true;
            this.Create_Product.Click += new System.EventHandler(this.Create_Prod_button);
            // 
            // Remove_Product
            // 
            this.Remove_Product.Location = new System.Drawing.Point(122, 22);
            this.Remove_Product.Name = "Remove_Product";
            this.Remove_Product.Size = new System.Drawing.Size(95, 59);
            this.Remove_Product.TabIndex = 1;
            this.Remove_Product.Text = "Remove Products";
            this.Remove_Product.UseVisualStyleBackColor = true;
            this.Remove_Product.Click += new System.EventHandler(this.Remove_Product_Click);
            // 
            // Edit_Product
            // 
            this.Edit_Product.Location = new System.Drawing.Point(6, 22);
            this.Edit_Product.Name = "Edit_Product";
            this.Edit_Product.Size = new System.Drawing.Size(95, 59);
            this.Edit_Product.TabIndex = 0;
            this.Edit_Product.Text = "Edit Products";
            this.Edit_Product.UseVisualStyleBackColor = true;
            this.Edit_Product.Click += new System.EventHandler(this.Edit_Product_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.genStats);
            this.groupBox2.Controls.Add(this.busyHoursBtn);
            this.groupBox2.Controls.Add(this.profChartBtn);
            this.groupBox2.Controls.Add(this.soldStatBtn);
            this.groupBox2.Location = new System.Drawing.Point(173, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // genStats
            // 
            this.genStats.Location = new System.Drawing.Point(6, 51);
            this.genStats.Name = "genStats";
            this.genStats.Size = new System.Drawing.Size(95, 23);
            this.genStats.TabIndex = 3;
            this.genStats.Text = "General Stats";
            this.genStats.UseVisualStyleBackColor = true;
            this.genStats.Click += new System.EventHandler(this.genStats_Click);
            // 
            // busyHoursBtn
            // 
            this.busyHoursBtn.Enabled = false;
            this.busyHoursBtn.Location = new System.Drawing.Point(235, 22);
            this.busyHoursBtn.Name = "busyHoursBtn";
            this.busyHoursBtn.Size = new System.Drawing.Size(95, 23);
            this.busyHoursBtn.TabIndex = 2;
            this.busyHoursBtn.Text = "Busy Hours";
            this.busyHoursBtn.UseVisualStyleBackColor = true;
            this.busyHoursBtn.Click += new System.EventHandler(this.busyHoursBtn_Click);
            // 
            // profChartBtn
            // 
            this.profChartBtn.Location = new System.Drawing.Point(122, 22);
            this.profChartBtn.Name = "profChartBtn";
            this.profChartBtn.Size = new System.Drawing.Size(95, 23);
            this.profChartBtn.TabIndex = 1;
            this.profChartBtn.Text = "Profit Chart";
            this.profChartBtn.UseVisualStyleBackColor = true;
            this.profChartBtn.Click += new System.EventHandler(this.profChartBtn_Click);
            // 
            // soldStatBtn
            // 
            this.soldStatBtn.Enabled = false;
            this.soldStatBtn.Location = new System.Drawing.Point(6, 22);
            this.soldStatBtn.Name = "soldStatBtn";
            this.soldStatBtn.Size = new System.Drawing.Size(95, 23);
            this.soldStatBtn.TabIndex = 0;
            this.soldStatBtn.Text = "Most Sold";
            this.soldStatBtn.UseVisualStyleBackColor = true;
            this.soldStatBtn.Click += new System.EventHandler(this.soldStatBtn_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(12, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 59);
            this.button7.TabIndex = 3;
            this.button7.Text = "PANIK";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Create_Category);
            this.groupBox3.Controls.Add(this.Remove_Category);
            this.groupBox3.Location = new System.Drawing.Point(173, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category";
            // 
            // Create_Category
            // 
            this.Create_Category.Location = new System.Drawing.Point(235, 22);
            this.Create_Category.Name = "Create_Category";
            this.Create_Category.Size = new System.Drawing.Size(95, 59);
            this.Create_Category.TabIndex = 2;
            this.Create_Category.Text = "Create Category";
            this.Create_Category.UseVisualStyleBackColor = true;
            this.Create_Category.Click += new System.EventHandler(this.Create_Category_Click);
            // 
            // Remove_Category
            // 
            this.Remove_Category.Enabled = false;
            this.Remove_Category.Location = new System.Drawing.Point(6, 22);
            this.Remove_Category.Name = "Remove_Category";
            this.Remove_Category.Size = new System.Drawing.Size(95, 59);
            this.Remove_Category.TabIndex = 1;
            this.Remove_Category.Text = "Remove Category";
            this.Remove_Category.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button Edit_Product;
        private GroupBox groupBox2;
        private Button busyHoursBtn;
        private Button profChartBtn;
        private Button soldStatBtn;
        private Button Create_Product;
        private Button Remove_Product;
        private Button button7;
        private GroupBox groupBox3;
        private Button Create_Category;
        private Button Remove_Category;
        private Button genStats;
    }
}