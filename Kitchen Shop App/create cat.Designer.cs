namespace Kitchen_Shop_App
{
    partial class create_cat
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
            panel1 = new Panel();
            button1 = new Button();
            previewPictureBox = new PictureBox();
            btnUpload = new Button();
            Finalize_prod = new Button();
            Category_name = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(previewPictureBox);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(Finalize_prod);
            panel1.Controls.Add(Category_name);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 260);
            panel1.TabIndex = 3;
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
            // previewPictureBox
            // 
            previewPictureBox.Location = new Point(58, 74);
            previewPictureBox.MinimumSize = new Size(100, 100);
            previewPictureBox.Name = "previewPictureBox";
            previewPictureBox.Size = new Size(100, 100);
            previewPictureBox.TabIndex = 8;
            previewPictureBox.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(48, 200);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(123, 23);
            btnUpload.TabIndex = 7;
            btnUpload.Text = "Upload image";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // Finalize_prod
            // 
            Finalize_prod.Location = new Point(48, 229);
            Finalize_prod.Name = "Finalize_prod";
            Finalize_prod.Size = new Size(123, 23);
            Finalize_prod.TabIndex = 4;
            Finalize_prod.Text = "Create Category";
            Finalize_prod.UseVisualStyleBackColor = true;
            Finalize_prod.Click += Finalize_prod_Click_1;
            // 
            // Category_name
            // 
            Category_name.Location = new Point(101, 32);
            Category_name.Name = "Category_name";
            Category_name.Size = new Size(100, 23);
            Category_name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // create_cat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 385);
            Controls.Add(panel1);
            Name = "create_cat";
            Text = "create_cat";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpload;
        private Button Finalize_prod;
        private TextBox Category_name;
        private Label label1;
        private PictureBox previewPictureBox;
        private Button button1;
    }
}