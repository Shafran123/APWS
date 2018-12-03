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
    public partial class GenGatePass : Form
    {
        public GenGatePass()
        {
            InitializeComponent();
            fillvehicleno();
            filldrivername();
        }

        void fillvehicleno()
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");

            cn2.Open();
            SqlCommand cmd2 = cn2.CreateCommand();
            
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from vehicaldetails ;";
            cmd2.ExecuteNonQuery();
            SqlDataReader reader;
            try
            {
                reader = cmd2.ExecuteReader();

                while (reader.Read())
                {
                    String vno = reader["vehicalnumber"].ToString();
                    comboBox1.Items.Add(vno);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cn2.Close();
        }

        void filldrivername()
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");

            cn2.Open();
            SqlCommand cmd2 = cn2.CreateCommand();

            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from driverdetailsnew2 ;";
            cmd2.ExecuteNonQuery();
            SqlDataReader reader;
            try
            {
                reader = cmd2.ExecuteReader();

                while (reader.Read())
                {
                    String dname = reader["name"].ToString();
                    comboBox2.Items.Add(dname);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cn2.Close();
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }

        private void GenGatePass_Load(object sender, EventArgs e)
        {

           
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;
            connetionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = "insert into gatepass ([gatepassid], [from] ,[to],[fullbottles],[emptybot],[dmgbot],[vnum],[dname],[cmnts]) values(@gatepassid,@from,@to,@fullbottles,@emptybot,@dmgbot,@vnum,@dname,@cmnts)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@gatepassid", bunifuMetroTextbox1.Text);
                    cmd.Parameters.AddWithValue("@from", bunifuMaterialTextbox2.Text);
                    cmd.Parameters.AddWithValue("@to", bunifuMaterialTextbox3.Text);
                    cmd.Parameters.AddWithValue("@fullbottles", bunifuMaterialTextbox6.Text);
                    cmd.Parameters.AddWithValue("@emptybot", bunifuMaterialTextbox5.Text);
                    cmd.Parameters.AddWithValue("@dmgbot", bunifuMaterialTextbox4.Text);
                    cmd.Parameters.AddWithValue("@vnum", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@dname", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@cmnts", bunifuMaterialTextbox7.Text);
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gatepass Added Sucessfull");
                }
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
                SqlDataAdapter ad1 = new SqlDataAdapter("select * from gatepass where gatepassid ='" + bunifuMetroTextbox1.Text + "'", cn1);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                bunifuMaterialTextbox2.Text = dt1.Rows[0][1].ToString();
                bunifuMaterialTextbox3.Text = dt1.Rows[0][2].ToString();
                bunifuMaterialTextbox6.Text = dt1.Rows[0][3].ToString();
                bunifuMaterialTextbox5.Text = dt1.Rows[0][4].ToString();
                bunifuMaterialTextbox4.Text = dt1.Rows[0][5].ToString();
                comboBox1.Text = dt1.Rows[0][6].ToString();
                comboBox2.Text = dt1.Rows[0][7].ToString();
                bunifuMaterialTextbox7.Text = dt1.Rows[0][8].ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("No Gatepass Found");
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
            cn2.Open();
            SqlCommand cmd2 = cn2.CreateCommand();

            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "delete from gatepass where gatepassid  ='" + bunifuMetroTextbox1.Text + "'";
            cmd2.ExecuteNonQuery();
            cn2.Close();
            MessageBox.Show("Delete Sucessfull");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image logo = Image.FromFile("logo_645.png");
            e.Graphics.DrawImage(logo, 250,20);
            e.Graphics.DrawString("GatePass Generated On : " + DateTime.Now, new Font("Lucida Console", 12), Brushes.Black, new Point(25, 120));
            e.Graphics.DrawString("__________________________________________________________________________________", new Font("Ludica Console", 12), Brushes.Black, new Point(25, 130));
            e.Graphics.DrawString("GatePass", new Font("Lucida Console", 24, FontStyle.Bold), Brushes.Red, new Point(310,170));
            e.Graphics.DrawString("Gate Pass ID : " + bunifuMetroTextbox1.Text, new Font("Lucida Console", 14, FontStyle.Bold), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Vehical Number : " + comboBox1.Text, new Font("Lucida Console", 14, FontStyle.Bold), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("Vehical Exit From : " + bunifuMaterialTextbox2.Text, new Font("Lucida Console", 14, FontStyle.Bold), Brushes.Black, new Point(350, 230));
            e.Graphics.DrawString("Driver Name: " + comboBox2.Text, new Font("Lucida Console", 14, FontStyle.Bold), Brushes.Black, new Point(25, 260));
            e.Graphics.DrawString("Transport Destination : " + bunifuMaterialTextbox3.Text, new Font("Lucida Console", 14, FontStyle.Bold), Brushes.Black, new Point(350, 260));
            e.Graphics.DrawString("__________________________________________________________________________________", new Font("Ludica Console", 12), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString("Cargo Transcript Exit", new Font("Lucida Console", 24, FontStyle.Bold), Brushes.Red, new Point(180, 330));
            e.Graphics.DrawString("Full Bottles   : " + bunifuMaterialTextbox6.Text, new Font("Lucida Console", 18, FontStyle.Bold), Brushes.Black, new Point(25, 380));
            e.Graphics.DrawString("Empty Bottles  : " + bunifuMaterialTextbox5.Text, new Font("Lucida Console", 18, FontStyle.Bold), Brushes.Black, new Point(25, 420));
            e.Graphics.DrawString("Damage Bottles : " + bunifuMaterialTextbox4.Text, new Font("Lucida Console", 18, FontStyle.Bold), Brushes.Black, new Point(25, 460));
            e.Graphics.DrawString("_______________________", new Font("Ludica Console", 12), Brushes.Black, new Point(25, 510));
            e.Graphics.DrawString("Loading Superviser Sign ", new Font("Lucida Console", 12), Brushes.Black, new Point(25, 550));
            e.Graphics.DrawString("_______________________", new Font("Ludica Console", 12), Brushes.Black, new Point(300, 510));
            e.Graphics.DrawString("     Driver  Sign ", new Font("Lucida Console", 12), Brushes.Black, new Point(300, 550));
            e.Graphics.DrawString("_______________________", new Font("Ludica Console", 12), Brushes.Black, new Point(550, 510));
            e.Graphics.DrawString("Exit Gate Security Sign ", new Font("Lucida Console", 12), Brushes.Black, new Point(550, 550));
            e.Graphics.DrawString("__________________________________________________________________________________", new Font("Ludica Console", 12), Brushes.Black, new Point(25, 600));
            e.Graphics.DrawString("Cargo Transcript In", new Font("Lucida Console", 24, FontStyle.Bold), Brushes.Red, new Point(180, 640));
            e.Graphics.DrawString("Full Bottles   : _____ ", new Font("Lucida Console", 18, FontStyle.Bold), Brushes.Black, new Point(25, 680));
            e.Graphics.DrawString("Empty Bottles  : _____ ", new Font("Lucida Console", 18, FontStyle.Bold), Brushes.Black, new Point(25, 720));
            e.Graphics.DrawString("Damage Bottles : _____ ", new Font("Lucida Console", 18, FontStyle.Bold), Brushes.Black, new Point(25, 760));
            e.Graphics.DrawString("__________________________", new Font("Ludica Console", 12), Brushes.Black, new Point(25, 810));
            e.Graphics.DrawString("UN Loading Superviser Sign ", new Font("Lucida Console", 12), Brushes.Black, new Point(25, 850));
            e.Graphics.DrawString("__________________________", new Font("Ludica Console", 12), Brushes.Black, new Point(300, 810));
            e.Graphics.DrawString("     Driver  Sign ", new Font("Lucida Console", 12), Brushes.Black, new Point(300, 850));
            e.Graphics.DrawString("__________________________", new Font("Ludica Console", 12), Brushes.Black, new Point(550, 810));
            e.Graphics.DrawString("IN Gate Security Sign ", new Font("Lucida Console", 12), Brushes.Black, new Point(550, 850));
            e.Graphics.DrawString("__________________________________________________________________________________", new Font("Ludica Console", 12), Brushes.Black, new Point(25, 910));
            e.Graphics.DrawString("__________________________________________________________________________________", new Font("Ludica Console", 12), Brushes.Black, new Point(25, 950));
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            this.Hide();
            Driver d1 = new Driver();
            d1.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            GatepaasHis d2 = new GatepaasHis();
            d2.Show();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehical d3 = new Vehical();
            d3.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emp_Pro_History d4 = new Emp_Pro_History();
            d4.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            this.Hide();
            Emp_Add_Pro d5 = new Emp_Add_Pro();
            d5.Show();
        }
    }
}
