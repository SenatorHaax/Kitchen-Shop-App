using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Kitchen_staff_app
{
    //todo obfuscate
    public partial class edit_prod : Form
    {
        public edit_prod()
        {
            InitializeComponent();
            comboBox1.DataSource = mysql.fetch_all_products();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
        }

        private void edit_prod_Load(object sender, EventArgs e)
        {
            
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string name = ProdName.Text;
            string price = ProdPrice.Text;
            string cost = ProdCost.Text;
            string id = comboBox1.SelectedValue.ToString();

            Dictionary<string, object> fields = new Dictionary<string, object>
{
    { "name", name },
    { "price", price },
    { "cost_price", cost }
};

            mysql.update("Products", $"id = {id}", fields);
        }

        private void UpdateButton_Update(object sender, EventArgs e)
        {
            if (comboBox1.DisplayMember != "")
            {
                DataTable dt = mysql.fetch_product_by_id(comboBox1.SelectedValue.ToString());
                ProdName.Text = dt.Rows[0]["name"].ToString();
                ProdPrice.Text = dt.Rows[0]["sale_price"].ToString();
                ProdCost.Text = dt.Rows[0]["Cost_price"].ToString();
            }
            
        }
    }
}
