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

        public string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Dev\StatsSAQuestionnaireApp\StatsSAQuestionaireApp\StatsSADatabase.mdf;Integrated Security=True";
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

            if (string.Compare(selectedType,"Supervisor") == 1)
            {
                selectedType = "S";
            }
            else if (string.Compare(selectedType, "Manager") == 1)
            {
                selectedType = "M";
            }
            else if (string.Compare(selectedType, "DistrictManager") == 1)
            {
                selectedType = "DM";
            }
            else if (string.Compare(selectedType, "FieldWorker") == 1)
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

            if (string.Compare(selectedType, "Supervisor") == 1)
            {
                selectedType = "S";
            }
            else if (string.Compare(selectedType, "Manager") == 1)
            {
                selectedType = "M";
            }
            else if (string.Compare(selectedType, "DistrictManager") == 1)
            {
                selectedType = "DM";
            }
            else if (string.Compare(selectedType, "FieldWorker") == 1)
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


        //DELETE Employee RECORD
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

        //WHEN CLICKING ON SURVEY, LOAD DEFAULT VALUES
        private void tpSurveys_Click(object sender, EventArgs e)
        {
            loadDefaultSurveyValues();
        }


        //WHEN CLICKING ON EMPLOYEE, LOAD DEFAULT VALUES
        private void tpEmployee_Click(object sender, EventArgs e)
        {
            loadDefaultEmployeeValues();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadDefaultSurveyValues();
            loadDefaultQuestionnaireValues();
            loadDefaultEmployeeValues();
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

        private void btnExitSurvey_Click(object sender, EventArgs e)
        {
            this.Close()
;        }

        private void btnExitQuestionaires_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExxitEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbQuestionnaires_Click(object sender, EventArgs e)
        {
            loadDefaultQuestionnaireValues();
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


        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void dgSurveys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbEmplToUpdatte_TextChanged(object sender, EventArgs e)
        {

        }

        //CHECK IF EMPLOYEES UPDATE CHECKBOX IS CHECKED
        private void update_Employee_cb_CheckedChanged_1(object sender, EventArgs e)
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

        private void Type_empl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type_empl_selected = Type_empl.Text;
            Console.WriteLine(type_empl_selected);
        }

        private void btn_DeleteEmployee_Click_1(object sender, EventArgs e)
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
    }
}
