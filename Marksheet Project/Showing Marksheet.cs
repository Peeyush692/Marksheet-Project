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

namespace Marksheet_Project
{
    public partial class Showing_Marksheet : Form
    {
        public Showing_Marksheet()
        {
            InitializeComponent();
        }

        // Using the existing connection object
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O2OKVFM\SQLEXPRESS;Initial Catalog=Marksheetdb;Integrated Security=True;Encrypt=False");

        string studentName;
        int studentRoll;

        // Method to set the student name and roll number
        public void SetStudentName(string name, int rn)
        {
            stdname2.Text = name; // Set the label text to the student name
            studentName = name;
            studentRoll = rn;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content clicks if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label click event (can be left empty if unused)
        }

        // Fetch and display the marksheet when the form loads
        private void Showing_Marksheet_Load(object sender, EventArgs e)
        {
            // Automatically fetch and display the marksheet for the studentRoll
            FetchMarksheet(AppState.StudentRoll);
        }

        // Method to fetch marksheet for the given roll number
        private void FetchMarksheet(int rn)
        {
            // SQL query to fetch marksheet based on roll number
            string query = "SELECT ID, Roll, Name, Subject, OM, FM, PM FROM StudentMarksheet WHERE Roll = @rn";

            // Use the existing conn object for the database connection
            using (SqlConnection con = conn)
            {
                try
                {
                    // Open the connection
                    con.Open();

                    // Create a SQL command
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameter to SQL command
                        cmd.Parameters.AddWithValue("@rn", rn);

                        // Execute the query and load the data into a DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                       // MessageBox.Show("Search roll: " + AppState.StudentRoll);
                        // Check if data was returned
                        if (dt.Rows.Count > 0)
                        {
                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dt;

                            CalculateAndDisplayPercentage(dt);
                        }
                        else
                        {
                            MessageBox.Show("No data found for this roll number.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection after use
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to save the changes?", "Confirm Update", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // If the user confirms, save the changes
                SaveChangesToDatabase();
            }
        }


        // Method to save changes to the database
        private void SaveChangesToDatabase()
        {
             conn = new SqlConnection(@"Data Source=DESKTOP-O2OKVFM\SQLEXPRESS;Initial Catalog=Marksheetdb;Integrated Security=True;Encrypt=False");

            // Ensure connection string is initialized
            if (conn == null || string.IsNullOrEmpty(conn.ConnectionString))
            {
                MessageBox.Show("Error: The connection string has not been initialized properly.");
                return;
            }

            try
            {
                // Open the connection
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open(); // Open the database connection
                }

                // Loop through each row in the DataGridView and update the database
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue; // Skip new/empty row

                    int id = Convert.ToInt32(row.Cells["ID"].Value); // ID is the primary key
                    int roll = Convert.ToInt32(row.Cells["Roll"].Value);
                    string name = row.Cells["Name"].Value.ToString();
                    string subject = row.Cells["Subject"].Value.ToString();
                    int om = Convert.ToInt32(row.Cells["OM"].Value);
                    int fm = Convert.ToInt32(row.Cells["FM"].Value);
                    int pm = Convert.ToInt32(row.Cells["PM"].Value);

                    // SQL query to update the record
                    string updateQuery = "UPDATE StudentMarksheet SET Roll = @roll, Name = @name, Subject = @subject, OM = @om, FM = @fm, PM = @pm WHERE ID = @id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@roll", roll);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@subject", subject);
                        cmd.Parameters.AddWithValue("@om", om);
                        cmd.Parameters.AddWithValue("@fm", fm);
                        cmd.Parameters.AddWithValue("@pm", pm);
                        cmd.Parameters.AddWithValue("@id", id);

                        // Execute the update command
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Changes saved successfully.");
                Showing_Marksheet SM = new Showing_Marksheet();
                SM.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving changes: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void CalculateAndDisplayPercentage(DataTable dt)
        {
            // Initialize totals
            int totalObtainedMarks = 0;
            int totalFullMarks = 0;

            // Loop through each row in the DataTable to sum up marks
            foreach (DataRow row in dt.Rows)
            {
                totalObtainedMarks += Convert.ToInt32(row["OM"]); // OM stands for Obtained Marks
                totalFullMarks += Convert.ToInt32(row["FM"]); // FM stands for Full Marks
            }

            // Calculate percentage
            double percentage = (double)totalObtainedMarks / totalFullMarks * 100;

            // Display the calculated percentage in a label (below the DataGridView)
            lblpercentage.Text = "Total Percentage: " + percentage.ToString("F2") + "%"; // Format to 2 decimal places
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminDashboard AD = new AdminDashboard();
            AD.Show();
            this.Hide();
        }
    }
}
