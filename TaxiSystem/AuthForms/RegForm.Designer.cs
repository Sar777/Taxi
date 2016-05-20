namespace TaxiSystem.AuthForms
{
    partial class RegForm
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
            this._btReg = new System.Windows.Forms.Button();
            this._tbPassowrd2 = new System.Windows.Forms.TextBox();
            this._tbPassowrd1 = new System.Windows.Forms.TextBox();
            this._tbUsername = new System.Windows.Forms.TextBox();
            this._lbPassword = new System.Windows.Forms.Label();
            this._lbPassword2 = new System.Windows.Forms.Label();
            this._lbErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lbUsername
            // 
            this._lbUsername.AutoSize = true;
            this._lbUsername.Location = new System.Drawing.Point(26, 45);
            this._lbUsername.Name = "_lbUsername";
            this._lbUsername.Size = new System.Drawing.Size(32, 13);
            this._lbUsername.TabIndex = 0;
            this._lbUsername.Text = "Имя:";
            // 
            // _btReg
            // 
            this._btReg.Location = new System.Drawing.Point(34, 175);
            this._btReg.Name = "_btReg";
            this._btReg.Size = new System.Drawing.Size(85, 23);
            this._btReg.TabIndex = 1;
            this._btReg.Text = "Регистрация";
            this._btReg.UseVisualStyleBackColor = true;
            this._btReg.Click += new System.EventHandler(this._btReg_Click);
            // 
            // _tbPassowrd2
            // 
            this._tbPassowrd2.Location = new System.Drawing.Point(29, 143);
            this._tbPassowrd2.Name = "_tbPassowrd2";
            this._tbPassowrd2.PasswordChar = '*';
            this._tbPassowrd2.Size = new System.Drawing.Size(100, 20);
            this._tbPassowrd2.TabIndex = 2;
            this._tbPassowrd2.UseSystemPasswordChar = true;
            // 
            // _tbPassowrd1
            // 
            this._tbPassowrd1.Location = new System.Drawing.Point(29, 100);
            this._tbPassowrd1.Name = "_tbPassowrd1";
            this._tbPassowrd1.PasswordChar = '*';
            this._tbPassowrd1.Size = new System.Drawing.Size(100, 20);
            this._tbPassowrd1.TabIndex = 3;
            this._tbPassowrd1.UseSystemPasswordChar = true;
            // 
            // _tbUsername
            // 
            this._tbUsername.Location = new System.Drawing.Point(29, 61);
            this._tbUsername.Name = "_tbUsername";
            this._tbUsername.Size = new System.Drawing.Size(100, 20);
            this._tbUsername.TabIndex = 4;
            // 
            // _lbPassword
            // 
            this._lbPassword.AutoSize = true;
            this._lbPassword.Location = new System.Drawing.Point(26, 84);
            this._lbPassword.Name = "_lbPassword";
            this._lbPassword.Size = new System.Drawing.Size(48, 13);
            this._lbPassword.TabIndex = 5;
            this._lbPassword.Text = "Пароль:";
            // 
            // _lbPassword2
            // 
            this._lbPassword2.AutoSize = true;
            this._lbPassword2.Location = new System.Drawing.Point(26, 126);
            this._lbPassword2.Name = "_lbPassword2";
            this._lbPassword2.Size = new System.Drawing.Size(93, 13);
            this._lbPassword2.TabIndex = 6;
            this._lbPassword2.Text = "Пароль еще раз:";
            // 
            // _lbErrors
            // 
            this._lbErrors.AutoSize = true;
            this._lbErrors.ForeColor = System.Drawing.Color.Crimson;
            this._lbErrors.Location = new System.Drawing.Point(9, 9);
            this._lbErrors.MaximumSize = new System.Drawing.Size(150, 30);
            this._lbErrors.MinimumSize = new System.Drawing.Size(139, 30);
            this._lbErrors.Name = "_lbErrors";
            this._lbErrors.Size = new System.Drawing.Size(139, 30);
            this._lbErrors.TabIndex = 7;
            this._lbErrors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 210);
            this.Controls.Add(this._lbErrors);
            this.Controls.Add(this._lbPassword2);
            this.Controls.Add(this._lbPassword);
            this.Controls.Add(this._tbUsername);
            this.Controls.Add(this._tbPassowrd1);
            this.Controls.Add(this._tbPassowrd2);
            this.Controls.Add(this._btReg);
            this.Controls.Add(this._lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lbUsername;
        private System.Windows.Forms.Button _btReg;
        private System.Windows.Forms.TextBox _tbPassowrd2;
        private System.Windows.Forms.TextBox _tbPassowrd1;
        private System.Windows.Forms.TextBox _tbUsername;
        private System.Windows.Forms.Label _lbPassword;
        private System.Windows.Forms.Label _lbPassword2;
        private System.Windows.Forms.Label _lbErrors;
    }
}