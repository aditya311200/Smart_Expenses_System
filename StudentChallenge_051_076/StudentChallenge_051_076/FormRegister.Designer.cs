namespace StudentChallenge_051_076
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelHaveAccount = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelBackGround = new System.Windows.Forms.Label();
            this.labelFooter = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstName.Location = new System.Drawing.Point(221, 147);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(155, 26);
            this.textBoxFirstName.TabIndex = 2;
            this.textBoxFirstName.Text = "First Name . . . .";
            this.textBoxFirstName.Click += new System.EventHandler(this.textBoxFirstName_Click);
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(431, 376);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(79, 18);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Login Now";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            this.labelLogin.MouseLeave += new System.EventHandler(this.labelLogin_MouseLeave);
            this.labelLogin.MouseHover += new System.EventHandler(this.labelLogin_MouseHover);
            // 
            // labelHaveAccount
            // 
            this.labelHaveAccount.AutoSize = true;
            this.labelHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHaveAccount.ForeColor = System.Drawing.Color.Black;
            this.labelHaveAccount.Location = new System.Drawing.Point(250, 376);
            this.labelHaveAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHaveAccount.Name = "labelHaveAccount";
            this.labelHaveAccount.Size = new System.Drawing.Size(176, 18);
            this.labelHaveAccount.TabIndex = 8;
            this.labelHaveAccount.Text = "Already have an account?";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(414, 319);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(125, 31);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(221, 276);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConfirmPassword.Multiline = true;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(318, 26);
            this.textBoxConfirmPassword.TabIndex = 6;
            this.textBoxConfirmPassword.Text = "Confirm Password . . . .";
            this.textBoxConfirmPassword.Click += new System.EventHandler(this.textBoxConfirmPassword_Click);
            this.textBoxConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfirmPassword_KeyPress);
            this.textBoxConfirmPassword.Leave += new System.EventHandler(this.textBoxConfirmPassword_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(221, 233);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(318, 26);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "Password . . . .";
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLastName.Location = new System.Drawing.Point(384, 147);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(155, 26);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.Text = "Last Name . . . .";
            this.textBoxLastName.Click += new System.EventHandler(this.textBoxLastName_Click);
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            this.textBoxLastName.Leave += new System.EventHandler(this.textBoxLastName_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(221, 190);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(318, 26);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.Text = "Username . . . .";
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);
            this.textBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsername_KeyPress);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // labelBackGround
            // 
            this.labelBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.labelBackGround.Location = new System.Drawing.Point(194, 116);
            this.labelBackGround.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBackGround.Name = "labelBackGround";
            this.labelBackGround.Size = new System.Drawing.Size(375, 310);
            this.labelBackGround.TabIndex = 1;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.BackColor = System.Drawing.Color.Transparent;
            this.labelFooter.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.Color.Black;
            this.labelFooter.Location = new System.Drawing.Point(250, 458);
            this.labelFooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(252, 16);
            this.labelFooter.TabIndex = 10;
            this.labelFooter.Text = "Copyright © 2019 Smart Expenses System";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Black;
            this.labelHeader.Location = new System.Drawing.Point(221, 53);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(317, 36);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Create New Account";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.ControlBox = false;
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelFooter);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelHaveAccount);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelBackGround);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Page";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelHaveAccount;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelBackGround;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Label labelHeader;
    }
}