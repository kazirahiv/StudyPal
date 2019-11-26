namespace StudyPal.View
{
    partial class HomeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchCourseComboBox = new System.Windows.Forms.ComboBox();
            this.btnGo = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // searchCourseComboBox
            // 
            this.searchCourseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCourseComboBox.FormattingEnabled = true;
            this.searchCourseComboBox.Location = new System.Drawing.Point(221, 204);
            this.searchCourseComboBox.Name = "searchCourseComboBox";
            this.searchCourseComboBox.Size = new System.Drawing.Size(322, 33);
            this.searchCourseComboBox.TabIndex = 1;
            this.searchCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.searchCourseComboBox_SelectedIndexChanged);
            // 
            // btnGo
            // 
            this.btnGo.AutoSize = true;
            this.btnGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGo.Depth = 0;
            this.btnGo.Icon = null;
            this.btnGo.Location = new System.Drawing.Point(550, 204);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGo.Name = "btnGo";
            this.btnGo.Primary = false;
            this.btnGo.Size = new System.Drawing.Size(40, 36);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Study Pal";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(310, 246);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "Log In";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(397, 246);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(73, 36);
            this.materialFlatButton2.TabIndex = 5;
            this.materialFlatButton2.Text = "Sign Up";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.searchCourseComboBox);
            this.Name = "HomeView";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox searchCourseComboBox;
        private MaterialSkin.Controls.MaterialFlatButton btnGo;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}