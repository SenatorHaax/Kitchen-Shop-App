using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_staff_app
{
    //todo obfuscate
    public partial class create_prod : Form
    {
        public create_prod()
        {
            InitializeComponent();
        }

        private void Finalize_prod_Click(object sender, EventArgs e)
        {
            mysql mysql = new mysql();
            this.Hide();
            string name = Product_name.Text;
            string price = Product_price.Text;
            string cost = Product_cost.Text;

            //todo reconfig to prepared statements in sql class
            string query = "INSERT INTO Products (Name, Price, cost_price) VALUES ('" + name + "', '" + price + "', '" + cost + "')";
            mysql.insert(query);

            Main main = new Main();
            main.Show();
        }
    }
}
