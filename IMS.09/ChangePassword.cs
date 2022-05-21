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
    public partial class ChangePassword : Form
    {
        EDCode ed = new EDCode();
        string connectionstring = "Data Source=DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated Security = true;";

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnConformPassword_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                SqlDataAdapter da = new SqlDataAdapter("Select count(*) from Register where UserName ='" + txtUserName.Text + "' and Password='" +ed.PassED(txtOldPassword.Text) + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    if (txtNewPassword.Text == txtConformPassword.Text)
                    {
                        SqlDataAdapter dc = new SqlDataAdapter("Update Register set Password='" + txtNewPassword.Text + "' Where UserName ='" + txtUserName.Text + "' and Password='" +ed.PassED(txtOldPassword.Text) + "' ", con);
                        DataTable df = new DataTable();
                        dc.Fill(df);
                        MessageBox.Show("Password Changed...!!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unmatch Password...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please check your Username and Password...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtUserName.Text = string.Empty;
                txtOldPassword.Text = string.Empty;
                txtNewPassword.Text = string.Empty;
                txtConformPassword.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wents wrong...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
