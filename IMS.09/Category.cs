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
    public partial class Category : Form
    {
        private const string V = "INSERT INTO Category ( CategoryName  , Remarks) VALUES (@categoryName  , @remarks)";

        public Category()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            txtCategoryId.Visible = false;

            string connectionstring = "Data Source=DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated Security = true;";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT *FROM Category";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCategory.DataSource = dt;
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            {
                LoadGrid();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    var confrimation = MessageBox.Show("Do you want to save?", "confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confrimation == DialogResult.Yes)
                    {
                        string strCategoryName = txtCategoryName.Text;

                        if (strCategoryName == string.Empty)
                        {
                            MessageBox.Show("Category Name is required", "Warning--!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                       

                        string connection = "Data source = DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated security = true;";
                        SqlConnection con = new SqlConnection(connection);
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = "INSERT INTO Category(CategoryName,Remarks) values (@categoryName,@remarks)";
                        cmd.Parameters.AddWithValue("@categoryName", txtCategoryName.Text);
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data saved succesfully", "Success-!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCategoryName.Text = string.Empty;
                        txtRemarks.Text = string.Empty;
                        LoadGrid();
                    }
                    else
                    {
                        MessageBox.Show("You dont have permission to save");
                    }


                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("UK_Category"))
                    {
                        MessageBox.Show("Category Name is already exists", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    var confrimation = MessageBox.Show("Do you want to Update?", "confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confrimation == DialogResult.Yes)
                    {
                        string strCategoryName = txtCategoryName.Text;

                        if (strCategoryName == string.Empty)
                        {
                            MessageBox.Show("Category Name is required", "Warning--!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                       

                        string connection = "Data source = DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated security = true;";
                        SqlConnection con = new SqlConnection(connection);
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = "Update Category set CategoryName=@categoryName,Remarks=@remarks where CategoryId = @categoryId";
                        cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);
                        cmd.Parameters.AddWithValue("@categoryId", txtCategoryId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data updated succesfully", "Success-!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCategoryName.Text = string.Empty;
                        txtRemarks.Text = string.Empty;
                        LoadGrid();
                    }
                    else
                    {
                        MessageBox.Show("You dont have permission to update");
                    }


                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("UK_Category"))
                    {
                        MessageBox.Show("Category Name is already exists", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    var confrimation = MessageBox.Show("Do you want to Delete?", "confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confrimation == DialogResult.Yes)
                    {


                        string connection = "Data source = DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated security = true;";
                        SqlConnection con = new SqlConnection(connection);
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = "DELETE from Category where CategoryId = @categoryId";
                        cmd.Parameters.AddWithValue("@categoryId", txtCategoryId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data deleted succesfully", "Success-!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCategoryName.Text = string.Empty;
                        txtRemarks.Text = string.Empty;
                        txtCategoryId.Text = string.Empty;
                        LoadGrid();
                    }
                    else
                    {
                        MessageBox.Show("You dont have permission to delete");
                    }


                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("UK_Category"))
                    {
                        MessageBox.Show("Category Name is already exists", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void gvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadGrid();

        }

        private void gvCategory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                txtCategoryId.Text = (gvCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCategoryName.Text = (gvCategory.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtRemarks.Text = (gvCategory.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
