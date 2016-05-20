namespace TaxiSystem.UserForms.Client
{
    partial class OrderInformationForm
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
            this._lbDateOrder = new System.Windows.Forms.Label();
            this._lbAddressStart = new System.Windows.Forms.Label();
            this._lbAddressEnd = new System.Windows.Forms.Label();
            this._tbOrder = new System.Windows.Forms.TabControl();
            this._tpOrderInfo = new System.Windows.Forms.TabPage();
            this._lbTaxiType = new System.Windows.Forms.Label();
            this._lbStatus = new System.Windows.Forms.Label();
            this._tpDriverInfo = new System.Windows.Forms.TabPage();
            this._lbAutoNumber = new System.Windows.Forms.Label();
            this._lbAutoColor = new System.Windows.Forms.Label();
            this._lbRating = new System.Windows.Forms.Label();
            this._lbAutoMark = new System.Windows.Forms.Label();
            this._tbAutoType = new System.Windows.Forms.Label();
            this._lbDriverName = new System.Windows.Forms.Label();
            this._lbTaxiFor = new System.Windows.Forms.Label();
            this._tbOrder.SuspendLayout();
            this._tpOrderInfo.SuspendLayout();
            this._tpDriverInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lbDateOrder
            // 
            this._lbDateOrder.AutoSize = true;
            this._lbDateOrder.Location = new System.Drawing.Point(7, 36);
            this._lbDateOrder.Name = "_lbDateOrder";
            this._lbDateOrder.Size = new System.Drawing.Size(75, 13);
            this._lbDateOrder.TabIndex = 0;
            this._lbDateOrder.Text = "Дата заказа: ";
            // 
            // _lbAddressStart
            // 
            this._lbAddressStart.AutoSize = true;
            this._lbAddressStart.Location = new System.Drawing.Point(7, 83);
            this._lbAddressStart.Name = "_lbAddressStart";
            this._lbAddressStart.Size = new System.Drawing.Size(80, 13);
            this._lbAddressStart.TabIndex = 1;
            this._lbAddressStart.Text = "Адрес заказа: ";
            // 
            // _lbAddressEnd
            // 
            this._lbAddressEnd.AutoSize = true;
            this._lbAddressEnd.Location = new System.Drawing.Point(7, 107);
            this._lbAddressEnd.Name = "_lbAddressEnd";
            this._lbAddressEnd.Size = new System.Drawing.Size(103, 13);
            this._lbAddressEnd.TabIndex = 2;
            this._lbAddressEnd.Text = "Адрес назначения: ";
            // 
            // _tbOrder
            // 
            this._tbOrder.Controls.Add(this._tpOrderInfo);
            this._tbOrder.Controls.Add(this._tpDriverInfo);
            this._tbOrder.Location = new System.Drawing.Point(12, 12);
            this._tbOrder.Name = "_tbOrder";
            this._tbOrder.SelectedIndex = 0;
            this._tbOrder.Size = new System.Drawing.Size(273, 187);
            this._tbOrder.TabIndex = 4;
            // 
            // _tpOrderInfo
            // 
            this._tpOrderInfo.Controls.Add(this._lbTaxiFor);
            this._tpOrderInfo.Controls.Add(this._lbTaxiType);
            this._tpOrderInfo.Controls.Add(this._lbStatus);
            this._tpOrderInfo.Controls.Add(this._lbAddressStart);
            this._tpOrderInfo.Controls.Add(this._lbDateOrder);
            this._tpOrderInfo.Controls.Add(this._lbAddressEnd);
            this._tpOrderInfo.Location = new System.Drawing.Point(4, 22);
            this._tpOrderInfo.Name = "_tpOrderInfo";
            this._tpOrderInfo.Padding = new System.Windows.Forms.Padding(3);
            this._tpOrderInfo.Size = new System.Drawing.Size(265, 161);
            this._tpOrderInfo.TabIndex = 0;
            this._tpOrderInfo.Text = "Информация о заказе";
            this._tpOrderInfo.UseVisualStyleBackColor = true;
            // 
            // _lbTaxiType
            // 
            this._lbTaxiType.AutoSize = true;
            this._lbTaxiType.Location = new System.Drawing.Point(7, 59);
            this._lbTaxiType.Name = "_lbTaxiType";
            this._lbTaxiType.Size = new System.Drawing.Size(61, 13);
            this._lbTaxiType.TabIndex = 4;
            this._lbTaxiType.Text = "Тип такси: ";
            // 
            // _lbStatus
            // 
            this._lbStatus.AutoSize = true;
            this._lbStatus.Location = new System.Drawing.Point(7, 131);
            this._lbStatus.Name = "_lbStatus";
            this._lbStatus.Size = new System.Drawing.Size(64, 13);
            this._lbStatus.TabIndex = 3;
            this._lbStatus.Text = "Состояние: ";
            // 
            // _tpDriverInfo
            // 
            this._tpDriverInfo.Controls.Add(this._lbAutoNumber);
            this._tpDriverInfo.Controls.Add(this._lbAutoColor);
            this._tpDriverInfo.Controls.Add(this._lbRating);
            this._tpDriverInfo.Controls.Add(this._lbAutoMark);
            this._tpDriverInfo.Controls.Add(this._tbAutoType);
            this._tpDriverInfo.Controls.Add(this._lbDriverName);
            this._tpDriverInfo.Location = new System.Drawing.Point(4, 22);
            this._tpDriverInfo.Name = "_tpDriverInfo";
            this._tpDriverInfo.Padding = new System.Windows.Forms.Padding(3);
            this._tpDriverInfo.Size = new System.Drawing.Size(265, 161);
            this._tpDriverInfo.TabIndex = 1;
            this._tpDriverInfo.Text = "О водителе";
            this._tpDriverInfo.UseVisualStyleBackColor = true;
            // 
            // _lbAutoNumber
            // 
            this._lbAutoNumber.AutoSize = true;
            this._lbAutoNumber.Location = new System.Drawing.Point(8, 109);
            this._lbAutoNumber.Name = "_lbAutoNumber";
            this._lbAutoNumber.Size = new System.Drawing.Size(66, 13);
            this._lbAutoNumber.TabIndex = 5;
            this._lbAutoNumber.Text = "Гос. номер: ";
            // 
            // _lbAutoColor
            // 
            this._lbAutoColor.AutoSize = true;
            this._lbAutoColor.Location = new System.Drawing.Point(8, 83);
            this._lbAutoColor.Name = "_lbAutoColor";
            this._lbAutoColor.Size = new System.Drawing.Size(35, 13);
            this._lbAutoColor.TabIndex = 4;
            this._lbAutoColor.Text = "Цвет: ";
            // 
            // _lbRating
            // 
            this._lbRating.AutoSize = true;
            this._lbRating.Location = new System.Drawing.Point(8, 134);
            this._lbRating.Name = "_lbRating";
            this._lbRating.Size = new System.Drawing.Size(51, 13);
            this._lbRating.TabIndex = 3;
            this._lbRating.Text = "Рейтинг: ";
            // 
            // _lbAutoMark
            // 
            this._lbAutoMark.AutoSize = true;
            this._lbAutoMark.Location = new System.Drawing.Point(8, 60);
            this._lbAutoMark.Name = "_lbAutoMark";
            this._lbAutoMark.Size = new System.Drawing.Size(107, 13);
            this._lbAutoMark.TabIndex = 2;
            this._lbAutoMark.Text = "Марка автомобиля: ";
            // 
            // _tbAutoType
            // 
            this._tbAutoType.AutoSize = true;
            this._tbAutoType.Location = new System.Drawing.Point(8, 36);
            this._tbAutoType.Name = "_tbAutoType";
            this._tbAutoType.Size = new System.Drawing.Size(93, 13);
            this._tbAutoType.TabIndex = 1;
            this._tbAutoType.Text = "Тип автомобиля: ";
            // 
            // _lbDriverName
            // 
            this._lbDriverName.AutoSize = true;
            this._lbDriverName.Location = new System.Drawing.Point(8, 12);
            this._lbDriverName.Name = "_lbDriverName";
            this._lbDriverName.Size = new System.Drawing.Size(32, 13);
            this._lbDriverName.TabIndex = 0;
            this._lbDriverName.Text = "Имя: ";
            // 
            // _lbTaxiFor
            // 
            this._lbTaxiFor.AutoSize = true;
            this._lbTaxiFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lbTaxiFor.Location = new System.Drawing.Point(7, 13);
            this._lbTaxiFor.Name = "_lbTaxiFor";
            this._lbTaxiFor.Size = new System.Drawing.Size(72, 13);
            this._lbTaxiFor.TabIndex = 5;
            this._lbTaxiFor.Text = "Такси для ";
            // 
            // OrderInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 206);
            this.Controls.Add(this._tbOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderInformationForm";
            this.Text = "Информация о заказе #";
            this.Load += new System.EventHandler(this.OrderInformationForm_Load);
            this._tbOrder.ResumeLayout(false);
            this._tpOrderInfo.ResumeLayout(false);
            this._tpOrderInfo.PerformLayout();
            this._tpDriverInfo.ResumeLayout(false);
            this._tpDriverInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lbDateOrder;
        private System.Windows.Forms.Label _lbAddressStart;
        private System.Windows.Forms.Label _lbAddressEnd;
        private System.Windows.Forms.TabControl _tbOrder;
        private System.Windows.Forms.TabPage _tpOrderInfo;
        private System.Windows.Forms.TabPage _tpDriverInfo;
        private System.Windows.Forms.Label _lbStatus;
        private System.Windows.Forms.Label _lbRating;
        private System.Windows.Forms.Label _lbAutoMark;
        private System.Windows.Forms.Label _tbAutoType;
        private System.Windows.Forms.Label _lbDriverName;
        private System.Windows.Forms.Label _lbAutoColor;
        private System.Windows.Forms.Label _lbTaxiType;
        private System.Windows.Forms.Label _lbAutoNumber;
        private System.Windows.Forms.Label _lbTaxiFor;
    }
}