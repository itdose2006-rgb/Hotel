using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;


namespace Hotel
{



    public partial class home : Form

    {
        


        SqlConnection cn = new SqlConnection(@"Server=THEBest\SQLEXPRESS ; DataBase=hotel  ; Integrated Security=true");

        public home()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            report ad = new report();
            addusercontrol((ad));
        }


        // دالة مسؤولة عن إخفاء الزر الخاص بالمدير
        public void showButton()
        {
            // ضع هنا اسم الزر الحقيقي لديك (مثلاً button1 أو زر الإدارة)
           addemp.Visible = false;
        }







        public void addusercontrol(UserControl userControl)
        {
            userControl.Dock=DockStyle.Fill;
            userControl.AutoScroll= true;
            motherpanel.Controls.Clear();
            motherpanel.Controls.Add(userControl);
            userControl.BringToFront();
            


        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
             
        }
        
        
        private void motherpanel_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AboutuUs ad = new AboutuUs();
            addusercontrol(ad);
        }

        private void minbut_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void add1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void ching()
        {

            addemp.Visible = true;
        }
        private void addemp_Click(object sender, EventArgs e)
        {
            Add ad = new Add();
            addusercontrol(ad);
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            report ad=new report();
            addusercontrol((ad));
        }
      
            private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomsbut_Click(object sender, EventArgs e)
        {

           
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void roomsbut_Click_1(object sender, EventArgs e)
        {
            room ad = new room();
            addusercontrol(ad);

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pbut_Click(object sender, EventArgs e)
        {

            apartment ad = new apartment();
            addusercontrol(ad);
        }
    }
}
