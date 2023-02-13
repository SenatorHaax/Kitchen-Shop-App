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
    public partial class create_cat : Form
    {
        private byte[] imageData;
        public create_cat()
        {
            InitializeComponent();
        }
        
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe, *.jfif; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageData = File.ReadAllBytes(openFileDialog.FileName);
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    previewPictureBox.Image = Image.FromStream(memoryStream);
                }
            }
        }

        private void Finalize_prod_Click_1(object sender, EventArgs e)
        {
            mysql mysql = new mysql();
            this.Hide();
            string name = Category_name.Text;

            using (MySqlConnection con = new MySqlConnection(mysql.con.ConnectionString))
            {
                con.Open();
                string query = "INSERT INTO categories (Name, image) VALUES (@name, @image)";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@image", imageData);
                    cmd.ExecuteNonQuery();
                }
            }

            Main main = new Main();
            main.Show();
        }
    }
}
