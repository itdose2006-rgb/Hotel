namespace Hotel
{
    partial class Add
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txact = new Guna.UI2.WinForms.Guna2ComboBox();
            this.butdelete = new Guna.UI2.WinForms.Guna2Button();
            this.butupdate = new Guna.UI2.WinForms.Guna2Button();
            this.chekadmin = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txpa2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txph = new Guna.UI2.WinForms.Guna2TextBox();
            this.txus = new Guna.UI2.WinForms.Guna2TextBox();
            this.butadd = new Guna.UI2.WinForms.Guna2Button();
            this.txcom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ch = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txpa = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akhbar MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(166, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "اضافة مستخدم";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BackgroundImage = global::Hotel.Properties.Resources.MacBook_Pro_16____2;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.txact);
            this.guna2GroupBox1.Controls.Add(this.butdelete);
            this.guna2GroupBox1.Controls.Add(this.butupdate);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.chekadmin);
            this.guna2GroupBox1.Controls.Add(this.txid);
            this.guna2GroupBox1.Controls.Add(this.txn);
            this.guna2GroupBox1.Controls.Add(this.txpa2);
            this.guna2GroupBox1.Controls.Add(this.txph);
            this.guna2GroupBox1.Controls.Add(this.txus);
            this.guna2GroupBox1.Controls.Add(this.butadd);
            this.guna2GroupBox1.Controls.Add(this.txcom);
            this.guna2GroupBox1.Controls.Add(this.ch);
            this.guna2GroupBox1.Controls.Add(this.txpa);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(18, 64);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(489, 621);
            this.guna2GroupBox1.TabIndex = 12;
            this.guna2GroupBox1.Text = "تسجيل الدخول";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txact
            // 
            this.txact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txact.BackColor = System.Drawing.Color.Transparent;
            this.txact.BorderColor = System.Drawing.Color.Aquamarine;
            this.txact.BorderRadius = 5;
            this.txact.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txact.FillColor = System.Drawing.Color.Black;
            this.txact.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txact.ForeColor = System.Drawing.Color.White;
            this.txact.ItemHeight = 30;
            this.txact.Items.AddRange(new object[] {
            "مفعل",
            "محضور"});
            this.txact.Location = new System.Drawing.Point(61, 365);
            this.txact.Name = "txact";
            this.txact.Size = new System.Drawing.Size(229, 36);
            this.txact.StartIndex = 0;
            this.txact.TabIndex = 22;
            this.txact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butdelete
            // 
            this.butdelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butdelete.BorderRadius = 8;
            this.butdelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butdelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butdelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butdelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butdelete.FillColor = System.Drawing.Color.Aquamarine;
            this.butdelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butdelete.ForeColor = System.Drawing.Color.Black;
            this.butdelete.Location = new System.Drawing.Point(286, 476);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(156, 44);
            this.butdelete.TabIndex = 21;
            this.butdelete.Text = "حذف";
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butupdate
            // 
            this.butupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butupdate.BorderRadius = 8;
            this.butupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butupdate.FillColor = System.Drawing.Color.Aquamarine;
            this.butupdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butupdate.ForeColor = System.Drawing.Color.Black;
            this.butupdate.Location = new System.Drawing.Point(286, 556);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(156, 44);
            this.butupdate.TabIndex = 20;
            this.butupdate.Text = "تعديل";
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click_1);
            // 
            // chekadmin
            // 
            this.chekadmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chekadmin.AutoSize = true;
            this.chekadmin.CheckedState.BorderColor = System.Drawing.Color.White;
            this.chekadmin.CheckedState.BorderRadius = 0;
            this.chekadmin.CheckedState.BorderThickness = 0;
            this.chekadmin.CheckedState.FillColor = System.Drawing.Color.Aquamarine;
            this.chekadmin.CheckMarkColor = System.Drawing.Color.Aquamarine;
            this.chekadmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chekadmin.ForeColor = System.Drawing.Color.White;
            this.chekadmin.Location = new System.Drawing.Point(-15, 365);
            this.chekadmin.Name = "chekadmin";
            this.chekadmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chekadmin.Size = new System.Drawing.Size(71, 32);
            this.chekadmin.TabIndex = 18;
            this.chekadmin.Text = "مدير";
            this.chekadmin.UncheckedState.BorderColor = System.Drawing.Color.Aquamarine;
            this.chekadmin.UncheckedState.BorderRadius = 0;
            this.chekadmin.UncheckedState.BorderThickness = 0;
            this.chekadmin.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // txid
            // 
            this.txid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txid.BorderColor = System.Drawing.Color.Aquamarine;
            this.txid.BorderRadius = 5;
            this.txid.BorderThickness = 2;
            this.txid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txid.DefaultText = "";
            this.txid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txid.FillColor = System.Drawing.Color.Black;
            this.txid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txid.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txid.ForeColor = System.Drawing.Color.White;
            this.txid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txid.Location = new System.Drawing.Point(-173, 108);
            this.txid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txid.MaxLength = 100;
            this.txid.Name = "txid";
            this.txid.PlaceholderForeColor = System.Drawing.Color.White;
            this.txid.PlaceholderText = "البريد الاكتروني";
            this.txid.SelectedText = "";
            this.txid.Size = new System.Drawing.Size(420, 48);
            this.txid.TabIndex = 17;
            this.txid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txn
            // 
            this.txn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txn.BorderColor = System.Drawing.Color.Aquamarine;
            this.txn.BorderRadius = 5;
            this.txn.BorderThickness = 2;
            this.txn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txn.DefaultText = "";
            this.txn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txn.FillColor = System.Drawing.Color.Black;
            this.txn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txn.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txn.ForeColor = System.Drawing.Color.White;
            this.txn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txn.Location = new System.Drawing.Point(266, 108);
            this.txn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txn.MaxLength = 100;
            this.txn.Name = "txn";
            this.txn.PlaceholderForeColor = System.Drawing.Color.White;
            this.txn.PlaceholderText = "اسم الموضف الكامل   ";
            this.txn.SelectedText = "";
            this.txn.Size = new System.Drawing.Size(407, 48);
            this.txn.TabIndex = 16;
            this.txn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txpa2
            // 
            this.txpa2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txpa2.BorderColor = System.Drawing.Color.Aquamarine;
            this.txpa2.BorderRadius = 4;
            this.txpa2.BorderThickness = 2;
            this.txpa2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txpa2.DefaultText = "";
            this.txpa2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txpa2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txpa2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txpa2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txpa2.FillColor = System.Drawing.Color.Black;
            this.txpa2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txpa2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpa2.ForeColor = System.Drawing.Color.White;
            this.txpa2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txpa2.Location = new System.Drawing.Point(-173, 269);
            this.txpa2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txpa2.MaxLength = 8;
            this.txpa2.Name = "txpa2";
            this.txpa2.PlaceholderForeColor = System.Drawing.Color.White;
            this.txpa2.PlaceholderText = "تئكيد كلمة المرور ";
            this.txpa2.SelectedText = "";
            this.txpa2.Size = new System.Drawing.Size(420, 48);
            this.txpa2.TabIndex = 15;
            this.txpa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txpa2.UseSystemPasswordChar = true;
            // 
            // txph
            // 
            this.txph.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txph.BorderColor = System.Drawing.Color.Aquamarine;
            this.txph.BorderRadius = 5;
            this.txph.BorderThickness = 2;
            this.txph.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txph.DefaultText = "";
            this.txph.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txph.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txph.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txph.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txph.FillColor = System.Drawing.Color.Black;
            this.txph.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txph.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txph.ForeColor = System.Drawing.Color.White;
            this.txph.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txph.Location = new System.Drawing.Point(266, 269);
            this.txph.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txph.MaxLength = 12;
            this.txph.Name = "txph";
            this.txph.PlaceholderForeColor = System.Drawing.Color.White;
            this.txph.PlaceholderText = "رقم الهاتف ";
            this.txph.SelectedText = "";
            this.txph.Size = new System.Drawing.Size(407, 48);
            this.txph.TabIndex = 14;
            this.txph.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txus
            // 
            this.txus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txus.BorderColor = System.Drawing.Color.Aquamarine;
            this.txus.BorderRadius = 5;
            this.txus.BorderThickness = 2;
            this.txus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txus.DefaultText = "";
            this.txus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txus.FillColor = System.Drawing.Color.Black;
            this.txus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txus.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txus.ForeColor = System.Drawing.Color.White;
            this.txus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txus.Location = new System.Drawing.Point(269, 187);
            this.txus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txus.MaxLength = 8;
            this.txus.Name = "txus";
            this.txus.PlaceholderForeColor = System.Drawing.Color.White;
            this.txus.PlaceholderText = "اسم مستخدم النظام  ";
            this.txus.SelectedText = "";
            this.txus.Size = new System.Drawing.Size(407, 48);
            this.txus.TabIndex = 13;
            this.txus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butadd
            // 
            this.butadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butadd.BorderRadius = 8;
            this.butadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butadd.FillColor = System.Drawing.Color.Aquamarine;
            this.butadd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butadd.ForeColor = System.Drawing.Color.Black;
            this.butadd.Location = new System.Drawing.Point(112, 557);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(156, 44);
            this.butadd.TabIndex = 7;
            this.butadd.Text = "اضافة";
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // txcom
            // 
            this.txcom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txcom.BackColor = System.Drawing.Color.Transparent;
            this.txcom.BorderColor = System.Drawing.Color.Aquamarine;
            this.txcom.BorderRadius = 5;
            this.txcom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txcom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txcom.FillColor = System.Drawing.Color.Black;
            this.txcom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txcom.ForeColor = System.Drawing.Color.White;
            this.txcom.ItemHeight = 30;
            this.txcom.Items.AddRange(new object[] {
            "ذكر ",
            "انثا"});
            this.txcom.Location = new System.Drawing.Point(312, 365);
            this.txcom.Name = "txcom";
            this.txcom.Size = new System.Drawing.Size(229, 36);
            this.txcom.StartIndex = 0;
            this.txcom.TabIndex = 9;
            this.txcom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ch
            // 
            this.ch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ch.CheckedState.BorderColor = System.Drawing.Color.Aquamarine;
            this.ch.CheckedState.BorderRadius = 2;
            this.ch.CheckedState.BorderThickness = 0;
            this.ch.CheckedState.FillColor = System.Drawing.Color.Aquamarine;
            this.ch.CheckMarkColor = System.Drawing.Color.Black;
            this.ch.Location = new System.Drawing.Point(-54, 280);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(25, 21);
            this.ch.TabIndex = 8;
            this.ch.Text = "guna2CustomCheckBox1";
            this.ch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ch.UncheckedState.BorderRadius = 2;
            this.ch.UncheckedState.BorderThickness = 0;
            this.ch.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // txpa
            // 
            this.txpa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txpa.BorderColor = System.Drawing.Color.Aquamarine;
            this.txpa.BorderRadius = 5;
            this.txpa.BorderThickness = 2;
            this.txpa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txpa.DefaultText = "";
            this.txpa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txpa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txpa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txpa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txpa.FillColor = System.Drawing.Color.Black;
            this.txpa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txpa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpa.ForeColor = System.Drawing.Color.White;
            this.txpa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txpa.Location = new System.Drawing.Point(-173, 187);
            this.txpa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txpa.MaxLength = 8;
            this.txpa.Name = "txpa";
            this.txpa.PlaceholderForeColor = System.Drawing.Color.White;
            this.txpa.PlaceholderText = "كلمة المرور";
            this.txpa.SelectedText = "";
            this.txpa.Size = new System.Drawing.Size(420, 48);
            this.txpa.TabIndex = 0;
            this.txpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(733, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(523, 660);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "Add";
            this.Size = new System.Drawing.Size(1132, 749);
            this.Load += new System.EventHandler(this.Add_Load_2);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button butdelete;
        private Guna.UI2.WinForms.Guna2Button butupdate;
        private Guna.UI2.WinForms.Guna2CheckBox chekadmin;
        private Guna.UI2.WinForms.Guna2Button butadd;
        private Guna.UI2.WinForms.Guna2ComboBox txcom;
        private Guna.UI2.WinForms.Guna2TextBox txid;
        private Guna.UI2.WinForms.Guna2TextBox txn;
        private Guna.UI2.WinForms.Guna2TextBox txpa2;
        private Guna.UI2.WinForms.Guna2TextBox txph;
        private Guna.UI2.WinForms.Guna2TextBox txus;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ch;
        private Guna.UI2.WinForms.Guna2TextBox txpa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox txact;
    }
}
