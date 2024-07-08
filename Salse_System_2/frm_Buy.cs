using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraEditors;
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

        }
    }
}