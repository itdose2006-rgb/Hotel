using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Media;
using System.Xml.Linq;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;

namespace Hotel
{
    public partial class propertiesroom : UserControl
    {
        public propertiesroom()
        {
            InitializeComponent();

           
        }
        SqlConnection cn = new SqlConnection(@"Server=THEBest\SQLEXPRESS ; DataBase=hotel  ; Integrated Security=true");
        private void txn_TextChanged(object sender, EventArgs e)
        {

        }

        private void reff2()
        {
            txname.Text="";
            txphone.Text= "";
            txcard.Text="";
            txpr1.Text = "";
            txpr2.Text = "";

            txdate.Text = "";
            txleave.Text = "";
            txFRe.Text = "";



        }
        


        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
            
                // 1. إنشاء كائن من اليوزر كنترول الجديد الذي تريد الانتقال إليه
                room uc = new room();

                // 2. الوصول إلى فورم home الرئيسي واستدعاء دالة التحميل العادية
                home mainForm = this.ParentForm as home;

                if (mainForm != null)
                {
                    mainForm.addusercontrol(uc);
                }
        }
        private void buedd_Click(object sender, EventArgs e)

        {
            string name = txname.Text;
            string phone= txphone.Text;
            string card=  txcard.Text;
            string pr1=   txpr1.Text;
            string pr2=   txpr2.Text;
           
            string datein=txdate.Text;
            string datel= txleave.Text;
            string rent=  txFRe.Text;
            int state = 1;
            int num = Convert.ToInt32(txnum.Text);
            try
            {
                cn.Open();
                SqlCommand ad = new SqlCommand("exec insert_cas '" + name + "', '" + phone + "', " + num + ", '" + datein + "', " + rent + ", " + state + ", '" + datel + "', NULL", cn);
                ad.ExecuteNonQuery();
                MessageBox.Show("add successfully", "add", MessageBoxButtons.OK);
                reff2();
              



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

        private void budele_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand ad = new SqlCommand("delete  room1 ", cn);
                ad.ExecuteNonQuery();
                MessageBox.Show("delete successfully", "add", MessageBoxButtons.OK);
                

                


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

        private void buprint_Click(object sender, EventArgs e)
        {


        
                // نافذة لاختيار مكان واسم وحفظ الملف
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text File (*.txt)|*.txt|CSV File (*.csv)|*.csv";
                sfd.Title = "حفظ تقرير الغرف";
                sfd.FileName = "Room_Report";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        cn.Open();
                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM room1", cn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        System.Text.StringBuilder sb = new System.Text.StringBuilder();

                        // كتابة أسماء الأعمدة في الأعلى
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            sb.Append(dt.Columns[i].ColumnName + (i == dt.Columns.Count - 1 ? "" : ","));
                        }
                        sb.AppendLine();

                        // كتابة بيانات كل صف
                        foreach (DataRow row in dt.Rows)
                        {
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                sb.Append(row[i].ToString() + (i == dt.Columns.Count - 1 ? "" : ","));
                            }
                            sb.AppendLine();
                        }

                        // حفظ الملف في المسار الذي اختاره المستخدم
                        System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), System.Text.Encoding.UTF8);

                        MessageBox.Show("تم حفظ التقرير بنجاح!", "التقرير", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
