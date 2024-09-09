using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClaimApplication
{
    public partial class Form1 : Form
    {
        // Define controls
        private Label lblRoleSelection;
        private RadioButton rbtnLecturer;
        private RadioButton rbtnCoordinator;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;

        public Form1()
        {
            InitializeComponent();
            // Call method to initialize controls
            InitializeLoginForm();
        }

        private void InitializeLoginForm()
        {
            // Initialize label for role selection
            lblRoleSelection = new Label();
            lblRoleSelection.Text = "Select Your Role:";
            lblRoleSelection.Location = new Point(20, 20);
            lblRoleSelection.AutoSize = true;

            // Initialize radio buttons for role selection
            rbtnLecturer = new RadioButton();
            rbtnLecturer.Text = "Lecturer";
            rbtnLecturer.Location = new Point(20, 50);
            rbtnLecturer.AutoSize = true;

            rbtnCoordinator = new RadioButton();
            rbtnCoordinator.Text = "Program Coordinator";
            rbtnCoordinator.Location = new Point(20, 80);
            rbtnCoordinator.AutoSize = true;

            // Initialize label and textbox for username
            lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point(20, 120);
            lblUsername.AutoSize = true;

            txtUsername = new TextBox();
            txtUsername.Location = new Point(120, 120);
            txtUsername.Width = 200;

            // Initialize label and textbox for password
            lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Location = new Point(20, 160);
            lblPassword.AutoSize = true;

            txtPassword = new TextBox();
            txtPassword.Location = new Point(120, 160);
            txtPassword.Width = 200;
            txtPassword.PasswordChar = '*'; // Mask password input

            // Initialize login button
            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Location = new Point(120, 200);
            btnLogin.Width = 100;

            // Add event handler for login button click
            btnLogin.Click += BtnLogin_Click;

            // Add controls to the form
            this.Controls.Add(lblRoleSelection);
            this.Controls.Add(rbtnLecturer);
            this.Controls.Add(rbtnCoordinator);
            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
        }

        // Event handler for Login button click
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string selectedRole = rbtnLecturer.Checked ? "Lecturer" : (rbtnCoordinator.Checked ? "Program Coordinator" : null);

            if (selectedRole == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Simple demonstration of login logic (replace with actual validation)
            if (username == "admin" && password == "password") // Example credentials
            {
                MessageBox.Show($"Login successful as {selectedRole}!");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
