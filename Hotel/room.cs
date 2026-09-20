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

       

        public void addusercontrol(UserControl userControl)
        {
          /*  userControl.Dock = DockStyle.Fill;
            userControl.AutoScroll = true;
            motherpanel.Controls.Clear();
            motherpanel.Controls.Add(userControl);
            userControl.BringToFront();*/  



        }

     

       

        private void room_Load(object sender, EventArgs e)
        {

            string date = DateTime.Now.ToString("yyyyy-MM-dd");
            string time = DateTime.Now.ToShortTimeString();
            labdate.Text = date;
            labtime.Text = time;

        }

   

      

     

        private void guna2Button6_Click(object sender, EventArgs e)
        {
           // propertiesroom ad = new propertiesroom();
          //  addusercontrol(ad);
        }
    }
}
