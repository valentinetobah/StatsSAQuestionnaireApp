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


namespace StatsSAQuestionaireApp
{
    public partial class Add_empl : Form
    {
        //public SqlConnection con;

        ////Declaring public values
        //String connectionString = @"Data Source=SHANÉ-PC\SQLEXPRESS;Initial Catalog=StatsSADb;Integrated Security=True";

        //SqlCommand command;

        //public SqlDataAdapter data_adapter;
        //DataSet ds;
        //SqlDataReader dr;

        public string eName;
        public string eLastName;
        public string eTypeOfEmpl;

        public Add_empl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try {

                eName = textBox1.Text;
                eLastName = textBox2.Text;
                eTypeOfEmpl = comboBox1.SelectedItem.ToString();

                label3.Text = eName;
                label4.Text = eLastName;
                label5.Text = eTypeOfEmpl;

                SqlConnection connection = new SqlConnection(@"Data Source=SHANÉ-PC\SQLEXPRESS;Initial Catalog=StatsSADb;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("sp_insert_empl", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@name";
                param.Value = eName;

                //SqlParameter param = new SqlParameter();
                param.ParameterName = "@LastName";
                param.Value = eLastName;

                //SqlParameter param = new SqlParameter();
                param.ParameterName = "@type";
                param.Value = eTypeOfEmpl;



                cmd.Parameters.AddWithValue("@name", eName);
                cmd.Parameters.AddWithValue("@LastName", eLastName);
                cmd.Parameters.AddWithValue("@type", eTypeOfEmpl);
                connection.Open();
                int i = cmd.ExecuteNonQuery();
                connection.Close();

                if (i != 0)
                {
                    MessageBox.Show(i + "Data Saved");

                }

            }

            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        
        }
    }
}
