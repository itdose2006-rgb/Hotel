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
using Microsoft.AnalysisServices;

namespace Hotel
{
  
    public partial class Form3 : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=THEBest\SQLEXPRESS ; DataBase=hotel  ; Integrated Security=true");
        public Form3()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
        private void cle()
        {
            
            txn.Text = "";
            txpa.Text = "";
            txus.Text = "";
            txph.Text = "";
            txcom.Text = "";
            txid.Enabled = true;



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {

                cn.Open();
                SqlCommand cm = new SqlCommand("insert into emp values ('" + txn.Text + "','" + txph.Text + "','" + txus.Text + "','" + txpa.Text + "','" + txcom.Text + "', 2)", cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("add successfully","add",MessageBoxButtons.OK);
                cle();
                refr();






            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {

                cn.Close();
               
            }
                  
            
            
        }

        private void cht_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void refr()
        {
            SqlDataAdapter da = new SqlDataAdapter("selALL", cn);
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = txid.Text;

            p[1] = new SqlParameter("@name", SqlDbType.VarChar,507);
            p[1].Value = txid.Text;

            p[2] = new SqlParameter("@name", SqlDbType.VarChar, 507);
            p[2].Value = txid.Text;







            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        private void Form3_Load(object sender, EventArgs e)
        {
            refr();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txid.Enabled = false;
            txid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            txn.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txph.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txus.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txpa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txcom.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                txid.Enabled = false;

                cn.Open();
                SqlCommand up = new SqlCommand(" update emp set name='"+ txn.Text+"', phone ='"+txph.Text+"' ,username='"+txus.Text+"', pass ='"+txpa.Text+"' ,gen ='"+txcom.Text+"' , active=1 where id=" + txid.Text + "", cn);
                up.ExecuteNonQuery();
                MessageBox.Show("add successfully", "add", MessageBoxButtons.OK);
                cle();
                refr();






            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                cn.Close();

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                txid.Enabled = false;

                cn.Open();
                SqlCommand dl = new SqlCommand("delete from emp where id=" + txid.Text + "", cn);
                dl.ExecuteNonQuery();
                MessageBox.Show("add successfully", "add", MessageBoxButtons.OK);
                cle();
                refr();






            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                cn.Close();

            }
        }

        private void txus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txn_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txcom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ch_Click(object sender, EventArgs e)
        {

        }

        private void txpa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






