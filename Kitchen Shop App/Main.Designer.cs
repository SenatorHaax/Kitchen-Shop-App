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
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            Category_name = new TextBox();
            label6 = new Label();
            ProductPanel = new Panel();
            label7 = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            expiry_date = new DateTimePicker();
            UpdateButton = new Button();
            ProdCost = new TextBox();
            label9 = new Label();
            ProdPrice = new TextBox();
            label10 = new Label();
            ProdName = new TextBox();
            label11 = new Label();
            panel3 = new Panel();
            confirm_rem = new Button();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewPictureBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
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
            Remove_Category.Click += Remove_Category_Click;
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
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(Category_name);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(437, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 260);
            panel2.TabIndex = 6;
            panel2.Visible = false;
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
            // ProductPanel
            // 
            ProductPanel.Controls.Add(label7);
            ProductPanel.Controls.Add(comboBox1);
            ProductPanel.Controls.Add(checkBox1);
            ProductPanel.Controls.Add(pictureBox2);
            ProductPanel.Controls.Add(label8);
            ProductPanel.Controls.Add(expiry_date);
            ProductPanel.Controls.Add(UpdateButton);
            ProductPanel.Controls.Add(ProdCost);
            ProductPanel.Controls.Add(label9);
            ProductPanel.Controls.Add(ProdPrice);
            ProductPanel.Controls.Add(label10);
            ProductPanel.Controls.Add(ProdName);
            ProductPanel.Controls.Add(label11);
            ProductPanel.Location = new Point(419, 33);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(264, 343);
            ProductPanel.TabIndex = 8;
            ProductPanel.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 158);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 15;
            label7.Text = "Is Product Promotional:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(226, 158);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 14;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(74, 199);
            pictureBox2.MinimumSize = new Size(100, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 135);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 5;
            label8.Text = "Expiery Date:";
            // 
            // expiry_date
            // 
            expiry_date.Location = new Point(130, 129);
            expiry_date.Name = "expiry_date";
            expiry_date.Size = new Size(134, 23);
            expiry_date.TabIndex = 6;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(89, 305);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 5;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ProdCost
            // 
            ProdCost.Location = new Point(164, 100);
            ProdCost.Name = "ProdCost";
            ProdCost.Size = new Size(100, 23);
            ProdCost.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 103);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 4;
            label9.Text = "Product Cost:";
            // 
            // ProdPrice
            // 
            ProdPrice.Location = new Point(164, 71);
            ProdPrice.Name = "ProdPrice";
            ProdPrice.Size = new Size(100, 23);
            ProdPrice.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 74);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 2;
            label10.Text = "Product Price:";
            // 
            // ProdName
            // 
            ProdName.Location = new Point(164, 42);
            ProdName.Name = "ProdName";
            ProdName.Size = new Size(100, 23);
            ProdName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 45);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 0;
            label11.Text = "Product Name:";
            // 
            // panel3
            // 
            panel3.Controls.Add(confirm_rem);
            panel3.Controls.Add(comboBox2);
            panel3.Location = new Point(422, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 9;
            panel3.Visible = false;
            // 
            // confirm_rem
            // 
            confirm_rem.Location = new Point(63, 63);
            confirm_rem.Name = "confirm_rem";
            confirm_rem.Size = new Size(75, 23);
            confirm_rem.TabIndex = 4;
            confirm_rem.Text = "Confirm Removal";
            confirm_rem.UseVisualStyleBackColor = true;
            confirm_rem.Click += confirm_rem_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(22, 14);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(156, 23);
            comboBox2.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(ProductPanel);
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
            ProductPanel.ResumeLayout(false);
            ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private TextBox Category_name;
        private Label label6;
        private Panel ProductPanel;
        private Label label7;
        private CheckBox checkBox1;
        private PictureBox pictureBox2;
        private Label label8;
        private DateTimePicker expiry_date;
        private Button UpdateButton;
        private TextBox ProdCost;
        private Label label9;
        private TextBox ProdPrice;
        private Label label10;
        private TextBox ProdName;
        private Label label11;
        private ComboBox comboBox1;
        private Panel panel3;
        private Button confirm_rem;
        private ComboBox comboBox2;
    }
}