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
            if (!cbIsUpdate.Checked)
            {
                tbSurveyIDToUpdate.Enabled = false;
            }
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

                DialogResult result;

                if (cbIsUpdate.Checked && tbSurveyIDToUpdate.Text.Length > 0)
                {
                    result = updateExistingRecord(adapter, connection);
                }
                else
                {
                    result = insertNewRecord(adapter, connection);
                }

                connection.Close();

                if (result == DialogResult.OK)
                {
                    tbSurveyIDToUpdate.Text = "";
                    tbSurveyName.Text = "";
                    Survey_Load(sender, e);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DialogResult insertNewRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string insertQuery = $"INSERT INTO Survey VALUES('{tbSurveyName.Text}', " +
                   $"'{dtpStartDate.Value}', '{dtpEndDate.Value}')";

            command = new SqlCommand(insertQuery, con);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            return MessageBox.Show("New Survey Sucessfully Added !!!!");
        }

        private DialogResult updateExistingRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string updateQuery = $"Update Survey SET Name = '{tbSurveyName.Text}', " +
                   $"StartDate = '{dtpStartDate.Value}', EndDate ='{dtpEndDate.Value}'" +
                   $"WHERE Survey_ID = '{Convert.ToInt32(tbSurveyIDToUpdate.Text)}'";

            command = new SqlCommand(updateQuery, con);
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();

            return MessageBox.Show("Survey with ID: "+ tbSurveyIDToUpdate.Text
                + " Sucessfully Updated !!!!");
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

        private void cbIsUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsUpdate.Checked)
            {
                tbSurveyIDToUpdate.Enabled = true;
            }
            else
            {
                tbSurveyIDToUpdate.Enabled = false;
            }
        }
    }
}
