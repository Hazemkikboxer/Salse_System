using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salse_System_2
{
    public partial class frm_Buy : DevExpress.XtraEditors.XtraForm
    {

        private static frm_Buy frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static frm_Buy GetForm
        {
            get
            {
                if(frm == null)
                {
                    frm= new frm_Buy();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
             }
        }
      
        public frm_Buy()
        {
            InitializeComponent();
            if(frm == null)
            {
                frm = this;
            }
                          
        }
        Data_Base_Class db = new Data_Base_Class();
        DataTable tbl = new DataTable();
        private void AutoNumper()
        {
            tbl.Clear();
            tbl = db.ReedData("select max (Order_ID) from Buys_Table","");

            if (string.IsNullOrEmpty(tbl.Rows[0][0].ToString()))
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = ((int)tbl.Rows[0][0] + 1).ToString();
            }
            dtpDate.Text = DateTime.Now.ToShortDateString();
            dtpAagel.Text = DateTime.Now.ToShortDateString();
            cbxProduct.SelectedIndex = -0;
            cbxSuppliers.SelectedIndex = 0;
            cbxProduct.Text = "اختر منتج";
            rbtnCash.Checked = true;
            txtTotal.Clear();
            txtParCode.Clear();
            txtParCode.Focus();

        }

        private void FillProducts()
        {
            cbxProduct.DataSource = db.ReedData("select * from Products_Table","");
            cbxProduct.DisplayMember = "Pro_Name";
            cbxProduct.ValueMember = "Pro_ID";

        }

        public void FillSuppliers() 
        {
            cbxSuppliers.DataSource = db.ReedData("select * from Suppliers_Table","");
            cbxSuppliers.DisplayMember = "Sup_Name";
            cbxSuppliers.ValueMember = "Sup_ID";
        }

        private void frm_Buy_Load(object sender, EventArgs e)
        {
           FillProducts();
           FillSuppliers();
         try
         {
         AutoNumper();
         }
         catch(Exception ex)
         {
           MessageBox.Show(ex.ToString());
         }
           
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            frm_Suppliers frm = new frm_Suppliers();
            frm.ShowDialog();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnItemDown_Click(object sender, EventArgs e)
        {
            if (cbxProduct.Text == "اختر منتج")
            {
                MessageBox.Show("يجب اختيار منتج","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (cbxProduct.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك قم بأدخال المنتجات في جدول المنتجات","انتبه",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }

            DataTable TBL_Product = new DataTable();
            TBL_Product = db.ReedData($"SELECT * FROM Products_Table WHERE Pro_ID = {cbxProduct.SelectedValue} ", "");

            if (TBL_Product.Rows.Count >= 1)
            {

                try
                {
                    string  Product_ID = TBL_Product.Rows[0][0].ToString();
                    string  Product_Name = TBL_Product.Rows[0][1].ToString();
                    string  Product_Qty = TBL_Product.Rows[0][2].ToString();
                    string  Product_Buy_Price = TBL_Product.Rows[0][3].ToString();
                    decimal Discount = 0;
                    decimal Total = 1 * Convert.ToDecimal(TBL_Product.Rows[0][3]);

                    dgvBuy.Rows.Add(1);
                    int RowIndex = dgvBuy.Rows.Count - 1;
                    dgvBuy.Rows[RowIndex].Cells[0].Value = Product_ID;
                    dgvBuy.Rows[RowIndex].Cells[1].Value = Product_Name;
                    dgvBuy.Rows[RowIndex].Cells[2].Value = Product_Qty;
                    dgvBuy.Rows[RowIndex].Cells[3].Value = Product_Buy_Price;
                    dgvBuy.Rows[RowIndex].Cells[4].Value = Discount;
                    dgvBuy.Rows[RowIndex].Cells[5].Value = Total;

                }
                catch (Exception ex)
                {

                }
                try
                {
                    decimal TotalOrder = 0;
                    for (int i = 0;i <= dgvBuy.Rows.Count -1; i++)
                    {
                        TotalOrder +=Convert.ToDecimal(dgvBuy.Rows[i].Cells[5].Value);
                    }
                    txtTotal.Text =Math.Round( TotalOrder ).ToString();
                }
                catch(Exception ex)
                {

                }
                
            }


        }

        private void cbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}