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

        private void Create_Prod_button(object sender, EventArgs e)
        {
            create_prod test = new create_prod();
            test.Show();
            this.Close();
        }

        private void Remove_Product_Click(object sender, EventArgs e)
        {
            remove_prod Rprod = new remove_prod();
            Rprod.Show();
            this.Close();
        }

        private void Edit_Product_Click(object sender, EventArgs e)
        {
            edit_prod Eprod = new edit_prod();
            Eprod.Show();
            this.Close();
        }

        private void soldStatBtn_Click(object sender, EventArgs e)
        {
            stats statWindow = new stats();
            statWindow.Show();
            statWindow.pickStat(2);
            this.Close();
        }

        private void profChartBtn_Click(object sender, EventArgs e)
        {
            stats statWindow = new stats();
            statWindow.Show();
            statWindow.pickStat(1);
            this.Close();
        }

        private void busyHoursBtn_Click(object sender, EventArgs e)
        {
            stats statWindow = new stats();
            statWindow.Show();
            statWindow.pickStat(3);
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            categorized_shop.hasExecuted = false;

            edit_prod Eprod = new edit_prod();
            create_prod Cprod = new create_prod();
            remove_prod Rprod = new remove_prod();
            Eprod.Close();
            Cprod.Close();
            Rprod.Close();
            categorized_shop.instance.Close();
            this.Close();
        }

        private void genStats_Click(object sender, EventArgs e)
        {
            stats statWindow = new stats();
            statWindow.Show();
            statWindow.pickStat(0);
            this.Close();
        }

        private void Create_Category_Click(object sender, EventArgs e)
        {
            create_cat Ccat = new create_cat();
            Ccat.Show();
            this.Close();
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            categorized_shop.hasExecuted = false;
            categorized_shop.reload();
            categorized_shop.show_form();
        }
    }
}