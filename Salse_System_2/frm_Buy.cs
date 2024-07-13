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
            tbl = db.ReedData("select Max (Order_ID) from Buy_Table ","");

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
            cbxProduct.SelectedIndex = 0;
            cbxSuppliers.SelectedIndex = 0;
            cbxProduct.Text = "اختر منتج";
            rbtnCash.Checked = true;
            dgvBuy.Rows.Clear();
            lblProductCount.Text = "0";
            txtTotal.Clear();
            txtBarCode.Clear();
            txtBarCode.Focus();

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
        private void TotalCounter()
        {
            try
            {
                decimal TotalOrder = 0;
                for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                {
                    TotalOrder += Convert.ToDecimal(dgvBuy.Rows[i].Cells[5].Value);
                }
                txtTotal.Text = Math.Round(TotalOrder).ToString();
                lblProductCount.Text = dgvBuy.Rows.Count.ToString();
            }
            catch (Exception ex)
            {

            }
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
                    string  Product_Qty = "1";
                    string  Product_Buy_Price = TBL_Product.Rows[0][3].ToString();
                    decimal Discount = 0;
                    decimal Total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(TBL_Product.Rows[0][3]);

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

                TotalCounter();              
            }


        }

        private void cbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            if (dgvBuy.Rows.Count >= 1)
            {           
                if (MessageBox.Show(" هل بالفعل تريد مسح البيانات المحدده", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int index = dgvBuy.SelectedRows[0].Index;
                    dgvBuy.Rows.RemoveAt(index);
                    TotalCounter();

                    if (dgvBuy.Rows.Count <= 0)
                    {
                        txtTotal.Text = "0";
                    }

                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("قم بأضافة منتجات اولا ","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
        }

        private void txtParCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               
                DataTable TBL_Product = new DataTable();
                TBL_Product = db.ReedData($"SELECT * FROM Products_Table WHERE Barcode = N'{txtBarCode.Text}' ", "");

                if (TBL_Product.Rows.Count >= 1)
                {

                    try
                    {
                        string Product_ID = TBL_Product.Rows[0][0].ToString();
                        string Product_Name = TBL_Product.Rows[0][1].ToString();
                        string Product_Qty = TBL_Product.Rows[0][2].ToString();
                        string Product_Buy_Price = TBL_Product.Rows[0][3].ToString();
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

                    TotalCounter();
                }

            }
        }
        private void Pay_Order()
        {
            if (dgvBuy.Rows.Count >= 1)
            {
                if (cbxSuppliers.Items.Count <= 0)
                {
                    MessageBox.Show("يجب ادخال اسم المورد اولا ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    string Date = dtpDate.EditValue.ToString();
                    db.ExecuteData($"insert into Buy_Table values({txtID.Text} ,{cbxSuppliers.SelectedValue} , N'{Date}' )", "");
                    for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                    {
                        db.ExecuteData($"INSERT INTO Buy_Detalis_Table VALUES ({txtID.Text},{dgvBuy.Rows[i].Cells[0].Value},{cbxSuppliers.SelectedValue},{dgvBuy.Rows[i].Cells[2].Value},{dgvBuy.Rows[i].Cells[3].Value},{dgvBuy.Rows[i].Cells[4].Value},{dgvBuy.Rows[i].Cells[5].Value},'{Date}','123','')", "");

                    }
                    AutoNumper();
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void Update_Qty()
        {
            if (dgvBuy.Rows.Count >= 1)
            {
                Properties.Settings.Default.Item_Qty = Convert.ToDecimal(dgvBuy.CurrentRow.Cells[2].Value);
                Properties.Settings.Default.Item_BuyPrice = Convert.ToDecimal(dgvBuy.CurrentRow.Cells[3].Value);
                Properties.Settings.Default.Discount = Convert.ToDecimal(dgvBuy.CurrentRow.Cells[4].Value);
                Properties.Settings.Default.Save();
                  
                 frm_Update_Qty frm = new frm_Update_Qty(this);
                 frm.ShowDialog();

            }
        }
        private void labelControl4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                Pay_Order();
            }else if (e.KeyCode == Keys.F11)
            {
                Update_Qty();
            } 
        }

        private void dgvBuy_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal Item_Qty; decimal Item_BuyPrice; decimal Item_Discount;
            try
            {
                //int index = dgvBuy.CurrentRow.Cells[0].Index;
                if (dgvBuy.CurrentRow != null)
                {

                 Item_Qty = Convert.ToDecimal(dgvBuy.CurrentRow.Cells[2].Value);
                 Item_BuyPrice = Convert.ToDecimal(dgvBuy.CurrentRow.Cells[3].Value);
                 Item_Discount = Convert.ToDecimal(dgvBuy.CurrentRow.Cells[4].Value);
                 decimal Total = 0;
                 Total = (Item_Qty * Item_BuyPrice) - Item_Discount;
                
                 dgvBuy.CurrentRow.Cells[5].Value = Total;
                
                 decimal TotalOrder = 0;
                 for (int i = 0; i < dgvBuy.Rows.Count; i++)
                 {
                     TotalOrder += Convert.ToDecimal(dgvBuy.Rows[i].Cells[5].Value);
                 }
                 txtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                }  

            }
            catch (Exception ex) { 
            }
             
            
            
        }
    }
}