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
            create_prod();
            panel1.Visible = true;
            //create_prod test = new create_prod();
            //test.Show();
            //this.Close();
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

        #region create prod
        private byte[] imageData;
        private Control lastFocusedControl;

        //explain this FFS its important
        private Dictionary<string, int> categoriesDictionary;
        public void create_prod()
        {
            //InitializeComponent();
            DataTable categories = mysql.fetch_all_categories();
            categoriesDictionary = new Dictionary<string, int>();
            foreach (DataRow row in categories.Rows)
            {
                int id = (int)row["id"];
                string name = (string)row["Name"];
                categoryBox.Items.Add(name);
                //todo: cannot have 2 of the same names in database fix this scenario
                categoriesDictionary.Add(name, id);

            }
            //use image from resources named default
            previewPictureBox.Image = Kitchen_Shop_App.Properties.Resources.default_img.GetThumbnailImage(100, 100, null, IntPtr.Zero);
            //CreateTouchKeyboard();
        }

        private void Finalize_prod_Click(object sender, EventArgs e)
        {
            mysql mysql = new mysql();
            //this.Hide();
            string name = Product_name.Text;
            string price = Product_price.Text.Replace(',', '.');
            string cost = Product_cost.Text.Replace(',', '.'); ;
            int categoryId = categoriesDictionary[(string)categoryBox.SelectedItem];


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(cost))
            {
                MessageBox.Show("name, price and cost has to be filled to createa product.");
                return;
            }


            Dictionary<string, object> data = new Dictionary<string, object>
            {
                { "Name", name },
                { "sale_price", price },
                { "cost_price", cost },
                { "image", imageData },
                { "expiry_date", exp_date.Value },
                { "category_id", categoryId },
                { "is_promotional", is_promotional.Checked }
            };
            mysql.insert("Products", data);

            //Main main = new Main();
            // main.Show();
        }
        #endregion
        #region event handlers
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageData = File.ReadAllBytes(openFileDialog.FileName);
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    previewPictureBox.Image = Image.FromStream(memoryStream).GetThumbnailImage(100, 100, null, IntPtr.Zero);
                }
            }
        }

        #endregion

    }
}