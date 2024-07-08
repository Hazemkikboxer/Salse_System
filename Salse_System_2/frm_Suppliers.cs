﻿using DevExpress.XtraEditors;
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
            if (TBL.Rows.Count <= 0)
            {
                MessageBox.Show(" لا يوجد بيانات في هذه الشاشه ","أنتبه",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                txtID.Text = TBL.Rows[row][0].ToString();
                txtName.Text = TBL.Rows[row][1].ToString();
                txtAdress.Text = TBL.Rows[row][2].ToString();
                txtPhone.Text = TBL.Rows[row][3].ToString();
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
                DB.ExecuteData($"INSERT INTO Suppliers_Table values ( {txtID.Text},N'{txtName.Text}' , N'{txtAdress.Text}' ,N'{txtPhone.Text}' , N'{txtNotes.Text}' )", "تم اضافة البيانات بنجاح ");
                AutoNumper();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumper();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TBL.Clear();
            TBL = DB.ReedData($"SELECT * FROM Suppliers_Table where Sup_Name like N'%{txtSearch.Text}%'", "");
            try
            {
                txtID.Text = TBL.Rows[0][0].ToString();
                txtName.Text = TBL.Rows[0][1].ToString();
                txtAdress.Text = TBL.Rows[0][2].ToString();
                txtPhone.Text = TBL.Rows[0][3].ToString();
                txtNotes.Text = TBL.Rows[0][4].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
             
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSearch.Enabled = true;


        }

        private void btnFrist_Click(object sender, EventArgs e)
        {
            row = 0; 
            show();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            TBL.Clear();
            TBL = DB.ReedData("SELECT COUNT (Sup_ID) FROM Suppliers_Table ", "");
            row = (int)(TBL.Rows[0][0]) - 1;
            show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            row -=1;
            if (row < 0)
            {
                MessageBox.Show("this is the frist supplier in suppliers table ","انتبه",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TBL.Clear();
            TBL = DB.ReedData("SELECT COUNT (Sup_ID) FROM Suppliers_Table ", "");
            row += 1;
            if (row == (int)TBL.Rows[0][0])
            {
                MessageBox.Show("this is the last supplier in the suppliers table","watch out",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            else
            {
                show();
            }
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBL.Clear();
            TBL = DB.ReedData ($"update Suppliers_Table set Sup_Name = '{txtName.Text}' ,Sup_Adress = '{txtAdress.Text}', Sup_Phone = '{txtPhone.Text}',Notes = '{txtNotes.Text}' where Sup_ID ={txtID.Text}", "تم التعديل بنجاح ");
            AutoNumper();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("هل تريد بتأكيد مسح بيانات هذا المورد","انتبه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning).ToString())=="Yes")
            {
                DB.ExecuteData($"DELETE FROM Suppliers_Table where Sup_ID ={txtID.Text} ", "تم مسح البيانات بنجاح ");
            }
            else
            {
                AutoNumper();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بتأكيد مسح بيانات جميع الموردين بالفعل", "انتبه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning).ToString()=="Yes" )
            {
                DB.ExecuteData("DELETE FROM Suppliers_Table", "تم مسح جميع البيانات بنجاح");
            }
            else
            {
                AutoNumper();
            }

        }

        private void frm_Suppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Buy.GetForm.FillSuppliers();
        }
    }
}