using ClosedXML.Excel;
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
    public partial class Main : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Task_Management_App_v2\Task_Management_App_v2\Task_Management_App_v2\Database.mdf;Integrated Security=True");

        public Main()
        {
            InitializeComponent();
            disp_data();
        }

        public void disp_data()
        {
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from UserTasks";
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter dateAdap = new SqlDataAdapter(cmd);
            dateAdap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
            dataGridView3.DataSource = dt;
            sqlCon.Close();
        }

        private void btnLogOutCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPg = new Login();
            loginPg.Show();
        }

        private void btnLogoutEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPg = new Login();
            loginPg.Show();
        }

        private void btnLogoutDel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPg = new Login();
            loginPg.Show();
        }

        private void btnExportToFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.appData.UserTasks.CopyToDataTable(), "UserTasks");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("You have successfully exported your data to a file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into UserTasks(Title, Description) Values(@Title, @Description)";
            cmd.Parameters.AddWithValue("@Title", textTitle.Text);
            cmd.Parameters.AddWithValue("@Description", textDescription.Text);

            cmd.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("Task added");

            //tbClientID.Text = "";
            textTitle.Text = "";
            textDescription.Text = "";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.UserTasks' table. You can move, or remove it, as needed.
            this.userTasksTableAdapter.Fill(this.appData.UserTasks);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editPage.Show();
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UserTasks SET Title='" + textBoxTitleEdit.Text + "', Description='" + textBoxDescriptionEdit.Text + "' WHERE ID='" + textBoxID.Text + "'", sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("Task updated");

            textBoxID.Text = "";
            textBoxTitleEdit.Text = "";
            textBoxDescriptionEdit.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM UserTasks WHERE ID='" + textBoxIdDel.Text + "'", sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("Task deleted");

            textBoxTitleDel.Text = "";
            textBoxIdDel.Text = "";
        }

        private void btnSearchDel_Click(object sender, EventArgs e)
        {
            string sql = "Select * from UserTasks where ID = '" + textBoxIdDel.Text + "' OR Title = '" + textBoxTitleDel.Text + "'";
            SqlCommand com = new SqlCommand(sql, sqlCon);
            sqlCon.Open();
            DataSet data = new DataSet();
            var adapter = new SqlDataAdapter(com);
            adapter.Fill(data);
            int count = data.Tables[0].Rows.Count;
            sqlCon.Close();

            if (count > 0)
            {
                textBoxIdDel.Text = data.Tables[0].Rows[0]["ID"].ToString();
                textBoxTitleDel.Text = data.Tables[0].Rows[0]["Title"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID or Title", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "Select * from UserTasks where ID = '" + textBoxID.Text + "' OR Title = '" + textBoxTitleEdit.Text + "'";
            SqlCommand com = new SqlCommand(sql, sqlCon);
            sqlCon.Open();
            DataSet data = new DataSet();
            var adapter = new SqlDataAdapter(com);
            adapter.Fill(data);
            int count = data.Tables[0].Rows.Count;
            sqlCon.Close();
            if (count > 0)
            {
                textBoxID.Text = data.Tables[0].Rows[0]["ID"].ToString();
                textBoxTitleEdit.Text = data.Tables[0].Rows[0]["Title"].ToString();
                textBoxDescriptionEdit.Text = data.Tables[0].Rows[0]["Description"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID or Title", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
