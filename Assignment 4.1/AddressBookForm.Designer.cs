namespace Assignment_4._1
{
    partial class AddressBookForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAddressBook = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.buttonDeletePerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddressBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADDRESS              BOOK";
            // 
            // dataGridViewAddressBook
            // 
            this.dataGridViewAddressBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddressBook.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewAddressBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddressBook.GridColor = System.Drawing.Color.Bisque;
            this.dataGridViewAddressBook.Location = new System.Drawing.Point(288, 199);
            this.dataGridViewAddressBook.Name = "dataGridViewAddressBook";
            this.dataGridViewAddressBook.RowHeadersWidth = 51;
            this.dataGridViewAddressBook.RowTemplate.Height = 24;
            this.dataGridViewAddressBook.Size = new System.Drawing.Size(884, 475);
            this.dataGridViewAddressBook.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Bisque;
            this.labelSearch.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(282, 155);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(153, 32);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Search Bar: ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Bisque;
            this.textBoxSearch.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(457, 155);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(606, 38);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.SeaShell;
            this.buttonSearch.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(1069, 155);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(103, 38);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddPerson.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPerson.Location = new System.Drawing.Point(288, 766);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(193, 38);
            this.buttonAddPerson.TabIndex = 5;
            this.buttonAddPerson.Text = "Add Person";
            this.buttonAddPerson.UseVisualStyleBackColor = false;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // buttonDeletePerson
            // 
            this.buttonDeletePerson.BackColor = System.Drawing.Color.SeaShell;
            this.buttonDeletePerson.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePerson.Location = new System.Drawing.Point(976, 766);
            this.buttonDeletePerson.Name = "buttonDeletePerson";
            this.buttonDeletePerson.Size = new System.Drawing.Size(196, 38);
            this.buttonDeletePerson.TabIndex = 6;
            this.buttonDeletePerson.Text = "Delete Person";
            this.buttonDeletePerson.UseVisualStyleBackColor = false;
            this.buttonDeletePerson.Click += new System.EventHandler(this.buttonDeletePerson_Click_1);
            // 
            // AddressBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_4._1.Properties.Resources.notebook;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1525, 839);
            this.Controls.Add(this.buttonDeletePerson);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.dataGridViewAddressBook);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "AddressBookForm";
            this.Text = "AddressBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddressBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAddressBook;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Button buttonDeletePerson;
    }
}
