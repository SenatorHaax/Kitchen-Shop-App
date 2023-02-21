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
        #region variables
        DataTable products = mysql.fetch_all_products();
        DataTable categories = mysql.fetch_all_categories();
        Button backButton = new Button();
        Panel productPanel = new Panel();
        Button cartButton = new Button();
        Panel cartPanel = new Panel();
        Button purchaseButton = new Button();


        public static bool hasExecuted = false;
        public static categorized_shop? instance;
        #endregion

        public categorized_shop()
        {
            InitializeComponent();
            instance = this;
            KeyPreview = true;
            KeyDown += categorized_shop_KeyDown;
            Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;

            //this.CategoriesMenuPanel.AutoScroll = true;
            //forces the window to be fullscreen no matter what to stop shenanigans
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
            backButton.Click += new EventHandler(back_button_click);
            topPanel.Controls.Add(backButton);

            //add emergency shutdown button todo remove TODO: please for the love of god remember to remove this before delivery
            Button shutdownButton = new Button();
            shutdownButton.Text = "Shutdown";
            shutdownButton.Location = new Point(100, 10);
            shutdownButton.BackColor = Color.Red;
            shutdownButton.Click += new EventHandler(shutdown_button_Click);
            topPanel.Controls.Add(shutdownButton);

            // Add a panel to the right of the form for the shopping cart
            cartPanel = new Panel();
            cartPanel.Dock = DockStyle.Right;
            cartPanel.Size = new Size(350, 10);
            this.Controls.Add(cartPanel);

            purchaseButton.Text = "Purchase";
            purchaseButton.Location = new Point(100, cartPanel.ClientSize.Height - 100);
            purchaseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            purchaseButton.Size = new Size(150, 50);
            purchaseButton.Click += new EventHandler(purchase_button_click);
            cartPanel.Controls.Add(purchaseButton);
        }
        #region main methods
        private void categorized_shop_Load(object sender, EventArgs e)
        {
            int x = 10; // Starting x coordinate of the first button
            int y = 10; // Starting y coordinate of the first button

            // Load the default image from file
            string defaultImagePath = Path.Combine(Application.StartupPath, @"images\etc\no_img.jpg");
            Image defaultImage = Image.FromFile(defaultImagePath);

            // Loop through each category and create a button and label for it
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

                // Query the database for the category's image and load it
                string imageQuery = "SELECT Image FROM Categories WHERE id = " + categorie["id"].ToString();
                DataTable imageData = mysql.select(imageQuery, new Dictionary<string, object>());
                Image image = load_image_from_database(imageData, defaultImage);

                // Set the button's image to the loaded image
                btn.Image = image.GetThumbnailImage(100, 100, null, IntPtr.Zero);

                // Add the button and label to the CategoriesMenuPanel
                CategoriesMenuPanel.Controls.Add(btn);
                CategoriesMenuPanel.Controls.Add(name);

                // Increment the x coordinate to the next button position
                x += 120;
                if (x > this.ClientSize.Width - 350)
                {
                    // If the buttons have reached the end of the form's width, move to the next row
                    x = 10;
                    y += 120;
                }

                // Add's an event handler to the button's click event and set its tag to the category's ID
                btn.Click += new EventHandler(category_button_click);
                btn.Tag = categorie["id"].ToString();
            }

            // Set the CategoriesMenuPanel to auto-scroll and adjust its size to fit the form
            CategoriesMenuPanel.AutoScroll = true;
            CategoriesMenuPanel.Width = this.ClientSize.Width - 350;
            CategoriesMenuPanel.Height = this.ClientSize.Height;
        }
        // This method generates a panel of products based on a DataTable of product data and adds it to a parent form
        private void generate_product_panel(Form parentForm, DataTable productsData)
        {
            // Clear any existing controls from the product panel
            productPanel.Controls.Clear();

            // Set initial coordinates for the buttons and labels to be added to the panel
            int x = 10;
            int y = 10;

            // Define a default image to use if a product has no image data
            string defaultImagePath = Path.Combine(Application.StartupPath, @"images\etc\no_img.jpg");
            Image defaultImage = Image.FromFile(defaultImagePath);

            // Set the dock style of the product panel to fill the parent form
            productPanel.Dock = DockStyle.Fill;

            // Loop through each row of product data in the DataTable
            foreach (DataRow product in productsData.Rows)
            {
                // Create a new button to represent the product
                Button btn = new Button();
                btn.Text = "";
                btn.Location = new Point(x, y);
                btn.Size = new Size(100, 100);

                // Create a label to display the name of the product
                Label name = new Label();
                name.Text = product["Name"].ToString();
                name.Location = new Point(x, y + btn.Height);
                name.Font = new Font("Arial", 12);
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.BringToFront();

                // Retrieve image data for the product from the database
                DataTable imageData = mysql.select("SELECT Image FROM Products WHERE id = " + product["id"].ToString(), new Dictionary<string, object>());

                // Load the image data into an Image object and set it as the button's thumbnail image
                Image image = load_image_from_database(imageData, defaultImage);
                btn.Image = image.GetThumbnailImage(100, 100, null, IntPtr.Zero);
                btn.Click += new EventHandler(product_button_click);


                // Set the button's tag to the ID of the product
                btn.Tag = product["id"].ToString();

                // Add the label and button to the product panel
                productPanel.Controls.Add(name);
                productPanel.Controls.Add(btn);

                // Increment the x coordinate for the next button
                x += 120;

                // If the x coordinate has reached the edge of the parent form, reset it and increment the y coordinate
                if (x > parentForm.ClientSize.Width - 300)
                {
                    x = 10;
                    y += 120;
                }
            }

            // Clear the product data from the DataTable
            productsData.Clear();

            // Set the size of the product panel to match the size of the parent form
            productPanel.Size = parentForm.ClientSize;

            // Add the product panel to the parent form's controls
            parentForm.Controls.Add(productPanel);

            // Bring the product panel to the front
            productPanel.BringToFront();
        }
        #endregion
        #region Event Handlers

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
            }
        }

        private void product_button_click(object sender, EventArgs e)
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
                decrementButton.Click += decrement_button_click;
                decrementButton.Location = new Point(lbl.Location.X + lbl.Width + 10, lbl.Location.Y);
                cartPanel.Controls.Add(decrementButton);
            }


        }

        private void decrement_button_click(object sender, EventArgs e)
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

        private void shutdown_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_button_click(object sender, EventArgs e)
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

        private void category_button_click(object sender, EventArgs e)
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
            generate_product_panel(this, categoryData);
        }

        private void purchase_button_click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
            //todo make purchase logic preferably with paypal/stripe
        }
        #endregion
        #region custom methods
        private Image load_image_from_database(DataTable imageData, Image defaultImage)
        {
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

            return image;
        }
        
        //funbction to later open the same shop window you had open before you opened the admin page
        public static void show_form()
        {
            instance.Show();
        }
        #endregion
    }
}
