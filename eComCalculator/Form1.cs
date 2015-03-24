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


            double pricePer = Double.Parse(txtPricePer.Text);
            double shipCosts = Double.Parse(txtShippingCosts.Text);
            double sellPrice = Double.Parse(txtSellPrice.Text);
            double estimateShip = Double.Parse(txtEstShipping.Text);
            int quantity = Int32.Parse(txtQty.Text);
            double fees = Double.Parse(txtFee.Text) / 100;


            double priceAfterShip = (pricePer * quantity + shipCosts) / quantity;
            txtPricePerAfter.Text = priceAfterShip.ToString("c", us);

            double feePerAfter = (fees * sellPrice);
            txtFeePerAfter.Text = feePerAfter.ToString("c", us); ;

            double totalFees = feePerAfter * quantity;
            txtTotalFeeAfter.Text = totalFees.ToString("c", us); 

            double profitPer = sellPrice - feePerAfter - priceAfterShip - estimateShip;
            txtProfitPerAfter.Text = profitPer.ToString("c", us);

            double totalProfit = profitPer * quantity;
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

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtShippingCosts_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtEstShipping_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

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
