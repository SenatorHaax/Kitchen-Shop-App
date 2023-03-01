namespace Kitchen_Shop_App
{
    partial class categorized_shop
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
            this.CategoriesMenuPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CategoriesMenuPanel
            // 
            this.CategoriesMenuPanel.Location = new System.Drawing.Point(0, 45);
            this.CategoriesMenuPanel.Name = "CategoriesMenuPanel";
            this.CategoriesMenuPanel.Size = new System.Drawing.Size(711, 336);
            this.CategoriesMenuPanel.TabIndex = 0;
            // 
            // categorized_shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoriesMenuPanel);
            this.Name = "categorized_shop";
            this.Text = "categorized_shop";
            this.Load += new System.EventHandler(this.categorized_shop_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categorized_shop_KeyDown);
            this.Resize += new System.EventHandler(this.categorized_shop_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel CategoriesMenuPanel;
    }
}