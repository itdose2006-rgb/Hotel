
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
        SqlConnection cn = new SqlConnection(@"Server=THEBest\SQLEXPRESS ; DataBase=hotel  ; Integrated Security=true");
        public Add()
        {
            InitializeComponent();
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        public void refr()
        {
            SqlDataAdapter da = new SqlDataAdapter("selALL", cn);
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = txid.Text;

            p[1] = new SqlParameter("@name", SqlDbType.VarChar, 507);
            p[1].Value = txid.Text;

            p[2] = new SqlParameter("@name", SqlDbType.VarChar, 507);
            p[2].Value = txid.Text;




            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }


        private void butadd_Click(object sender, EventArgs e)
        {


            string name = txn.Text;
            string phone = txph.Text;
            string username = txus.Text;
            string pass = txpa.Text;
            string passg = txpa2.Text;
            string gen = txcom.Text;
            int actve;
            int admin;

            if (chekadmin.Checked == true)
            {
                admin = 1;
            }
            else
            {
                admin = 0;
            }
            if (txact.Text == "محضور")
            {
                actve = 1;


            }
            else
            {
                actve = 0;
            }

            if (pass != passg)
            {
                MessageBox.Show("خطاء في تطابق كلمة المرور", MessageBoxIcon.Error.ToString());

            }

            if (name == "" && pass == "" && username == "" && passg == "" && phone == "")
            {
                MessageBox.Show("مدخلاات فارغة", MessageBoxIcon.Error.ToString());

            }




            try
            {
                cn.Open();

                SqlCommand ad = new SqlCommand("exec insert_emp '" + name + "', '" + phone + "', '" + username + "', '" + pass + "', '" + gen + "', " + actve + ", " + admin, cn);
                ad.ExecuteNonQuery();
                MessageBox.Show("add successfully", "add", MessageBoxButtons.OK);
                refr();



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                cn.Close();
            }
        }










        

        private void butupdate_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txid.Text);
            string name = txn.Text;
            string phone = txph.Text;
            string username = txus.Text;
            string pass = txpa.Text;
            string gen = txcom.Text;
            int actve;
            int admin;
            if (chekadmin.Checked == true)
            {
                admin = 1;
            }
            else
            {
                admin = 0;
            }
            if (txact.Text == "محضور")
            {
                actve = 1;


            }
            else
            {
                actve = 0;
            }


            try
            {
                txid.Enabled = false;

                cn.Open();
                SqlCommand up = new SqlCommand(" exec upd " + id + "  ,  " + name + "  ,  " + phone + "  ,  " + username + " ,  " + pass + " ,  " + gen + "  ,  " + actve + "  ,  " + admin + "   ", cn);
                up.ExecuteNonQuery();
                MessageBox.Show(" successfully Update", "Update", MessageBoxButtons.OK);
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

        private void Add_Load_2(object sender, EventArgs e)
        {
            refr();
        }

       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txid.Enabled = false;
            txid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            txn.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txph.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txus.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txpa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txcom.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txid.Text);
            string name = txn.Text;
            string phone = txph.Text;
            string username = txus.Text;
            string pass = txpa.Text;
            string gen = txcom.Text;
            int actve;
            int admin;
            if (chekadmin.Checked == true)
            {
                admin = 1;
            }
            else
            {
                admin = 0;
            }
            if (txact.Text == "محضور")
            {
                actve = 1;


            }
            else
            {
                actve = 0;
            }


            try
            {
                txid.Enabled = false;

                cn.Open();
                SqlCommand up = new SqlCommand(" exec delete_emp "+id+"", cn);
                up.ExecuteNonQuery();
                MessageBox.Show(" successfully delete", "Update", MessageBoxButtons.OK);
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

    
    }

}; 