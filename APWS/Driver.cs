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
    public partial class Driver : Form
    {

        public Driver()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;
            connetionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = "insert into driverdetailsnew2 ([driverid], [Name] ,[nicnumber],[age],[address],[mobile],[email],[assignedvehical],[assignedroute],[comments]) values(@driverid,@name,@nicnumber,@age,@address,@mobile,@email,@assignedvehical,@assignedroute,@comments)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@driverid", bunifuMetroTextbox1.Text);
                    cmd.Parameters.AddWithValue("@name", bunifuMaterialTextbox1.Text);
                    cmd.Parameters.AddWithValue("@nicnumber", bunifuMaterialTextbox2.Text);
                    cmd.Parameters.AddWithValue("@age", bunifuMaterialTextbox3.Text);
                    cmd.Parameters.AddWithValue("@address", bunifuMaterialTextbox6.Text);
                    cmd.Parameters.AddWithValue("@mobile", bunifuMaterialTextbox5.Text);
                    cmd.Parameters.AddWithValue("@email", bunifuMaterialTextbox4.Text);
                    cmd.Parameters.AddWithValue("@assignedvehical", bunifuMaterialTextbox9.Text);
                    cmd.Parameters.AddWithValue("@assignedroute", bunifuMaterialTextbox8.Text);
                    cmd.Parameters.AddWithValue("@comments", bunifuMaterialTextbox7.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Add Sucessfull");
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
                SqlDataAdapter ad1 = new SqlDataAdapter("select * from driverdetailsnew2 where driverid ='" + bunifuMetroTextbox1.Text + "'", cn1);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                bunifuMaterialTextbox1.Text = dt1.Rows[0][1].ToString();
                bunifuMaterialTextbox2.Text = dt1.Rows[0][2].ToString();
                bunifuMaterialTextbox3.Text = dt1.Rows[0][3].ToString();
                bunifuMaterialTextbox6.Text = dt1.Rows[0][4].ToString();
                bunifuMaterialTextbox5.Text = dt1.Rows[0][5].ToString();
                bunifuMaterialTextbox4.Text = dt1.Rows[0][6].ToString();
                bunifuMaterialTextbox9.Text = dt1.Rows[0][7].ToString();
                bunifuMaterialTextbox8.Text = dt1.Rows[0][8].ToString();
                bunifuMaterialTextbox7.Text = dt1.Rows[0][9].ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("No Driver Found ");
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            SqlConnection cn3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
            cn3.Open();
            SqlCommand cmd3 = cn3.CreateCommand();

            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "update driverdetailsnew2 set name='"+bunifuMaterialTextbox1.Text+ "' , nicnumber='" + bunifuMaterialTextbox2.Text + "' , age='" + bunifuMaterialTextbox3.Text + "' , address='" + bunifuMaterialTextbox6.Text + "' , mobile='" + bunifuMaterialTextbox5.Text + "' , email='" + bunifuMaterialTextbox4.Text + "' , assignedvehical='" + bunifuMaterialTextbox9.Text + "' , assignedroute='" + bunifuMaterialTextbox8.Text + "' , comments='" + bunifuMaterialTextbox7.Text + "' where driverid  ='" + bunifuMetroTextbox1.Text + "'";
            cmd3.ExecuteNonQuery();
            cn3.Close();
            MessageBox.Show("Update Sucessfull");

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
            cn2.Open();
            SqlCommand cmd2 = cn2.CreateCommand();

            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "delete from driverdetailsnew2 where driverid  ='" + bunifuMetroTextbox1.Text + "'";
            cmd2.ExecuteNonQuery();
            cn2.Close();
            MessageBox.Show("Delete Sucessfull");

        
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehical v1 = new Vehical();
            v1.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenGatePass v2 = new GenGatePass();
            v2.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            GatepaasHis v3 = new GatepaasHis();
            v3.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emp_Add_Pro v4 = new Emp_Add_Pro();
            v4.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emp_Pro_History v5 = new Emp_Pro_History();
            v5.Show();
        }
    }
}