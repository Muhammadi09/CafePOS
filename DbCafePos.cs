using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafePOS
{
    public static class DbCafePos
    {
        
        public static MySqlConnection GetConnection()
        {
            string sql = "server=localhost;uid=root;pwd=Umar2;database=cafepos";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("MySQl connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddProduct(string name, double price, string category)
        {
            string sqlInsert = "insert into Product(product_name,price,category) values('" + name + "','" + price + "','" + category + "');";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sqlInsert, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfully added.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: Adding product failed.");
            }
            con.Close();
        }

        public static DataTable GetAllProducts(DataTable dataTable)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT Product.product_name AS ProductName, Product.price AS Price, Product.category AS Category FROM product", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);

            return dataTable;
        }
        public static MySqlDataReader GetSpecificProducts(string column, string value)
        {
            MySqlConnection connection = GetConnection();
            string query = string.Format("SELECT Product.product_name AS ProductName, Product.price AS Price, Product.category AS Category FROM product WHERE Product.{0} = '{1}'", column, value);
            MySqlCommand cmd = new MySqlCommand(query,connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }
        public static void DeleteProduct(string productName, string category)
        {
            MySqlConnection con = GetConnection();
            string removeProduct = string.Format("DELETE FROM Product WHERE product_name = '{0}' AND category = '{1}'", productName, category);

            try
            {
                MySqlCommand cmd = new MySqlCommand(removeProduct, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Deletion failed.");
            }
            con.Close();
        }
    }
}
