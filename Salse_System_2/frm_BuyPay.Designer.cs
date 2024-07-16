namespace Salse_System_2
{
    partial class frm_BuyPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BuyPay));
            this.btn_Enter = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Matlob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.btn_Return = new DevExpress.XtraEditors.SimpleButton();
            this.F2 = new DevExpress.XtraEditors.LabelControl();
            this.Enter = new DevExpress.XtraEditors.LabelControl();
            this.txt_Madfo3 = new System.Windows.Forms.TextBox();
            this.txt_Baky = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Enter
            // 
            this.btn_Enter.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Appearance.Options.UseFont = true;
            this.btn_Enter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Enter.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Enter.ImageOptions.SvgImage")));
            this.btn_Enter.Location = new System.Drawing.Point(64, 257);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(225, 45);
            this.btn_Enter.TabIndex = 43;
            this.btn_Enter.Text = "للحفظ و الطباعه اضغط انتر";
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            this.btn_Enter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Enter_KeyDown);
            // 
            // txt_Matlob
            // 
            this.txt_Matlob.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Matlob.Location = new System.Drawing.Point(31, 21);
            this.txt_Matlob.Multiline = true;
            this.txt_Matlob.Name = "txt_Matlob";
            this.txt_Matlob.ReadOnly = true;
            this.txt_Matlob.Size = new System.Drawing.Size(258, 50);
            this.txt_Matlob.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(295, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = " المطلوب :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(295, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = " المدفوع :";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.Crimson;
            this.lable1.Location = new System.Drawing.Point(295, 209);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(66, 18);
            this.lable1.TabIndex = 37;
            this.lable1.Text = " الباقي :";
            // 
            // btn_Return
            // 
            this.btn_Return.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Appearance.Options.UseFont = true;
            this.btn_Return.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Return.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Return.ImageOptions.SvgImage")));
            this.btn_Return.Location = new System.Drawing.Point(206, 307);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(83, 45);
            this.btn_Return.TabIndex = 44;
            this.btn_Return.Text = "رجوع";
            this.btn_Return.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // F2
            // 
            this.F2.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.F2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.F2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F2.Appearance.Options.UseFont = true;
            this.F2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.F2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.F2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.F2.Location = new System.Drawing.Point(15, 266);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(43, 30);
            this.F2.TabIndex = 45;
            this.F2.Text = "Enter";
            this.F2.Click += new System.EventHandler(this.F2_Click);
            // 
            // Enter
            // 
            this.Enter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Enter.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Appearance.Options.UseFont = true;
            this.Enter.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Enter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Enter.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Enter.Location = new System.Drawing.Point(161, 316);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(39, 29);
            this.Enter.TabIndex = 46;
            this.Enter.Text = "F12";
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // txt_Madfo3
            // 
            this.txt_Madfo3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Madfo3.Location = new System.Drawing.Point(31, 108);
            this.txt_Madfo3.Multiline = true;
            this.txt_Madfo3.Name = "txt_Madfo3";
            this.txt_Madfo3.Size = new System.Drawing.Size(258, 50);
            this.txt_Madfo3.TabIndex = 47;
            this.txt_Madfo3.TextChanged += new System.EventHandler(this.txt_Payed_TextChanged_1);
            // 
            // txt_Baky
            // 
            this.txt_Baky.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Baky.Location = new System.Drawing.Point(31, 192);
            this.txt_Baky.Multiline = true;
            this.txt_Baky.Name = "txt_Baky";
            this.txt_Baky.ReadOnly = true;
            this.txt_Baky.Size = new System.Drawing.Size(258, 50);
            this.txt_Baky.TabIndex = 48;
            // 
            // frm_BuyPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 364);
            this.Controls.Add(this.txt_Baky);
            this.Controls.Add(this.txt_Madfo3);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.txt_Matlob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_BuyPay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BuyPay";
            this.Load += new System.EventHandler(this.frm_BuyPay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_BuyPay_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Enter;
        private System.Windows.Forms.TextBox txt_Matlob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private DevExpress.XtraEditors.SimpleButton btn_Return;
        private DevExpress.XtraEditors.LabelControl F2;
        private DevExpress.XtraEditors.LabelControl Enter;
        private System.Windows.Forms.TextBox txt_Madfo3;
        private System.Windows.Forms.TextBox txt_Baky;
    }
}