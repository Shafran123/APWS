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

namespace APWS
{
    public partial class Vehical : Form
    {
        public Vehical()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = null;
                string sql = null;
                connetionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    sql = "insert into vehicaldetails ([vehicalnumber], [type] ,[owner],[capacity],[model],[comment]) values(@vehicalnumber,@type,@owner,@capacity,@model,@comment)";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@vehicalnumber", bunifuMetroTextbox1.Text);
                        cmd.Parameters.AddWithValue("@type", bunifuMaterialTextbox1.Text);
                        cmd.Parameters.AddWithValue("@owner", bunifuMaterialTextbox2.Text);
                        cmd.Parameters.AddWithValue("@capacity", bunifuMaterialTextbox3.Text);
                        cmd.Parameters.AddWithValue("@model", bunifuMaterialTextbox6.Text);
                        cmd.Parameters.AddWithValue("@comment", bunifuMaterialTextbox5.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vehical Add Sucessfull");
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Vehical Number Already Exist!! ");
            }


        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SqlConnection cn3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
            cn3.Open();
            SqlCommand cmd3 = cn3.CreateCommand();

            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "update vehicaldetails set type='" + bunifuMaterialTextbox1.Text + "' , owner='" + bunifuMaterialTextbox2.Text + "' , capacity='" + bunifuMaterialTextbox3.Text + "' , model='" + bunifuMaterialTextbox6.Text + "' , comment='" + bunifuMaterialTextbox5.Text + "' where vehicalnumber  ='" + bunifuMetroTextbox1.Text + "'";
            cmd3.ExecuteNonQuery();
            cn3.Close();
            MessageBox.Show("Update Sucessfull");

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
                SqlDataAdapter ad1 = new SqlDataAdapter("select * from vehicaldetails where vehicalnumber ='" + bunifuMetroTextbox1.Text + "'", cn1);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                bunifuMaterialTextbox1.Text = dt1.Rows[0][1].ToString();
                bunifuMaterialTextbox2.Text = dt1.Rows[0][2].ToString();
                bunifuMaterialTextbox3.Text = dt1.Rows[0][3].ToString();
                bunifuMaterialTextbox6.Text = dt1.Rows[0][4].ToString();
                bunifuMaterialTextbox5.Text = dt1.Rows[0][5].ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("No Vehical Found ");
            }
            
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
            cn2.Open();
            SqlCommand cmd2 = cn2.CreateCommand();

            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "delete from vehicaldetails where vehicalnumber  ='" + bunifuMetroTextbox1.Text + "'";
            cmd2.ExecuteNonQuery();
            cn2.Close();
            MessageBox.Show("Delete Sucessfull");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
           Emp_Add_Pro d1 = new Emp_Add_Pro();
            d1.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emp_Pro_History d2 = new Emp_Pro_History();
            d2.Show();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            this.Hide();
            Driver d3 = new Driver();
            d3.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenGatePass d4 = new GenGatePass();
            d4.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            GatepaasHis d5 = new GatepaasHis();
            d5.Show();
        }
    }
}
