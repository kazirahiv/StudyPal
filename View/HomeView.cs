using MaterialSkin;
using MaterialSkin.Controls;
using StudyPal.Model;
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
    public partial class HomeView : BaseView
    {
        public HomeView()
        {
            InitializeComponent();
            PopulateSearchCourseComboBox();
        }

        public void PopulateSearchCourseComboBox()
        {
            this.searchCourseComboBox.Items.AddRange(CourseRepository.GetAllCourses().Select(s=> s.CourseName).ToArray());
        }

        private void searchCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }

        private void HomeView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            goPBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            goPBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        private void goPBtn_Click(object sender, EventArgs e)
        {
            if (searchCourseComboBox.Text.Equals(""))
            {
                MessageBox.Show("Provide your desired course first !", "Oops");
            }
            else
            {
                MessageBox.Show(searchCourseComboBox.Text, "Course");
            }
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpView().Show();
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
