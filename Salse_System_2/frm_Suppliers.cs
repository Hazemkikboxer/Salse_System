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
                MessageBox.Show(" لا يوجد بيانات في هذه الشاشه ","أنتبه",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                txtID.Text = TBL.Rows[row][0].ToString();
                txtName.Text = TBL.Rows[row][1].ToString();
                txtAdress.Text = TBL.Rows[row][2].ToString();
                txtName.Text = TBL.Rows[row][3].ToString();
                txtNotes.Text = TBL.Rows[row][4].ToString();
            }
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSearch.Enabled = true;

        }

        private void frm_Suppliers_Load(object sender, EventArgs e)
        {
            AutoNumper();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("يجب عليك ادخال اسم المورد ","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DB.ExecuteData($"INSERT INTO Suppliers_Table values ( {txtID.Text},N'{txtName.Text}' , N'{txtAdress.Text}' ,N'{txtPhone.Text}' , N'{txtNotes.Text}' )", "تم ادخال البيانات بنجاح ");
                AutoNumper();
            }
        }
    }
}