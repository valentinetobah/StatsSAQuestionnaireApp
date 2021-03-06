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
        public int fRespID;
        public string fName; //Declaring variable with access modifier publicly
        public string fSurname;
        public string fStrName;
        public int fDOB;
        public int fStrNo;
        public int fCityID;



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fRespID = Convert.ToInt32(txtRespID.Text);
            fName = txtName.Text;
            fSurname = txtSurname.Text;
            //fDOB = Convert.ToInt32(txtDOB.Text);
            fStrNo = Convert.ToInt32(txtStrNo.Text);
            fStrName = txtStrName.Text;
            fCityID = Convert.ToInt32(txtCity.Text);
                        
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-PA4SGPS2\SQLEXPRESS;Initial Catalog = spCreateTables; Integrated Security = True"); //Connection to connect and update the database with the Respondents details
                conn.Open();
                SqlCommand SqlInsert = new SqlCommand($"INSERT INTO Respondent (RespID,Name, Surname, DOB, StreetNumber, StreetName,City)  VALUES ('"+Convert.ToInt32(txtRespID.Text)+ "', '"+txtName.Text +"', '"+txtSurname.Text + "','" + this.dateTimePicker1.Text + "','" + Convert.ToInt32(txtStrNo.Text) + "','" + txtStrName.Text + "', '" + Convert.ToInt32(txtCity.Text) + "') AND ", conn); 
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.InsertCommand = SqlInsert;
                adap.InsertCommand.ExecuteNonQuery();
                SqlCommand SqlCity = new SqlCommand("INSERT INTO City (CityID) VALUES ('" + Convert.ToInt32(txtCity.Text) + "");

                conn.Close();
                MessageBox.Show("Respondent Successfully Added and updated");
                
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Connection to connect and Delete the respondents data on the databse 
                conn.Open();
                string sql = "DELETE FROM Respondent WHERE RespID = Convert.ToInt32(txtRespID.Text)" ;
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader theReader = comm.ExecuteReader();

                conn.Close();
                MessageBox.Show("Respondent Successfully Deleted");

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
