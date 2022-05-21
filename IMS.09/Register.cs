using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace IMS._09
{
    public partial class Register : Form
    {
        EDCode ed = new EDCode();
        string connectionstring = "Data Source=DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated Security = true;";
      

        public Register()
        {
            InitializeComponent();
        }


        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        { 
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConformPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cmbUserType.SelectedIndex = -1;

        }

        private bool FormValidation()
        {
            
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("User Name is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }
          
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Password  is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text != txtConformPassword.Text)
            {
                MessageBox.Show("Correct Password wents wrong...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConformPassword.Focus();
                return false;
            }

            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Email is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Phone Number is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }
            if (cmbUserType.Text == string.Empty)
            {
                MessageBox.Show("User Type is required...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUserType.Focus();
                return false;
            }

            return true;
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
                            cmd.CommandText = "INSERT INTO Register(UserName,Password,Email,Phone,UserType) values (@UserName,@Password,@Email,@Phone,@UserType)";
                            con.Open();
                            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                            cmd.Parameters.AddWithValue("@Password",ed.PassED(txtPassword.Text));
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                            cmd.Parameters.AddWithValue("@UserType", cmbUserType.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Saved  sucessfully...!!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                         
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

       
    }
}
