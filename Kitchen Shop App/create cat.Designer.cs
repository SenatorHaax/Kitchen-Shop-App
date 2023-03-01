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
            this.panel1 = new System.Windows.Forms.Panel();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.Finalize_prod = new System.Windows.Forms.Button();
            this.Category_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.previewPictureBox);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.Finalize_prod);
            this.panel1.Controls.Add(this.Category_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 260);
            this.panel1.TabIndex = 3;
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Location = new System.Drawing.Point(58, 74);
            this.previewPictureBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(100, 100);
            this.previewPictureBox.TabIndex = 8;
            this.previewPictureBox.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(48, 200);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(123, 23);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Finalize_prod
            // 
            this.Finalize_prod.Location = new System.Drawing.Point(48, 229);
            this.Finalize_prod.Name = "Finalize_prod";
            this.Finalize_prod.Size = new System.Drawing.Size(123, 23);
            this.Finalize_prod.TabIndex = 4;
            this.Finalize_prod.Text = "Create Category";
            this.Finalize_prod.UseVisualStyleBackColor = true;
            this.Finalize_prod.Click += new System.EventHandler(this.Finalize_prod_Click_1);
            // 
            // Category_name
            // 
            this.Category_name.Location = new System.Drawing.Point(100, 15);
            this.Category_name.Name = "Category_name";
            this.Category_name.Size = new System.Drawing.Size(100, 23);
            this.Category_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // create_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 385);
            this.Controls.Add(this.panel1);
            this.Name = "create_cat";
            this.Text = "create_cat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnUpload;
        private Button Finalize_prod;
        private TextBox Category_name;
        private Label label1;
        private PictureBox previewPictureBox;
    }
}