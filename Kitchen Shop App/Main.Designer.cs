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
            groupBox1 = new GroupBox();
            Create_Product = new Button();
            Remove_Product = new Button();
            Edit_Product = new Button();
            groupBox2 = new GroupBox();
            genStats = new Button();
            busyHoursBtn = new Button();
            profChartBtn = new Button();
            soldStatBtn = new Button();
            button7 = new Button();
            groupBox3 = new GroupBox();
            Create_Category = new Button();
            Remove_Category = new Button();
            donebtn = new Button();
            panel1 = new Panel();
            label5 = new Label();
            is_promotional = new CheckBox();
            label4 = new Label();
            exp_date = new DateTimePicker();
            previewPictureBox = new PictureBox();
            categoryLabel = new Label();
            categoryBox = new ComboBox();
            btnUpload = new Button();
            Product_cost = new TextBox();
            label3 = new Label();
            Finalize_prod = new Button();
            Product_price = new TextBox();
            label2 = new Label();
            Product_name = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            Category_name = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewPictureBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Create_Product);
            groupBox1.Controls.Add(Remove_Product);
            groupBox1.Controls.Add(Edit_Product);
            groupBox1.Location = new Point(3, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Products";
            // 
            // Create_Product
            // 
            Create_Product.Location = new Point(235, 22);
            Create_Product.Name = "Create_Product";
            Create_Product.Size = new Size(95, 59);
            Create_Product.TabIndex = 2;
            Create_Product.Text = "Create Product";
            Create_Product.UseVisualStyleBackColor = true;
            Create_Product.Click += Create_Prod_button;
            // 
            // Remove_Product
            // 
            Remove_Product.Location = new Point(122, 22);
            Remove_Product.Name = "Remove_Product";
            Remove_Product.Size = new Size(95, 59);
            Remove_Product.TabIndex = 1;
            Remove_Product.Text = "Remove Products";
            Remove_Product.UseVisualStyleBackColor = true;
            Remove_Product.Click += Remove_Product_Click;
            // 
            // Edit_Product
            // 
            Edit_Product.Location = new Point(6, 22);
            Edit_Product.Name = "Edit_Product";
            Edit_Product.Size = new Size(95, 59);
            Edit_Product.TabIndex = 0;
            Edit_Product.Text = "Edit Products";
            Edit_Product.UseVisualStyleBackColor = true;
            Edit_Product.Click += Edit_Product_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(genStats);
            groupBox2.Controls.Add(busyHoursBtn);
            groupBox2.Controls.Add(profChartBtn);
            groupBox2.Controls.Add(soldStatBtn);
            groupBox2.Location = new Point(3, 348);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Statistics";
            // 
            // genStats
            // 
            genStats.Location = new Point(6, 71);
            genStats.Name = "genStats";
            genStats.Size = new Size(95, 23);
            genStats.TabIndex = 3;
            genStats.Text = "General Stats";
            genStats.UseVisualStyleBackColor = true;
            genStats.Click += genStats_Click;
            // 
            // busyHoursBtn
            // 
            busyHoursBtn.Location = new Point(235, 22);
            busyHoursBtn.Name = "busyHoursBtn";
            busyHoursBtn.Size = new Size(95, 23);
            busyHoursBtn.TabIndex = 2;
            busyHoursBtn.Text = "Busy Hours";
            busyHoursBtn.UseVisualStyleBackColor = true;
            busyHoursBtn.Click += busyHoursBtn_Click;
            // 
            // profChartBtn
            // 
            profChartBtn.Location = new Point(122, 22);
            profChartBtn.Name = "profChartBtn";
            profChartBtn.Size = new Size(95, 23);
            profChartBtn.TabIndex = 1;
            profChartBtn.Text = "Profit Chart";
            profChartBtn.UseVisualStyleBackColor = true;
            profChartBtn.Click += profChartBtn_Click;
            // 
            // soldStatBtn
            // 
            soldStatBtn.Location = new Point(6, 22);
            soldStatBtn.Name = "soldStatBtn";
            soldStatBtn.Size = new Size(95, 23);
            soldStatBtn.TabIndex = 0;
            soldStatBtn.Text = "Most Sold";
            soldStatBtn.UseVisualStyleBackColor = true;
            soldStatBtn.Click += soldStatBtn_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Location = new Point(12, 12);
            button7.Name = "button7";
            button7.Size = new Size(95, 59);
            button7.TabIndex = 3;
            button7.Text = "PANIK";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Create_Category);
            groupBox3.Controls.Add(Remove_Category);
            groupBox3.Location = new Point(3, 242);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(336, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Category";
            // 
            // Create_Category
            // 
            Create_Category.Location = new Point(235, 22);
            Create_Category.Name = "Create_Category";
            Create_Category.Size = new Size(95, 59);
            Create_Category.TabIndex = 2;
            Create_Category.Text = "Create Category";
            Create_Category.UseVisualStyleBackColor = true;
            Create_Category.Click += Create_Category_Click;
            // 
            // Remove_Category
            // 
            Remove_Category.Enabled = false;
            Remove_Category.Location = new Point(6, 22);
            Remove_Category.Name = "Remove_Category";
            Remove_Category.Size = new Size(95, 59);
            Remove_Category.TabIndex = 1;
            Remove_Category.Text = "Remove Category";
            Remove_Category.UseVisualStyleBackColor = true;
            // 
            // donebtn
            // 
            donebtn.BackColor = Color.Green;
            donebtn.Location = new Point(693, 379);
            donebtn.Name = "donebtn";
            donebtn.Size = new Size(95, 59);
            donebtn.TabIndex = 4;
            donebtn.Text = "Done";
            donebtn.UseVisualStyleBackColor = false;
            donebtn.Click += donebtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(is_promotional);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(exp_date);
            panel1.Controls.Add(previewPictureBox);
            panel1.Controls.Add(categoryLabel);
            panel1.Controls.Add(categoryBox);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(Product_cost);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Finalize_prod);
            panel1.Controls.Add(Product_price);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Product_name);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(440, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 393);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 171);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 13;
            label5.Text = "Is Product Promotional";
            // 
            // is_promotional
            // 
            is_promotional.AutoSize = true;
            is_promotional.Location = new Point(185, 172);
            is_promotional.Name = "is_promotional";
            is_promotional.Size = new Size(15, 14);
            is_promotional.TabIndex = 12;
            is_promotional.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 148);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 11;
            label4.Text = "Expiery Date:";
            // 
            // exp_date
            // 
            exp_date.Location = new Point(100, 142);
            exp_date.Name = "exp_date";
            exp_date.Size = new Size(121, 23);
            exp_date.TabIndex = 10;
            // 
            // previewPictureBox
            // 
            previewPictureBox.Location = new Point(58, 220);
            previewPictureBox.MinimumSize = new Size(100, 100);
            previewPictureBox.Name = "previewPictureBox";
            previewPictureBox.Size = new Size(100, 100);
            previewPictureBox.TabIndex = 9;
            previewPictureBox.TabStop = false;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(14, 116);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(55, 15);
            categoryLabel.TabIndex = 9;
            categoryLabel.Text = "Category";
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Location = new Point(100, 113);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(121, 23);
            categoryBox.TabIndex = 8;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(47, 326);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(123, 23);
            btnUpload.TabIndex = 7;
            btnUpload.Text = "Upload image";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // Product_cost
            // 
            Product_cost.Location = new Point(100, 84);
            Product_cost.Name = "Product_cost";
            Product_cost.Size = new Size(100, 23);
            Product_cost.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 87);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 5;
            label3.Text = "Product Cost";
            // 
            // Finalize_prod
            // 
            Finalize_prod.Location = new Point(47, 355);
            Finalize_prod.Name = "Finalize_prod";
            Finalize_prod.Size = new Size(123, 23);
            Finalize_prod.TabIndex = 4;
            Finalize_prod.Text = "Create Product";
            Finalize_prod.UseVisualStyleBackColor = true;
            Finalize_prod.Click += Finalize_prod_Click;
            // 
            // Product_price
            // 
            Product_price.Location = new Point(100, 56);
            Product_price.Name = "Product_price";
            Product_price.Size = new Size(100, 23);
            Product_price.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 59);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Product Pris";
            // 
            // Product_name
            // 
            Product_name.Location = new Point(100, 27);
            Product_name.Name = "Product_name";
            Product_name.Size = new Size(100, 23);
            Product_name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 30);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Product Navn";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(Category_name);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(440, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 260);
            panel2.TabIndex = 6;
            panel2.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(145, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(58, 74);
            pictureBox1.MinimumSize = new Size(100, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(48, 200);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 7;
            button2.Text = "Upload image";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(48, 229);
            button3.Name = "button3";
            button3.Size = new Size(123, 23);
            button3.TabIndex = 4;
            button3.Text = "Create Category";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Category_name
            // 
            Category_name.Location = new Point(101, 32);
            Category_name.Name = "Category_name";
            Category_name.Size = new Size(100, 23);
            Category_name.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 35);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 1;
            label6.Text = "Category";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(donebtn);
            Controls.Add(groupBox3);
            Controls.Add(button7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Main";
            Text = "Main";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Button donebtn;
        private Panel panel1;
        private Label label5;
        private CheckBox is_promotional;
        private Label label4;
        private DateTimePicker exp_date;
        private PictureBox previewPictureBox;
        private Label categoryLabel;
        private ComboBox categoryBox;
        private Button btnUpload;
        private TextBox Product_cost;
        private Label label3;
        private Button Finalize_prod;
        private TextBox Product_price;
        private Label label2;
        private TextBox Product_name;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private TextBox Category_name;
        private Label label6;
    }
}