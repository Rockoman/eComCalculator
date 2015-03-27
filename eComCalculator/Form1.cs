using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace eComCalculator
{
    public partial class Form1 : Form
    {
        CultureInfo us = new CultureInfo("en-US");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {

            //convert string value of price per item into a double
            double pricePer = Double.Parse(txtPricePer.Text);
            //convert string value of total shipping costs into a double
            double shipCosts = Double.Parse(txtShippingCosts.Text);
            //convert string value of the selling price per item into a double
            double sellPrice = Double.Parse(txtSellPrice.Text);
            //convert the estimate shipping costs (after sold) into a double
            double estimateShip = Double.Parse(txtEstShipping.Text);
            //convert string value of fee percentage into a double.
            double fees = Double.Parse(txtFee.Text) / 100;
            //convert the string value of the total quantity into an int
            int quantity = Int32.Parse(txtQty.Text);


            //calculate the total costs of each item when factoring shipping costs
            double priceAfterShip = (pricePer * quantity + shipCosts) / quantity;
            //display the new total costs
            txtPricePerAfter.Text = priceAfterShip.ToString("c", us);

            //calculate the fees per item
            double feePerAfter = (fees * sellPrice);
            //display the fees per item
            txtFeePerAfter.Text = feePerAfter.ToString("c", us); ;

            //calculate the total fees
            double totalFees = feePerAfter * quantity;
            //display the of fees
            txtTotalFeeAfter.Text = totalFees.ToString("c", us); 

            //calculate how much profit will be earned through each sale
            double profitPer = sellPrice - feePerAfter - priceAfterShip - estimateShip;
            //display profit
            txtProfitPerAfter.Text = profitPer.ToString("c", us);

            //calculate total profit
            double totalProfit = profitPer * quantity;
            //display total profit
            txtTotalProfitAfter.Text = totalProfit.ToString("c", us);

        }

        private void txtPricePer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPricePer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;


            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            //disable punctuation and text from input box
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //disable punctuation and text from input box
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtShippingCosts_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //disable punctuation and text from input box
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtEstShipping_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //disable punctuation and text from input box
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //disable punctuation and text from input box
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void txtPricePerAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetterOrDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void txtFeePerAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetterOrDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void txtTotalFeeAfter_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtTotalFeeAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetterOrDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void txtProfitPerAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetterOrDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void txtTotalProfitAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetterOrDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

    }
}
