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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            var addProductsForm = new AddProductsForm();
            addProductsForm.Show();
        }

        private void listProductsBtn_Click(object sender, EventArgs e)
        {
            var listProductForm = new ListProductForm();
            listProductForm.Show();
        }
    }
}
