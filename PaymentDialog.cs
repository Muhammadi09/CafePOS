using System;
using System.Windows.Forms;

namespace CafePOS
{
    public partial class PaymentDialog : Form
    {
        public PaymentDialog()
        {
            InitializeComponent();
            AmountToPay();

        }

        private void AmountToPay()
        {
            amountToPayTextBox.Text = Payment.GetPrice().ToString();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {

            double payment = Convert.ToDouble(amountToPayTextBox.Text) - Convert.ToDouble(paymentGivenTextBox.Text);
            amountToPayTextBox.Text = String.Format("{0:0.00}", payment);
            Payment.UpdatePrice(payment);
            paymentGivenTextBox.Text = null;

            if (Payment.GetPrice() <= 0)
            {
                amountToPayTextBox.Text = null;
                MessageBox.Show($"Change to be given: £{String.Format("{0:0.00}",Math.Abs(Payment.GetPrice()))}");
                SaveTransaction();
                this.Close();
                TillForm tillform = (TillForm)Application.OpenForms["TillForm"];
                tillform.Close();
                //tillForm2.Show();
                return;
            }


        }

        private void SaveTransaction()
        {
            Transaction transaction = new Transaction();
            string products = "";
            double totalPrice = 0;
            DateTime date = transaction.GetDate();
            date = date.Date;
            string format = "yyyy-MM-dd"; 

            foreach (var product in TillProducts.products)
            {
                transaction.AddItems(product);
            }

            //Save to DB Transaction
            foreach (var item in transaction.GetItems())
            {
                products += item.Name + ",";
                totalPrice += item.Price;
            }

            DbCafePos.SaveToTransaction(products, totalPrice, date.ToString(format));
            TillProducts.products.Clear();
        }
    }
}
