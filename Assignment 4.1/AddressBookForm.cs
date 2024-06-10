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
    public partial class AddressBookForm : Form
    {
        // Dictionary to store address book entries with the full name as the key
        private Dictionary<string, Person> addressBook;

        public AddressBookForm()
        {
            InitializeComponent();
            SampleData(); // Initialize the address book with sample data
            UpdateGrid(); // Update the grid to display the current address book entries
        }

        private void SampleData()
        {
            addressBook = new Dictionary<string, Person>();

            // Adding some sample data to the address book
            var samplePersons = new List<Person>
            {
                new Person("John", "Doe", "1234567890", "0987654321", "123 Main St"),
                new Person("Jane", "Smith", "2345678901", "8765432109", "456 Elm St"),
                new Person("Jim", "Beam", "3456789012", "7654321098", "789 Oak St")
            };

            // Adding each sample person to the address book dictionary
            foreach (var person in samplePersons)
            {
                if (!addressBook.ContainsKey(person.FullName))
                {
                    addressBook.Add(person.FullName, person);
                }
            }
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            using (AddPerson addPersonForm = new AddPerson())
            {
                // Show the AddPerson form as a modal dialog
                if (addPersonForm.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("AddPerson form returned OK");
                    AddNewPerson(addPersonForm.NewPerson); // Add the new person to the address book
                }
                else
                {
                    Console.WriteLine("AddPerson form did not return OK");
                }
            }
            this.Show(); // Show the current form again
        }

        private void buttonDeletePerson_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewAddressBook.CurrentRow != null)
            {
                int rowIndex = dataGridViewAddressBook.CurrentRow.Index;
                string fullName = dataGridViewAddressBook.Rows[rowIndex].Cells["FullName"].Value.ToString();

                // Confirm deletion with the user
                var confirmResult = MessageBox.Show($"Are you sure you want to delete {fullName}?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    addressBook.Remove(fullName); // Remove the person from the address book
                    UpdateGrid(); // Update the grid to reflect the changes
                    MessageBox.Show($"{fullName} has been removed from the address book.", "Person Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No person selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim().ToLower();

            // Search for a person whose full name contains the search text
            var matchedPerson = addressBook.Values.FirstOrDefault(person =>
                person.FullName.ToLower().Contains(searchText));

            if (matchedPerson != null)
            {
                // Display the details of the matched person
                MessageBox.Show($"Name: {matchedPerson.FullName}\nMobile: {matchedPerson.MobilePhone}\nWork: {matchedPerson.WorkPhone}\nAddress: {matchedPerson.Address}",
                                "Person Details",
                                MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewPerson(Person newPerson)
        {
            // Add the new person to the address book if they don't already exist
            if (!addressBook.ContainsKey(newPerson.FullName))
            {
                addressBook.Add(newPerson.FullName, newPerson);
                UpdateGrid(); // Update the grid to reflect the new addition
            }
            else
            {
                MessageBox.Show("Person with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGrid()
        {
            // Refresh the data source of the DataGridView to display the current address book entries
            dataGridViewAddressBook.DataSource = null;
            dataGridViewAddressBook.DataSource = addressBook.Values.ToList();
        }
    }
}