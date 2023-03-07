using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kitchen_staff_app
{
    public partial class stats : Form
    {
        
        public stats()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Picks what statistic to display<br></br>
        /// 0 General Stats<br></br>
        /// 1 Monthly Profit<br></br>
        /// </summary>
        /// <param name="statistic">integer value for what stat to show</param>
        public void pickStat(int statistic)
        {
            Main main = new Main();

            DataTable monthlyprofit;
            DataTable popularorder;
            DataTable totalOrders;
            DataTable avgPrice;
            DataTable monthProfit;
            DataTable popularCat;
            switch (statistic)
            {
                case 0:
                    //generalStatBtn_Click
                    #region general stats
                    popularorder = mysql.select(
    "SELECT products.name, SUM(order_items.quantity) as total_quantity " +
    "FROM order_items " +
    "JOIN products ON order_items.product_id = products.id " +
    "GROUP BY products.name " +
    "ORDER BY total_quantity DESC " +
    "LIMIT 1;", new Dictionary<string, object>());

                    totalOrders = mysql.select(
    "SELECT COUNT(*) as 'Total Orders' " +
    "FROM orders " +
    "WHERE delivered = 1;", new Dictionary<string, object>());

                    avgPrice = mysql.select(
                        "SELECT AVG(total_cost) as 'Avg Order Price' " +
                        "FROM orders " +
                        "WHERE delivered = 1;", new Dictionary<string, object>());

                    popularCat = mysql.select(
                        "SELECT c.name as category_name, " +
                        "SUM(oi.quantity) as total_quantity " +
                        "FROM categories c " +
                        "JOIN products p ON c.id = p.category_id " +
                        "JOIN order_items oi ON p.id = oi.product_id " +
                        "GROUP BY c.name " +
                        "ORDER BY total_quantity DESC " +
                        "LIMIT 1;", new Dictionary<string, object>());

                    monthProfit = mysql.select(
                        "SELECT SUM(o.total_cost - (oi.quantity * p.cost_price)) AS profit " +
                        "FROM orders o " +
                        "JOIN order_items oi ON oi.order_id = o.id " +
                        "JOIN products p ON p.id = oi.product_id " +
                        "WHERE o.order_datetime >= DATE_SUB(NOW(), INTERVAL 30 DAY) " +
                        "AND o.delivered = 1;", new Dictionary<string, object>());

                    if (popularorder.Rows.Count == 0 || totalOrders.Rows.Count == 0 || avgPrice.Rows.Count == 0 || popularCat.Rows.Count == 0 || monthProfit.Rows.Count == 0)
                    {
                        MessageBox.Show("No data available.");
                        this.Close();
                        main.Show();
                        break;
                    }

                    popularProductValue.Text = popularorder.Rows[0]["name"].ToString();
                    totalOrderValue.Text = totalOrders.Rows[0]["Total Orders"].ToString();
                    averageOrderValue.Text = avgPrice.Rows[0]["Avg Order Price"].ToString() + "$";
                    popularCategoryValue.Text = popularCat.Rows[0]["category_name"].ToString();
                    profitValue.Text = monthProfit.Rows[0]["profit"].ToString() + "$";
                    generalStatPanel.Visible = true;
                    generalStatPanel.BringToFront();
                    break;
                #endregion
                case 1:
                    //monthlyProfitBtn_Click
                    #region monthly profit
                    panel1.Visible = true;
                    monthlyprofit = mysql.select(
                        "SELECT DATE_FORMAT(order_datetime, '%Y-%m') as month, " +
                        "SUM(total_cost - (oi.quantity * p.cost_price)) AS profit " +
                        "FROM orders o " +
                        "JOIN order_items oi ON oi.order_id = o.id " +
                        "JOIN products p ON p.id = oi.product_id " +
                        "WHERE o.delivered = 1 " +
                        "GROUP BY month " +
                        "ORDER BY month;", new Dictionary<string, object>());

                    if (monthlyprofit.Rows.Count == 0)
                    {
                        MessageBox.Show("No data available.");
                        this.Close();
                        main.Show();
                        break;
                    }

                    chart1.DataSource = monthlyprofit;
                    chart1.Series.Add("Profit");
                    chart1.Series["Profit"].ChartType = SeriesChartType.Line;
                    chart1.Series["Profit"].XValueMember = "month";
                    chart1.Series["Profit"].YValueMembers = "profit";
                    chart1.DataBind();
                    break;
#endregion
                case 2:
                    //popularProductBtn_Click
                    //most sold product
                    #region most sold product
                    MessageBox.Show("Not implemented yet.");
                    this.Close();
                    main.Show();
                    break;
                #endregion
                case 3:
                    //busyHoursBtn_Click
                    #region busy hours
                    MessageBox.Show("Not implemented yet.");
                    this.Close();
                    main.Show();
                    break;
                    #endregion
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            generalStatPanel.Visible = false;
            panel1.Visible = false;

            Main main = new Main();
            main.Show();
        }
    }
}
