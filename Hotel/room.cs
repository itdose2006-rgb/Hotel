using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel

{




    public partial class room : UserControl
    {
        public room()
        {
            InitializeComponent();
        }

       
        public void roomcolo()
        {
            room1.BackColor = Color.Aquamarine;


        }
        public void addusercontrol(UserControl userControl)
        {
          /*  userControl.Dock = DockStyle.Fill;
            userControl.AutoScroll = true;
            motherpanel.Controls.Clear();
            motherpanel.Controls.Add(userControl);
            userControl.BringToFront();*/  



        }

        public void goroom()
        {


            // 1. إنشاء كائن من اليوزر كنترول الجديد الذي تريد الانتقال إليه
            propertiesroom uc = new propertiesroom();

            // 2. الوصول إلى فورم home الرئيسي واستدعاء دالة addusercontrol
            home mainForm = this.ParentForm as home;

            if (mainForm != null)
            {
                mainForm.addusercontrol(uc);
            }

        }




        private void room_Load(object sender, EventArgs e)
        {

            string date = DateTime.Now.ToString("yyyyy-MM-dd");
            string time = DateTime.Now.ToShortTimeString();
            //labdate.Text = date;
           // labtime.Text = time;

        }

   

      

     

        private void guna2Button6_Click(object sender, EventArgs e)
        {
           
            goroom();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            goroom();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            goroom();

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

            goroom();

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            goroom();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

            goroom();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            goroom();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {


            goroom();

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void room1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
