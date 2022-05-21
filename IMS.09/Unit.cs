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
    public partial class Unit : Form
    {

        private const string V = "INSERT INTO Unit ( UnitName , Alias , Remarks) VALUES (@unitName , @alias , @remarks)";

        public Unit()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            txtUnitId.Visible = false;

            string connectionstring = "Data Source=DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated Security = true;";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT *FROM Unit";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvUnit.DataSource = dt;
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
                        string strUnitName = txtUnitName.Text;

                        if (strUnitName == string.Empty)
                        {
                            MessageBox.Show("Unit Name is required", "Warning--!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        string StrAlias = txtAlias.Text;

                        if (StrAlias == string.Empty)
                        {
                            MessageBox.Show("Alias is required", "Warning--!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string connection = "Data source = DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated security = true;";
                        SqlConnection con = new SqlConnection(connection);
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = "INSERT INTO Unit(UnitName,Alias,Remarks) values (@unitName,@alias,@remarks)";
                        cmd.Parameters.AddWithValue("@unitName", txtUnitName.Text);
                        cmd.Parameters.AddWithValue("@alias", txtAlias.Text);
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Unit saved succesfully", "Success-!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUnitName.Text = string.Empty;
                        txtAlias.Text = string.Empty;
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
                    if (ex.Message.Contains("UK_Unit"))
                    {
                        MessageBox.Show("Unit Name is already exists", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            {
                string connectionstring = "Data Source=DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated Security = true;";
                SqlConnection con = new SqlConnection(connectionstring);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT UnitName, Alias, Remarks FROM Unit where UnitName Like @Search OR Alias Like @Search OR Remarks Like @Search";
                cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvUnit.DataSource = dt;
            }
        }

        private void gvUnit_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                txtUnitName.Text = (gvUnit.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtAlias.Text = (gvUnit.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtRemarks.Text = (gvUnit.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtUnitId.Text = (gvUnit.Rows[e.RowIndex].Cells[3].Value.ToString());
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
                        string strUnitName = txtUnitName.Text;

                        if (strUnitName == string.Empty)
                        {
                            MessageBox.Show("Unit Name is required", "Warning--!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        string StrAlias = txtAlias.Text;

                        if (StrAlias == string.Empty)
                        {
                            MessageBox.Show("Alias is required", "Warning--!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string connection = "Data source = DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated security = true;";
                        SqlConnection con = new SqlConnection(connection);
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        cmd.CommandText = "Update Unit set UnitName=@unitName,Alias=@alias,Remarks=@remarks where UnitId = @unitId";
                        cmd.Parameters.AddWithValue("@unitName", txtUnitName.Text);
                        cmd.Parameters.AddWithValue("@alias", txtAlias.Text);
                        cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);
                        cmd.Parameters.AddWithValue("@unitId", txtUnitId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Unit updated succesfully", "Success-!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUnitName.Text = string.Empty;
                        txtAlias.Text = string.Empty;
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
                    if (ex.Message.Contains("UK_Unit"))
                    {
                        MessageBox.Show("Unit Name is already exists", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }


        }

        private void BTNDelete_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "DELETE from UNIT where UnitId = @unitId";
                        cmd.Parameters.AddWithValue("@unitId", txtUnitId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Unit deleted succesfully", "Success-!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUnitName.Text = string.Empty;
                        txtAlias.Text = string.Empty;
                        txtRemarks.Text = string.Empty;
                        txtUnitId.Text = string.Empty;
                        LoadGrid();
                    }
                    else
                    {
                        MessageBox.Show("You dont have permission to delete");
                    }


                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("UK_Unit"))
                    {
                        MessageBox.Show("Unit Name is already exists", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }


        }

        private void gvUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadGrid();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUnitName.Text = string.Empty;
            txtAlias.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtUnitId.Text = string.Empty;

        }
    }
}
