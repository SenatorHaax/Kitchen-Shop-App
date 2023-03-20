namespace Kitchen_staff_app
{
    partial class stats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.generalStatPanel = new System.Windows.Forms.Panel();
            this.totalOrderValue = new System.Windows.Forms.Label();
            this.averageOrderValue = new System.Windows.Forms.Label();
            this.popularCategoryValue = new System.Windows.Forms.Label();
            this.popularProductValue = new System.Windows.Forms.Label();
            this.profitValue = new System.Windows.Forms.Label();
            this.totalOrderLabel = new System.Windows.Forms.Label();
            this.averageOrderValueLabel = new System.Windows.Forms.Label();
            this.popularCategoryLabel = new System.Windows.Forms.Label();
            this.popularProductLabel = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.generalStatPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // generalStatPanel
            // 
            this.generalStatPanel.Controls.Add(this.totalOrderValue);
            this.generalStatPanel.Controls.Add(this.averageOrderValue);
            this.generalStatPanel.Controls.Add(this.popularCategoryValue);
            this.generalStatPanel.Controls.Add(this.popularProductValue);
            this.generalStatPanel.Controls.Add(this.profitValue);
            this.generalStatPanel.Controls.Add(this.totalOrderLabel);
            this.generalStatPanel.Controls.Add(this.averageOrderValueLabel);
            this.generalStatPanel.Controls.Add(this.popularCategoryLabel);
            this.generalStatPanel.Controls.Add(this.popularProductLabel);
            this.generalStatPanel.Controls.Add(this.profitLabel);
            this.generalStatPanel.Location = new System.Drawing.Point(2, 63);
            this.generalStatPanel.Name = "generalStatPanel";
            this.generalStatPanel.Size = new System.Drawing.Size(864, 249);
            this.generalStatPanel.TabIndex = 0;
            this.generalStatPanel.Visible = false;
            // 
            // totalOrderValue
            // 
            this.totalOrderValue.AutoSize = true;
            this.totalOrderValue.Location = new System.Drawing.Point(216, 195);
            this.totalOrderValue.Name = "totalOrderValue";
            this.totalOrderValue.Size = new System.Drawing.Size(0, 15);
            this.totalOrderValue.TabIndex = 9;
            // 
            // averageOrderValue
            // 
            this.averageOrderValue.AutoSize = true;
            this.averageOrderValue.Location = new System.Drawing.Point(216, 156);
            this.averageOrderValue.Name = "averageOrderValue";
            this.averageOrderValue.Size = new System.Drawing.Size(0, 15);
            this.averageOrderValue.TabIndex = 8;
            // 
            // popularCategoryValue
            // 
            this.popularCategoryValue.AutoSize = true;
            this.popularCategoryValue.Location = new System.Drawing.Point(216, 115);
            this.popularCategoryValue.Name = "popularCategoryValue";
            this.popularCategoryValue.Size = new System.Drawing.Size(0, 15);
            this.popularCategoryValue.TabIndex = 7;
            // 
            // popularProductValue
            // 
            this.popularProductValue.AutoSize = true;
            this.popularProductValue.Location = new System.Drawing.Point(216, 74);
            this.popularProductValue.Name = "popularProductValue";
            this.popularProductValue.Size = new System.Drawing.Size(0, 15);
            this.popularProductValue.TabIndex = 6;
            // 
            // profitValue
            // 
            this.profitValue.AutoSize = true;
            this.profitValue.Location = new System.Drawing.Point(216, 33);
            this.profitValue.Name = "profitValue";
            this.profitValue.Size = new System.Drawing.Size(0, 15);
            this.profitValue.TabIndex = 5;
            // 
            // totalOrderLabel
            // 
            this.totalOrderLabel.AutoSize = true;
            this.totalOrderLabel.Location = new System.Drawing.Point(21, 195);
            this.totalOrderLabel.Name = "totalOrderLabel";
            this.totalOrderLabel.Size = new System.Drawing.Size(183, 15);
            this.totalOrderLabel.TabIndex = 4;
            this.totalOrderLabel.Text = "Total delivered orders this month:";
            // 
            // averageOrderValueLabel
            // 
            this.averageOrderValueLabel.AutoSize = true;
            this.averageOrderValueLabel.Location = new System.Drawing.Point(21, 156);
            this.averageOrderValueLabel.Name = "averageOrderValueLabel";
            this.averageOrderValueLabel.Size = new System.Drawing.Size(115, 15);
            this.averageOrderValueLabel.TabIndex = 3;
            this.averageOrderValueLabel.Text = "Average order value:";
            // 
            // popularCategoryLabel
            // 
            this.popularCategoryLabel.AutoSize = true;
            this.popularCategoryLabel.Location = new System.Drawing.Point(21, 115);
            this.popularCategoryLabel.Name = "popularCategoryLabel";
            this.popularCategoryLabel.Size = new System.Drawing.Size(132, 15);
            this.popularCategoryLabel.TabIndex = 2;
            this.popularCategoryLabel.Text = "Most Popular Category:";
            // 
            // popularProductLabel
            // 
            this.popularProductLabel.AutoSize = true;
            this.popularProductLabel.Location = new System.Drawing.Point(21, 74);
            this.popularProductLabel.Name = "popularProductLabel";
            this.popularProductLabel.Size = new System.Drawing.Size(105, 15);
            this.popularProductLabel.TabIndex = 1;
            this.popularProductLabel.Text = "Most orderet item:";
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Location = new System.Drawing.Point(21, 33);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(103, 15);
            this.profitLabel.TabIndex = 0;
            this.profitLabel.Text = "Profit Past Month:";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(128, 45);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // createProductPanel
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "createProductPanel";
            this.panel1.Size = new System.Drawing.Size(776, 375);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 60);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "profit";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "month";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(773, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Name = "profit";
            this.chart1.Titles.Add(title1);
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.generalStatPanel);
            this.Controls.Add(this.Back);
            this.Name = "stats";
            this.Text = "stats";
            this.generalStatPanel.ResumeLayout(false);
            this.generalStatPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel generalStatPanel;
        private Button Back;
        private Label totalOrderValue;
        private Label averageOrderValue;
        private Label popularCategoryValue;
        private Label popularProductValue;
        private Label profitValue;
        private Label totalOrderLabel;
        private Label averageOrderValueLabel;
        private Label popularCategoryLabel;
        private Label popularProductLabel;
        private Label profitLabel;
        private Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}