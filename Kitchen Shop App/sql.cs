using System.Data;
using MySqlConnector;

namespace Kitchen_staff_app
{
    //class mysql
    class mysql
    {
        //create connection 
        private protected static readonly MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=resturant");

        //create method to insert data into database
        /// <summary>
        /// Inserts data into the specified table.
        /// </summary>
        /// <param name="tableName">The name of the table to insert the data into.</param>
        /// <param name="data">A dictionary containing the column names and values to insert.</param>
        public static int insert(string tableName, Dictionary<string, object> data)
        {
            // construct the parameterized query
            string columns = string.Join(", ", data.Keys);
            string values = string.Join(", ", data.Keys.Select(k => $"@{k}"));
            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";

            // open connection
            con.Open();

            // create command
            MySqlCommand cmd = new MySqlCommand(query, con);

            // add parameters to the command
            foreach (var kvp in data)
            {
                cmd.Parameters.AddWithValue($"@{kvp.Key}", kvp.Value);
            }

            // execute command and fetches id
            cmd.ExecuteNonQuery();
            int id = (int)cmd.LastInsertedId;
            

            // close connection
            con.Close();

            return id;
        }

        /// <summary>
        /// Executes a SELECT query on the database with the specified parameters and returns the results as a DataTable.
        /// </summary>
        /// <param name="query">The SELECT query to execute, with placeholders for parameters using the syntax "@paramName".</param>
        /// <param name="parameters">A dictionary containing the parameter names and values to be substituted in the query.</param>
        /// <returns>A DataTable containing the results of the query.</returns>
        public static DataTable select(string query, Dictionary<string, object> parameters)
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand(query, con);
            //add parameters
            foreach (KeyValuePair<string, object> param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
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
        /// <summary>
        /// Updates the specified table with the given fields based on the specified conditions.
        /// </summary>
        /// <param name="table">The name of the table to update.</param>
        /// <param name="where">The conditions to use for the update.</param>
        /// <param name="fields">A dictionary of field names and values to update in the table.</param>
        public static void update(string table, string where, Dictionary<string, object> fields)
        {
            string query = $"UPDATE {table} SET ";
            int i = 0;
            foreach (var field in fields)
            {
                query += $"{field.Key}=@{field.Key}";
                i++;
                if (i < fields.Count) query += ",";
            }
            query += $" WHERE {where}";

            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                foreach (var field in fields)
                {
                    cmd.Parameters.AddWithValue($"@{field.Key}", field.Value);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //create method to delete data from database
        /// <summary>
        /// Deletes data from a table in the database using a prepared statement.
        /// </summary>
        /// <param name="tableName">The name of the table to delete data from.</param>
        /// <param name="whereClause">The WHERE clause to filter data to be deleted.</param>
        /// <param name="parameters">A list of parameters to be used in the prepared statement.</param>
        /// <remarks>
        /// This method constructs a DELETE query with a WHERE clause and executes it using a prepared statement. 
        /// The WHERE clause is used to filter data to be deleted. The `parameters` argument is a list of parameters 
        /// to be used in the prepared statement. Each parameter should have its name and value set before passing 
        /// to the method.
        /// </remarks>
        public static void delete(string tableName, string whereClause, List<MySqlParameter> parameters)
        {
            // construct the query
            string query = $"DELETE FROM {tableName} WHERE {whereClause}";

            // open connection
            con.Open();

            // create command
            MySqlCommand cmd = new MySqlCommand(query, con);

            // add parameters to command
            foreach (MySqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }

            // execute command
            cmd.ExecuteNonQuery();

            // close connection
            con.Close();
        }

        //fetch all products
        /// <summary>
        /// Fetches all products from the Products table.
        /// </summary>
        /// <returns>A DataTable containing all products.</returns>
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

        /// <summary>
        /// Fetches a product with the specified ID from the Products table.
        /// </summary>
        /// <param name="id">The ID of the product to fetch.</param>
        /// <returns>A DataTable containing the product with the specified ID.</returns>
        public static DataTable fetch_product_by_id(string? id)
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Products WHERE id = @id", con);
            //add parameters to command
            cmd.Parameters.AddWithValue("@id", id);
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

        /// <summary>
        /// Fetches all products in the specified category from the Products table.
        /// </summary>
        /// <param name="id">The ID of the category to fetch products from.</param>
        /// <returns>A DataTable containing all products in the specified category.</returns>
        public static DataTable fetch_product_by_category_id(string? id)
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Products WHERE category_id = @id", con);
            //add parameters to command
            cmd.Parameters.AddWithValue("@id", id);
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

        /// <summary>
        /// Fetches a category with the specified ID from the categories table.
        /// </summary>
        /// <param name="id">The ID of the category to fetch.</param>
        /// <returns>A DataTable containing the category with the specified ID.</returns>
        public static DataTable fetch_category_by_id(string? id)
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM categories WHERE id = @id", con);
            //add parameters to command
            cmd.Parameters.AddWithValue("@id", id);
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

        /// <summary>
        /// Fetches all categories from the categories table.
        /// </summary>
        /// <returns>A DataTable containing all categories.</returns>
        public static DataTable fetch_all_categories()
        {
            //open connection
            con.Open();
            //create command
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM categories", con);
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

        public static int getLastInsertedId()
        {
            // open connection
            con.Open();

            // create command to get the last inserted id
            MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", con);

            // execute command and get the last inserted id
            int lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());

            // close connection
            con.Close();

            return lastInsertedId;
        }

        public static DataTable fetch_all_order_items_with_product_name(string? order_id)
        {
            string query = "SELECT order_items.quantity, products.name as product_name FROM order_items JOIN products ON order_items.product_id = products.id WHERE order_items.order_id = @order_id";
            using (var command = new MySqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@order_id", order_id);
                using (var adapter = new MySqlDataAdapter(command))
                {
                    var result = new DataTable();
                    adapter.Fill(result);
                    return result;
                }
            }
        }

    }
}
