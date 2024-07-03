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
    public partial class frm_Suppliers : DevExpress.XtraEditors.XtraForm
    {
        public frm_Suppliers()
        {
            InitializeComponent();
        }
        Data_Base_Class DB = new Data_Base_Class();
        DataTable TBL = new DataTable ();

        private void AutoNumper()
        {
            TBL = DB.ReedData("SELECT Max (Sup_ID) FROM Suppliers_Table ", "");
            if (TBL.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = ((int)TBL.Rows[0][0] +1).ToString();
            }
            txtName.Clear();
            txtAdress.Clear();
            txtPhone.Clear();
            txtNotes.Clear();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnSave.Enabled = false;
        }
        int row;
        private void show()
        {
            TBL.Clear();
            TBL = DB.ReedData("SELECT * FROM Suppliers_Table","");
            if (TBL.Rows.Count.ToString() == "")
            {
                MessageBox.Show("هذا الجدول لا يوجد به بيانات ","أنتبه",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                txtID.Text = TBL.Rows[row][0].ToString();
                txtName.Text = TBL.Rows[row][1].ToString();
                txtAdress.Text = TBL.Rows[row][2].ToString();
                txtName.Text = TBL.Rows[row][3].ToString();
                txtNotes.Text = TBL.Rows[row][4].ToString();
            }
        }

        private void frm_Suppliers_Load(object sender, EventArgs e)
        {
            AutoNumper();
        }
    }
}