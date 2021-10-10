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
    public partial class LoginForm : Form
    {
        public string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\35968060\source\repos\valentinetobah\StatsSAQuestionnaireApp\StatsSAQuestionaireApp\StatsSADatabase.mdf;Integrated Security=True";
        public String query;
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader dataReader;
        public DataSet dataset;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();

                query = $"SELECT * FROM SystemUser WHERE Employee_ID = '{Convert.ToInt32(tbEmployeeID.Text)}'";

                if (systemUserExists(query, connection, dataReader))
                {
                    query = $"SELECT * FROM SystemUser WHERE Employee_ID = '{Convert.ToInt32(tbEmployeeID.Text)}' " +
                    $" AND password = '{tbPassword.Text}'";
                    
                    if (systemUserExists(query, connection, dataReader))
                    {
                        MainForm mainfrmObject = new MainForm();
                        mainfrmObject.emp_id = tbEmployeeID.Text;

                        tbPassword.Text = "";
                        tbEmployeeID.Text = "";

                        mainfrmObject.ShowDialog();
                    }
                    else
                    {
                        tbPassword.Text = "";
                        MessageBox.Show("Invalid Password. Please try again");
                    }
                      
                }
                else
                {
                    dataReader.Close();
                    adapter = new SqlDataAdapter();
                    string insertQuery = $"INSERT INTO SystemUser VALUES('{tbPassword.Text}'" +
                        $", '{Convert.ToInt32(tbEmployeeID.Text)}')";

                    command = new SqlCommand(insertQuery, connection);
                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();

                    tbPassword.Text = "";
                    tbEmployeeID.Text = "";

                    MessageBox.Show("User Registered Sucessfully !!!!!");
                }

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool systemUserExists(String query, SqlConnection con, SqlDataReader reader)
        {
            command = new SqlCommand(query, con);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tbPassword.Text = "";
            tbEmployeeID.Text = "";
            toolTipEmployeeIDTb.SetToolTip(tbEmployeeID, "Please enter a valid Employee ID");
            toolTipLoginRegisterBtn.SetToolTip(btnLoginRegister, "Click button to Login or Register");
            toolTipPasswordTb.SetToolTip(tbPassword, "Please enter a valid password");
        }
    }
}
