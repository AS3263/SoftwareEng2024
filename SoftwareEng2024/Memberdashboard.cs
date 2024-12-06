using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEng2024
{
    public partial class Memberdashboard : Form
    {
        private int memberId; // Store the logged-in member's ID

        public Memberdashboard(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId; // Assign the logged-in MemberID
        }

        private void CONBTN_Click(object sender, EventArgs e)
        {
            // Create an instance of the DCM form
            DCM dcmForm = new DCM();

            // Show the DCM form
            dcmForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Return to Main page
            var mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void ChatBox_Button_Click(object sender, EventArgs e)
        {
            var chatboxForm = new Form1();
            chatboxForm.Show();
            this.Hide();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            int memberId = this.memberId; // Ensure memberId is available in memberdashboard
            Profile PROFILEForm = new Profile(memberId);
            PROFILEForm.Show();

        }

        private void Memberdashboard_Load(object sender, EventArgs e)
        {
            LoadMembershipType(); // Load the membership type when the form loads
            LoadInterest();// Populate label
        }

        private void Mybenefits_Click(object sender, EventArgs e)
        {
            MyBenefits benefitsForm = new MyBenefits(memberId);
            benefitsForm.Show();
        }

        private void BTNMYBENEFITS_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadMembershipType()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserDatabaseConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get the membership type for the logged-in member
                    string query = @"
                        SELECT MT.TypeName
                        FROM Members M
                        INNER JOIN MembershipTypes MT ON M.MembershipTypeID = MT.MembershipTypeID
                        WHERE M.MemberID = @MemberID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string membershipType = result.ToString();
                            lblmembershiptype.Text = $"Membership Type: {membershipType}"; // Display membership type in label
                        }
                        else
                        {
                            lblmembershiptype.Text = "Membership Type: Not Found"; // Default message if no type is found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching membership type: {ex.Message}");
            }
        }
        private void LoadInterest()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserDatabaseConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get the interests for the member
                    string query = @"
                SELECT I.InterestName
                FROM MemberInterests MI
                INNER JOIN Interests I ON MI.InterestID = I.InterestID
                WHERE MI.MemberID = @MemberID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            StringBuilder interests = new StringBuilder();
                            while (reader.Read())
                            {
                                interests.Append(reader["InterestName"].ToString() + ", ");
                            }

                            // Remove trailing comma and space
                            if (interests.Length > 0)
                            {
                                interests.Length -= 2;
                            }

                            lblinterest.Text = interests.Length > 0 ? $"Interests: {interests}" : "Interests: None";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching interests: {ex.Message}");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
