using Kitchen_staff_app;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_Shop_App
{
    public partial class categorized_shop : Form
    {
        DataTable products = mysql.fetch_all_products();
        DataTable categories = mysql.fetch_all_categories();
        Button backButton = new Button();
        Panel productPanel = new Panel();

        public categorized_shop()
        {
            InitializeComponent();
            //this.CategoriesMenuPanel.AutoScroll = true;
            //forces the window to be fullscreen no matter what
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Add a panel at the top of the form for the back button
            Panel topPanel = new Panel();
            topPanel.Dock = DockStyle.Top;
            topPanel.Size = new Size(this.ClientSize.Width, 50);
            this.Controls.Add(topPanel);

            // Add a back button to the top panel
            
            backButton.Text = "Back";
            backButton.Tag = "main";
            backButton.Location = new Point(10, 10);
            backButton.Click += new EventHandler(backBtn_Click);
            topPanel.Controls.Add(backButton);

            // Add a panel to the right of the form for the shopping cart
            Panel cartPanel = new Panel();
            cartPanel.Dock = DockStyle.Right;
            cartPanel.Size = new Size(200, this.ClientSize.Height);
            this.Controls.Add(cartPanel);

            // Add components to display shopping cart information in the cart panel
            // ...
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag)
            {
                case "main":
                    this.Close();
                    break;
                case "products":
                    CategoriesMenuPanel.Show();
                    CategoriesMenuPanel.BringToFront();
                    productPanel.Hide();
                    btn.Tag = "main";
                    break;
            }
        }

        private void categorized_shop_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            string defaultImagePath = Path.Combine(Application.StartupPath, @"images\etc\no_img.jpg");
            Image defaultImage = Image.FromFile(defaultImagePath);
            string imageStoragePath = Path.Combine(Application.StartupPath, @"images\Categories\");

            foreach (DataRow categorie in categories.Rows)
            {
                Button btn = new Button();
                btn.Text = categorie["Name"].ToString();
                btn.Location = new Point(x, y);
                btn.Size = new Size(100, 100);

                string imageFileName = categorie["Image"].ToString();
                string imagePath = Path.Combine(imageStoragePath, imageFileName);
                Image image;
                try
                {
                    image = Image.FromFile(imagePath);
                }
                catch (FileNotFoundException)
                {
                    image = defaultImage;
                }

                btn.Image = image.GetThumbnailImage(100, 100, null, IntPtr.Zero);

                CategoriesMenuPanel.Controls.Add(btn);
                x += 120;
                if (x > this.ClientSize.Width - 100)
                {
                    x = 10;
                    y += 120;
                }

                btn.Click += new EventHandler(CategoryButton_Click);
                btn.Tag = categorie["id"].ToString();

            }
            CategoriesMenuPanel.Size = this.ClientSize;
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string id = clickedButton.Tag.ToString();
            DataTable categoryData = new DataTable();
            categoryData.Clear();
            categoryData = mysql.fetch_product_by_category_id(id);
            backButton.Tag = "products";
            productPanel.Show();
            CategoriesMenuPanel.Hide();
            // code to open the new panel with all products from the selected category
            GenerateProductPanel(this, categoryData);
        }
        
        private void GenerateProductPanel(Form parentForm, DataTable productsData)
        {
            productPanel.Controls.Clear();
            int x = 10;
            int y = 10;
            string defaultImagePath = Path.Combine(Application.StartupPath, @"images\etc\no_img.jpg");
            Image defaultImage = Image.FromFile(defaultImagePath);
            string imageStoragePath = Path.Combine(Application.StartupPath, @"images\Products\");

            productPanel.Dock = DockStyle.Fill;

            foreach (DataRow product in productsData.Rows)
            {
                Button btn = new Button();
                btn.Text = product["Name"].ToString();
                btn.Location = new Point(x, y);
                btn.Size = new Size(100, 100);

                string imageFileName = product["Image"].ToString();
                string imagePath = Path.Combine(imageStoragePath, imageFileName);
                Image image;
                try
                {
                    image = Image.FromFile(imagePath);
                }
                catch (FileNotFoundException)
                {
                    image = defaultImage;
                }

                btn.Image = image.GetThumbnailImage(100, 100, null, IntPtr.Zero);

                productPanel.Controls.Add(btn);
                x += 120;
                if (x > parentForm.ClientSize.Width - 100)
                {
                    x = 10;
                    y += 120;
                }
            }
            productsData.Clear();
            productPanel.Size = parentForm.ClientSize;
            // add the product panel to the form controls
            parentForm.Controls.Add(productPanel);
            
            // bring the product panel to the front
            productPanel.BringToFront();
            

        }

        private void categorized_shop_Resize(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            int maxX = this.ClientSize.Width - 110;

            foreach (Control control in CategoriesMenuPanel.Controls)
            {
                if (control is Button btn)
                {
                    btn.Location = new Point(x, y);
                    x += 120;
                    if (x > maxX)
                    {
                        x = 10;
                        y += 120;
                    }
                }
            }
        }
    }
}
