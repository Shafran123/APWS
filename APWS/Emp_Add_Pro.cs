using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace APWS
{
    public partial class Emp_Add_Pro : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        public Emp_Add_Pro()
        {
            InitializeComponent();
        }

        private void Emp_Add_Pro_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

     


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO production (pcycle,pcount,pdate) VALUES (@pcycle,@pcount,@pdate)",con);
            cmd.Parameters.AddWithValue("@pcycle", bunifuDropdown1.selectedValue.ToString());
            cmd.Parameters.AddWithValue("@pcount", bunifuMetroTextbox1.Text);
            cmd.Parameters.AddWithValue("@pdate", bunifuDatepicker1.Value.Date);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Production Updated Sucesfully!! ");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emp_Add_Pro Emp4 = new Emp_Add_Pro();
            Emp4.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emp_Pro_History Emp3 = new Emp_Pro_History();
            Emp3.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehical v1 = new Vehical();
            v1.Show();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            this.Hide();
            Driver d1 = new Driver();
            d1.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenGatePass d2 = new GenGatePass();
            d2.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            GatepaasHis d3 = new  GatepaasHis();
            d3.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
