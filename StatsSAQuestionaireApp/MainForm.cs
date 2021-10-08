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
    public partial class MainForm : Form
    {
        public string emp_id { set; get; }

        public string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\35968060\source\repos\valentinetobah\StatsSAQuestionnaireApp\StatsSAQuestionaireApp\StatsSADatabase.mdf;Integrated Security=True";
        public String query;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader dataReader;
        public DataSet dataset;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadDefaultSurveyValues();
            loadDefaultQuestionnaireValues();
            loadDefaultRespQuestionnaireValues();

            toolTipAddUpdateQnBtn.SetToolTip(btnAddUpdateQuestionnaire, "Click Button to insert new record update existing record");
            toolTipApproveBtn.SetToolTip(btnApproveRespQuestionnaire, "Click the button to approve the questionnaire with ID entered above");
            toolTipDeleteBtn.SetToolTip(btnDeleteQuestionnaire, "Click the button to delete the questionnaire with ID entered above");
            toolTipExitBtn.SetToolTip(btnExitQuestionaires, "Click button to exit");
            toolTipQuestionnaireDescTb.SetToolTip(tbQuestionnaireDesc, "Enter Questionnaire Description");
            toolTipQuestionnaireID.SetToolTip(tbQuestionnaireID, "Enter Questionniare ID");
            toolTipQuestionnaireID.SetToolTip(tbQuestionnaireIDToDelete, "Enter Questionniare ID");
            toolTipSurveyIDComboBox.SetToolTip(comboBoxSurveyID, "Enter Survey ID for Questionnaire");

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
        private void cbIsUpdate_CheckedChanged_1(object sender, EventArgs e)
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

        private void btnAddUpdateSurvey_Click(object sender, EventArgs e)
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
                    selectSurveys();
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

            return MessageBox.Show("Survey with ID: " + tbSurveyIDToUpdate.Text
                + " Sucessfully Updated !!!!");
        }
        private void btnDeleteSurvey_Click_1(object sender, EventArgs e)
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
                    selectSurveys();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadDefaultSurveyValues()
        {
            tbSurveyID.Text = "";
            tbSurveyIDToUpdate.Text = "";
            tbSurveyName.Text = "";

            if (!cbIsUpdate.Checked)
            {
                tbSurveyIDToUpdate.Enabled = false;
            }

            selectSurveys();
        }
        private void selectQuestionnaires()
        {
            try
            {
                string query = "SELECT * FROM Questionnaire";
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                command = new SqlCommand(query, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Questionnaire");

                dgQuestionnaires.DataSource = dataset;
                dgQuestionnaires.DataMember = "Questionnaire";

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void loadDefaultQuestionnaireValues()
        {
            tbQuestionnaireID.Text = "";
            tbQuestionnaireIDToDelete.Text = "";
            tbQuestionnaireDesc.Text = "";

            if (!cbIsQuestionnaireUpdate.Checked)
            {
                tbQuestionnaireID.Enabled = false;
            }

            selectQuestionnaires();
            populateSurveyIDComboBox();
        }

        private void cbIsQuestionnaireUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsQuestionnaireUpdate.Checked)
            {
                tbQuestionnaireID.Enabled = true;
            }
            else
            {
                tbQuestionnaireID.Enabled = false;
            }
        }

        private void populateSurveyIDComboBox()
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                query = "SELECT Survey_ID FROM Survey";
                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                comboBoxSurveyID.Items.Clear();

                while (dataReader.Read())
                {
                    comboBoxSurveyID.Items.Add(dataReader.GetValue(0));
                }

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddUpdateQuestionnaire_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                DialogResult result;

                if (cbIsQuestionnaireUpdate.Checked && tbQuestionnaireID.Text.Length > 0)
                {
                    result = updateQuestionnaireExistingRecord(adapter, connection);
                }
                else
                {
                    result = insertQuestionnaireNewRecord(adapter, connection);
                }

                connection.Close();

                if (result == DialogResult.OK)
                {
                    tbQuestionnaireID.Text = "";
                    tbQuestionnaireIDToDelete.Text = "";
                    tbQuestionnaireDesc.Text = "";
                    selectQuestionnaires();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DialogResult insertQuestionnaireNewRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string insertQuery = $"INSERT INTO Questionnaire VALUES('{Convert.ToInt32(comboBoxSurveyID.Text)}', " +
                   $"'{tbQuestionnaireDesc.Text}')";

            command = new SqlCommand(insertQuery, con);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            return MessageBox.Show("New Questionnaire Sucessfully Added !!!!");
        }

        private DialogResult updateQuestionnaireExistingRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string updateQuery = $"Update Questionnaire SET Description = '{tbQuestionnaireDesc.Text}', " +
                   $"Survey_ID = '{Convert.ToInt32(comboBoxSurveyID.Text)}'" +
                   $"WHERE QN_ID = '{Convert.ToInt32(tbQuestionnaireID.Text)}'";

            command = new SqlCommand(updateQuery, con);
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();

            return MessageBox.Show("Questionnaire with ID: " + tbQuestionnaireID.Text
                + " Sucessfully Updated !!!!");
        }

        private void btnDeleteQuestionnaire_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                int qn_id = Convert.ToInt32(tbQuestionnaireIDToDelete.Text);
                command = new SqlCommand($"DELETE FROM Questionnaire WHERE QN_ID = '{qn_id}'", connection);
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                connection.Close();

                DialogResult result = MessageBox.Show("Questionnaire sucessfully deleted !!!");
                if (result == DialogResult.OK)
                {
                    tbQuestionnaireIDToDelete.Text = "";
                    selectQuestionnaires();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnApproveRespQuestionnaire_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                string updateQuery = $"Update RespondentQuestionnaire SET Approved_YN = 'Y', " +
                   $"Approved_by = '{Convert.ToInt32(emp_id)}' WHERE Resp_ID = '{Convert.ToInt32(comboBoxRespIDApprove.Text)}'" +
                   $" AND Resp_ID = '{Convert.ToInt32(comboBoxQuestionnaireIDApprove.Text)}'";

                command = new SqlCommand(updateQuery, connection);
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Respondent and Questionnaire with ID's "
                    + comboBoxRespIDApprove.Text + " and " + comboBoxQuestionnaireIDApprove.Text
                    + " respectively have been Approved !!!!");

                connection.Close();

                if (result == DialogResult.OK)
                {
                    selectRespondentQuestionnaires();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectRespondentQuestionnaires()
        {
            try
            {
                string query;

                if (isCurrentUserManager())
                {
                    query = $"SELECT * FROM RespondentQuestionnaire";
                }
                else
                {
                    query = $"SELECT * FROM RespondentQuestionnaire WHERE Field_Worker =" +
                    $" '{Convert.ToInt32(emp_id)}'";
                }

                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                command = new SqlCommand(query, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "RespondentQuestionnaire");

                dgRespQuestionnaires.DataSource = dataset;
                dgRespQuestionnaires.DataMember = "RespondentQuestionnaire";

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void populateDistrictComboBox()
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                query = "SELECT District_ID FROM District";
                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                comboBoxDistrictID.Items.Clear();

                while (dataReader.Read())
                {
                    comboBoxDistrictID.Items.Add(dataReader.GetValue(0));
                }

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void populateFieldworkerComboBox()
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                query = "SELECT * FROM Employee WHERE Type_empl = 'F'";
                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                comboBoxFieldworker.Items.Clear();

                while (dataReader.Read())
                {
                    comboBoxFieldworker.Items.Add(dataReader.GetValue(0));
                }

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void populateRespondentComboBox()
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                query = "SELECT Resp_ID FROM Respondent";
                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                comboBoxRespID.Items.Clear();
                comboBoxRespIDApprove.Items.Clear();

                while (dataReader.Read())
                {
                    comboBoxRespID.Items.Add(dataReader.GetValue(0));
                    comboBoxRespIDApprove.Items.Add(dataReader.GetValue(0));
                }

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void populateQuestionnaireIDComboBoxForRespId()
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();
                if (chbIsRespQuestionnaireUpdate.Checked)
                {
                    query = $"SELECT QN_ID FROM RespondentQuestionnaire WHERE Resp_ID = " +
                        $"'{Convert.ToInt32(comboBoxRespID.Text)}'";
                }
                else
                {
                    query = "SELECT QN_ID FROM Questionnaire";
                }
                
                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                comboBoxQuestionnaireID.Items.Clear();

                while (dataReader.Read())
                {
                    comboBoxQuestionnaireID.Items.Add(dataReader.GetValue(0));
                }

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void populateQuestionnaireIDComboBoxForRespIdForApproval()
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();
                query = $"SELECT QN_ID FROM RespondentQuestionnaire WHERE Resp_ID = " +
                    $"'{Convert.ToInt32(comboBoxRespIDApprove.Text)}'";

                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                comboBoxQuestionnaireIDApprove.Items.Clear();

                while (dataReader.Read())
                {
                    comboBoxQuestionnaireIDApprove.Items.Add(dataReader.GetValue(0));
                }

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool isCurrentUserManager()
        {
            bool isManager = false;
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                query = $"SELECT * FROM Employee WHERE Empl_ID = '{Convert.ToInt32(emp_id)}' " +
                    $"AND Type_empl = 'M'";
                command = new SqlCommand(query, connection);
                dataReader = command.ExecuteReader();

                comboBoxDistrictID.Items.Clear();

                if (dataReader.HasRows)
                {
                    isManager = true;
                }

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

            return isManager;
        }
        private void comboBoxRespID_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateQuestionnaireIDComboBoxForRespId();
        }
        private void comboBoxRespIDApprove_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateQuestionnaireIDComboBoxForRespIdForApproval();
        }
        private void btnAddUpdateRespQuestionnaire_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                DialogResult result;

                if (!chbIsRespQuestionnaireUpdate.Checked )
                {
                    result = insertRespQuestionnaireNewRecord(adapter, connection);
                }
                else if(comboBoxRespID.Text.Length > 0
                    && comboBoxQuestionnaireID.Text.Length > 0)
                {
                    result = updateRespQuestionnaireExistingRecord(adapter, connection);
                }
                else
                {
                    result = MessageBox.Show("Please fill in the required fields");
                }

                connection.Close();

                if (result == DialogResult.OK)
                {
                    loadDefaultRespQuestionnaireValues();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DialogResult insertRespQuestionnaireNewRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string insertQuery = $"INSERT INTO RespondentQuestionnaire VALUES('{Convert.ToInt32(comboBoxRespID.Text)}', " +
                   $"'{comboBoxQuestionnaireID.Text}', '{dtpCompletedDate.Value}', '{Convert.ToInt32(comboBoxDistrictID.Text)}', " +
                   $"'N', 'null', '{Convert.ToInt32(comboBoxFieldworker.Text)}')";

            command = new SqlCommand(insertQuery, con);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            return MessageBox.Show("New Respondent Questionnaire Sucessfully Added !!!!");
        }

        private DialogResult updateRespQuestionnaireExistingRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string updateQuery = $"Update RespondentQuestionnaire SET Date_Completed = '{dtpCompletedDate.Value}', " +
                   $"District_ID = '{Convert.ToInt32(comboBoxDistrictID.Text)}', " +
                   $"Approved_By = null, " +
                   $"Field_Worker = '{Convert.ToInt32(comboBoxFieldworker.Text)}'" +
                   $"WHERE Resp_ID = '{Convert.ToInt32(comboBoxRespID.Text)}'" +
                   $"AND QN_ID = '{Convert.ToInt32(comboBoxQuestionnaireID.Text)}'";

            command = new SqlCommand(updateQuery, con);
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();

            return MessageBox.Show("Respondent and Questionnaire with ID's " + comboBoxRespID.Text 
                + " and " + comboBoxQuestionnaireID.Text + " Sucessfully Updated !!!!");
        }

        private void tpSurveys_Click(object sender, EventArgs e)
        {
            loadDefaultSurveyValues();
        }
        private void tbQuestionnaires_Click(object sender, EventArgs e)
        {
            loadDefaultQuestionnaireValues();
        }
        private void tbRespQuestionnaires_Click(object sender, EventArgs e)
        {
            loadDefaultRespQuestionnaireValues();
        }

        private void loadDefaultRespQuestionnaireValues()
        {
            if (!isCurrentUserManager())
            {
                btnApproveRespQuestionnaire.Enabled = false;
            }
            selectRespondentQuestionnaires();
            populateDistrictComboBox();
            populateFieldworkerComboBox();
            populateRespondentComboBox();
        }

        private void btnExitSurvey_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExitQuestionaires_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
