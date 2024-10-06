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
namespace Marksheet_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O2OKVFM\SQLEXPRESS;Initial Catalog=Marksheetdb;Integrated Security=True;Encrypt=False");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string un = username.Text;  // Gets the username from the text box
            string pwd = password.Text;  // Gets the password from the text box

            try
            {
                string querry = "SELECT * FROM login_table WHERE username = '" + un + "' AND password = '" + pwd + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    AdminDashboard Admin = new AdminDashboard();
                    Admin.Show();
                    this.Hide();
                }
                else
                {
                    username.Clear();
                    password.Clear(); 
                    username.Focus();
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

// AppState.cs
namespace Marksheet_Project
{
    // Class to manage global state
    public static class AppState
    {
        // Static variable to store the student roll number
        public static int StudentRoll { get; set; }

        // You can add other global variables here
        public static string StudentName { get; set; }
    }
}

