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
            lblRespIdS.Text = emp_id;
            lblRespIDRQ.Text = emp_id;
            lblRespIdEm.Text = emp_id;
            lblRespIdS.Text = emp_id;
            lblNameResp.Text = emp_id;
            lblnameCity.Text = emp_id;
            lblNameDistrict.Text = emp_id;

            loadDefaultSurveyValues();
            loadDefaultQuestionnaireValues();
            loadDefaultRespQuestionnaireValues();
            loadDefaultEmployeeValues();
            loadDefaultRespondentsValues();
            loadDefaultCityValues();
            loadDefaultDistrictValues();

            toolTipAddUpdateQnBtn.SetToolTip(btnAddUpdateQuestionnaire, "Click Button to insert new record update existing record");
            toolTipApproveBtn.SetToolTip(btnApproveRespQuestionnaire, "Click the button to approve the questionnaire with ID entered above");
            toolTipDeleteBtn.SetToolTip(btnDeleteQuestionnaire, "Click the button to delete the questionnaire with ID entered above");
            toolTipExitBtn.SetToolTip(btnExitQuestionaires, "Click button to exit");
            toolTipQuestionnaireDescTb.SetToolTip(tbQuestionnaireDesc, "Enter Questionnaire Description");
            toolTipQuestionnaireID.SetToolTip(tbQuestionnaireID, "Enter Questionniare ID");
            toolTipQuestionnaireID.SetToolTip(tbQuestionnaireIDToDelete, "Enter Questionniare ID");
            toolTipSurveyIDComboBox.SetToolTip(comboBoxSurveyID, "Enter Survey ID for Questionnaire");

        }

        //SELECT * FROM SURVEYS
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


        //SELECT ALL FROM EMPLOYEE
        private void selectEmployees()
        {
            try
            {
                string query = "SELECT * FROM Employee";
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                command = new SqlCommand(query, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Employee");

                dgEmployee.DataSource = dataset;
                dgEmployee.DataMember = "Employee";

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //CHECK IF THE UPDATE SURVEY CHECKBOX IS TICKED
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


        //UPDATE SURVEY CLICK
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

        //UPDATE EMPLOYEE CLICK
        private void btnAddUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                DialogResult result;

                if (update_Employee_cb.Checked && tbEmplIDToUpdate.Text.Length > 0)
                {
                    result = updateExistingEmplyee(adapter, connection);
                }
                else
                {
                    result = insertNewEmployee(adapter, connection);
                }

                connection.Close();

                if (result == DialogResult.OK)
                {
                    tbEmplIDToUpdate.Text = "";
                    tbName.Text = "";
                    tbLastname.Text = "";
                    Type_empl.SelectedItem = "";
                    selectEmployees();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //INSERT NEW RECORD TO SURVEY TABLE
        private DialogResult insertNewRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string insertQuery = $"INSERT INTO Survey VALUES('{tbSurveyName.Text}', " +
                   $"'{dtpStartDate.Value}', '{dtpEndDate.Value}')";

            command = new SqlCommand(insertQuery, con);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            return MessageBox.Show("New Survey Sucessfully Added !!!!");
        }


        //INSERT RECORD TO EMPLOYEE TABLE
        private DialogResult insertNewEmployee(SqlDataAdapter adapter, SqlConnection con)
        {


            string selectedType = Type_empl.SelectedItem.ToString();


            if (selectedType == "Supervisor")
            {
                selectedType = "S";
            }
            else if (selectedType == "Manager")
            {
                selectedType = "M";
            }
            else if (selectedType == "DistrictManager")
            {
                selectedType = "DM";
            }
            else if (selectedType == "FieldWorker")
            {
                selectedType = "F";
            }

            string insertQuery = $"INSERT INTO Employee (Name, LastName, Type_empl) VALUES ('{tbName.Text}','{tbLastname.Text}','{selectedType}')";

            command = new SqlCommand(insertQuery, con);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            return MessageBox.Show("New Employee Sucessfully Added !!!!");
        }



        //UPDATE EXISTING SURVEY RECORD
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

        private DialogResult updateExistingEmplyee(SqlDataAdapter adapter, SqlConnection con)
        {

            string selectedType = Type_empl.SelectedItem.ToString();


            if (selectedType == "Supervisor")
            {
                selectedType = "S";
            }
            else if (selectedType == "Manager")
            {
                selectedType = "M";
            }
            else if (selectedType == "DistrictManager")
            {
                selectedType = "DM";
            }
            else if (selectedType == "FieldWorker")
            {
                selectedType = "F";
            }


            string updateQuery = $"Update Employee SET Name = '{tbName.Text}', " +
                   $"LastName = '{tbLastname.Text}', Type_empl ='{selectedType}'" +
                   $"WHERE Empl_ID = '{Convert.ToInt32(tbEmplIDToUpdate.Text)}'";

            command = new SqlCommand(updateQuery, con);
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();

            return MessageBox.Show("Employee with ID: " + tbEmplIDToUpdate.Text
                + " Sucessfully Updated !!!!");
        }


        //DELETE EXISTING SURVEY RECORD
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
                   $" AND QN_ID = '{Convert.ToInt32(comboBoxQuestionnaireIDApprove.Text)}'";

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
                   $"'N', null, '{emp_id}')";

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
                   $"Field_Worker = '{emp_id}'" +
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

   

        private void ExxitEmployee_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //CHECK IF EMPLOYEES UPDATE CHECKBOX IS CHECKED
        private void update_Employee_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (update_Employee_cb.Checked)
            {
                tbEmplIDToUpdate.Enabled = true;
            }
            else
            {
                tbEmplIDToUpdate.Enabled = false;
            }

        }

        private void btnAddUpdateEmployee_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                DialogResult result;

                if (update_Employee_cb.Checked && tbEmplIDToUpdate.Text.Length > 0)
                {
                    result = updateExistingEmplyee(adapter, connection);
                }
                else
                {
                    result = insertNewEmployee(adapter, connection);
                }

                connection.Close();

                if (result == DialogResult.OK)
                {
                    tbEmplIDToUpdate.Text = "";
                    tbName.Text = "";
                    tbLastname.Text = "";
                    Type_empl.SelectedItem = "";
                    selectEmployees();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                int empl_id = Convert.ToInt32(tbEmplDtoDelete.Text);
                string deleteQuery = $"DELETE FROM Employee WHERE Empl_ID = {empl_id}";
                command = new SqlCommand(deleteQuery, connection);
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                connection.Close();

                DialogResult result = MessageBox.Show("Employee sucessfully deleted !!!");
                if (result == DialogResult.OK)
                {
                    tbName.Text = "";
                    tbLastname.Text = "";
                    Type_empl.ResetText();
                    selectEmployees();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void loadDefaultEmployeeValues()
        {
            tbEmplIDToUpdate.Text = "";
            tbName.Text = "";
            tbLastname.Text = "";
            Type_empl.SelectedItem = "";

            if (!update_Employee_cb.Checked)
            {
                tbEmplIDToUpdate.Enabled = false;

            }

            selectEmployees();
        }

        private void loadDefaultRespondentsValues()
        {
            tbRespCityID.Text = "";
            tbRespID.Text = "";
            tbRespIDDelete.Text = "";

            tbRespLastName.Text = "";
            tbRespName.Text = "";
            tbRespStreetName.Text = "";
            tbRespStreetnNo.Text = "";
            tbRespCityID.Text = "";


            if (!chbIsRespUpdate.Checked)
            {
                tbRespID.Enabled = false;

            }

            selectRespondents();
        }

        private void loadDefaultCityValues()
        {
            tbCityID.Text = "";
            tbCityIdDelete.Text = "";
            tbCityName.Text = "";


            if (!chbIsCityUpdate.Checked)
            {
                tbCityID.Enabled = false;

            }

            selectCities();
        }

        private void loadDefaultDistrictValues()
        {
            tbDistrictID.Text = "";
            tbDistrictIdDelete.Text = "";
            tbDistrictName.Text = "";


            if (!chbIsDistrictUpdate.Checked)
            {
                tbDistrictID.Enabled = false;

            }

            selecDistricts();
        }

        private void selecDistricts()
        {
            try
            {
                string query = "SELECT * FROM District";
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                command = new SqlCommand(query, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "District");

                dgDistricts.DataSource = dataset;
                dgDistricts.DataMember = "District";

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void selectCities()
        {
            try
            {
                string query = "SELECT * FROM City";
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                command = new SqlCommand(query, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "City");

                dgCities.DataSource = dataset;
                dgCities.DataMember = "City";

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRespExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectRespondents()
        {
            try
            {
                string query = "SELECT * FROM Respondent";
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                command = new SqlCommand(query, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Respondent");

                dgRespondents.DataSource = dataset;
                dgRespondents.DataMember = "Respondent";

                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddUpdateResp_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                DialogResult result;

                if (chbIsRespUpdate.Checked && tbRespID.Text.Length > 0)
                {
                    result = updateExistingRespondentRecord(adapter, connection);
                }
                else
                {
                    result = insertRespondentNewRecord(adapter, connection);
                }

                connection.Close();

                if (result == DialogResult.OK)
                {
                    loadDefaultRespondentsValues();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DialogResult updateExistingRespondentRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string updateQuery = $"Update Respondent SET Name = '{tbRespName.Text}', LastName = '{tbRespLastName.Text}'," +
                   $"DOB = '{dtpRespDob.Value}', Street_No_Addr ='{Convert.ToInt32(tbRespStreetnNo.Text)}', " +
                   $"Street_Name = '{tbRespStreetName.Text}', City_ID ='{Convert.ToInt32(tbRespCityID.Text)}'" +
                   $"WHERE Resp_ID = '{Convert.ToInt32(tbRespID.Text)}'";

            command = new SqlCommand(updateQuery, con);
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();

            return MessageBox.Show("Respondent with ID: " + tbRespID.Text
                + " Sucessfully Updated !!!!");
        }

        private DialogResult insertRespondentNewRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string insertQuery = $"INSERT INTO Respondent VALUES('{tbRespName.Text}', '{tbRespLastName.Text}'," +
                   $"'{dtpRespDob.Value}', '{Convert.ToInt32(tbRespStreetnNo.Text)}', '{tbRespStreetName.Text}', " +
                   $"'{Convert.ToInt32(tbRespCityID.Text)}')";

            command = new SqlCommand(insertQuery, con);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            return MessageBox.Show("New Respondent Sucessfully Added !!!!");
        }

        private void btnDeleteResp_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                command = new SqlCommand($"DELETE FROM Respondent WHERE Resp_ID = '{Convert.ToInt32(tbRespIDDelete.Text)}'", connection);
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                connection.Close();

                DialogResult result = MessageBox.Show("Respondent sucessfully deleted !!!");
                if (result == DialogResult.OK)
                {
                    loadDefaultRespondentsValues();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chbIsRespUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsRespUpdate.Checked)
            {
                tbRespID.Enabled = true;
            }
            else
            {

                tbRespID.Enabled = false;
            }
        }

        private void btnExitCity_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbIsCityUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsCityUpdate.Checked)
            {
                tbCityID.Enabled = true;
            }
            else
            {
                tbCityID.Enabled = false;
            }
        }

        private void btnAddUpdateCity_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                DialogResult result;

                if (chbIsCityUpdate.Checked && tbCityID.Text.Length > 0)
                {
                    result = updateExistingCityRecord(adapter, connection);
                }
                else
                {
                    result = insertNewCityRecord(adapter, connection);
                }

                connection.Close();

                if (result == DialogResult.OK)
                {
                    loadDefaultCityValues();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DialogResult updateExistingCityRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string updateQuery = $"Update City SET City_Name = '{tbCityName.Text}'" +
                   $"WHERE City_ID = '{Convert.ToInt32(tbCityID.Text)}'";

            command = new SqlCommand(updateQuery, con);
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();

            return MessageBox.Show("City with ID: " + tbCityID.Text + " Sucessfully Updated !!!!");
        }

        private DialogResult insertNewCityRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string insertQuery = $"INSERT INTO City VALUES('{tbCityName.Text}')";

            command = new SqlCommand(insertQuery, con);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            return MessageBox.Show("New City Sucessfully Added !!!!");
        }

        private void btnDeleteCity_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                command = new SqlCommand($"DELETE FROM City WHERE City_ID = '{Convert.ToInt32(tbCityIdDelete.Text)}'", connection);
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                connection.Close();

                DialogResult result = MessageBox.Show("City sucessfully deleted !!!");
                if (result == DialogResult.OK)
                {
                    loadDefaultCityValues();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExitdistrict_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUpdateDistrict_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                DialogResult result;

                if (chbIsDistrictUpdate.Checked && tbDistrictID.Text.Length > 0)
                {
                    result = updateExistingDistrictRecord(adapter, connection);
                }
                else
                {
                    result = insertNewDistrictRecord(adapter, connection);
                }

                connection.Close();

                if (result == DialogResult.OK)
                {
                    loadDefaultDistrictValues();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteDistrict_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                adapter = new SqlDataAdapter();

                command = new SqlCommand($"DELETE FROM District WHERE District_ID = '{Convert.ToInt32(tbDistrictIdDelete.Text)}'", connection);
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                connection.Close();

                DialogResult result = MessageBox.Show("District sucessfully deleted !!!");
                if (result == DialogResult.OK)
                {
                    loadDefaultDistrictValues();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DialogResult updateExistingDistrictRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string updateQuery = $"Update District SET District_Name = '{tbDistrictName.Text}'" +
                   $"WHERE District_ID = '{Convert.ToInt32(tbDistrictID.Text)}'";

            command = new SqlCommand(updateQuery, con);
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();

            return MessageBox.Show("District with ID: " + tbDistrictID.Text + " Sucessfully Updated !!!!");
        }

        private DialogResult insertNewDistrictRecord(SqlDataAdapter adapter, SqlConnection con)
        {
            string insertQuery = $"INSERT INTO District VALUES('{tbDistrictName.Text}')";

            command = new SqlCommand(insertQuery, con);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            return MessageBox.Show("New District Sucessfully Added !!!!");
        }

        private void chbIsDistrictUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsDistrictUpdate.Checked)
            {
                tbDistrictID.Enabled = true;
            }
            else
            {
                tbDistrictID.Enabled = false;
            }
        }
    }
}
