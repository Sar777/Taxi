namespace TaxiSystem.AuthForms
{
    partial class AuthForm
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
            this._lbUsername = new System.Windows.Forms.Label();
            this._tbUsername = new System.Windows.Forms.TextBox();
            this._tbPassword = new System.Windows.Forms.TextBox();
            this._lbPassword = new System.Windows.Forms.Label();
            this._btAuth = new System.Windows.Forms.Button();
            this._lbAuthError = new System.Windows.Forms.Label();
            this._btReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lbUsername
            // 
            this._lbUsername.AutoSize = true;
            this._lbUsername.Location = new System.Drawing.Point(26, 42);
            this._lbUsername.Name = "_lbUsername";
            this._lbUsername.Size = new System.Drawing.Size(106, 13);
            this._lbUsername.TabIndex = 0;
            this._lbUsername.Text = "Имя пользователя:";
            // 
            // _tbUsername
            // 
            this._tbUsername.Location = new System.Drawing.Point(28, 58);
            this._tbUsername.Name = "_tbUsername";
            this._tbUsername.Size = new System.Drawing.Size(100, 20);
            this._tbUsername.TabIndex = 1;
            // 
            // _tbPassword
            // 
            this._tbPassword.Location = new System.Drawing.Point(28, 102);
            this._tbPassword.Name = "_tbPassword";
            this._tbPassword.Size = new System.Drawing.Size(100, 20);
            this._tbPassword.TabIndex = 3;
            this._tbPassword.UseSystemPasswordChar = true;
            // 
            // _lbPassword
            // 
            this._lbPassword.AutoSize = true;
            this._lbPassword.Location = new System.Drawing.Point(25, 86);
            this._lbPassword.Name = "_lbPassword";
            this._lbPassword.Size = new System.Drawing.Size(48, 13);
            this._lbPassword.TabIndex = 2;
            this._lbPassword.Text = "Пароль:";
            // 
            // _btAuth
            // 
            this._btAuth.Location = new System.Drawing.Point(27, 128);
            this._btAuth.Name = "_btAuth";
            this._btAuth.Size = new System.Drawing.Size(101, 22);
            this._btAuth.TabIndex = 4;
            this._btAuth.Text = "Войти";
            this._btAuth.UseVisualStyleBackColor = true;
            this._btAuth.Click += new System.EventHandler(this._btAuth_Click);
            // 
            // _lbAuthError
            // 
            this._lbAuthError.AutoSize = true;
            this._lbAuthError.ForeColor = System.Drawing.Color.Crimson;
            this._lbAuthError.Location = new System.Drawing.Point(12, 9);
            this._lbAuthError.MaximumSize = new System.Drawing.Size(130, 25);
            this._lbAuthError.MinimumSize = new System.Drawing.Size(130, 25);
            this._lbAuthError.Name = "_lbAuthError";
            this._lbAuthError.Size = new System.Drawing.Size(130, 25);
            this._lbAuthError.TabIndex = 5;
            this._lbAuthError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _btReg
            // 
            this._btReg.Location = new System.Drawing.Point(27, 156);
            this._btReg.Name = "_btReg";
            this._btReg.Size = new System.Drawing.Size(101, 23);
            this._btReg.TabIndex = 6;
            this._btReg.Text = "Регистрация";
            this._btReg.UseVisualStyleBackColor = true;
            this._btReg.Click += new System.EventHandler(this._btReg_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 192);
            this.Controls.Add(this._btReg);
            this.Controls.Add(this._lbAuthError);
            this.Controls.Add(this._btAuth);
            this.Controls.Add(this._tbPassword);
            this.Controls.Add(this._lbPassword);
            this.Controls.Add(this._tbUsername);
            this.Controls.Add(this._lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lbUsername;
        private System.Windows.Forms.TextBox _tbUsername;
        private System.Windows.Forms.TextBox _tbPassword;
        private System.Windows.Forms.Label _lbPassword;
        private System.Windows.Forms.Button _btAuth;
        private System.Windows.Forms.Label _lbAuthError;
        private System.Windows.Forms.Button _btReg;
    }
}