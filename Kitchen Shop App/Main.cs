using Kitchen_Shop_App;
using System.Data;

namespace Kitchen_staff_app
{
    //todo obfuscate
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Create_Prod_button(object sender, EventArgs e)
        {
            create_prod test = new create_prod();
            test.Show();
            this.Hide();
        }

        private void Remove_Product_Click(object sender, EventArgs e)
        {
            remove_prod Rprod = new remove_prod();
            Rprod.Show();
            this.Hide();
        }

        private void Edit_Product_Click(object sender, EventArgs e)
        {
            edit_prod Eprod = new edit_prod();
            Eprod.Show();
            this.Hide();
        }

        private void soldStatBtn_Click(object sender, EventArgs e)
        {

        }

        private void profChartBtn_Click(object sender, EventArgs e)
        {
            stats statWindow = new stats();
            statWindow.Show();
            statWindow.pickStat(1);
            this.Hide();
        }

        private void busyHoursBtn_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            categorized_shop.hasExecuted = false;

            edit_prod Eprod = new edit_prod();
            create_prod Cprod = new create_prod();
            remove_prod Rprod = new remove_prod();
            Eprod.Hide();
            Cprod.Hide();
            Rprod.Hide();
            
            this.Hide();
        }

        private void genStats_Click(object sender, EventArgs e)
        {
            stats statWindow = new stats();
            statWindow.pickStat(0);
            statWindow.Show();
            this.Hide();
        }

        private void Create_Category_Click(object sender, EventArgs e)
        {
            create_cat Ccat = new create_cat();
            Ccat.Show();
            this.Hide();
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            categorized_shop.ShowForm();

        }
    }
}