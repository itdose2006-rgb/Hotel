namespace Hotel
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ch = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.bulogen = new Guna.UI2.WinForms.Guna2Button();
            this.txpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txuer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BackgroundImage = global::Hotel.Properties.Resources.MacBook_Pro_16____2;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Aquamarine;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.ch);
            this.guna2GroupBox1.Controls.Add(this.bulogen);
            this.guna2GroupBox1.Controls.Add(this.txpass);
            this.guna2GroupBox1.Controls.Add(this.txuer);
            this.guna2GroupBox1.Controls.Add(this.guna2PictureBox1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(148, 31);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(697, 642);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.Text = "تسجيل الدخول";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akhbar MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(275, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "تسجيل الدخول";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ch
            // 
            this.ch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ch.CheckedState.BorderColor = System.Drawing.Color.Aquamarine;
            this.ch.CheckedState.BorderRadius = 2;
            this.ch.CheckedState.BorderThickness = 0;
            this.ch.CheckedState.FillColor = System.Drawing.Color.Aquamarine;
            this.ch.CheckMarkColor = System.Drawing.Color.Black;
            this.ch.Location = new System.Drawing.Point(198, 405);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(20, 20);
            this.ch.TabIndex = 8;
            this.ch.Text = "guna2CustomCheckBox1";
            this.ch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ch.UncheckedState.BorderRadius = 2;
            this.ch.UncheckedState.BorderThickness = 0;
            this.ch.UncheckedState.FillColor = System.Drawing.Color.White;
            this.ch.Click += new System.EventHandler(this.ch_Click);
            // 
            // bulogen
            // 
            this.bulogen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bulogen.BorderRadius = 8;
            this.bulogen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bulogen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bulogen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bulogen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bulogen.FillColor = System.Drawing.Color.Aquamarine;
            this.bulogen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bulogen.ForeColor = System.Drawing.Color.Black;
            this.bulogen.Location = new System.Drawing.Point(258, 475);
            this.bulogen.Name = "bulogen";
            this.bulogen.Size = new System.Drawing.Size(176, 44);
            this.bulogen.TabIndex = 7;
            this.bulogen.Text = "دخول";
            this.bulogen.Click += new System.EventHandler(this.bulogen_Click);
            // 
            // txpass
            // 
            this.txpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txpass.BorderColor = System.Drawing.Color.White;
            this.txpass.BorderRadius = 8;
            this.txpass.BorderThickness = 2;
            this.txpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txpass.DefaultText = "";
            this.txpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txpass.FillColor = System.Drawing.Color.Black;
            this.txpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txpass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpass.ForeColor = System.Drawing.Color.White;
            this.txpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txpass.Location = new System.Drawing.Point(182, 390);
            this.txpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txpass.MaxLength = 8;
            this.txpass.Name = "txpass";
            this.txpass.PlaceholderForeColor = System.Drawing.Color.White;
            this.txpass.PlaceholderText = "كلمة المرور";
            this.txpass.SelectedText = "";
            this.txpass.Size = new System.Drawing.Size(326, 48);
            this.txpass.TabIndex = 0;
            this.txpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txpass.UseSystemPasswordChar = true;
            // 
            // txuer
            // 
            this.txuer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txuer.BorderColor = System.Drawing.Color.White;
            this.txuer.BorderRadius = 8;
            this.txuer.BorderThickness = 2;
            this.txuer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txuer.DefaultText = "";
            this.txuer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txuer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txuer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txuer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txuer.FillColor = System.Drawing.Color.Black;
            this.txuer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txuer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txuer.ForeColor = System.Drawing.Color.White;
            this.txuer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txuer.Location = new System.Drawing.Point(182, 317);
            this.txuer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txuer.MaxLength = 8;
            this.txuer.Name = "txuer";
            this.txuer.PlaceholderForeColor = System.Drawing.Color.White;
            this.txuer.PlaceholderText = "اسم المستخدم";
            this.txuer.SelectedText = "";
            this.txuer.Size = new System.Drawing.Size(326, 48);
            this.txuer.TabIndex = 0;
            this.txuer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.Image = global::Hotel.Properties.Resources.Modern_Letter_AS_Logo_Instagram_Post;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(79, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(520, 301);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(983, 738);
            this.Controls.Add(this.guna2GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txuer;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button bulogen;
        private Guna.UI2.WinForms.Guna2TextBox txpass;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ch;
        private System.Windows.Forms.Label label1;
    }
}

