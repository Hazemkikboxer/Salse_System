namespace Salse_System_2
{
    partial class frm_Update_Qty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Update_Qty));
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.txt_Buy_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Enter = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(45, 215);
            this.txt_Qty.Multiline = true;
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(258, 50);
            this.txt_Qty.TabIndex = 31;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.Crimson;
            this.lable1.Location = new System.Drawing.Point(309, 233);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(65, 18);
            this.lable1.TabIndex = 30;
            this.lable1.Text = " الكميه :";
            // 
            // txt_Buy_Price
            // 
            this.txt_Buy_Price.Location = new System.Drawing.Point(45, 133);
            this.txt_Buy_Price.Multiline = true;
            this.txt_Buy_Price.Name = "txt_Buy_Price";
            this.txt_Buy_Price.Size = new System.Drawing.Size(258, 50);
            this.txt_Buy_Price.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(309, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = " سعر الشراء :";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(45, 45);
            this.txt_Discount.Multiline = true;
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(258, 50);
            this.txt_Discount.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(309, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = " الخصم :";
            // 
            // btn_Enter
            // 
            this.btn_Enter.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Appearance.Options.UseFont = true;
            this.btn_Enter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Enter.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Enter.ImageOptions.SvgImage")));
            this.btn_Enter.Location = new System.Drawing.Point(45, 295);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(258, 45);
            this.btn_Enter.TabIndex = 36;
            this.btn_Enter.Text = "حفظ";
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // frm_Update_Qty
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(368, 371);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Buy_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.lable1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_Update_Qty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Update_Qty_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Update_Qty_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txt_Buy_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_Enter;
    }
}