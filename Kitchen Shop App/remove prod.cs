using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Kitchen_staff_app
{
    
    public partial class remove_prod : Form
    {
        public remove_prod()
        {
            InitializeComponent();
        }

        private void remove_prod_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = mysql.fetch_all_products();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember="id";
        }

        private void confirm_rem_Click(object sender, EventArgs e)
        {
            string? id = comboBox1.SelectedValue.ToString();
            // create a list of parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@id", id)
            };

            // call the delete function
            mysql.delete("Products", "id = @id", parameters);
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
