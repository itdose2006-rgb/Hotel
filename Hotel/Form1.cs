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
using System.Windows;
using System.Data;
using System.Web.UI;
using Hotel;
using static Hotel.home;

namespace Hotel
{
    public partial class Login : Form

    {
         
        
            
        
        SqlConnection cn = new SqlConnection(@"Server=THEBest\SQLEXPRESS ; DataBase=hotel  ; Integrated Security=true");
        public Login()
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
            string usern=txuer.Text;
            string pass=txpass.Text;
            if(usern == "" || pass =="")
            {
               System.Windows.MessageBox.Show("الحقل فارغ","خطاء",MessageBoxButton.OK);
            };

            try
            {
                cn.Open();
                SqlDataAdapter cm = new SqlDataAdapter("exec loginn '"+usern+"', '"+pass+"' ",cn);
                DataTable dt =new DataTable();
                cm.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string n = dt.Rows[0]["username"].ToString();
                    string p = dt.Rows[0]["pass"].ToString();
                    string admin = dt.Rows[0]["admin"].ToString();

                    if (admin == "1")
                    {
                        System.Windows.MessageBox.Show("مرحبا بك يامدير" + n, "Admin", MessageBoxButton.OK);
                        home homeForm = new home();
                        homeForm.Show();



                    }
                    else
                    {
                        System.Windows.MessageBox.Show("مرحبا " + n, "User", MessageBoxButton.OK);
                        home homeForm = new home();
                        homeForm.Show();
                        homeForm.showButton();







                    }




                }
                else
                {
                    System.Windows.MessageBox.Show("كلمة المرور او اسم المستخدم خطاء " , "خطاء", MessageBoxButton.OK);

                    

                }



            }
            catch (SqlException ex)
            {


                System.Windows.MessageBox.Show(ex.Message);






            }
            finally
            {
                cn.Close();



            }





        }





        }

      
    }

