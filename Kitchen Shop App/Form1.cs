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
                price.Text = products.Rows[i]["price"].ToString();
                price.Location = new Point(100, 10 + (i * 45));
                price.AutoSize = true;
                this.Controls.Add(price);
                Button purchase = new Button();
                purchase.Text = products.Rows[i]["id"].ToString();
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
                            dataGridView1.Rows.Add(product["id"], product["name"], product["price"], 1);
                            return;
                        }
                    }
                    return;
                }
                if (row.Cells[0].Value.ToString().Contains(id.ToString()))
                {
                    row.Cells[3].Value = Convert.ToInt32(row.Cells[3].Value) + 1;
                    return;
                }
                //row.Cells["chat1"].Style.ForeColor = Color.CadetBlue;
                i++;
            }
            foreach (DataRow product in products.Rows)
            {
                if (Convert.ToInt32(product["id"]) == id)
                {
                    dataGridView1.Rows.Add(product["id"], product["name"], product["price"], 1);
                    return;
                }
            }

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            //delete all rows in datagridview1
            dataGridView1.Rows.Clear();
        }
    }
}