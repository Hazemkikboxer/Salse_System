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
            if (txt_Madfo3.Text == "")
            {
                MessageBox.Show("يجب ادخال المبلغ المدفوع", "انتبه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Properties.Settings.Default.Item_Madfo3 = Convert.ToDecimal(txt_Madfo3.Text);
            Properties.Settings.Default.Item_Baky = Convert.ToDecimal(txt_Baky.Text);
            Properties.Settings.Default.Is_Eenter = true;
            Properties.Settings.Default.Save();
            Close();
        }

        private void F2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e) // This is the btn_Return Method 
        {
            Properties.Settings.Default.Is_Eenter = false;
            Properties.Settings.Default.Save();
            Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {

        }

        private void frm_BuyPay_Load(object sender, EventArgs e)
        {
            try { txt_Matlob.Text = (Properties.Settings.Default.Item_Matlob).ToString(); }
            catch (Exception ex) { }
           
            txt_Madfo3.Focus();
            txt_Madfo3.Text = "0.0";
            txt_Baky.Text = "0.0";
        }

        private void txt_Payed_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                decimal Bakey = Convert.ToDecimal(txt_Matlob.Text) - Convert.ToDecimal(txt_Madfo3.Text);
                txt_Baky.Text = Bakey.ToString();
            }
            catch (Exception) { }
        }

        private void btn_Enter_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void frm_BuyPay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Madfo3.Text == "")
                {
                    MessageBox.Show("يجب ادخال المبلغ المدفوع", "انتبه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Properties.Settings.Default.Item_Madfo3 = Convert.ToDecimal(txt_Madfo3.Text);
                Properties.Settings.Default.Item_Baky = Convert.ToDecimal(txt_Baky.Text);
                Properties.Settings.Default.Is_Eenter = true;
                Properties.Settings.Default.Save();

                Close();
            }
            if (e.KeyCode == Keys.F12)
            {
                Properties.Settings.Default.Is_Eenter = false;
                Properties.Settings.Default.Save();
                Close();
            }

        }
    }
}