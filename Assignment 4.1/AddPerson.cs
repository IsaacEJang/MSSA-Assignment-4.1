using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._1
{
    public partial class AddPerson : Form
    {
        // Property to store the new person details
        public Person NewPerson { get; private set; }

        // Constructor
        public AddPerson()
        {
            InitializeComponent();
        }

        // Event handler for the Add button click
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Retrieve and trim the input values
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string mobilePhone = txtMobilePhone.Text.Trim();
            string workPhone = txtWorkPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            // Validate that none of the fields are empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(mobilePhone) || string.IsNullOrEmpty(workPhone) ||
                string.IsNullOrEmpty(address))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that mobile phone and work phone are numeric and exactly 10 digits
            if (!long.TryParse(mobilePhone, out _) || mobilePhone.Length != 10 ||
                !long.TryParse(workPhone, out _) || workPhone.Length != 10)
            {
                MessageBox.Show("Mobile Phone and Work Phone must be numeric and exactly 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Person object with the provided details
            NewPerson = new Person(firstName, lastName, mobilePhone, workPhone, address);
            MessageBox.Show($"{firstName} {lastName} has been added to the address book.", "Person Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Set the dialog result to OK and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Event handler for the Back to Home button click
        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box
            var confirmResult = MessageBox.Show("Do you want to go back to the address book?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            // If the user clicks Yes, set the dialog result to Cancel and close the form
            if (confirmResult == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel; // Setting DialogResult to Cancel to indicate no new person is added
                this.Close();
            }
        }
    }
}