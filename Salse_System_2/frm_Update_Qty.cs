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
    public partial class frm_Update_Qty : DevExpress.XtraEditors.XtraForm
    {
        frm_Buy _frm_Buy=null;
        public frm_Update_Qty(frm_Buy frm_Buy)
        {
            _frm_Buy = frm_Buy;
            InitializeComponent();
        }

        private void frm_Update_Qty_Load(object sender, EventArgs e)
        {
            txt_Qty.Text = Properties.Settings.Default.Item_Qty.ToString();
            txt_Buy_Price.Text = Properties.Settings.Default.Item_BuyPrice.ToString();
            txt_Discount.Text = Properties.Settings.Default.Discount.ToString();
      
            txt_Qty.Focus();
        }

        private void frm_Update_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                var frm = frm_Buy.GetForm;

                if (frm != null)  
                {
                    frm.dgvBuy.CurrentRow.Cells[2].Value = Convert.ToInt32(txt_Qty.Text);
                    frm.dgvBuy.CurrentRow.Cells[3].Value = Convert.ToInt32(txt_Buy_Price.Text);
                    frm.dgvBuy.CurrentRow.Cells[4].Value = Convert.ToInt32(txt_Discount.Text);

                }
                this.Close();
            }

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (txt_Qty.Text == "") { MessageBox.Show("من فضلك ادخل الكميه", "تأكيد"); }
            if (txt_Buy_Price.Text == "") { MessageBox.Show("من فضلك ادخل السعر","تأكيد"); }
            if (txt_Discount.Text == "") { MessageBox.Show("من فضلك ادخل الخصم","تأكيد"); }

            
             var frm = _frm_Buy;

             if (frm != null)
             {
                 frm.dgvBuy.CurrentRow.Cells[2].Value = Convert.ToInt32(txt_Qty.Text);
                 frm.dgvBuy.CurrentRow.Cells[3].Value = Convert.ToInt32(txt_Buy_Price.Text);
                 frm.dgvBuy.CurrentRow.Cells[4].Value = Convert.ToInt32(txt_Discount.Text);
             }
             this.Close();
           
        }
    }
}