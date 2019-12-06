using StudyPal.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyPal.View
{
    public partial class LogIn : BaseView
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeView().Show();
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool authenticated =  UserRepository.AuthenticateUser(textBoxName.Text, textBoxPassword.Text);
            if (authenticated)
            {
                MessageBox.Show("User Authenticated !", "Logged In !");
            }
            else
            {
                MessageBox.Show("Log In error !", "Ooops !");
            }
        }
    }
}
