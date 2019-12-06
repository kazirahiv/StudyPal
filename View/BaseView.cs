using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyPal.View
{
    public class BaseView : MaterialForm
    {
        public BaseView()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseView 
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "BaseView";
            this.Load += new System.EventHandler(this.BaseView_Load);
            this.ResumeLayout(false); 

        }

        private void BaseView_Load(object sender, EventArgs e)
        {

        }

        void BaseView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();

                if (e.CloseReason == CloseReason.WindowsShutDown) { }
        }


    }
}
