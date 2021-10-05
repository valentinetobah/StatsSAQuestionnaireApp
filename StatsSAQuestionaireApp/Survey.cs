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
/**
 * Name: VN Tobah
 * Student Number: 35968060
 *
 */
namespace StatsSAQuestionaireApp
{
    public partial class Survey : Form
    {
        public string emp_id { set; get; }

        public string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\35968060\source\repos\valentinetobah\StatsSAQuestionnaireApp\StatsSAQuestionaireApp\StatsSADatabase.mdf;Integrated Security=True";
        public String query;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader dataReader;
        public DataSet dataset;
        public Survey()
        {
            InitializeComponent();
        }

        private void Survey_Load(object sender, EventArgs e)
        {

            selectSurveys();
        }

        private void selectSurveys()
        {
            try
            {
                string query = "SELECT * FROM Survey";
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                command = new SqlCommand(query, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Survey");

                dgSurveys.DataSource = dataset;
                dgSurveys.DataMember = "Survey";

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNewSurvey_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                string insertQuery = $"INSERT INTO Survey VALUES('{tbSurveyName.Text}', " +
                    $"'{dtpStartDate.Value}', '{dtpEndDate.Value}')";

                command = new SqlCommand(insertQuery, connection);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                connection.Close();

                DialogResult result = MessageBox.Show("New Survey Sucessfully Added !!!!");
                if(result == DialogResult.OK)
                {
                    tbSurveyName.Text = "";
                    Survey_Load(sender, e);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteSurvey_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                int survey_id = Convert.ToInt32(tbSurveyID.Text);
                command = new SqlCommand($"DELETE FROM Survey WHERE Survey_ID = '{survey_id}'", connection);
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                connection.Close();
                
                DialogResult result = MessageBox.Show("Survey sucessfully deleted !!!");
                if (result == DialogResult.OK)
                {
                    tbSurveyName.Text = "";
                    Survey_Load(sender, e);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
