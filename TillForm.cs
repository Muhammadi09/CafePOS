using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafePOS
{
    
    public partial class TillForm : Form
    {
        private BindingList<Product> products = new BindingList<Product>();
        private List<string> categories = new List<string>();
        private double price;
        private double currentPrice;
        public TillForm()
        {
            InitializeComponent();
            productsListBox.DataSource = products;
            //productsListBox.DisplayMember = "Description";
            CreateCategoryTabs();
            CreateProductButtons();
            
        }

        private void CreateCategoryTabs()
        {
            MySqlConnection connection = DbCafePos.GetConnection();
            string query = "SELECT category_name FROM Category";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                categories.Add((string)reader["category_name"]);
            }
            foreach (var category in categories)
            {
                categoryPanel.TabPages.Add(category);
            }
            connection.Close();           
        }

        private void CreateProductButtons()
        {
            foreach(TabPage tp in categoryPanel.TabPages)
            {
                MySqlConnection connection = DbCafePos.GetConnection();
                string query = $"SELECT * FROM Product WHERE category = '{tp.Text}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                Product product;
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.Fill;

                while (reader.Read())
                {
                    Button b = new Button();
                    b.Size = new Size(75, 75);
                    b.Text = (string)reader["product_name"];
                    product = new Product((string)reader["product_name"], (string)reader["category"],Convert.ToDouble(reader["price"]));
                    b.Tag = product;
                    b.Click += new EventHandler(addProductToList_Click);
                    flowLayoutPanel.Controls.Add(b);
                }
                tp.Controls.Add(flowLayoutPanel);

            }
        }

        private void addProductToList_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Product p = (Product)b.Tag;
            UpdateProductInfoBox(p);
            products.Add(p);
            productsListBox.SelectedIndex = productsListBox.Items.Count - 1;
            UpdatePriceTotal(p);

        }

        private void UpdatePriceTotal(Product product)
        {
           
            price += product.Price;
            totalPriceBox.Text = String.Format("{0:c}", price);
        }

        private void UpdateProductInfoBox(Product product)
        {
            productInfoBox.Text = product.Name + " " + product.Price.ToString();
        }
        
        private void productsListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string currentDescription = ((Product)e.ListItem).Name;
            string currentPrice = String.Format("{0:c}", ((Product)e.ListItem).Price);
            string currentDescriptionPadded = currentDescription.PadRight(20);
            this.currentPrice = ((Product)e.ListItem).Price;
            e.Value = currentDescriptionPadded + currentPrice;
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                price -= currentPrice;
                totalPriceBox.Text = String.Format("{0:c}", price);
                products.Remove((Product)productsListBox.SelectedItem);
                productInfoBox.Text = null;

            }




        }
    }
}
