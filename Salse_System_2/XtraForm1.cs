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
    public partial class Frm_Customers : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Customers()
        {
            InitializeComponent();
        }
        Data_Base_Class db = new Data_Base_Class();
        DataTable tbl = new DataTable();
        
        private void AutoNumper()
        {
          tbl =  db.ReedData("select max (Cust_ID)from Customers_Table", ""); 
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtID.Text = "1";

            }
            else
            {

                txtID.Text = ((int)tbl.Rows[0][0]+ 1).ToString();
            }
            txtName.Clear();
            txtPhone.Clear();
            txtAdress.Clear();
            txtNotes.Clear();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnSave.Enabled = false;
        }

        int row;
        private void Show ()
        {
            tbl.Clear();
            tbl = db.ReedData("SELECT * FROM Customers_Table ","");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد اي بيانات في هذه الشاشه");
            }
            else
            {
                txtID.Text = tbl.Rows[row][0].ToString();
                txtName.Text = tbl.Rows[row][1].ToString();
                txtAdress.Text = tbl.Rows[row][2].ToString();
                txtPhone.Text = tbl.Rows[row][3].ToString();
                txtNotes.Text = tbl.Rows[row][4].ToString();
            }
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           // DataTable tblSearch = new DataTable ();
            tbl.Clear();
            tbl = db.ReedData($"SELECT * FROM Customers_Table where Cust_Name LIKE N'%{txtSearch.Text}%'", "");
            if (txtSearch.Text == "")
            {
                MessageBox.Show("قم بأدخال الاسم للبحث عنه", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                txtID.Text = tbl.Rows[0][0].ToString();
                txtName.Text = tbl.Rows[0][1].ToString();
                txtAdress.Text = tbl.Rows[0][2].ToString();
                txtPhone.Text = tbl.Rows[0][3].ToString();
                txtNotes.Text = tbl.Rows[0][4].ToString();

            }
            btnAdd.Enabled = false;
            btnNew.Enabled = true; 
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Customers_Load(object sender, EventArgs e)
        {
            AutoNumper();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("يجب ادخال اسم العميل","تحذير", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                db.ExecuteData($"insert into Customers_Table Values ('{txtID.Text}',N'{txtName.Text}',N'{txtAdress.Text}',N'{txtPhone.Text}',N'{txtNotes.Text}')", "تم ادخال البيانات بنجاح");
                AutoNumper();
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumper();
        }

        private void btnFrist_Click(object sender, EventArgs e)
        {
            row = 0;
            Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.ReedData($"UPDATE Customers_Table SET Cust_Name = '{txtName.Text}' , Cust_Adress = '{txtAdress.Text}' , Cust_Phone = '{txtPhone.Text}' , Notes = '{txtNotes.Text}' where Cust_ID = {txtID.Text}","تم التعديل بنجاح");
            AutoNumper();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد مسح هذا العميل", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData($"DELETE  FROM Customers_Table where Cust_ID= {txtID.Text} ", "تم مسح العميل بنجاح ");
            }
            AutoNumper();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد مسح كل العملاء بالفعل", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData($"DELETE  FROM Customers_Table ", "تم مسح كل العملاء بنجاح ");
            }
            AutoNumper();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReedData(" SELECT COUNT (Cust_ID) FROM Customers_Table ", "");
            row = (int)tbl.Rows[0][0] - 1;
            Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                MessageBox.Show("هذا هو اول صف في هذا الجدول", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (row > 0) 
            {
                row -= 1;
                Show();
            }
         
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReedData(" SELECT COUNT (Cust_ID) FROM Customers_Table ", "");
            if ((int)tbl.Rows[0][0] - 1 == row)
            {
                MessageBox.Show("هذا هو اخر صف في هذا الجدول","تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                row += 1;
                Show();
            }
            

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}