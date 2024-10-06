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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Marksheet_Project
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O2OKVFM\SQLEXPRESS;Initial Catalog=Marksheetdb;Integrated Security=True;Encrypt=False");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            int rollno = Convert.ToInt32(roll.Text);
            AppState.StudentRoll = rollno;
            try
            {
                string querry = "SELECT * FROM StudentMarksheet WHERE Roll = '" + rollno + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    string studentName = dtable.Rows[0]["Name"].ToString();
                    Showing_Marksheet SM = new Showing_Marksheet();
                    SM.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No student found");
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
    }
}
