using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Kitchen_staff_app
{
    
    public partial class edit_prod : Form
    {
        private Control lastFocusedControl;
        public edit_prod()
        {
            InitializeComponent();
            comboBox1.DataSource = mysql.fetch_all_products();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            CreateTouchKeyboard();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string? name = ProdName.Text;
            string? price = ProdPrice.Text;
            string? cost = ProdCost.Text;
            string? id = comboBox1.SelectedValue.ToString();

            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(cost))
            {
                MessageBox.Show("name, price and cost has to be filled to update a product.");
                return;
            }

            
            Dictionary<string, object> fields = new Dictionary<string, object>
            {
                { "name", name },
                { "price", price },
                { "cost_price", cost },
                { "expiry_date", expiry_date.Value },
                {  "is_promotional", is_promotional.Checked }
            };

            mysql.update("Products", $"id = {id}", fields);
        }
        //todo: rename this pls wtf it is combobox not button
        private void UpdateButton_Update(object sender, EventArgs e)
        {
            if (comboBox1.DisplayMember != "")
            {
                DataTable dt = mysql.fetch_product_by_id(comboBox1.SelectedValue.ToString());
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
            int startY = 335;

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
                if (startY + buttonHeight > this.ClientSize.Height - 5)
                {
                    break;
                }
            }

            // Subscribe to the Enter and Leave events of all text boxes and rich text boxes on the form
            SubscribeToEnterAndLeaveEvents(this);
        }

        private void SubscribeToEnterAndLeaveEvents(Control control)
        {
            // Subscribe to the Enter and Leave events of text boxes and rich text boxes
            if (control is TextBoxBase textBox)
            {
                textBox.Enter += TextBox_Enter;
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.Enter += TextBox_Enter;
            }

            // Recursively loop through all child controls
            foreach (Control childControl in control.Controls)
            {
                SubscribeToEnterAndLeaveEvents(childControl);
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
