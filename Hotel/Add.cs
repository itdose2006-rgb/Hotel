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
namespace Hotel
{
    public partial class Add : UserControl
    {
       SqlConnection cn = new SqlConnection(@"server= THEBest\SQLEXPRESS ; DataBase=hotel ; Integrated Security =true");
        public Add()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ch_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           try
            {
                cn.Open();

                SqlCommand ad=new SqlCommand("insert into emp (name,phone,username,pass,gen,active) Values ('akaza ','780121263','amam','soso','main',1)", cn);
                ad.ExecuteNonQuery();
              
             
            }
            catch(SqlException ex) {
                MessageBox.Show(ex .Message);
            
            }
            cn.Close();


        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }


       

        private void guna2GroupBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
