using StudyPal.Model;
using StudyPal.Model.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudyPal.View
{
    public partial class SkillView : BaseView
    {
        SignUpView signUpView;
        public SkillView(List<Skill> ownedSkills, SignUpView signUpView)
        {
            InitializeComponent();
            this.signUpView = signUpView;
            List<Course> courses = CourseRepository.GetAllCourses();
            foreach(Course course in courses)
            {
                int n = dataGridViewChooseCourses.Rows.Add();
                dataGridViewChooseCourses.Rows[n].Cells[0].Value = "false";
                dataGridViewChooseCourses.Rows[n].Cells[1].Value = course.CourseId.ToString();
                dataGridViewChooseCourses.Rows[n].Cells[2].Value = course.CourseCode.ToString();
                dataGridViewChooseCourses.Rows[n].Cells[3].Value = course.CourseName.ToString();
            }

            if(ownedSkills != null)
            {
                foreach (Skill skill in ownedSkills)
                {
                    foreach (DataGridViewRow item in dataGridViewChooseCourses.Rows)
                    {
                        if (Convert.ToInt16(item.Cells[1].Value.ToString()) == skill.CourseId)
                        {
                            item.Cells[0].Value = "true";
                        }
                    }
                }
            }
        }

        private void dataGridViewChooseCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Skill> skills = new List<Skill>();
            int count = 0;
            foreach (DataGridViewRow item in dataGridViewChooseCourses.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    Skill skill = new Skill();
                    skill.CourseId = Convert.ToInt16(item.Cells[1].Value);
                    skills.Add(skill);
                    count += 1;
                }
            }
            if (count > 0)
            {
                MessageBox.Show(count.ToString() + " - Courses selected !", "Done !");
                signUpView.skills = skills;
                this.Hide();
            }
            else
            {
                MessageBox.Show("No courses selected !", "Oops");
            }
        }
    }
}
