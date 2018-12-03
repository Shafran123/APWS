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
using Microsoft.Reporting.WinForms;

namespace APWS
{
    public partial class GatepaasHis : Form
    {
        public GatepaasHis()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emp_Add_Pro d1 = new Emp_Add_Pro();
            d1.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenGatePass d5 = new GenGatePass();
            d5.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emp_Pro_History d2 = new Emp_Pro_History();
            d2.Show();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            this.Hide();
           Vehical d3 = new Vehical();
            d3.Show();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            this.Hide();
            Driver d4 = new Driver();
            d4.Show();
        }

        private void GatepaasHis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GatepassHis.gatepass' table. You can move, or remove it, as needed.
            
            this.gatepassTableAdapter.Fill(this.GatepassHis.gatepass);
           
            this.reportViewer1.RefreshReport();
          
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            

            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
