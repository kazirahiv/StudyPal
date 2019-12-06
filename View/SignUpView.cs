using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using StudyPal.Model;
using StudyPal.Model.Repository;
using StudyPal.Model.ViewModels;
using StudyPal.Services;

namespace StudyPal.View
{
    public partial class SignUpView : BaseView
    {
        public List<Skill> skills = new List<Skill>();
        public SignUpView()
        {
            InitializeComponent();
            labelSetCharge.Visible = textBoxSetCharge.Visible = btnSetProficiency.Visible = radioButtonAvailable.Visible = radioButtonBusy.Visible = labelStatus.Visible = false;
        }

        private void SignUpView_Load(object sender, EventArgs e)
        {

        }

        private void SubmitData(object sender, EventArgs e)
        {
            //User usersz = StudentRepository.GetStudentById(1).User;
            if (FormValidationCheck().ValidationStatus)
            {
                User user = new User();
                user.Name = textBoxName.Text;
                user.Address = textBoxAddress.Text;
                user.PhoneNumber = textBoxPhone.Text;
                user.UserName = textBoxEmail.Text;
                user.Password = textBoxPassword.Text;
                user.UserEnabled = true;
                if (profileImagePictureBox.Image != null)
                {
                    user.UserAvatar = SaveImage(profileImagePictureBox.ImageLocation);
                }
                UserRepository.AddUser(user);
                if (checkBoxTeacher.Checked)
                {
                    Teacher teacher = new Teacher();
                    teacher.UserId = user.UserId;
                    teacher.AvailableToHire = radioButtonAvailable.Checked ? true : false;
                    teacher.ChargeAmount = Convert.ToDecimal(textBoxSetCharge.Text);
                    TeacherRepository.AddTeacher(teacher);

                    foreach(Skill skill in skills)
                    {
                        skill.TeacherId = teacher.TeacherId;
                    }
                    SkillRepository.AddSkills(skills);
                }
                else
                {
                    Student student = new Student();
                    student.UserId = user.UserId;
                    StudentRepository.AddStudent(student);
                }
                MessageBox.Show("Registration Successful !", "Success !");
                int milliseconds = 1000;
                Thread.Sleep(milliseconds);
                this.Hide();
                new LogIn().Show();
            }
            else
            {
                MessageBox.Show(FormValidationCheck().Errors, "Error");
            }
        }


        private string SaveImage(string file)
        {
            string currentDirectory = Application.StartupPath.Replace("bin\\Debug","");
            string filePath = System.IO.Path.Combine(currentDirectory, "Contents\\Images\\", Path.GetFileName(file));
            File.Copy(file, filePath, true);
            return Path.GetFileName(file);
        }


        private FormValidationVM FormValidationCheck()
        {
            var vald = new FormValidationVM();
            bool _vald = true;
            string errors = "";
            if(textBoxName.Text.Length == 0)
            {
                _vald = false;
                errors = errors + "Name required ! \n";
            }
            else if(textBoxAddress.Text.Length == 0)
            {
                _vald = false;
                errors = errors + "Address required ! \n";
            }
            else if (textBoxPhone.Text.Length == 0)
            {
                _vald = false;
                errors = errors + "Phone number required ! \n";
            }
            else if (textBoxEmail.Text.Length == 0)
            {
                _vald = false;
                errors = errors + "Email required ! \n";
            }
            else if ((checkBoxTeacher.Checked == false) && (checkBoxStudent.Checked == false))
            {
                _vald = false;
                errors = errors + "User role required ! \n";
            }
            else if (textBoxPhone.Text.Length > 0)
            {
                if (!PhoneNoHelper.ValidatePhoneNo(textBoxPhone.Text))
                {
                    _vald = false;
                    errors = errors + "Not a valid phone number ! \n";
                }
            }
            if (textBoxEmail.Text.Length > 0)
            {
                if (!EmailHelper.IsValidEmail(textBoxEmail.Text))
                {
                    _vald = false;
                    errors = errors + "Not a valid Email address ! \n";
                }
            }
            if (textBoxPassword.Text.Length == 0)
            {
                _vald = false;
                errors = errors + "Please provide password ! \n";
            }
            if (checkBoxTeacher.Checked)
            {
                if(textBoxSetCharge.Text.Length == 0)
                {
                    _vald = false;
                    errors = errors + "Set your tuition charge ! \n";
                }
                if(skills.Count == 0)
                {
                    _vald = false;
                    errors = errors + "Set your skills ! \n";
                }
            }
            vald.ValidationStatus = _vald;
            vald.Errors = errors;
            return vald;
        }

        private void AlsoATeacher(object sender, EventArgs e)
        {
            if (checkBoxTeacher.Checked)
            {
                labelSetCharge.Visible = textBoxSetCharge.Visible = btnSetProficiency.Visible = radioButtonAvailable.Visible = radioButtonBusy.Visible = labelStatus.Visible = true;
            }
            else
            {
                labelSetCharge.Visible = textBoxSetCharge.Visible = btnSetProficiency.Visible = radioButtonAvailable.Visible = radioButtonBusy.Visible = labelStatus.Visible = false;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxSetCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        { 
            this.Hide();
            new HomeView().Show();
        }

        private void SignUpView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    profileImagePictureBox.ImageLocation = imageLocation;
                    
                }
            }catch(Exception v)
            {
                MessageBox.Show(v.Message);
            }
        }

        private void btnSetProficiency_Click(object sender, EventArgs e)
        {
            SkillView skillView = new SkillView(null, this);
            skillView.Show();
        }
    }
}
