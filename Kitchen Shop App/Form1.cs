using Kitchen_staff_app;
using System.Data;


namespace Kitchen_Shop_App
{
    public partial class Form1 : Form
    {
        DataTable products = mysql.fetch_all_products();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //make dynamic lines of labels from products
            for (int i = 0; i < products.Rows.Count; i++)
            {
                Label name = new Label();
                name.Text = products.Rows[i]["name"].ToString();
                name.Location = new Point(10, 10 + (i * 45));
                name.AutoSize = true;
                this.Controls.Add(name);
                Label price = new Label();
                price.Text = products.Rows[i]["sale_price"].ToString();
                price.Location = new Point(155, 10 + (i * 45));
                price.AutoSize = true;
                this.Controls.Add(price);
                Button purchase = new Button();
                purchase.Text = "+";
                purchase.Tag = products.Rows[i]["id"].ToString();
                purchase.Location = new Point(200, 5 + (i * 45));
                purchase.AutoSize = true;
                purchase.Click += new EventHandler(purchase_Click);

                this.Controls.Add(purchase);
            }
        }
        private void purchase_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id = Convert.ToInt32(button.Tag);
            int i = 0;
            //if dataGridView1 id row contains id
            //dataGridView1 quantity row += 1
            //else
            //add new row to dataGridView1 with id and quantity 1
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    foreach (DataRow product in products.Rows)
                    {
                        if (Convert.ToInt32(product["id"]) == id)
                        {
                            dataGridView1.Rows.Add(product["id"], product["name"], product["sale_price"], 1);
                            return;
                        }
                    }
                }
                if (row.Cells[0].Value.ToString().Contains(id.ToString()))
                {
                    row.Cells[3].Value = Convert.ToInt32(row.Cells[3].Value) + 1;
                    return;
                }
                i++;
            }
            foreach (DataRow product in products.Rows)
            {
                if (Convert.ToInt32(product["id"]) == id)
                {
                    dataGridView1.Rows.Add(product["id"], product["name"], product["sale_price"], 1);
                    return;
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells["price"].Value) * Convert.ToDecimal(row.Cells["quantity"].Value);
            }
            sub_total.Text = subtotal.ToString();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            //delete all rows in datagridview1
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewCellEventArgs e)
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["price"].Value) * Convert.ToDecimal(row.Cells["quantity"].Value);
                }
            }
            sub_total.Text = subtotal.ToString();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            int stand_id = 1; // retrieve stand_id
            DateTime order_datetime = DateTime.Now;

            decimal total_cost = 0;
            // calculate sub total
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);

                total_cost += price * quantity;
            }
            // Insert the order and retrieve the last inserted id
            string query = $"INSERT INTO orders (stand_id, order_datetime, total_cost, created_at) VALUES ({stand_id}, '{order_datetime.ToString("yyyy-MM-dd HH:mm:ss")}', '{total_cost}', NOW()); SELECT LAST_INSERT_ID();";
            int order_id = mysql.insertAndRetrieveId(query);

            // Insert the order items
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["id"].Value != null && !string.IsNullOrEmpty(row.Cells["id"].Value.ToString())
    && row.Cells["quantity"].Value != null && !string.IsNullOrEmpty(row.Cells["quantity"].Value.ToString())
    && Convert.ToInt32(row.Cells["quantity"].Value) != 0
    && row.Cells["price"].Value != null && !string.IsNullOrEmpty(row.Cells["price"].Value.ToString())
    && Convert.ToDecimal(row.Cells["price"].Value) != 0)
                {
                    int product_id = Convert.ToInt32(row.Cells["id"].Value);
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);

                total_cost += price * quantity;

                string query2 = $"INSERT INTO order_items (order_id, product_id, quantity) VALUES ( {order_id}, {product_id}, {quantity})";
                mysql.insert(query2);
                }
                
            }

        }
    }
}