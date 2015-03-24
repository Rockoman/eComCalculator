namespace eComCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPricePerAfter = new System.Windows.Forms.TextBox();
            this.txtFeePerAfter = new System.Windows.Forms.TextBox();
            this.txtTotalFeeAfter = new System.Windows.Forms.TextBox();
            this.txtProfitPerAfter = new System.Windows.Forms.TextBox();
            this.txtTotalProfitAfter = new System.Windows.Forms.TextBox();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.txtEstShipping = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtShippingCosts = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPricePer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCal.Location = new System.Drawing.Point(218, 249);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(190, 99);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(89, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price Per Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(89, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(89, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shipping Costs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(305, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sell Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(305, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estimate Shipping";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(305, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fees %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(150, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Cost Per Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(64, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fee Per Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(64, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total Fees";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(305, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Profit Per Item";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(305, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total Profit";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.Location = new System.Drawing.Point(92, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(426, 20);
            this.txtName.TabIndex = 12;
            this.txtName.Text = "Product Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPricePerAfter
            // 
            this.txtPricePerAfter.Location = new System.Drawing.Point(319, 383);
            this.txtPricePerAfter.Name = "txtPricePerAfter";
            this.txtPricePerAfter.Size = new System.Drawing.Size(100, 20);
            this.txtPricePerAfter.TabIndex = 13;
            this.txtPricePerAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPricePerAfter_KeyPress);
            // 
            // txtFeePerAfter
            // 
            this.txtFeePerAfter.Location = new System.Drawing.Point(164, 438);
            this.txtFeePerAfter.Name = "txtFeePerAfter";
            this.txtFeePerAfter.Size = new System.Drawing.Size(100, 20);
            this.txtFeePerAfter.TabIndex = 14;
            this.txtFeePerAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeePerAfter_KeyPress);
            // 
            // txtTotalFeeAfter
            // 
            this.txtTotalFeeAfter.Location = new System.Drawing.Point(164, 490);
            this.txtTotalFeeAfter.Name = "txtTotalFeeAfter";
            this.txtTotalFeeAfter.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFeeAfter.TabIndex = 15;
            this.txtTotalFeeAfter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalFeeAfter_KeyDown);
            this.txtTotalFeeAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalFeeAfter_KeyPress);
            // 
            // txtProfitPerAfter
            // 
            this.txtProfitPerAfter.Location = new System.Drawing.Point(396, 435);
            this.txtProfitPerAfter.Name = "txtProfitPerAfter";
            this.txtProfitPerAfter.Size = new System.Drawing.Size(100, 20);
            this.txtProfitPerAfter.TabIndex = 16;
            this.txtProfitPerAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfitPerAfter_KeyPress);
            // 
            // txtTotalProfitAfter
            // 
            this.txtTotalProfitAfter.Location = new System.Drawing.Point(396, 490);
            this.txtTotalProfitAfter.Name = "txtTotalProfitAfter";
            this.txtTotalProfitAfter.Size = new System.Drawing.Size(100, 20);
            this.txtTotalProfitAfter.TabIndex = 17;
            this.txtTotalProfitAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalProfitAfter_KeyPress);
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(418, 117);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSellPrice.TabIndex = 18;
            this.txtSellPrice.Text = "0.00";
            this.txtSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellPrice_KeyPress);
            // 
            // txtEstShipping
            // 
            this.txtEstShipping.Location = new System.Drawing.Point(418, 159);
            this.txtEstShipping.Name = "txtEstShipping";
            this.txtEstShipping.Size = new System.Drawing.Size(100, 20);
            this.txtEstShipping.TabIndex = 19;
            this.txtEstShipping.Text = "0.00";
            this.txtEstShipping.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEstShipping.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstShipping_KeyPress);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(418, 194);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 20;
            this.txtFee.Text = "15";
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFee.TextChanged += new System.EventHandler(this.txtFee_TextChanged);
            this.txtFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFee_KeyPress);
            // 
            // txtShippingCosts
            // 
            this.txtShippingCosts.Location = new System.Drawing.Point(192, 194);
            this.txtShippingCosts.Name = "txtShippingCosts";
            this.txtShippingCosts.Size = new System.Drawing.Size(100, 20);
            this.txtShippingCosts.TabIndex = 23;
            this.txtShippingCosts.Text = "0.00";
            this.txtShippingCosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtShippingCosts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShippingCosts_KeyPress);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(192, 159);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 22;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtPricePer
            // 
            this.txtPricePer.Location = new System.Drawing.Point(192, 117);
            this.txtPricePer.Name = "txtPricePer";
            this.txtPricePer.Size = new System.Drawing.Size(100, 20);
            this.txtPricePer.TabIndex = 21;
            this.txtPricePer.Text = "0.00";
            this.txtPricePer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPricePer.TextChanged += new System.EventHandler(this.txtPricePer_TextChanged);
            this.txtPricePer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPricePer_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1039, 759);
            this.Controls.Add(this.txtShippingCosts);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPricePer);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtEstShipping);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.txtTotalProfitAfter);
            this.Controls.Add(this.txtProfitPerAfter);
            this.Controls.Add(this.txtTotalFeeAfter);
            this.Controls.Add(this.txtFeePerAfter);
            this.Controls.Add(this.txtPricePerAfter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCal);
            this.Name = "Form1";
            this.Text = "e-Commerce Product Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPricePerAfter;
        private System.Windows.Forms.TextBox txtFeePerAfter;
        private System.Windows.Forms.TextBox txtTotalFeeAfter;
        private System.Windows.Forms.TextBox txtProfitPerAfter;
        private System.Windows.Forms.TextBox txtTotalProfitAfter;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.TextBox txtEstShipping;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtShippingCosts;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPricePer;
    }
}

