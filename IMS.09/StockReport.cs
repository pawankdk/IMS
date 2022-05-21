﻿using System;
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
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        string connectionstring = "Data Source=DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated Security = true;";


        private void StockReport_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = @"SELECT p.ProductName,c.CategoryName,u.UnitName,p.Quantity[Stock] from  Product p   
                                        inner join Category c on  c.CategoryId = p.CategoryId
                                        INNER JOIN Unit u on u.UnitId = p.UnitId 
                                     ";
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStockReport.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    SqlConnection con = new SqlConnection(connectionstring);
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = @"SELECT p.ProductName,c.CategoryName,u.UnitName,p.Quantity[Stock] from  Product p   
                                        inner join Category c on  c.CategoryId = p.CategoryId
                                        INNER JOIN Unit u on u.UnitId = p.UnitId 
                                     where ProductName Like @Search OR CategoryName Like @Search OR UnitName Like @Search OR Quantity Like @Search ";
                    cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvStockReport.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error-!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }
}
