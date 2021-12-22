namespace StudentChallenge_051_076
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBoxVisibility = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelFooter = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelDontHave = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxPasswordIcon = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.pictureBoxUserIcon = new System.Windows.Forms.PictureBox();
            this.labelBackGround = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVisibility
            // 
            this.pictureBoxVisibility.Image = global::StudentChallenge_051_076.Properties.Resources.visibilityoff;
            this.pictureBoxVisibility.Location = new System.Drawing.Point(801, 237);
            this.pictureBoxVisibility.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxVisibility.Name = "pictureBoxVisibility";
            this.pictureBoxVisibility.Size = new System.Drawing.Size(24, 20);
            this.pictureBoxVisibility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVisibility.TabIndex = 31;
            this.pictureBoxVisibility.TabStop = false;
            this.pictureBoxVisibility.Click += new System.EventHandler(this.pictureBoxVisibility_Click);
            this.pictureBoxVisibility.MouseHover += new System.EventHandler(this.pictureBoxVisibility_MouseHover);
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(503, 54);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(369, 45);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Welcome To S.E.S";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFooter
            // 
            this.labelFooter.BackColor = System.Drawing.Color.Transparent;
            this.labelFooter.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.Color.White;
            this.labelFooter.Location = new System.Drawing.Point(503, 457);
            this.labelFooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(362, 19);
            this.labelFooter.TabIndex = 7;
            this.labelFooter.Text = "Copyright © 2019 Smart Expenses System";
            this.labelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.White;
            this.labelRegister.Location = new System.Drawing.Point(723, 344);
            this.labelRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(98, 18);
            this.labelRegister.TabIndex = 6;
            this.labelRegister.Text = "Register Now";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            this.labelRegister.MouseLeave += new System.EventHandler(this.labelRegister_MouseLeave);
            this.labelRegister.MouseHover += new System.EventHandler(this.labelRegister_MouseHover);
            // 
            // labelDontHave
            // 
            this.labelDontHave.AutoSize = true;
            this.labelDontHave.BackColor = System.Drawing.Color.Transparent;
            this.labelDontHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDontHave.ForeColor = System.Drawing.Color.White;
            this.labelDontHave.Location = new System.Drawing.Point(558, 344);
            this.labelDontHave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDontHave.Name = "labelDontHave";
            this.labelDontHave.Size = new System.Drawing.Size(163, 18);
            this.labelDontHave.TabIndex = 5;
            this.labelDontHave.Text = "Don\'t have an account?";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.Font = new System.Drawing.Font("Patua One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(730, 277);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 31);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxPasswordIcon
            // 
            this.pictureBoxPasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPasswordIcon.Image = global::StudentChallenge_051_076.Properties.Resources.password;
            this.pictureBoxPasswordIcon.Location = new System.Drawing.Point(538, 235);
            this.pictureBoxPasswordIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPasswordIcon.Name = "pictureBoxPasswordIcon";
            this.pictureBoxPasswordIcon.Size = new System.Drawing.Size(26, 24);
            this.pictureBoxPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPasswordIcon.TabIndex = 25;
            this.pictureBoxPasswordIcon.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(589, 237);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(241, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxUsername.Location = new System.Drawing.Point(589, 192);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(241, 22);
            this.textBoxUsername.TabIndex = 2;
            // 
            // pictureBoxUserIcon
            // 
            this.pictureBoxUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUserIcon.Image = global::StudentChallenge_051_076.Properties.Resources.user;
            this.pictureBoxUserIcon.Location = new System.Drawing.Point(538, 190);
            this.pictureBoxUserIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUserIcon.Name = "pictureBoxUserIcon";
            this.pictureBoxUserIcon.Size = new System.Drawing.Size(26, 24);
            this.pictureBoxUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserIcon.TabIndex = 22;
            this.pictureBoxUserIcon.TabStop = false;
            // 
            // labelBackGround
            // 
            this.labelBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.labelBackGround.Location = new System.Drawing.Point(500, 147);
            this.labelBackGround.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBackGround.Name = "labelBackGround";
            this.labelBackGround.Size = new System.Drawing.Size(372, 245);
            this.labelBackGround.TabIndex = 1;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.pictureBoxVisibility);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelFooter);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelDontHave);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxPasswordIcon);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.pictureBoxUserIcon);
            this.Controls.Add(this.labelBackGround);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVisibility;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelDontHave;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxPasswordIcon;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.PictureBox pictureBoxUserIcon;
        private System.Windows.Forms.Label labelBackGround;
    }
}

