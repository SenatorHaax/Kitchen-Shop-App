namespace Kitchen_staff_app
{
    partial class remove_prod
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
            this.confirm_rem = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // confirm_rem
            // 
            this.confirm_rem.Location = new System.Drawing.Point(12, 61);
            this.confirm_rem.Name = "confirm_rem";
            this.confirm_rem.Size = new System.Drawing.Size(75, 23);
            this.confirm_rem.TabIndex = 1;
            this.confirm_rem.Text = "Confirm Removal";
            this.confirm_rem.UseVisualStyleBackColor = true;
            this.confirm_rem.Click += new System.EventHandler(this.confirm_rem_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(93, 61);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 2;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // remove_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 148);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.confirm_rem);
            this.Controls.Add(this.comboBox1);
            this.Name = "remove_prod";
            this.Text = "remove_prod";
            this.Load += new System.EventHandler(this.remove_prod_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private Button confirm_rem;
        private Button Cancel_button;
    }
}