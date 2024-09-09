using System;
using System.Windows.Forms;

namespace ClaimApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Set the form properties
            this.Text = "Lecturer Claim Form";
            this.Size = new System.Drawing.Size(400, 500);

            // Lecturer Name
            Label lblLecturerName = new Label();
            lblLecturerName.Text = "Lecturer Name:";
            lblLecturerName.Location = new System.Drawing.Point(30, 30);

            TextBox txtLecturerName = new TextBox();
            txtLecturerName.Location = new System.Drawing.Point(150, 30);
            txtLecturerName.Width = 200;

            // Email
            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Location = new System.Drawing.Point(30, 70);

            TextBox txtEmail = new TextBox();
            txtEmail.Location = new System.Drawing.Point(150, 70);
            txtEmail.Width = 200;

            // Cellphone
            Label lblCellphone = new Label();
            lblCellphone.Text = "Cellphone:";
            lblCellphone.Location = new System.Drawing.Point(30, 110);

            TextBox txtCellphone = new TextBox();
            txtCellphone.Location = new System.Drawing.Point(150, 110);
            txtCellphone.Width = 200;

            // Module Code
            Label lblModuleCode = new Label();
            lblModuleCode.Text = "Module Code:";
            lblModuleCode.Location = new System.Drawing.Point(30, 150);

            TextBox txtModuleCode = new TextBox();
            txtModuleCode.Location = new System.Drawing.Point(150, 150);
            txtModuleCode.Width = 200;

            // Hourly Rate
            Label lblHourlyRate = new Label();
            lblHourlyRate.Text = "Hourly Rate:";
            lblHourlyRate.Location = new System.Drawing.Point(30, 190);

            TextBox txtHourlyRate = new TextBox();
            txtHourlyRate.Location = new System.Drawing.Point(150, 190);
            txtHourlyRate.Width = 200;

            // Number of Working Hours
            Label lblWorkingHours = new Label();
            lblWorkingHours.Text = "Working Hours:";
            lblWorkingHours.Location = new System.Drawing.Point(30, 230);

            TextBox txtWorkingHours = new TextBox();
            txtWorkingHours.Location = new System.Drawing.Point(150, 230);
            txtWorkingHours.Width = 200;

            // Upload Documents Button
            Label lblUploadDocuments = new Label();
            lblUploadDocuments.Text = "Upload Documents:";
            lblUploadDocuments.Location = new System.Drawing.Point(30, 270);

            Button btnUploadDocuments = new Button();
            btnUploadDocuments.Text = "Upload";
            btnUploadDocuments.Location = new System.Drawing.Point(150, 270);
            btnUploadDocuments.Click += new EventHandler(btnUploadDocuments_Click);

            // Add Claim Button
            Button btnAddClaim = new Button();
            btnAddClaim.Text = "Add Claim";
            btnAddClaim.Location = new System.Drawing.Point(150, 320);
            btnAddClaim.Click += new EventHandler(btnAddClaim_Click);

            // Add controls to the form
            this.Controls.Add(lblLecturerName);
            this.Controls.Add(txtLecturerName);
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblCellphone);
            this.Controls.Add(txtCellphone);
            this.Controls.Add(lblModuleCode);
            this.Controls.Add(txtModuleCode);
            this.Controls.Add(lblHourlyRate);
            this.Controls.Add(txtHourlyRate);
            this.Controls.Add(lblWorkingHours);
            this.Controls.Add(txtWorkingHours);
            this.Controls.Add(lblUploadDocuments);
            this.Controls.Add(btnUploadDocuments);
            this.Controls.Add(btnAddClaim);
        }

        // Event handler for Upload Documents button
        private void btnUploadDocuments_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Document to Upload";
            openFileDialog.Filter = "PDF Files|*.pdf|Word Documents|*.docx|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // You can handle the file path here as needed, for example:
                string filePath = openFileDialog.FileName;
                MessageBox.Show("Document uploaded: " + filePath);
            }
        }

        // Event handler for Add Claim button
        private void btnAddClaim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Claim added successfully!");
            // You can add more logic here to handle the claim data and save it
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label click event (if needed)
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
