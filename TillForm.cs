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
        //private BindingList<Product> products = new BindingList<Product>();
        private List<string> categories = new List<string>();
        private double price;

        public TillForm()
        {
            InitializeComponent();
            productsListBox.DataSource = TillProducts.products;
            productsListBox.DisplayMember = "Description";
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
            TillProducts.products.Add(p);
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
        
      
        private void deleteBtn_Click(object sender, EventArgs e)
        {

            double price = 0;
            foreach (var item in TillProducts.products)
            {
                if (item.Description.Equals(productsListBox.Text))
                {
                    price = item.Price;
                }
            }
            if(TillProducts.products.Count > 0)
            {
                this.price -= price;
                totalPriceBox.Text = String.Format("{0:c}", this.price);
                TillProducts.products.Remove((Product)productsListBox.SelectedItem);
                productInfoBox.Text = null;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            
            
            if (TillProducts.products.Count > 0)
            {
                double totalPrice = Convert.ToDouble(totalPriceBox.Text.TrimStart('£'));
                Payment.UpdatePrice(totalPrice);
                PaymentDialog paymentDialog = new PaymentDialog();
                paymentDialog.ShowDialog();

            }
            else
            {
                MessageBox.Show("No items added");
            }
            
        }
    }
}
