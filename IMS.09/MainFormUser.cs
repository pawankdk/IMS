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
    public partial class MainFormUser : Form
    {
        public static string transactionType;

        public MainFormUser()
        {
            InitializeComponent();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
