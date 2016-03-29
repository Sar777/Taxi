namespace TaxiSystem
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
            this._textBoxUsername = new System.Windows.Forms.TextBox();
            this._textBoxPassword = new System.Windows.Forms.TextBox();
            this._lbPassword = new System.Windows.Forms.Label();
            this._btAuth = new System.Windows.Forms.Button();
            this._lbAuthError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lbUsername
            // 
            this._lbUsername.AutoSize = true;
            this._lbUsername.Location = new System.Drawing.Point(23, 23);
            this._lbUsername.Name = "_lbUsername";
            this._lbUsername.Size = new System.Drawing.Size(106, 13);
            this._lbUsername.TabIndex = 0;
            this._lbUsername.Text = "Имя пользователя:";
            // 
            // _textBoxUsername
            // 
            this._textBoxUsername.Location = new System.Drawing.Point(25, 39);
            this._textBoxUsername.Name = "_textBoxUsername";
            this._textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this._textBoxUsername.TabIndex = 1;
            // 
            // _textBoxPassword
            // 
            this._textBoxPassword.Location = new System.Drawing.Point(25, 83);
            this._textBoxPassword.Name = "_textBoxPassword";
            this._textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this._textBoxPassword.TabIndex = 3;
            this._textBoxPassword.UseSystemPasswordChar = true;
            // 
            // _lbPassword
            // 
            this._lbPassword.AutoSize = true;
            this._lbPassword.Location = new System.Drawing.Point(22, 67);
            this._lbPassword.Name = "_lbPassword";
            this._lbPassword.Size = new System.Drawing.Size(48, 13);
            this._lbPassword.TabIndex = 2;
            this._lbPassword.Text = "Пароль:";
            // 
            // _btAuth
            // 
            this._btAuth.Location = new System.Drawing.Point(24, 109);
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
            this._lbAuthError.Location = new System.Drawing.Point(25, 5);
            this._lbAuthError.Name = "_lbAuthError";
            this._lbAuthError.Size = new System.Drawing.Size(0, 13);
            this._lbAuthError.TabIndex = 5;
            this._lbAuthError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 141);
            this.Controls.Add(this._lbAuthError);
            this.Controls.Add(this._btAuth);
            this.Controls.Add(this._textBoxPassword);
            this.Controls.Add(this._lbPassword);
            this.Controls.Add(this._textBoxUsername);
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
        private System.Windows.Forms.TextBox _textBoxUsername;
        private System.Windows.Forms.TextBox _textBoxPassword;
        private System.Windows.Forms.Label _lbPassword;
        private System.Windows.Forms.Button _btAuth;
        private System.Windows.Forms.Label _lbAuthError;
    }
}