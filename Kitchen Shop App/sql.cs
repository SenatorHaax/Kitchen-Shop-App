using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Kitchen_staff_app
{
    //todo reconfigure to dynamic prepared statements
    //class mysql
    class mysql
    {
        //create connection 
        static MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=resturant");
        //dynamic insert
        
        //create method to insert data into database
        public static void insert(string query)
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand(query, con);
            //execute command
            cmd.ExecuteNonQuery();
            //close connection
            con.Close();
        }

        //create method to select data from database
        public static DataTable select(string query)
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand(query, con);
            //create data adapter
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //create data table
            DataTable dt = new DataTable();
            //fill data table
            da.Fill(dt);
            //close connection
            con.Close();
            //return data table
            return dt;
        }

        //create method to update data in database
        public static void update(string query)
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand(query, con);
            //execute command
            cmd.ExecuteNonQuery();
            //close connection
            con.Close();
        }

        //create method to delete data from database
        public static void delete(string query)
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand(query, con);
            //execute command
            cmd.ExecuteNonQuery();
            //close connection
            con.Close();
        }

        //fetch all products
        public static DataTable fetch_all_products()
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Products", con);
            //create data adapter
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //create data table
            DataTable dt = new DataTable();
            //fill data table
            da.Fill(dt);
            //close connection
            con.Close();
            //return data table
            return dt;
        }
        
        //fetch product by id
        public static DataTable fetch_product_by_id(string id)
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Products WHERE id = " + id, con);
            //create data adapter
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //create data table
            DataTable dt = new DataTable();
            //fill data table
            da.Fill(dt);
            //close connection
            con.Close();
            //return data table
            return dt;
        }

    }
}
