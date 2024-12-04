﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEng2024
{
    public partial class Profile : Form
    {
        private int memberId;
        public Profile(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId; // Assign the logged-in MemberID
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadFullName();
            LoadMembershipType(); // Load the membership type when the form loads
            LoadInterest();// Populate label
            LoadEmailAndJoinDate();

        }
        private void LoadFullName()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserDatabaseConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                // Open the connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to fetch FirstName and LastName of the member
                    string query = @"
                        SELECT FirstName, LastName
                        FROM Members
                        WHERE MemberID = @MemberID";

                    // Create the command
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@MemberID", memberId);

                        // Execute the reader
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Safely retrieve FirstName and LastName
                                string firstName = reader["FirstName"]?.ToString() ?? "Unknown";
                                string lastName = reader["LastName"]?.ToString() ?? "Unknown";

                                // Concatenate FirstName and LastName
                                string fullName = $"{firstName} {lastName}";
                                lblname.Text = $"{fullName}";

                            }
                            else
                            {
                                // Handle case where MemberID is not found
                                lblname.Text = "Member not found.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error (if logging mechanism is available)
                // Show user-friendly error message
                MessageBox.Show("An error occurred while fetching the member details. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error fetching full name: {ex.Message}");
            }
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
        private void LoadEmailAndJoinDate()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserDatabaseConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT Email, JoinDate
                        FROM Members
                        WHERE MemberID = @MemberID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string email = reader["Email"]?.ToString() ?? "Not Provided";
                                string joinDate = reader["JoinDate"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["JoinDate"]).ToString("MMMM dd, yyyy")
                                : "Unknown";

                                lblemail.Text = $"Email: {email}";
                                lbljoindate.Text = $"Join Date: {joinDate}";
                            }
                            else
                            {
                                lblemail.Text = "Email: Not Found";
                                lbljoindate.Text = "Join Date: Not Found";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching email and join date: {ex.Message}");
            }

        }
    }
}
