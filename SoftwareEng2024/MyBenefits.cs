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

namespace SoftwareEng2024
{
    public partial class MyBenefits : Form
    {
        private int memberId; // Store the MemberID

        public MyBenefits(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId; // Assign the MemberID
        }

        private void MyBenefits_Load(object sender, EventArgs e)
        {
            LoadBenefits(memberId); // Load benefits on form load
        }
        private void LoadBenefits(int memberId)
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ashwin\Source\Repos\SoftwareEngabinavandash\SoftwareEng2024\Database2.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Step 1: Get MembershipTypeID for the member
                    int membershipTypeId = 0;
                    string memberQuery = "SELECT MembershipTypeID FROM Members WHERE MemberID = @MemberID";

                    using (SqlCommand cmd = new SqlCommand(memberQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            membershipTypeId = Convert.ToInt32(result); // Extract MembershipTypeID
                        }
                        else
                        {
                            MessageBox.Show("Member not found.");
                            return; // Stop if the member doesn't exist
                        }
                    }

                    // Step 2: Fetch all benefits based on MembershipTypeID logic
                    string benefitsQuery = "SELECT BenefitName, Description, ApplicableMembershipTypeID FROM Benefits";

                    using (SqlCommand cmd = new SqlCommand(benefitsQuery, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            benefitsView.Nodes.Clear(); // Clear existing nodes in the TreeView

                            while (reader.Read())
                            {
                                string benefitName = reader["BenefitName"].ToString();
                                string benefitDescription = reader["Description"].ToString();
                                int applicableMembershipTypeId = Convert.ToInt32(reader["ApplicableMembershipTypeID"]);

                                // Apply logic to include benefits based on MembershipTypeID
                                if (applicableMembershipTypeId <= membershipTypeId)
                                {
                                    // Add benefit as a parent node and description as a child node
                                    TreeNode parentNode = new TreeNode(benefitName);
                                    parentNode.Nodes.Add(benefitDescription); // Add description as a child node
                                    benefitsView.Nodes.Add(parentNode);
                                }
                            }
                        }
                    }

                    // Step 3: Handle case where no benefits are found
                    if (benefitsView.Nodes.Count == 0)
                    {
                        TreeNode noBenefitsNode = new TreeNode("No benefits available for your membership type.");
                        benefitsView.Nodes.Add(noBenefitsNode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading benefits: {ex.Message}");
            }
        }
    }
}
