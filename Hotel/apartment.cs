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
    public partial class apartment : UserControl
    {
        public apartment()
        {
            InitializeComponent();
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
        private void apartment_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            goroom();
        }
    }
}
