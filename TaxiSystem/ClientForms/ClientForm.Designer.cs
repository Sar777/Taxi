namespace TaxiSystem.ClientForms
{
    partial class ClientForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._toolStripMyOrders = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this._gbOrder = new System.Windows.Forms.GroupBox();
            this._lbErrors = new System.Windows.Forms.Label();
            this._lbOrderType = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this._cbEAddress = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cbSAddress = new System.Windows.Forms.ComboBox();
            this._btAddOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._toolStripStatusOrder = new System.Windows.Forms.ToolStripStatusLabel();
            this._btOrderCancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this._gbOrder.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripMyOrders,
            this._toolStripSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "_mainMenuStripTool";
            // 
            // _toolStripMyOrders
            // 
            this._toolStripMyOrders.Name = "_toolStripMyOrders";
            this._toolStripMyOrders.Size = new System.Drawing.Size(84, 20);
            this._toolStripMyOrders.Text = "Мои заказы";
            // 
            // _toolStripSettings
            // 
            this._toolStripSettings.Name = "_toolStripSettings";
            this._toolStripSettings.Size = new System.Drawing.Size(79, 20);
            this._toolStripSettings.Text = "Настройки";
            this._toolStripSettings.Click += new System.EventHandler(this._toolStripSettings_Click);
            // 
            // _gbOrder
            // 
            this._gbOrder.Controls.Add(this._btOrderCancel);
            this._gbOrder.Controls.Add(this._lbErrors);
            this._gbOrder.Controls.Add(this._lbOrderType);
            this._gbOrder.Controls.Add(this.label3);
            this._gbOrder.Controls.Add(this._cbEAddress);
            this._gbOrder.Controls.Add(this.label2);
            this._gbOrder.Controls.Add(this._cbSAddress);
            this._gbOrder.Controls.Add(this._btAddOrder);
            this._gbOrder.Controls.Add(this.label1);
            this._gbOrder.Location = new System.Drawing.Point(12, 36);
            this._gbOrder.Name = "_gbOrder";
            this._gbOrder.Size = new System.Drawing.Size(354, 177);
            this._gbOrder.TabIndex = 1;
            this._gbOrder.TabStop = false;
            this._gbOrder.Text = "Заказ";
            // 
            // _lbErrors
            // 
            this._lbErrors.AutoSize = true;
            this._lbErrors.ForeColor = System.Drawing.Color.Crimson;
            this._lbErrors.Location = new System.Drawing.Point(15, 18);
            this._lbErrors.MaximumSize = new System.Drawing.Size(320, 15);
            this._lbErrors.MinimumSize = new System.Drawing.Size(320, 15);
            this._lbErrors.Name = "_lbErrors";
            this._lbErrors.Size = new System.Drawing.Size(320, 15);
            this._lbErrors.TabIndex = 8;
            // 
            // _lbOrderType
            // 
            this._lbOrderType.FormattingEnabled = true;
            this._lbOrderType.Location = new System.Drawing.Point(122, 98);
            this._lbOrderType.Name = "_lbOrderType";
            this._lbOrderType.Size = new System.Drawing.Size(120, 30);
            this._lbOrderType.TabIndex = 7;
            this._lbOrderType.SelectedIndexChanged += new System.EventHandler(this._lbOrderType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип такси:";
            // 
            // _cbEAddress
            // 
            this._cbEAddress.FormattingEnabled = true;
            this._cbEAddress.Location = new System.Drawing.Point(122, 70);
            this._cbEAddress.Name = "_cbEAddress";
            this._cbEAddress.Size = new System.Drawing.Size(215, 21);
            this._cbEAddress.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адрес назначения:";
            // 
            // _cbSAddress
            // 
            this._cbSAddress.FormattingEnabled = true;
            this._cbSAddress.Location = new System.Drawing.Point(122, 45);
            this._cbSAddress.Name = "_cbSAddress";
            this._cbSAddress.Size = new System.Drawing.Size(215, 21);
            this._cbSAddress.TabIndex = 3;
            // 
            // _btAddOrder
            // 
            this._btAddOrder.Enabled = false;
            this._btAddOrder.Location = new System.Drawing.Point(138, 138);
            this._btAddOrder.Name = "_btAddOrder";
            this._btAddOrder.Size = new System.Drawing.Size(75, 23);
            this._btAddOrder.TabIndex = 2;
            this._btAddOrder.Text = "Заказатть";
            this._btAddOrder.UseVisualStyleBackColor = true;
            this._btAddOrder.Click += new System.EventHandler(this._btAddOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текущий адрес:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripStatusOrder});
            this.statusStrip1.Location = new System.Drawing.Point(0, 230);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(381, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _toolStripStatusOrder
            // 
            this._toolStripStatusOrder.Name = "_toolStripStatusOrder";
            this._toolStripStatusOrder.Size = new System.Drawing.Size(69, 17);
            this._toolStripStatusOrder.Text = "Состояние:";
            // 
            // _btOrderCancel
            // 
            this._btOrderCancel.Location = new System.Drawing.Point(259, 101);
            this._btOrderCancel.Name = "_btOrderCancel";
            this._btOrderCancel.Size = new System.Drawing.Size(75, 23);
            this._btOrderCancel.TabIndex = 9;
            this._btOrderCancel.Text = "Отказаться";
            this._btOrderCancel.UseVisualStyleBackColor = true;
            this._btOrderCancel.Click += new System.EventHandler(this._btOrderCancel_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 252);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._gbOrder);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._gbOrder.ResumeLayout(false);
            this._gbOrder.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem _toolStripSettings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox _gbOrder;
        private System.Windows.Forms.ToolStripMenuItem _toolStripMyOrders;
        private System.Windows.Forms.ComboBox _cbSAddress;
        private System.Windows.Forms.Button _btAddOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox _lbOrderType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbEAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _toolStripStatusOrder;
        private System.Windows.Forms.Label _lbErrors;
        private System.Windows.Forms.Button _btOrderCancel;
    }
}

