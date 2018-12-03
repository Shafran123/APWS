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
   /* class VException :ApplicationException
    {
        public override string Message { get
            {
                return "Value is here";
            }

        }
    }*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void usernamelogin_MouseLeave(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void usernamelogin_Enter(object sender, EventArgs e)
        {
        /*    if (bunifuMaterialTextbox1.Text == "Username")
            {
                bunifuMaterialTextbox1.Text = "";

                bunifuMaterialTextbox1.ForeColor = Color.Black;
            }*/
        }

        private void usernamelogin_Leave(object sender, EventArgs e)
        {
          /*  if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Username";

                bunifuMaterialTextbox1.ForeColor = Color.Silver;
            }*/
        }

        private void pwlogin_Enter(object sender, EventArgs e)
        {
       /*     if (bunifuMaterialTextbox2.Text == "Password")
            {
                bunifuMaterialTextbox2.Text = "";

                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }*/
        }

        private void pwlogin_Leave(object sender, EventArgs e)
        {
         /*   if (bunifuMaterialTextbox2.Text == "")
            {
                bunifuMaterialTextbox2.Text = "Password";

                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }*/
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafran\Desktop\APWS\APWS\APWS\APWS.mdf;Integrated Security=True");
            string Qry = "Select * from productionloginuser where Username = '" + bunifuMaterialTextbox1.Text.Trim() + "' and Password = '" + bunifuMaterialTextbox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Qry, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Visible = false;
                EmpDashboard Emp1 = new EmpDashboard();
                Emp1.Show();

            }
            else
            {
                MessageBox.Show("Incorrect UserName Or Password", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
            
        }
    }

