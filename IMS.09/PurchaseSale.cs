﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace IMS._09
{
    public partial class PurchaseSale : Form
    {
        DataTable myDT =new DataTable();
        public int CustomerSupplierId;
        public int ProductId;
        string connectionstring = "Data Source=DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated Security = true;";

        public PurchaseSale()
        {
            InitializeComponent();
        }

        private void PurchaseSale_Load(object sender, EventArgs e)
        {
            txtCustSupplier.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNo.Enabled = false;
            txtMobileNo.Enabled = false;
            txtAddress.Enabled = false;

            txtProduct.Enabled = false;
            txtStock.Enabled = false;
            txtRate.Enabled = false;

            txtSubTotal.Enabled = false;
            TxtGrandTotal.Enabled = false;
            txtReturnAmount.Enabled = false;

            myDT.Columns.Add("Product Id");
            myDT.Columns.Add("Product Name");
            myDT.Columns.Add("Quantity");
            myDT.Columns.Add("Rate");
            myDT.Columns.Add("Total");
            gvProducts.DataSource = myDT;

            String myval = MainForm.transactionType;
            this.Text = MainForm.transactionType;
            this.Refresh();
            if (MainForm.transactionType == "Purchase")
            {
                lblCustSupplier.Text = "Supplier";
                lblTypeRate.Text = "Purchase Rate";
            }
            else if (MainForm.transactionType == "Sale")
            {
                lblCustSupplier.Text = "Customer";
                lblTypeRate.Text = "Sales Rate";
            }
        }

        private void txtCustSupplier_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustSuppSearch_TextChanged(object sender, EventArgs e)
        {
                try
                {
                if (txtCustSuppSearch.Text == string.Empty)
                {
                    txtCustSupplier.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtPhoneNo.Text = string.Empty;
                    txtMobileNo.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                    return;
                }


                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "SELECT CustomerSupplierId,Name,Email,PhoneNo,MobileNo,Address FROM CustomerSupplier where Type = @type AND (CustomerSupplierId like @search OR Name like @search)";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        if (MainForm.transactionType == "Purchase")
                        {
                            cmd.Parameters.AddWithValue("@type", "Supplier");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@type", "Customer");
                        }
                        cmd.Parameters.AddWithValue("@search", "%" + txtCustSupplier.Text + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            DataRow dr = dt.Rows[0];
                            CustomerSupplierId = int.Parse(dr["CustomerSupplierId"].ToString());
                            txtCustSupplier.Text = dr["Name"].ToString();
                            txtEmail.Text = dr["Email"].ToString();
                            txtPhoneNo.Text = dr["PhoneNo"].ToString();
                            txtMobileNo.Text = dr["MobileNo"].ToString();
                            txtAddress.Text = dr["Address"].ToString();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProductSearch.Text == string.Empty)
                {
                    txtProduct.Text = string.Empty;
                    txtStock.Text = string.Empty;
                    txtRate.Text = string.Empty;
                    txtTypeRate.Text = string.Empty;
                    txtQuantity.Text = string.Empty;
                    return;
                }


                using (SqlConnection con = new SqlConnection(connectionstring))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT ProductId,ProductName,Quantity,Rate FROM Product where ProductId like @search or ProductName Like @search";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@search", "%" + txtProductSearch.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        ProductId = int.Parse(dr["ProductId"].ToString());
                        txtProduct.Text = dr["ProductName"].ToString();
                        txtStock.Text = dr["Quantity"].ToString();
                        txtRate.Text = dr["Rate"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text == string.Empty)
            {
                MessageBox.Show("Please enter Product...!!!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductSearch.Focus();
                return;
            }

            if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please enter Quantity...!!!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            decimal outQuantity;
            bool isDecimal = decimal.TryParse(txtQuantity.Text, out outQuantity);
            if (isDecimal == false)
            {
                MessageBox.Show("Stock has no sufficient product to sell...!!!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Text = string.Empty;
                txtQuantity.Focus();
                return;
            }

            if (MainForm.transactionType == "Sale")
            {
                if (outQuantity > decimal.Parse(txtStock.Text))
                {
                    MessageBox.Show("Please enter Decimal Quantiy...!!!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Text = string.Empty;
                    txtQuantity.Focus();
                    return;
                }
                if (decimal.Parse(txtStock.Text) <= 0)
                {
                    MessageBox.Show("Stock has no any product to sell...!!!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (txtTypeRate.Text == string.Empty)
            {
                MessageBox.Show("Please enter  Rate...!!!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeRate.Focus();
                return;
            }
            
            decimal outRate;
            bool isRateDecimal = decimal.TryParse(txtTypeRate.Text, out outRate);
            if (isRateDecimal == false)
            {
                MessageBox.Show("Please enter  Rate...!!!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeRate.Text = string.Empty;
                txtTypeRate.Focus();
                return;
            }
                      
            decimal total = outRate * outQuantity;

            myDT.Rows.Add(ProductId, txtProduct.Text, txtQuantity.Text, txtTypeRate.Text,total);

            decimal subTotal = decimal.Parse(txtSubTotal.Text == string.Empty ? "0":txtSubTotal.Text);
            subTotal += total;
            txtSubTotal.Text = subTotal.ToString();
            if (TxtGrandTotal.Text == string.Empty)
            {
                TxtGrandTotal.Text = subTotal.ToString();
            }
            else
            {
                TxtGrandTotal.Text = (decimal.Parse(TxtGrandTotal.Text) + total).ToString();
            }

            txtProductSearch.Text = string.Empty;
            txtProduct.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtTypeRate.Text = string.Empty;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtVat.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    decimal outVat;
                    bool isvatDecimal = decimal.TryParse(txtVat.Text,out outVat);
                    if (isvatDecimal == false)
                    {
                        MessageBox.Show("Please enter decimal value for vat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtVat.Text = string.Empty;
                        txtVat.Focus();
                        return;
                    }

                    decimal vatParc = decimal.Parse(txtVat.Text == string.Empty ? "0" : txtVat.Text);
                    decimal subTotal = decimal.Parse(txtSubTotal.Text == string.Empty ? "0" : txtSubTotal.Text);
                    decimal vatAmt = (subTotal * vatParc) / 100;
                    decimal grandTotal = subTotal + vatAmt;
                    TxtGrandTotal.Text = grandTotal.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something wents wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtDiscount.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    decimal outDiscount;
                    bool isdiscountDecimal = decimal.TryParse(TxtDiscount.Text, out outDiscount);
                    if (isdiscountDecimal == false)
                    {
                        MessageBox.Show("Please enter decimal value for discount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtDiscount.Text = string.Empty;
                        TxtDiscount.Focus();
                        return;
                    }

                    decimal discParc = decimal.Parse(TxtDiscount.Text == string.Empty ? "0" : TxtDiscount.Text);
                    decimal subTotal = decimal.Parse(txtSubTotal.Text == string.Empty ? "0" : txtSubTotal.Text);
                    decimal discAmt = (subTotal * discParc) / 100;
                    decimal grandTotal = subTotal - discAmt;
                    TxtGrandTotal.Text = grandTotal.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something wents wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TxtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(TxtGrandTotal.Text == string.Empty ? "0" : TxtGrandTotal.Text);
            decimal paidAmount = decimal.Parse(TxtPaidAmount.Text == string.Empty ? "0" : TxtPaidAmount.Text);
            decimal returnAmount = paidAmount - grandTotal;
            txtReturnAmount.Text = returnAmount.ToString();
            if (returnAmount < 0)
            {
                txtReturnAmount.BackColor = Color.Red;
            }
            else
            {
                txtReturnAmount.BackColor = Color.Green;
            }
        }

        private bool FormValidation()
        {
           
            if (txtCustSupplier.Text == string.Empty)
            {
                MessageBox.Show("Customer/Supplier is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustSupplier.Focus();
                return false;
            }

            if (txtTransactionDate.Text == string.Empty)
            {
                MessageBox.Show("Transaction Date is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTransactionDate.Focus();
                return false;
            }
            if (myDT.Rows.Count <= 0)
            {
                MessageBox.Show("You should add at least one Product...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSubTotal.Text == string.Empty)
            {
                MessageBox.Show("Sub Total is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubTotal.Focus();
                return false;
            }
           
            if (TxtGrandTotal.Text == string.Empty)
            {
                MessageBox.Show("Grand Total is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtGrandTotal.Focus();
                return false;
            }

            return true;
           
        }

        private void ClearFrom()
        {
            txtTransactionDate.Text = string.Empty;   
            txtCustSuppSearch.Text = string.Empty;
            txtCustSupplier.Text = string.Empty;

            txtEmail.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;

            txtMobileNo.Text = string.Empty;
            txtAddress.Text = string.Empty;

            txtProduct.Text = string.Empty;
            txtProductSearch.Text = string.Empty;
            txtRate.Text = string.Empty;

            txtTypeRate.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtStock.Text = string.Empty;

            myDT.Rows.Clear();
            gvProducts.DataSource = myDT;

            txtSubTotal.Text = string.Empty;

            txtVat.Text = string.Empty;
            TxtDiscount.Text = string.Empty;
            TxtPaidAmount.Text = string.Empty;

            TxtGrandTotal.Text = string.Empty;
            txtReturnAmount.Text = string.Empty;



        }

        private void UpdateProduct(int productId,decimal quantity)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Update Product SET Quantity=@quantity where ProductId=@productId";
                    con.Open();
                    cmd.Parameters.AddWithValue("@quantity",quantity);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private decimal GetProductStockValue(decimal ProductId)
        {
            decimal stockValue = 0;

            try
            {
               
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Quantity From  Product where ProductId=@productId";
                    cmd.Parameters.AddWithValue("@productId", ProductId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        stockValue = decimal.Parse(dr["Quantity"].ToString());
                    }
                    
                }
                return stockValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return stockValue;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = MessageBox.Show("Do you want to save?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm.ToString().ToUpper() == "OK")
                {
                    bool isValiationSucess = FormValidation();
                    if (isValiationSucess == true)
                    {
                        using (SqlConnection con = new SqlConnection(connectionstring))
                        {
                            using (TransactionScope scope = new TransactionScope())
                            {
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = @"INSERT INTO tblTransactionMaster(TransactionDate,Type,CustomerSupplierId,GrandTotal,Vat,Discount) VALUES 
                                               ( @TransactionDate,@Type,@CustomerSupplierId,@GrandTotal,@Vat,@Discount)select scope_identity()";
                                con.Open();
                                cmd.Parameters.AddWithValue("@TransactionDate", txtTransactionDate.Text);
                                cmd.Parameters.AddWithValue("@Type", MainForm.transactionType == "Purchase" ? "Supplier" : "Customer");
                                cmd.Parameters.AddWithValue("@CustomerSupplierId", CustomerSupplierId);
                                cmd.Parameters.AddWithValue("@GrandTotal", decimal.Parse(TxtGrandTotal.Text == string.Empty ? "0" : TxtGrandTotal.Text));
                                cmd.Parameters.AddWithValue("@Vat", decimal.Parse(txtVat.Text == string.Empty ? "0" : txtVat.Text));
                                cmd.Parameters.AddWithValue("@Discount", decimal.Parse(TxtDiscount.Text == string.Empty ? "0" : TxtDiscount.Text));

                                var recentMasterId = cmd.ExecuteScalar();

                                for(int i = 0;i< myDT.Rows.Count; i++)
                                {
                                    string productId = myDT.Rows[i][0].ToString();
                                    string productName = myDT.Rows[i][1].ToString();
                                    string quantity = myDT.Rows[i][2].ToString();
                                    string rate = myDT.Rows[i][3].ToString();
                                    string total = myDT.Rows[i][4].ToString();


                                    SqlCommand cmd1 = new SqlCommand();
                                    cmd1.Connection = con;
                                    cmd1.CommandType = CommandType.Text;
                                    cmd1.CommandText = @"INSERT INTO TransactionDetail(TransactionMasterId,ProductId,Quantity,Rate,Total)
                                                        VALUES (@TransactionMasterId,@ProductId,@Quantity,@Rate,@Total)";

                                    cmd1.Parameters.AddWithValue("@TransactionMasterId", recentMasterId);
                                    cmd1.Parameters.AddWithValue("@ProductId", int.Parse(productId));
                                    cmd1.Parameters.AddWithValue("@Quantity", decimal.Parse(quantity == string.Empty ? "0" : quantity));
                                    cmd1.Parameters.AddWithValue("@Rate", decimal.Parse(rate == string.Empty ? "0" : rate));
                                    cmd1.Parameters.AddWithValue("@Total", decimal.Parse(total == string.Empty ? "0" : total));
                                    cmd1.ExecuteNonQuery();
                                    decimal updateQuantity = 0;
                                    decimal recentstockValue = GetProductStockValue(decimal.Parse(productId));
                                    if (MainForm.transactionType == "Purchase")
                                    {
                                        updateQuantity = recentstockValue + decimal.Parse(quantity);
                                    }
                                    else
                                    {
                                        updateQuantity = recentstockValue - decimal.Parse(quantity);
                                    }
                                    UpdateProduct(int.Parse(productId), updateQuantity);
                                    
                                }
                                scope.Complete();
                                ClearFrom(); 
                                MessageBox.Show("Transaction was done sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.ToString().Contains("UK_ProductName"))
                {
                    MessageBox.Show("Product Name should be unique...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
