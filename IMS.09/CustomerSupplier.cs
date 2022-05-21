using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS._09
{
    public partial class Customer_Supplier : Form
    {
        string connectionstring = "Data Source=DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated Security = true;";

        public Customer_Supplier()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            txtCustSuppId.Visible = false;
            {
                using (SqlConnection con = new SqlConnection(connectionstring))

                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.CommandText = "SELECT *FROM CustomerSupplier";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvCustSupp.DataSource = dt;
                }
            }
        }

        private bool FormValidation()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Name is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (cmbType.Text == string.Empty)
            {
                MessageBox.Show("Type is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbType.Focus();
                return false;
            }
            if (txtPhoneNo.Text == string.Empty)
            {
                MessageBox.Show("Phone.no is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNo.Focus();
                return false;
            }
            if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Address is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtCustSuppId.Text = string.Empty;
            txtName.Text = string.Empty;
            cmbType.SelectedIndex = -1;
            txtEmail.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            txtMobileNo.Text = string.Empty;
            txtAddress.Text = string.Empty;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = MessageBox.Show("Do you want to save?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm.ToString().ToUpper() == "OK")
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        bool isValiationSucess = FormValidation();
                        if (isValiationSucess == true)
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            con.Open();
                            cmd.CommandText = @"INSERT INTO CustomerSupplier (Name,Type,Email,PhoneNo,MobileNo,Address) 
                                               VALUES (@name,@type,@email,@PhoneNo,@MobileNo,@address) ";
                            cmd.Parameters.AddWithValue("@customerSupplierId", txtCustSuppId.Text);
                            cmd.Parameters.AddWithValue("@name", txtName.Text);
                            cmd.Parameters.AddWithValue("@type", cmbType.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text);
                            cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
                            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record saved sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            LoadGrid();


                        }

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gvCustSupp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadGrid();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.CommandText = @"SELECT Name,Type,Email,PhoneNo,MobileNo,Address From CustomerSupplier where Name Like @Search OR
                                       Type Like @Search OR Email Like @Search OR PhoneNo Like @Search OR MobileNo Like @Search OR Address Like @Search";
                    cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvCustSupp.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something wents wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvCustSupp_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtCustSuppId.Text = (gvCustSupp.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = (gvCustSupp.Rows[e.RowIndex].Cells[1].Value.ToString());
                cmbType.Text = (gvCustSupp.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtEmail.Text = (gvCustSupp.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtPhoneNo.Text = (gvCustSupp.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtMobileNo.Text = (gvCustSupp.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtAddress.Text = (gvCustSupp.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = MessageBox.Show("Do you want to update?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm.ToString().ToUpper() == "OK")
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        bool isValiationSucess = FormValidation();
                        if (isValiationSucess == true)
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            con.Open();
                            cmd.CommandText = @"Update  CustomerSupplier set Name=@name,Type=@type,Email=@email,PhoneNo=@phoneNo,MobileNo=@mobileNo,Address=@address where CustomerSupplierId=@customerSupplierId";
                            cmd.Parameters.AddWithValue("@customerSupplierId", txtCustSuppId.Text);

                            cmd.Parameters.AddWithValue("@name", txtName.Text);
                            cmd.Parameters.AddWithValue("@type", cmbType.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@phoneNo", txtPhoneNo.Text);
                            cmd.Parameters.AddWithValue("@mobileNo", txtMobileNo.Text);
                            cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Updated sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            LoadGrid();


                        }

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = MessageBox.Show("Do you want to Delete?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm.ToString().ToUpper() == "OK")
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        bool isValiationSucess = FormValidation();
                        if (isValiationSucess == true)
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            con.Open();
                            cmd.CommandText = "DELETE from CustomerSupplier where CustomerSupplierId = @customerSupplierId";
                            cmd.Parameters.AddWithValue("@customerSupplierId", txtCustSuppId.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            LoadGrid();


                        }

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Customer_Supplier_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}

