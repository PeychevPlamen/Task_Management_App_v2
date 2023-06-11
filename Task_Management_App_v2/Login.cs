using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management_App_v2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Task_Management_App_v2\Task_Management_App_v2\Task_Management_App_v2\Database.mdf;Integrated Security=True");

            string query = "select * from Users where Username = '" + BoxUsername.Text.Trim() + "' and Password = '" + TextBoxPassword.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);

            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Welcome to Task Management " + BoxUsername.Text);

                Main objMain = new Main();
                this.Hide();
                objMain.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
