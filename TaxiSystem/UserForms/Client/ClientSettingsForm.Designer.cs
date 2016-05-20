namespace TaxiSystem.Forms
{
    partial class ClientSettingsForm
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
            this._tbControl = new System.Windows.Forms.TabControl();
            this._myAddress = new System.Windows.Forms.TabPage();
            this._btRemoveAddress = new System.Windows.Forms.Button();
            this._lbMyAddress = new System.Windows.Forms.ListBox();
            this._lbCity = new System.Windows.Forms.Label();
            this._tbCity = new System.Windows.Forms.TextBox();
            this._lbStreet = new System.Windows.Forms.Label();
            this._tbStreet = new System.Windows.Forms.TextBox();
            this._btAddAddress = new System.Windows.Forms.Button();
            this._lbHouse = new System.Windows.Forms.Label();
            this._tbHouse = new System.Windows.Forms.TextBox();
            this._gbAddAddress = new System.Windows.Forms.GroupBox();
            this._addAddress = new System.Windows.Forms.TabPage();
            this._lbErrors = new System.Windows.Forms.Label();
            this._tbControl.SuspendLayout();
            this._myAddress.SuspendLayout();
            this._gbAddAddress.SuspendLayout();
            this._addAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tbControl
            // 
            this._tbControl.Controls.Add(this._myAddress);
            this._tbControl.Controls.Add(this._addAddress);
            this._tbControl.Location = new System.Drawing.Point(2, 12);
            this._tbControl.Name = "_tbControl";
            this._tbControl.SelectedIndex = 0;
            this._tbControl.Size = new System.Drawing.Size(288, 247);
            this._tbControl.TabIndex = 0;
            // 
            // _myAddress
            // 
            this._myAddress.Controls.Add(this._btRemoveAddress);
            this._myAddress.Controls.Add(this._lbMyAddress);
            this._myAddress.Location = new System.Drawing.Point(4, 22);
            this._myAddress.Name = "_myAddress";
            this._myAddress.Padding = new System.Windows.Forms.Padding(3);
            this._myAddress.Size = new System.Drawing.Size(280, 221);
            this._myAddress.TabIndex = 0;
            this._myAddress.Text = "Мои адреса";
            this._myAddress.UseVisualStyleBackColor = true;
            // 
            // _btRemoveAddress
            // 
            this._btRemoveAddress.Enabled = false;
            this._btRemoveAddress.Location = new System.Drawing.Point(99, 192);
            this._btRemoveAddress.Name = "_btRemoveAddress";
            this._btRemoveAddress.Size = new System.Drawing.Size(75, 23);
            this._btRemoveAddress.TabIndex = 4;
            this._btRemoveAddress.Text = "Удалить";
            this._btRemoveAddress.UseVisualStyleBackColor = true;
            this._btRemoveAddress.Click += new System.EventHandler(this._btRemoveAddress_Click);
            // 
            // _lbMyAddress
            // 
            this._lbMyAddress.FormattingEnabled = true;
            this._lbMyAddress.Location = new System.Drawing.Point(6, 6);
            this._lbMyAddress.Name = "_lbMyAddress";
            this._lbMyAddress.Size = new System.Drawing.Size(268, 173);
            this._lbMyAddress.TabIndex = 0;
            this._lbMyAddress.SelectedIndexChanged += new System.EventHandler(this._lbMyAddress_SelectedIndexChanged);
            // 
            // _lbCity
            // 
            this._lbCity.AutoSize = true;
            this._lbCity.Location = new System.Drawing.Point(45, 52);
            this._lbCity.Name = "_lbCity";
            this._lbCity.Size = new System.Drawing.Size(40, 13);
            this._lbCity.TabIndex = 3;
            this._lbCity.Text = "Город:";
            // 
            // _tbCity
            // 
            this._tbCity.Location = new System.Drawing.Point(93, 49);
            this._tbCity.Name = "_tbCity";
            this._tbCity.Size = new System.Drawing.Size(100, 20);
            this._tbCity.TabIndex = 2;
            // 
            // _lbStreet
            // 
            this._lbStreet.AutoSize = true;
            this._lbStreet.Location = new System.Drawing.Point(45, 78);
            this._lbStreet.Name = "_lbStreet";
            this._lbStreet.Size = new System.Drawing.Size(42, 13);
            this._lbStreet.TabIndex = 5;
            this._lbStreet.Text = "Улица:";
            // 
            // _tbStreet
            // 
            this._tbStreet.Location = new System.Drawing.Point(93, 75);
            this._tbStreet.Name = "_tbStreet";
            this._tbStreet.Size = new System.Drawing.Size(100, 20);
            this._tbStreet.TabIndex = 4;
            // 
            // _btAddAddress
            // 
            this._btAddAddress.Location = new System.Drawing.Point(93, 142);
            this._btAddAddress.Name = "_btAddAddress";
            this._btAddAddress.Size = new System.Drawing.Size(100, 23);
            this._btAddAddress.TabIndex = 1;
            this._btAddAddress.Text = "Добавить";
            this._btAddAddress.UseVisualStyleBackColor = true;
            this._btAddAddress.Click += new System.EventHandler(this._btAddAddress_Click);
            // 
            // _lbHouse
            // 
            this._lbHouse.AutoSize = true;
            this._lbHouse.Location = new System.Drawing.Point(52, 104);
            this._lbHouse.Name = "_lbHouse";
            this._lbHouse.Size = new System.Drawing.Size(33, 13);
            this._lbHouse.TabIndex = 7;
            this._lbHouse.Text = "Дом:";
            // 
            // _tbHouse
            // 
            this._tbHouse.Location = new System.Drawing.Point(93, 101);
            this._tbHouse.Name = "_tbHouse";
            this._tbHouse.Size = new System.Drawing.Size(100, 20);
            this._tbHouse.TabIndex = 6;
            // 
            // _gbAddAddress
            // 
            this._gbAddAddress.Controls.Add(this._lbErrors);
            this._gbAddAddress.Controls.Add(this._tbHouse);
            this._gbAddAddress.Controls.Add(this._tbStreet);
            this._gbAddAddress.Controls.Add(this._lbCity);
            this._gbAddAddress.Controls.Add(this._lbStreet);
            this._gbAddAddress.Controls.Add(this._tbCity);
            this._gbAddAddress.Controls.Add(this._btAddAddress);
            this._gbAddAddress.Controls.Add(this._lbHouse);
            this._gbAddAddress.Location = new System.Drawing.Point(6, 10);
            this._gbAddAddress.Name = "_gbAddAddress";
            this._gbAddAddress.Size = new System.Drawing.Size(268, 201);
            this._gbAddAddress.TabIndex = 5;
            this._gbAddAddress.TabStop = false;
            this._gbAddAddress.Text = "Адрес";
            // 
            // _addAddress
            // 
            this._addAddress.Controls.Add(this._gbAddAddress);
            this._addAddress.Location = new System.Drawing.Point(4, 22);
            this._addAddress.Name = "_addAddress";
            this._addAddress.Size = new System.Drawing.Size(280, 221);
            this._addAddress.TabIndex = 1;
            this._addAddress.Text = "Добавить адрес";
            this._addAddress.UseVisualStyleBackColor = true;
            // 
            // _lbErrors
            // 
            this._lbErrors.AutoSize = true;
            this._lbErrors.ForeColor = System.Drawing.Color.Crimson;
            this._lbErrors.Location = new System.Drawing.Point(23, 19);
            this._lbErrors.MinimumSize = new System.Drawing.Size(220, 20);
            this._lbErrors.Name = "_lbErrors";
            this._lbErrors.Size = new System.Drawing.Size(220, 20);
            this._lbErrors.TabIndex = 8;
            // 
            // ClientSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 261);
            this.Controls.Add(this._tbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientSettingsForm_Load);
            this._tbControl.ResumeLayout(false);
            this._myAddress.ResumeLayout(false);
            this._gbAddAddress.ResumeLayout(false);
            this._gbAddAddress.PerformLayout();
            this._addAddress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tbControl;
        private System.Windows.Forms.TabPage _myAddress;
        private System.Windows.Forms.ListBox _lbMyAddress;
        private System.Windows.Forms.Button _btRemoveAddress;
        private System.Windows.Forms.TabPage _addAddress;
        private System.Windows.Forms.GroupBox _gbAddAddress;
        private System.Windows.Forms.TextBox _tbHouse;
        private System.Windows.Forms.TextBox _tbStreet;
        private System.Windows.Forms.Label _lbCity;
        private System.Windows.Forms.Label _lbStreet;
        private System.Windows.Forms.TextBox _tbCity;
        private System.Windows.Forms.Button _btAddAddress;
        private System.Windows.Forms.Label _lbHouse;
        private System.Windows.Forms.Label _lbErrors;
    }
}