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

namespace MaintainCityUC
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
        public int fCityID;
        public string fCityName;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fCityID = Convert.ToInt32(txtCityID.Text);
            fCityName = txtCityName.Text;
        try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-PA4SGPS2\SQLEXPRESS;Initial Catalog = spCreateTables; Integrated Security = True"); //Connection to connect and update the database with the Respondents details
                conn.Open();
                SqlCommand SqlInsert = new SqlCommand($"INSERT INTO City (CityID, CityName)  VALUES ('" + Convert.ToInt32(txtCityID.Text) + "', '" + txtCityName.Text + "',)", conn);
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.InsertCommand = SqlInsert;
                adap.InsertCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("City Successfully Added and updated");
            }
        
        
        
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection to connect and Delete the respondents data on the databse 
                conn.Open();
                string sql = "DELETE FROM City WHERE CityID = Convert.ToInt32(txt.CityID.Text)";
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader theReader = comm.ExecuteReader();

                conn.Close();
                MessageBox.Show("City Successfully Deleted");

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
