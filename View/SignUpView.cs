using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyPal.Model.ViewModels;
namespace StudyPal.View
{
    public partial class SignUpView : BaseView
    {
        public SignUpView()
        {
            InitializeComponent();
        }

        private void SignUpView_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void SubmitData(object sender, EventArgs e)
        {
            var check = FormValidationCheck();
            if (check.ValidationStatus)
            {
                MessageBox.Show("Yae !!");
            }
            else
            {
                MessageBox.Show(check.Errors);
            }
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
            else if ((radioButtonAvailable.Checked == false) && (radioButtonBusy.Checked == false))
            {
                _vald = false;
                errors = errors + "Status required ! \n";
            }
            else if ((checkBoxTeacher.Checked == false) && (checkBoxStudent.Checked == false))
            {
                _vald = false;
                errors = errors + "User role required ! \n";
            }
            else if(checkBoxTeacher.Checked == true)
            {
                if(textBoxSetCharge.Text.Length == 0)
                {
                    _vald = false;
                    errors = errors + "Set your tuition charge ! \n";
                }
            }
            vald.ValidationStatus = _vald;
            vald.Errors = errors;
            return vald;
        }

    }
}
