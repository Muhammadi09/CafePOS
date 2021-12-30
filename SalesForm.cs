using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafePOS
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

            transactionsTable.DataSource = GetTransactionsList();
            transactionsTable.Columns[0].Width = 250;
            transactionsTable.Columns[1].Width = 250;
            transactionsTable.Columns[2].Width = 250;


        }

        private DataTable GetTransactionsList()
        {
            DataTable dtTransactions = new DataTable();
            return DbCafePos.GetAllTransactions(dtTransactions);
        }

        private void csvBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = GetTransactionsList();

            SaveFileDialog dialog = new SaveFileDialog();
            string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            dialog.Filter = filter;
            DialogResult result = dialog.ShowDialog();
            
            string selectedPath = "";
            if (result == DialogResult.OK)
            {
                
                selectedPath = dialog.FileName;
            }
            dt.ToCSV(selectedPath);
        }
    }
}
