using Kitchen_staff_app;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_Shop_App
{
    public partial class create_cat : Form
    {
        private byte[]? imageData;
        private Control? lastFocusedControl;
        public create_cat()
        {
            InitializeComponent();
            previewPictureBox.Image = Properties.Resources.default_img.GetThumbnailImage(100, 100, null, IntPtr.Zero);
            CreateTouchKeyboard();
        }

        private void btnUpload_Click(object? sender, EventArgs? e)
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

        private void Finalize_prod_Click_1(object? sender, EventArgs? e)
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

            Main main = new Main();
            main.Show();
        }

        private void TouchKeyboardButton_Click(object? sender, EventArgs? e)
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
                //something is always last focus if button is first thing you click the main window was focused
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
            int startY = 275;

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

        private void TextBox_Enter(object? sender, EventArgs? e)
        {
            // Store the currently focused control in the lastFocusedControl variable
            lastFocusedControl = (Control)sender;
        }

        private void button1_Click(object? sender, EventArgs? e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
