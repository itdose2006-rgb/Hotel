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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel
{
    public partial class Form1 : Form

    {

        SqlConnection cn = new SqlConnection(@"Server=THEBest\SQLEXPRESS ; DataBase=hotel  ; Integrated securty=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // guna2WinProgressIndicator1.Visible = false;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

      

      

     
       

        private void ch_Click(object sender, EventArgs e)
        {
            if (txpass.UseSystemPasswordChar == false)
            {
                txpass.UseSystemPasswordChar = true;
            }
            else if (txpass.UseSystemPasswordChar = true)
            {
                txpass.UseSystemPasswordChar = false;
            }

        }

        private void guna2GroupBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bulogen_Click(object sender, EventArgs e)
        {
           
         
           
           /* try
            {

                cn.Open();
                string usna = txuer.Text;
                string pas = txpass.Text;
                SqlCommand cm = new SqlCommand(" SELECT * from emp WHERE username ='" + usna + "' AND pass = '" + pas + "' AND active = 1", cn);
                cm.ExecuteNonQuery();

                cn.Close();




            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                cn.Close();

            }*/

        }

        private void txuer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
