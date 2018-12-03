using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APWS
{
    public partial class EmpDashboard : Form
    {
        public EmpDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emp_Add_Pro Emp2 = new Emp_Add_Pro();
            Emp2.Show();
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

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            this.Hide();
            Driver D1 = new Driver();
            D1.Show();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehical v2 = new Vehical();
            v2.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenGatePass G = new GenGatePass();
            G.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            GatepaasHis GP = new GatepaasHis();
            GP.Show();
        }
    }
}
