using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneInventory
{
    public partial class PaymentForm : Form
    {
        private double totalAmount;
        private double paymentAmount;
        private double changeAmount;
        private bool _isPaymentAmountValid;
        private bool _isTotalAmountValid;

        public PaymentForm()
        {
            InitializeComponent();
            PaymentAmount.TextChanged += PaymentAmount_TextChanged;
            setChangeAmount();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TotalChangeLabel_Click(object sender, EventArgs e)
        {
            setChangeAmount();
        }

        private void PaymentAmount_TextChanged(object? sender, EventArgs e)
        {
            setChangeAmount();
        }

        public void setChangeAmount()

        {
            _isTotalAmountValid = TryParseAmount(TotalAmount.Text, out totalAmount);
            if (!_isTotalAmountValid)
            {
                totalAmount = 0;
            }

            _isPaymentAmountValid = TryParseAmount(PaymentAmount.Text, out paymentAmount);
            if (!_isPaymentAmountValid)
            {
                paymentAmount = 0;
            }

            changeAmount = paymentAmount - totalAmount;
            if (changeAmount < 0)
            {
                changeAmount = 0;
            }
            TotalChangeLabel.Text = "P " + changeAmount.ToString("F2");
        }

        private static bool TryParseAmount(string? value, out double amount)
        {
            if (double.TryParse(value, out var result) && result >= 0)
            {
                amount = result;
                return true;
            }

            amount = 0;
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            setChangeAmount();
            if (!_isPaymentAmountValid)
            {
                MessageBox.Show("Please enter a valid payment amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_isTotalAmountValid)
            {
                MessageBox.Show("Unable to determine the total amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (paymentAmount >= totalAmount)
            {
                MessageBox.Show("Payment successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            MessageBox.Show("Insufficient funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
