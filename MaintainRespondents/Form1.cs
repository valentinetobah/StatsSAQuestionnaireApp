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

namespace MaintainCities
{
    public partial class Form1 : Form
    {
        public SqlConnection conn;

        //Declaring the public variables
        String conStr = @"Data Source=LAPTOP-PA4SGPS2\SQLEXPRESS;Initial Catalog = spCreateTables; Integrated Security = True";
        //SqlConnection conn;
        SqlCommand comm;
        public SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader theReader;
        public string fName; //Declaring variable with access modifier publicly
        public string fSurname;
        public string fStrName;
        public int fDOB;
        public int fStrNo;



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fName = txtName.Text;
            fSurname = txtSurname.Text;
            fDOB = Convert.ToInt32(txtDOB.Text);
            fStrNo = Convert.ToInt32(txtStrNo.Text);
            fStrName = txtStrName.Text;           
                        
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-PA4SGPS2\SQLEXPRESS;Initial Catalog = spCreateTables; Integrated Security = True");
                conn.Open();
                SqlCommand SqlInsert = new SqlCommand($"INSERT INTO Respondent VALUES ('"+txtName.Text +"', '"+txtSurname.Text + "','" + Convert.ToInt32(txtDOB.Text) + "','" + Convert.ToInt32(txtStrNo.Text) + "','" + txtStrName.Text + "')", conn); 
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.InsertCommand = SqlInsert;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
