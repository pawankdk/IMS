using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS._09
{
    public partial class MainForm : Form
    {
        public static string transactionType;

        public MainForm()
        {
            InitializeComponent();
        }
        internal class DebuggingTest
        {
            internal void Show()
            {

            }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unit uni = new Unit();
            uni.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
        }

        private void categoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
        }

        private void unitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Unit Uni = new Unit();
            Uni.Show();
        }

        private void productToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void customerSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Supplier Custsupp = new Customer_Supplier();
            Custsupp.Show();
        }

        private void purchaesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Purchase";
            PurchaseSale myobj = new PurchaseSale();
            myobj.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Sale";
            PurchaseSale myobj = new PurchaseSale();
            myobj.Show();
        }

      

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePassword chpas = new ChangePassword();
            chpas.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Report PR = new Purchase_Report();
            PR.Show();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReport SR = new SaleReport();
            SR.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReport STR = new StockReport();
            STR.Show();
        }
    }


}
