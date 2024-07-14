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
            this.txt_Required = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Payed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Baky = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.F2 = new DevExpress.XtraEditors.LabelControl();
            this.Enter = new DevExpress.XtraEditors.LabelControl();
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
            // 
            // txt_Required
            // 
            this.txt_Required.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Required.Location = new System.Drawing.Point(31, 21);
            this.txt_Required.Multiline = true;
            this.txt_Required.Name = "txt_Required";
            this.txt_Required.ReadOnly = true;
            this.txt_Required.Size = new System.Drawing.Size(258, 50);
            this.txt_Required.TabIndex = 42;
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
            // txt_Payed
            // 
            this.txt_Payed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Payed.Location = new System.Drawing.Point(31, 109);
            this.txt_Payed.Multiline = true;
            this.txt_Payed.Name = "txt_Payed";
            this.txt_Payed.Size = new System.Drawing.Size(258, 50);
            this.txt_Payed.TabIndex = 40;
            this.txt_Payed.TextChanged += new System.EventHandler(this.txt_Payed_TextChanged);
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
            // txt_Baky
            // 
            this.txt_Baky.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Baky.Location = new System.Drawing.Point(31, 191);
            this.txt_Baky.Multiline = true;
            this.txt_Baky.Name = "txt_Baky";
            this.txt_Baky.ReadOnly = true;
            this.txt_Baky.Size = new System.Drawing.Size(258, 50);
            this.txt_Baky.TabIndex = 38;
            this.txt_Baky.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
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
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(206, 307);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(83, 45);
            this.simpleButton1.TabIndex = 44;
            this.simpleButton1.Text = "رجوع";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.F2.Location = new System.Drawing.Point(12, 265);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(43, 32);
            this.F2.TabIndex = 45;
            this.F2.Text = "Enter";
            this.F2.Click += new System.EventHandler(this.F2_Click);
            // 
            // Enter
            // 
            this.Enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Enter.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Appearance.Options.UseFont = true;
            this.Enter.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Enter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Enter.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.Enter.Location = new System.Drawing.Point(161, 318);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(39, 26);
            this.Enter.TabIndex = 46;
            this.Enter.Text = "F12";
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // frm_BuyPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 347);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.txt_Required);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Payed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Baky);
            this.Controls.Add(this.lable1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_BuyPay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BuyPay";
            this.Load += new System.EventHandler(this.frm_BuyPay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Enter;
        private System.Windows.Forms.TextBox txt_Required;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Payed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Baky;
        private System.Windows.Forms.Label lable1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl F2;
        private DevExpress.XtraEditors.LabelControl Enter;
    }
}