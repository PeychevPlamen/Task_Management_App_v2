namespace Task_Management_App_v2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.LoginText = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.BoxUsername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.BackgroundImage")));
            this.pictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogin.Location = new System.Drawing.Point(137, 25);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(135, 93);
            this.pictureBoxLogin.TabIndex = 1;
            this.pictureBoxLogin.TabStop = false;
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.BackColor = System.Drawing.Color.Transparent;
            this.LoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(279, 32);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(176, 69);
            this.LoginText.TabIndex = 2;
            this.LoginText.Text = "Login";
            this.LoginText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username.Location = new System.Drawing.Point(71, 158);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(130, 29);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // BoxUsername
            // 
            this.BoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxUsername.Location = new System.Drawing.Point(279, 157);
            this.BoxUsername.Name = "BoxUsername";
            this.BoxUsername.Size = new System.Drawing.Size(249, 30);
            this.BoxUsername.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(71, 213);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(124, 29);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.Location = new System.Drawing.Point(279, 212);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(249, 30);
            this.TextBoxPassword.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmit.Location = new System.Drawing.Point(159, 297);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(299, 49);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(632, 377);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.BoxUsername);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.pictureBoxLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox BoxUsername;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button btnSubmit;
    }
}

