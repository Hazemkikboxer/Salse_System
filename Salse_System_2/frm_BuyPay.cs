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
    public partial class frm_BuyPay : DevExpress.XtraEditors.XtraForm
    {
        public frm_BuyPay()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {

        }

        private void F2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {

        }

        private void frm_BuyPay_Load(object sender, EventArgs e)
        {
            txt_Required.Text = (Properties.Settings.Default.Item_Required).ToString();
            txt_Payed.Focus();
            txt_Payed.Text = "0.0";
            txt_Baky.Text = "0.0";
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Payed_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                decimal Bakey = Convert.ToDecimal(txt_Required.Text) - Convert.ToDecimal(txt_Payed.Text);
                txt_Baky.Text = Bakey.ToString();
            }
            catch(Exception) { }
          
        }
    }
}