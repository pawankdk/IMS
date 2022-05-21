namespace IMS._09
{
    partial class PurchaseSale
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustSuppSearch = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustSupplier = new System.Windows.Forms.TextBox();
            this.lblCustSupplier = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTypeRate = new System.Windows.Forms.Label();
            this.txtTypeRate = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtPaidAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtGrandTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtDiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.txtTransactionDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCustSuppSearch);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMobileNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhoneNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustSupplier);
            this.groupBox1.Controls.Add(this.lblCustSupplier);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1696, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase-Customer Detalis";
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTransactionDate.Location = new System.Drawing.Point(1104, 43);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Size = new System.Drawing.Size(335, 32);
            this.txtTransactionDate.TabIndex = 13;
            this.txtTransactionDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(911, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Transaction Date";
            // 
            // txtCustSuppSearch
            // 
            this.txtCustSuppSearch.Location = new System.Drawing.Point(80, 151);
            this.txtCustSuppSearch.Name = "txtCustSuppSearch";
            this.txtCustSuppSearch.Size = new System.Drawing.Size(160, 32);
            this.txtCustSuppSearch.TabIndex = 11;
            this.txtCustSuppSearch.TextChanged += new System.EventHandler(this.txtCustSuppSearch_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(9, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 24);
            this.label16.TabIndex = 10;
            this.label16.Text = "Search";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1531, 146);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 53);
            this.txtAddress.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(1425, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(1272, 151);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(136, 32);
            this.txtMobileNo.TabIndex = 7;
            this.txtMobileNo.TextChanged += new System.EventHandler(this.txtMobileNo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1154, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "MobileNo";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(987, 151);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(161, 32);
            this.txtPhoneNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(878, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "PhoneNo";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(649, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 32);
            this.txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(587, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // txtCustSupplier
            // 
            this.txtCustSupplier.Location = new System.Drawing.Point(421, 151);
            this.txtCustSupplier.Name = "txtCustSupplier";
            this.txtCustSupplier.Size = new System.Drawing.Size(160, 32);
            this.txtCustSupplier.TabIndex = 1;
            this.txtCustSupplier.TextChanged += new System.EventHandler(this.txtCustSupplier_TextChanged);
            // 
            // lblCustSupplier
            // 
            this.lblCustSupplier.AutoSize = true;
            this.lblCustSupplier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCustSupplier.Location = new System.Drawing.Point(246, 159);
            this.lblCustSupplier.Name = "lblCustSupplier";
            this.lblCustSupplier.Size = new System.Drawing.Size(169, 24);
            this.lblCustSupplier.TabIndex = 0;
            this.lblCustSupplier.Text = "Customer/Supplier";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtProductSearch);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTypeRate);
            this.groupBox2.Controls.Add(this.txtTypeRate);
            this.groupBox2.Controls.Add(this.txtRate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtProduct);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1696, 105);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(1575, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 57);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Location = new System.Drawing.Point(80, 40);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(160, 32);
            this.txtProductSearch.TabIndex = 13;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(6, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 24);
            this.label17.TabIndex = 12;
            this.label17.Text = "Search";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(1041, 40);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(137, 32);
            this.txtQuantity.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(935, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantity";
            // 
            // lblTypeRate
            // 
            this.lblTypeRate.AutoSize = true;
            this.lblTypeRate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTypeRate.Location = new System.Drawing.Point(1227, 43);
            this.lblTypeRate.Name = "lblTypeRate";
            this.lblTypeRate.Size = new System.Drawing.Size(92, 24);
            this.lblTypeRate.TabIndex = 6;
            this.lblTypeRate.Text = "Type Rate";
            // 
            // txtTypeRate
            // 
            this.txtTypeRate.Location = new System.Drawing.Point(1363, 35);
            this.txtTypeRate.Name = "txtTypeRate";
            this.txtTypeRate.Size = new System.Drawing.Size(181, 32);
            this.txtTypeRate.TabIndex = 7;
            this.txtTypeRate.Text = " ";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(778, 40);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(151, 32);
            this.txtRate.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(724, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rate";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(550, 43);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(168, 32);
            this.txtStock.TabIndex = 3;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(489, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Stock";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(332, 45);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(151, 32);
            this.txtProduct.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(246, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Product";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.Controls.Add(this.gvProducts);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(882, 356);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Added Products";
            // 
            // gvProducts
            // 
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Location = new System.Drawing.Point(6, 22);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.ReadOnly = true;
            this.gvProducts.RowTemplate.Height = 24;
            this.gvProducts.Size = new System.Drawing.Size(869, 329);
            this.gvProducts.TabIndex = 0;
            this.gvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProducts_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox4.Controls.Add(this.txtReturnAmount);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.TxtPaidAmount);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.TxtGrandTotal);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.TxtDiscount);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtVat);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtSubTotal);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(900, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(808, 356);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculation Detalis";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.Location = new System.Drawing.Point(184, 270);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.Size = new System.Drawing.Size(418, 32);
            this.txtReturnAmount.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(23, 278);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Return Amount";
            // 
            // TxtPaidAmount
            // 
            this.TxtPaidAmount.Location = new System.Drawing.Point(184, 219);
            this.TxtPaidAmount.Name = "TxtPaidAmount";
            this.TxtPaidAmount.Size = new System.Drawing.Size(418, 32);
            this.TxtPaidAmount.TabIndex = 11;
            this.TxtPaidAmount.TextChanged += new System.EventHandler(this.TxtPaidAmount_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(23, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "Paid Amount";
            // 
            // TxtGrandTotal
            // 
            this.TxtGrandTotal.Location = new System.Drawing.Point(184, 172);
            this.TxtGrandTotal.Name = "TxtGrandTotal";
            this.TxtGrandTotal.Size = new System.Drawing.Size(418, 32);
            this.TxtGrandTotal.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(23, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "Grand Total";
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.Location = new System.Drawing.Point(184, 125);
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Size = new System.Drawing.Size(418, 32);
            this.TxtDiscount.TabIndex = 7;
            this.TxtDiscount.TextChanged += new System.EventHandler(this.TxtDiscount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(27, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Discount(%)";
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(184, 78);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(418, 32);
            this.txtVat.TabIndex = 3;
            this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(27, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "VAT(%)";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(184, 31);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(418, 32);
            this.txtSubTotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sub Total";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DimGray;
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Location = new System.Drawing.Point(12, 710);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1696, 79);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(1575, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 57);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PurchaseSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 801);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseSale";
            this.Load += new System.EventHandler(this.PurchaseSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustSupplier;
        private System.Windows.Forms.Label lblCustSupplier;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTypeRate;
        private System.Windows.Forms.Label lblTypeRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtPaidAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtGrandTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtDiscount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustSuppSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker txtTransactionDate;
        private System.Windows.Forms.Label label11;
    }
}