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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void add_empl_Click(object sender, EventArgs e)
        {
            Add_empl frm2 = new Add_empl();
            frm2.Show();

        }
    }
}
