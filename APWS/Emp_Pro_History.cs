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
    public partial class Emp_Pro_History : Form
    {
        SqlCommand cmd;
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt1;

        public Emp_Pro_History()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

     
            this.productionTableAdapter.Fill(this.PrReport.production,bunifuDatepicker1.Value.ToShortDateString(),bunifuDatepicker2.Value.ToShortDateString());
            
            this.reportViewer1.RefreshReport();
         

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Emp_Pro_History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PrReport.production' table. You can move, or remove it, as needed.
         
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emp_Add_Pro Emp7 = new Emp_Add_Pro();
            Emp7.Show();
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

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
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
            GatepaasHis d2 = new GatepaasHis();
            d2.Show();
        }
    }
}
