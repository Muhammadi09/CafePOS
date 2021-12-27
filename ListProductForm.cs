using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CafePOS
{
    public partial class ListProductForm : Form
    {
        public ListProductForm()
        {
            InitializeComponent();
        }

        private void ListProductForm_Load(object sender, EventArgs e)
        {
            
            productListDataView.DataSource = GetProductsList();
            productListDataView.Columns[0].Width = 220;
            productListDataView.Columns[1].Width = 220;
            productListDataView.Columns[2].Width = 220;

          
        }

        private DataTable GetProductsList()
        {
            DataTable dtProducts = new DataTable();
            return DbCafePos.GetAllProducts(dtProducts);
        }
        

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            string productName = productListDataView.SelectedRows[0].Cells[0].Value.ToString();
            string category = productListDataView.SelectedRows[0].Cells[2].Value.ToString();

            DbCafePos.DeleteProduct(productName, category);

            foreach (DataGridViewCell oneCell in productListDataView.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    productListDataView.Rows.RemoveAt(oneCell.RowIndex);
                }

            }
        }
        
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            var addProductsForm = new AddProductsForm();
            addProductsForm.Show();
            this.Close();
        }

        private void categoryFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtProducts = new DataTable();
            MySqlDataReader reader = DbCafePos.GetSpecificProducts("Category", categoryFilterBox.SelectedItem.ToString());
            dtProducts.Load(reader);
            productListDataView.DataSource = dtProducts;
        }
       
    }
}
