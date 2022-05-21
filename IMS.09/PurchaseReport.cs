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
    public partial class Purchase_Report : Form
    {
        public Purchase_Report()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source=DESKTOP-VE3HJV5\\ATISH;Initial Catalog = IMS_09;Integrated Security = true;";
        



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {

                    string fromDate = txtFromDate.Text;
                    string toDate = txtToDate.Text;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"Select m.TransactionDate, cs.Name, p.ProductName , c.CategoryName,u.UnitName,m.GrandTotal,m.Vat,m.Discount,d.Quantity,d.Rate as [Purchase Rate], d.Total from TransactionDetail d inner join tblTransactionMaster m on m.TransactionMasterId=d.TransactionMasterId 
                                       INNER JOIN Product p on p.ProductId = d.ProductId
                                        inner join Category c on  c.CategoryId = p.CategoryId
                                        INNER JOIN Unit u on u.UnitId = p.UnitId 
                                        INNER JOIN CustomerSupplier cs ON CS.CustomerSupplierId = m.CustomerSupplierId
                                       WHERE m.TransactionDate BETWEEN '"+fromDate+"' and  '"+toDate+"'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvPurchaseRepord.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something wents wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
