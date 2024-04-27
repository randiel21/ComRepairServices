using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComRepairServices
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = usern_text.Text;
            string enteredPassword = pass_text.Text;

            // Fixed username and password
            string username = "root";
            string password = "shin29";

            if (enteredUsername == username && enteredPassword == password)
            {
                // Successful authentication
                ShowDashboard(enteredUsername, enteredPassword, "localhost", 3386);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void ShowDashboard(string username, string password, string hostname, int port)
        {
            Dashboard dashboardForm = new Dashboard(username, password, hostname, port);
            dashboardForm.ShowDialog();
        }
        private bool AuthenticateUser(string username, string password)
        {
            // Check if the entered username and password match the fixed values
            return username == "root" && password == "shin29";
        }

        private void usern_text_TextChanged(object sender, EventArgs e)
        {
            // You can add additional logic for username text changes if needed
        }

        private void pass_text_TextChanged(object sender, EventArgs e)
        {
            // You can add additional logic for password text changes if needed
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Call the function to navigate to the forgot password recovery page
            NavigateToForgotPasswordRecovery();
        }

        private void NavigateToForgotPasswordRecovery()
        {
            // Assuming you have another form called ForgotPasswordRecoveryForm
            PassRecovery forgotPasswordForm = new PassRecovery();

            // Show the forgot password recovery form and hide the login form (if needed)
            forgotPasswordForm.Show();
            this.Hide();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Add your logic here for the pictureBox1 click event
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            // Add your logic here for the pictureBox2 click event
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Add your logic here for the form load event
        }


    }
}
