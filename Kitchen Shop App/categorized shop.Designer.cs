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
            CategoriesMenuPanel = new Panel();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // CategoriesMenuPanel
            // 
            CategoriesMenuPanel.Location = new Point(0, 45);
            CategoriesMenuPanel.Name = "CategoriesMenuPanel";
            CategoriesMenuPanel.Size = new Size(711, 336);
            CategoriesMenuPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(698, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Visible = false;
            textBox1.TextChanged += adminPass_TextChanged;
            // 
            // categorized_shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(CategoriesMenuPanel);
            Name = "categorized_shop";
            Text = "categorized_shop";
            Load += categorized_shop_Load;
            KeyDown += categorized_shop_KeyDown;
            Resize += categorized_shop_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CategoriesMenuPanel;
        private TextBox textBox1;
    }
}