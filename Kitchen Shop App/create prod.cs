﻿using MySqlConnector;
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
        }

        private void Finalize_prod_Click(object sender, EventArgs e)
        {
            mysql mysql = new mysql();
            this.Hide();
            string name = Product_name.Text;
            string price = Product_price.Text;
            string cost = Product_cost.Text;
            int categoryId = categoriesDictionary[(string)categoryBox.SelectedItem];//explain this pls


            
            string query = "INSERT INTO Products (Name, sale_price, cost_price, image,category_id) VALUES (@name, @price, @cost, @imageData, @categoryId)";
            using (MySqlCommand cmd = new MySqlCommand(query, mysql.con))
            {
                mysql.con.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@cost", cost);
                cmd.Parameters.AddWithValue("@imageData", imageData);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                cmd.ExecuteNonQuery();
                mysql.con.Close();
            }

            Main main = new Main();
            main.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageData = File.ReadAllBytes(openFileDialog.FileName);
            }
        }
    }
}