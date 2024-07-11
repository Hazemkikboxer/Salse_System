namespace Salse_System_2
{
    partial class frm_Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Buy));
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSuppliers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.btnItemDown = new DevExpress.XtraEditors.SimpleButton();
            this.F2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSupplerProwser = new DevExpress.XtraEditors.LabelControl();
            this.dtpDate = new DevExpress.XtraEditors.DateEdit();
            this.btnItemDelete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dgvBuy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.lblProductCount = new DevExpress.XtraEditors.LabelControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.rbtnAagel = new System.Windows.Forms.RadioButton();
            this.dtpAagel = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAagel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAagel.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(569, 67);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(191, 21);
            this.txtBarCode.TabIndex = 8;
            this.txtBarCode.TextChanged += new System.EventHandler(this.txtParCode_TextChanged);
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(766, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = " رقم الباركود :";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.Crimson;
            this.lable1.Location = new System.Drawing.Point(766, 7);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(102, 18);
            this.lable1.TabIndex = 5;
            this.lable1.Text = " رقم الفاتوره :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(433, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = " المورد :";
            // 
            // cbxSuppliers
            // 
            this.cbxSuppliers.FormattingEnabled = true;
            this.cbxSuppliers.Location = new System.Drawing.Point(295, 5);
            this.cbxSuppliers.Name = "cbxSuppliers";
            this.cbxSuppliers.Size = new System.Drawing.Size(132, 21);
            this.cbxSuppliers.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(433, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = " اختر المنتج :";
            // 
            // cbxProduct
            // 
            this.cbxProduct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(295, 70);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(132, 21);
            this.cbxProduct.TabIndex = 12;
            this.cbxProduct.SelectedIndexChanged += new System.EventHandler(this.cbxProduct_SelectedIndexChanged);
            // 
            // btnItemDown
            // 
            this.btnItemDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemDown.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnItemDown.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnItemDown.ImageOptions.SvgImage")));
            this.btnItemDown.Location = new System.Drawing.Point(261, 61);
            this.btnItemDown.Name = "btnItemDown";
            this.btnItemDown.Size = new System.Drawing.Size(30, 27);
            this.btnItemDown.TabIndex = 13;
            this.btnItemDown.Click += new System.EventHandler(this.btnItemDown_Click);
            // 
            // F2
            // 
            this.F2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.F2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F2.Appearance.Options.UseFont = true;
            this.F2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.F2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.F2.Location = new System.Drawing.Point(235, 67);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(24, 22);
            this.F2.TabIndex = 14;
            this.F2.Text = "F2";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(148, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 21);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Delete";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // btnSupplerProwser
            // 
            this.btnSupplerProwser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSupplerProwser.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplerProwser.Appearance.Options.UseFont = true;
            this.btnSupplerProwser.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.btnSupplerProwser.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSupplerProwser.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSupplerProwser.Location = new System.Drawing.Point(262, 5);
            this.btnSupplerProwser.Name = "btnSupplerProwser";
            this.btnSupplerProwser.Size = new System.Drawing.Size(28, 13);
            this.btnSupplerProwser.TabIndex = 19;
            this.btnSupplerProwser.Text = "...";
            this.btnSupplerProwser.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.EditValue = null;
            this.dtpDate.Location = new System.Drawing.Point(26, 69);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.MaxValue = new System.DateTime(2024, 9, 6, 0, 0, 0, 0);
            this.dtpDate.Properties.MinValue = new System.DateTime(2024, 9, 6, 0, 0, 0, 0);
            this.dtpDate.Properties.NullDateCalendarValue = new System.DateTime(2024, 7, 24, 0, 0, 0, 0);
            this.dtpDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDate.TabIndex = 22;
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnItemDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnItemDelete.ImageOptions.SvgImage")));
            this.btnItemDelete.Location = new System.Drawing.Point(194, 61);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(35, 28);
            this.btnItemDelete.TabIndex = 17;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(546, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(21, 20);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "F3";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(243, 20);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "لدفع و حفظ و طباعة الفاتوره اضغط F12";
            this.labelControl4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.labelControl4_KeyDown);
            // 
            // dgvBuy
            // 
            this.dgvBuy.AllowUserToAddRows = false;
            this.dgvBuy.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvBuy.Location = new System.Drawing.Point(3, 108);
            this.dgvBuy.Name = "dgvBuy";
            this.dgvBuy.Size = new System.Drawing.Size(851, 305);
            this.dgvBuy.TabIndex = 27;
            this.dgvBuy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم المنتج";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الكميه";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "السعر";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "الخصم";
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "الاجمالي";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(3, 30);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(244, 20);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = " لتعديل الكميه او الخصم اضغط F11     ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(569, 8);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(191, 21);
            this.txtID.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(760, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(94, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "اسم المستخدم";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblUserName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.lblUserName.Location = new System.Drawing.Point(736, 433);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(28, 21);
            this.lblUserName.TabIndex = 31;
            this.lblUserName.Text = "...";
            // 
            // lblProductCount
            // 
            this.lblProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblProductCount.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCount.Appearance.Options.UseFont = true;
            this.lblProductCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblProductCount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblProductCount.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.lblProductCount.Location = new System.Drawing.Point(736, 469);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(28, 22);
            this.lblProductCount.TabIndex = 33;
            this.lblProductCount.Text = "...";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(760, 469);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(94, 22);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "عدد الاصناف";
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCash.Location = new System.Drawing.Point(549, 434);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(121, 20);
            this.rbtnCash.TabIndex = 34;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "دفع الفاتوره كاش ";
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // rbtnAagel
            // 
            this.rbtnAagel.AutoSize = true;
            this.rbtnAagel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAagel.Location = new System.Drawing.Point(597, 469);
            this.rbtnAagel.Name = "rbtnAagel";
            this.rbtnAagel.Size = new System.Drawing.Size(73, 20);
            this.rbtnAagel.TabIndex = 35;
            this.rbtnAagel.TabStop = true;
            this.rbtnAagel.Text = "دفع اجل ";
            this.rbtnAagel.UseVisualStyleBackColor = true;
            // 
            // dtpAagel
            // 
            this.dtpAagel.EditValue = null;
            this.dtpAagel.Location = new System.Drawing.Point(367, 473);
            this.dtpAagel.Name = "dtpAagel";
            this.dtpAagel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpAagel.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpAagel.Properties.MaxValue = new System.DateTime(2024, 9, 6, 0, 0, 0, 0);
            this.dtpAagel.Properties.MinValue = new System.DateTime(2024, 9, 6, 0, 0, 0, 0);
            this.dtpAagel.Properties.NullDateCalendarValue = new System.DateTime(2024, 7, 24, 0, 0, 0, 0);
            this.dtpAagel.Size = new System.Drawing.Size(100, 20);
            this.dtpAagel.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(473, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = " تاريخ الاستحقاق :";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(3, 419);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(191, 86);
            this.txtTotal.TabIndex = 38;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(200, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = " اجمالي المطلوب:";
            // 
            // frm_Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 527);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpAagel);
            this.Controls.Add(this.rbtnAagel);
            this.Controls.Add(this.rbtnCash);
            this.Controls.Add(this.lblProductCount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.dgvBuy);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSupplerProwser);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnItemDelete);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.btnItemDown);
            this.Controls.Add(this.cbxProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSuppliers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frm_Buy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_Buy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.labelControl4_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAagel.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAagel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxProduct;
        private DevExpress.XtraEditors.SimpleButton btnItemDown;
        private DevExpress.XtraEditors.LabelControl F2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl btnSupplerProwser;
        private DevExpress.XtraEditors.DateEdit dtpDate;
        private DevExpress.XtraEditors.SimpleButton btnItemDelete;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DataGridView dgvBuy;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.LabelControl lblProductCount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.RadioButton rbtnAagel;
        private DevExpress.XtraEditors.DateEdit dtpAagel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbxSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}