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
    public partial class AddProductsForm : Form
    {
        public AddProductsForm()
        {
            InitializeComponent();
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(priceBox.Text, "^[0-9\b]{1}([\\.\\,]|([\\.\\,][0-9]{1,3}))?"))
            {
                MessageBox.Show("Error, must only contain integers and decimals");
                priceBox.Text = String.Empty;
                
            }

        }

        private void addBtnAddProduct_Click(object sender, EventArgs e)
        {
            if(!(categoryBox.SelectedIndex== -1) || !(String.IsNullOrWhiteSpace(priceBox.Text)) || !(String.IsNullOrWhiteSpace(productNameBox.Text)))
            {
                //Adding product to database(Product table)
                DbCafePos.AddProduct(this.productNameBox.Text, Convert.ToDouble(this.priceBox.Text), this.categoryBox.Text);
            }
        }

        private void cancelBtnAddproduct_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
