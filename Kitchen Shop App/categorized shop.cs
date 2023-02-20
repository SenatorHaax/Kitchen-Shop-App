using Kitchen_staff_app;
using MySqlConnector;
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
        Button cartButton = new Button();
        Panel cartPanel = new Panel();
        public static bool hasExecuted = false;


        public categorized_shop()
        {
            InitializeComponent();

            KeyPreview = true;
            KeyDown += categorized_shop_KeyDown;
            Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;

            //this.CategoriesMenuPanel.AutoScroll = true;
            //forces the window to be fullscreen no matter what
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Add a panel at the top of the form for the back button
            Panel topPanel = new Panel();
            topPanel.Dock = DockStyle.Top;
            topPanel.Size = new Size(this.ClientSize.Width-300, 50);
            topPanel.BackColor = Color.LightGray;
            this.Controls.Add(topPanel);

            // Add a back button to the top panel
            backButton.Text = "Back";
            backButton.Tag = "main";
            backButton.Location = new Point(10, 10);
            backButton.Click += new EventHandler(backBtn_Click);
            topPanel.Controls.Add(backButton);

            //add emergency shutdown button todo remove TODO: please for the love of god remember to remove this
            Button shutdownButton = new Button();
            shutdownButton.Text = "Shutdown";
            shutdownButton.Location = new Point(100, 10);
            shutdownButton.BackColor = Color.Red;
            shutdownButton.Click += new EventHandler(shutdownBtn_Click);
            topPanel.Controls.Add(shutdownButton);
            

            // add a shopping cart button to the top-right panel
            cartButton = new Button();
            cartButton.Text = "Shopping Cart";
            cartButton.Location = new Point(screen.Width - 85, 10);
            cartButton.Click += new EventHandler(cartBtn_Click);
            //topPanel.Controls.Add(cartButton);

            // Add a panel to the right of the form for the shopping cart
            cartPanel = new Panel();
            cartPanel.Dock = DockStyle.Right;
            cartPanel.Size = new Size(350, this.ClientSize.Height);
            cartPanel.BackColor = Color.Pink;
            this.Controls.Add(cartPanel);

            // Add components to display shopping cart information in the cart panel
            // todo
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void cartBtn_Click(object sender, EventArgs e)
        {
            //todo shopping cart funtionality or order functionality if side panel gets made to work
        }

        private void categorized_shop_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            string defaultImagePath = Path.Combine(Application.StartupPath, @"images\etc\no_img.jpg");
            Image defaultImage = Image.FromFile(defaultImagePath);
            //string imageStoragePath = Path.Combine(Application.StartupPath, @"images\Categories\");

            foreach (DataRow categorie in categories.Rows)
            {
                Button btn = new Button();
                btn.Location = new Point(x, y);
                btn.Size = new Size(100, 100);
                Label name = new Label();
                name.Text = categorie["Name"].ToString();
                name.Location = new Point(x, y + btn.Height);
                name.Font = new Font("Arial", 12);
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.BringToFront();

                string imageQuery = "SELECT Image FROM Categories WHERE id = " + categorie["id"].ToString();
                DataTable imageData = mysql.select(imageQuery);
                Image image;
                if (imageData.Rows[0]["Image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])imageData.Rows[0]["Image"];
                    try
                    {
                        //byte[] imageBytes = (byte[])imageData.Rows[0]["Image"];
                        if (imageData.Rows.Count > 0 && imageData.Rows[0]["Image"] != DBNull.Value)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error loading image: wtf");
                            image = defaultImage;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error loading image: " + ex.Message);
                        image = defaultImage;
                    }
                }
                else
                {
                    image = defaultImage;
                }


                btn.Image = image.GetThumbnailImage(100, 100, null, IntPtr.Zero);

                CategoriesMenuPanel.Controls.Add(btn);
                CategoriesMenuPanel.Controls.Add(name);

                x += 120;
                if (x > this.ClientSize.Width - 350)
                {
                    x = 10;
                    y += 120;
                }

                btn.Click += new EventHandler(CategoryButton_Click);
                btn.Tag = categorie["id"].ToString();

            }
            CategoriesMenuPanel.BackColor = Color.Green;
            CategoriesMenuPanel.AutoScroll = true;
            CategoriesMenuPanel.Width = this.ClientSize.Width - 350;
            CategoriesMenuPanel.Height = this.ClientSize.Height;
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
            //string imageStoragePath = Path.Combine(Application.StartupPath, @"images\Products\");

            productPanel.Dock = DockStyle.Fill;
            productPanel.BackColor = Color.LightBlue;

            foreach (DataRow product in productsData.Rows)
            {
                Button btn = new Button();
                btn.Text = "";
                btn.Location = new Point(x, y);
                btn.Size = new Size(100, 100);
                Label name = new Label();
                name.Text = product["Name"].ToString();
                name.Location = new Point(x, y + btn.Height);
                name.Font = new Font("Arial", 12);
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.BringToFront();
                byte[] imageBytes = (byte[])product["Image"];

                Image image;
                try
                {
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading image: " + ex.Message);
                    image = defaultImage;
                }

                btn.Image = image.GetThumbnailImage(100, 100, null, IntPtr.Zero);
                btn.Tag = product["id"].ToString();
                btn.Click += new EventHandler(ProductButton_Click);
                productPanel.Controls.Add(name);

                productPanel.Controls.Add(btn);
                x += 120;
                if (x > parentForm.ClientSize.Width - 300)
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

        
        //when a product is clicked i need to add a label with the name and amount of times it's been clicked to the cart panel
        private void ProductButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string productId = btn.Tag.ToString();
            string productName = mysql.fetch_product_by_id(productId).Rows[0]["Name"].ToString();
            int productCount = 1;
            Label lbl = new Label();
            Button decrementButton = new Button();


            // check if a label for the product already exists
            Label existingLabel = cartPanel.Controls.OfType<Label>()
    .FirstOrDefault(label => label.Tag != null && label.Tag.ToString() == productId);
            if (existingLabel != null)
            {
                // increment the count for the product
                int count = int.Parse(existingLabel.Text.Split(' ')[0]);
                productCount = count + 1;

                if (productCount > 1)
                {
                    // update the existing label text to reflect the new count
                    existingLabel.Text = productCount + " x " + productName;
                }
                else
                {
                    // remove the existing label and its associated decrement button
                    int existingLabelIndex = cartPanel.Controls.IndexOf(existingLabel);
                    int existingDecrementButtonIndex = existingLabelIndex + 1;
                    cartPanel.Controls.RemoveAt(existingLabelIndex);
                    if (existingDecrementButtonIndex < cartPanel.Controls.Count)
                    {
                        cartPanel.Controls.RemoveAt(existingDecrementButtonIndex);
                    }
                }
            }
            else
            {
                // add a new label for the product
                lbl.Text = productCount + " x " + productName;
                lbl.Tag = productId;
                lbl.Location = new Point(10, 10 + (cartPanel.Controls.Count * 20));
                cartPanel.Controls.Add(lbl);

                // add a new decrement button for the product
                decrementButton.Text = "-";
                decrementButton.Tag = productId;
                decrementButton.Click += DecrementButton_Click;
                decrementButton.Location = new Point(lbl.Location.X + lbl.Width + 10, lbl.Location.Y);
                cartPanel.Controls.Add(decrementButton);
            }

            
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string productId = btn.Tag.ToString();

            // find the associated label for the product
            Label lbl = cartPanel.Controls.OfType<Label>()
                .FirstOrDefault(label => label.Tag != null && label.Tag.ToString() == productId);
            if (lbl != null)
            {
                // decrement the count for the product
                int count = int.Parse(lbl.Text.Split(' ')[0]);
                if (count > 1)
                {
                    count--;
                    lbl.Text = count + " x " + lbl.Text.Split(' ')[2];
                }
                else
                {
                    // remove the label and its associated decrement button if the count is 1
                    cartPanel.Controls.Remove(lbl);
                    cartPanel.Controls.Remove(btn);

                    // update the locations of the other labels and decrement buttons
                    foreach (Control control in cartPanel.Controls)
                    {
                        if (control is Label label && label.Location.Y > lbl.Location.Y)
                        {
                            label.Location = new Point(label.Location.X, label.Location.Y - 40);
                        }
                        else if (control is Button button && button.Location.Y > btn.Location.Y)
                        {
                            button.Location = new Point(button.Location.X, button.Location.Y - 40);
                        }
                    }
                }
            }
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

        private void categorized_shop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.Insert && !hasExecuted)
            {
                hasExecuted = true;
                string text = "You are Admin congratz";
                MessageBox.Show(text);
                Main main = new Main();
                this.Hide();
                main.Show();
                main.BringToFront();
                //todo add all functionality from admin page to this instead for easier adding pictures (if not using blob on sql)
            }
        }
    }
}
