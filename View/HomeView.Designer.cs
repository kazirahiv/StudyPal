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
            this.logInBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.signUpBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.goPBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goPBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCourseComboBox
            // 
            this.searchCourseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchCourseComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchCourseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCourseComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.searchCourseComboBox.FormattingEnabled = true;
            this.searchCourseComboBox.Location = new System.Drawing.Point(221, 204);
            this.searchCourseComboBox.Name = "searchCourseComboBox";
            this.searchCourseComboBox.Size = new System.Drawing.Size(322, 32);
            this.searchCourseComboBox.TabIndex = 1;
            this.searchCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.searchCourseComboBox_SelectedIndexChanged);
            // 
            // logInBtn
            // 
            this.logInBtn.AutoSize = true;
            this.logInBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.logInBtn.Depth = 0;
            this.logInBtn.Icon = null;
            this.logInBtn.Location = new System.Drawing.Point(310, 246);
            this.logInBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logInBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Primary = false;
            this.logInBtn.Size = new System.Drawing.Size(64, 36);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.AutoSize = true;
            this.signUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpBtn.Depth = 0;
            this.signUpBtn.Icon = null;
            this.signUpBtn.Location = new System.Drawing.Point(397, 246);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signUpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Primary = false;
            this.signUpBtn.Size = new System.Drawing.Size(73, 36);
            this.signUpBtn.TabIndex = 5;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
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
            // goPBtn
            // 
            this.goPBtn.BackColor = System.Drawing.Color.White;
            this.goPBtn.Image = global::StudyPal.Properties.Resources.chevron_right_48px;
            this.goPBtn.Location = new System.Drawing.Point(549, 204);
            this.goPBtn.Name = "goPBtn";
            this.goPBtn.Size = new System.Drawing.Size(35, 33);
            this.goPBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goPBtn.TabIndex = 7;
            this.goPBtn.TabStop = false;
            this.goPBtn.Click += new System.EventHandler(this.goPBtn_Click);
            this.goPBtn.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.goPBtn.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = global::StudyPal.Properties.Resources.student_male_48px;
            this.pictureBox1.Location = new System.Drawing.Point(61, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goPBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCourseComboBox);
            this.Name = "HomeView";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing);
            this.Load += new System.EventHandler(this.HomeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goPBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox searchCourseComboBox;
        private MaterialSkin.Controls.MaterialFlatButton logInBtn;
        private MaterialSkin.Controls.MaterialFlatButton signUpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox goPBtn;
    }
}