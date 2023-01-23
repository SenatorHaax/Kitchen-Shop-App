using Kitchen_staff_app;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Windows.Forms;


namespace Kitchen_Shop_App
{
    public partial class Form1 : Form
    {
        DataTable products = mysql.fetch_all_products();
        DataTable categories = mysql.fetch_all_products();

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
                    MenuPanel.Controls.Add(name);
                    
                    Label price = new Label();
                    price.Text = products.Rows[i]["sale_price"].ToString();
                    price.Location = new Point(155, 10 + (i * 45));
                    price.AutoSize = true;
                    MenuPanel.Controls.Add(price);

                    Button remove = new Button();
                    remove.Text = "-";
                    remove.Tag = products.Rows[i]["id"].ToString();
                    remove.Location = new Point(250, 5 + (i * 45));
                    remove.AutoSize = true;
                    remove.Width = 20;
                    remove.Click += new EventHandler(remove_Click);
                    MenuPanel.Controls.Add(remove);


                    Button purchase = new Button();
                    purchase.Text = "+";
                    purchase.Tag = products.Rows[i]["id"].ToString();
                    purchase.Location = new Point(280, 5 + (i * 45));
                    purchase.AutoSize = true;
                    purchase.Width = 20;

                    purchase.Click += new EventHandler(purchase_Click);

                    MenuPanel.Controls.Add(purchase);
                }
            
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //master guard we dont wanna add null values or check an empty row
            if (button == null || dataGridView1.Rows.Count == 0)
            {
                return;
            }

            int id = Convert.ToInt32(button.Tag);
            bool isProductExist = false;
            int i = 0;
            //looks for product already existing if it does it will just +1 to the quantity
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                if (row.Cells[0].Value.ToString().Contains(id.ToString()))
                {
                    isProductExist = true;
                    int quantity = Convert.ToInt32(row.Cells[3].Value);
                    row.Cells[3].Value = quantity + 1;
                    break;
                }
                i++;
            }

            //add the product since no existing row of that product existed
            if (!isProductExist)
            {
                foreach (DataRow product in products.Rows)
                {
                    if (Convert.ToInt32(product["id"]) == id)
                    {
                        dataGridView1.Rows.Add(product["id"], product["name"], product["sale_price"], 1);
                        break;
                    }
                }
            }
        }

        //removes row and or a single quantity
        private void remove_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id = Convert.ToInt32(button.Tag);

            //master guard dont wanna remove 1 if its already null/0
            if (button == null || dataGridView1.Rows.Count == 0)
            {
                return;
            }

            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    return;
                }
                if (row.Cells[0].Value.ToString().Contains(id.ToString()))
                {
                    int quantity = Convert.ToInt32(row.Cells[3].Value);
                    if (quantity > 0)
                    {
                        row.Cells[3].Value = quantity - 1;
                        if (quantity == 1)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                        }
                        return;
                    }
                }
                i++;
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


            //todo: add logik for paying before submitting order to database
            if (total_cost == 0)
            {
                MessageBox.Show("Error: Total cost must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (total_cost < 0)
            {
                MessageBox.Show("how the fuck did u manage to steal my money", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            dataGridView1.Rows.Clear();
        }
    }
}