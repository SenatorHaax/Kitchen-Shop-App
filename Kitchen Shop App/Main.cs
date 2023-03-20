using Kitchen_Shop_App;
using MySqlConnector;
using System.Data;

namespace Kitchen_staff_app
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Create_Prod_button(object? sender, EventArgs? e)
        {
            create_prod();
            editProductPanel.Visible = false;
            createProductPanel.Visible = true;
            removeProductPanel.Visible = false;
            createCategoryPanel.Visible = false;
        }

        private void Remove_Product_Click(object? sender, EventArgs? e)
        {
            removeProductComboBox.DataSource = mysql.fetch_all_products();
            removeProductComboBox.DisplayMember = "name";
            removeProductComboBox.ValueMember = "id";
            createProductPanel.Visible = false;
            editProductPanel.Visible = false;
            removeProductPanel.Visible = true;
            createCategoryPanel.Visible = false;
        }

        private void Edit_Product_Click(object? sender, EventArgs? e)
        {
            editProductComboBox.DataSource = mysql.fetch_all_products();
            editProductComboBox.DisplayMember = "name";
            editProductComboBox.ValueMember = "id";
            pictureBox2.Image = Kitchen_Shop_App.Properties.Resources.default_img.GetThumbnailImage(100, 100, null, IntPtr.Zero);
            createProductPanel.Visible = false;
            removeProductPanel.Visible = false;
            editProductPanel.Visible = true;
            createCategoryPanel.Visible = false;
        }

        private void soldStatBtn_Click(object? sender, EventArgs? e)
        {
            stats statWindow = new stats();
            statWindow.Show();
            statWindow.pickStat(2);
            this.Close();
        }

        private void profChartBtn_Click(object? sender, EventArgs? e)
        {
            stats statWindow = new stats();
            statWindow.Show();
            statWindow.pickStat(1);
            this.Close();
        }

        private void busyHoursBtn_Click(object? sender, EventArgs? e)
        {
            stats statWindow = new stats();
            statWindow.Show();
            statWindow.pickStat(3);
            this.Close();
        }

        private void panikButton(object? sender, EventArgs? e)
        {
            categorized_shop.hasExecuted = false;

            categorized_shop.instance.Close();
            this.Close();
        }

        private void genStats_Click(object? sender, EventArgs? e)
        {
            stats statWindow = new stats();
            statWindow.Show();
            statWindow.pickStat(0);
            this.Close();
        }

        private void Create_Category_Click(object? sender, EventArgs? e)
        {
            editProductPanel.Visible = false;
            createProductPanel.Visible = false;
            removeProductPanel.Visible = false;
            createCategoryPanel.Visible = true;
                        pictureBox1.Image = Kitchen_Shop_App.Properties.Resources.default_img.GetThumbnailImage(100, 100, null, IntPtr.Zero);

        }

        private void donebtn_Click(object? sender, EventArgs? e)
        {
            this.Close();
            categorized_shop.hasExecuted = false;
            categorized_shop.reload();
            categorized_shop.show_form();
        }

        #region create prod
        private byte[]? imageData;
        private Control? lastFocusedControl;

        //explain this FFS its important edit1:(should probably have written a small description for it edit2:(figure it out agian plox))
        private Dictionary<string, int> categoriesDictionary;
        public void create_prod()
        {
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
            //use image from resources named default_img
            previewPictureBox.Image = Kitchen_Shop_App.Properties.Resources.default_img.GetThumbnailImage(100, 100, null, IntPtr.Zero);
        }

        private void Finalize_prod_Click(object? sender, EventArgs? e)
        {
            string name = Product_name.Text;
            string price = Product_price.Text.Replace(',', '.');
            string cost = Product_cost.Text.Replace(',', '.');
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
        }
        private void btnUpload_Click(object? sender, EventArgs? e)
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            string name = Category_name.Text;


            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("name has to be filled to create a category.");
                return;
            }


            // create dictionary with data to insert
            var data = new Dictionary<string, object>
            {
                { "Name", name },
                { "image", imageData }
            };

            // insert data into the table
            mysql.insert("categories", data);
            Category_name.Text = "";
            previewPictureBox.Image = Kitchen_Shop_App.Properties.Resources.default_img.GetThumbnailImage(100, 100, null, IntPtr.Zero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe, *.jfif; *.png";
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string? name = ProdName.Text;
            string? price = ProdPrice.Text;
            string? cost = ProdCost.Text;
            string? id = editProductComboBox.SelectedValue.ToString();


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(cost))
            {
                MessageBox.Show("name, price and cost has to be filled to update a product.");
                return;
            }


            Dictionary<string, object> fields = new Dictionary<string, object>
            {
                { "name", name },
                { "sale_price", price },
                { "cost_price", cost },
                { "expiry_date", expiry_date.Value },
                {  "is_promotional", is_promotional.Checked }
            };

            mysql.update("Products", $"id = {id}", fields);

            //empty all fields
            ProdName.Text = "";
            ProdPrice.Text = "";
            ProdCost.Text = "";
            expiry_date.Value = DateTime.Now;
            is_promotional.Checked = false;

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            DataTable dt = mysql.fetch_product_by_id(editProductComboBox.SelectedValue.ToString());
            //if dt not null or empty
            if (dt.Rows.Count > 0)
            {
                ProdName.Text = dt.Rows[0]["name"].ToString();
                ProdPrice.Text = dt.Rows[0]["sale_price"].ToString();
                ProdCost.Text = dt.Rows[0]["Cost_price"].ToString();
                expiry_date.Value = (dt.Rows[0]["expiry_date"] != DBNull.Value)
                    ? (DateTime)dt.Rows[0]["expiry_date"]
                    : DateTime.Now;
                is_promotional.Checked = (dt.Rows[0]["is_promotional"] != DBNull.Value) ? (bool)dt.Rows[0]["is_promotional"] : false;
                try
                {
                    if (dt.Rows[0]["image"] != DBNull.Value)
                    {
                        // convert the blob data to an image object
                        byte[] imageBytes = (byte[])dt.Rows[0]["image"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image img = Image.FromStream(ms);

                            // display the image in the picture box
                            previewPictureBox.Image = img.GetThumbnailImage(previewPictureBox.Width, previewPictureBox.Height, null, IntPtr.Zero);
                        }
                    }
                }
                catch
                {
                    previewPictureBox.Image = Kitchen_Shop_App.Properties.Resources.default_img.GetThumbnailImage(100, 100, null, IntPtr.Zero);
                }
                //dispose of unsused image
                previewPictureBox.Image.Dispose();
            }


        }

        private void confirm_rem_Click(object? sender, EventArgs? e)
        {
            string? id = removeProductComboBox.SelectedValue.ToString();
            // create a list of parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@id", id)
            };

            // call the delete function
            mysql.delete("Products", "id = @id", parameters);
        }

        private void Remove_Category_Click(object sender, EventArgs e)
        {
            createProductPanel.Visible = false;
            editProductPanel.Visible = false;
            removeProductPanel.Visible = false;
            createCategoryPanel.Visible = false;


        }

    }
}