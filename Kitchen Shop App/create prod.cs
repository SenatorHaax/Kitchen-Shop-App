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

namespace Kitchen_staff_app
{
    //todo obfuscate
    public partial class create_prod : Form
    {
        private byte[] imageData;
        private Control lastFocusedControl;

        //explain this FFS its important
        private Dictionary<string, int> categoriesDictionary;
        public create_prod()
        {
            InitializeComponent();
            DataTable categories = mysql.fetch_all_categories();
            categoriesDictionary = new Dictionary<string, int>();
            foreach (DataRow row in categories.Rows)
            {
                int id = (int)row["id"];
                string name = (string)row["Name"];
                categoryBox.Items.Add(name);
                categoriesDictionary.Add(name, id);
                
            }
            //use image from resources named default
            previewPictureBox.Image = Kitchen_Shop_App.Properties.Resources.default_img.GetThumbnailImage(100, 100, null, IntPtr.Zero);
            CreateTouchKeyboard();
        }

        private void Finalize_prod_Click(object sender, EventArgs e)
        {
            mysql mysql = new mysql();
            this.Hide();
            string name = Product_name.Text;
            string price = Product_price.Text;
            string cost = Product_cost.Text;
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

            Main main = new Main();
            main.Show();
        }
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
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        #endregion

        #region keyboard
        private void TouchKeyboardButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var textBox = lastFocusedControl;

            if (textBox != null)
            {
                if (button.Text == "-")
                {
                    textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                }
                else
                {
                    textBox.Text += button.Text;
                }
                lastFocusedControl.Focus();
            }
        }

        private void CreateTouchKeyboard()
        {
            // The characters to include in the touch keyboard
            string characters = "abcdefghijklmnopqrstuvwxyz-";

            // The width and height of the touch keyboard buttons
            int buttonWidth = 20;
            int buttonHeight = 20;

            // The spacing between the touch keyboard buttons
            int spacing = 5;

            // The starting position of the touch keyboard buttons
            int startX = 10;
            int startY = 410;

            // Create a touch keyboard button for each character
            foreach (char c in characters)
            {
                Button button = new Button();
                button.Text = c.ToString();
                button.Width = buttonWidth;
                button.Height = buttonHeight;
                button.Location = new Point(startX, startY);
                button.Click += TouchKeyboardButton_Click;
                this.Controls.Add(button);

                startX += buttonWidth + spacing;

                // If the keyboard buttons exceed the form width, move to the next row
                if (startX + buttonWidth > this.ClientSize.Width)
                {
                    startX = 10;
                    startY += buttonHeight + spacing;
                }

                // If the keyboard buttons exceed the form height, stop creating buttons
                if (startY + buttonHeight > this.ClientSize.Height - 25)
                {
                    break;
                }
            }

            // Subscribe to the Enter and Leave events of all text boxes and rich text boxes on the form
            SubscribeToEnterEvents(this);
        }

        private void SubscribeToEnterEvents(Control control)
        {
            // Subscribe to the Enter and Leave events of text boxes and rich text boxes
            if (control is TextBoxBase textBox)
            {
                textBox.Enter += TextBox_Enter;
                //textBox.Leave += TextBox_Leave;
            }

            // Recursively loop through all child controls
            foreach (Control childControl in control.Controls)
            {
                SubscribeToEnterEvents(childControl);
            }
        }
        
        private void TextBox_Enter(object sender, EventArgs e)
        {
            // Store the currently focused control in the lastFocusedControl variable
            lastFocusedControl = (Control)sender;
        }
        #endregion
    }
}
