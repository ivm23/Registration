namespace Registrstion.WinForms.Controlers
{
    partial class LetterWithResponseTimeControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerResponseRequired = new System.Windows.Forms.DateTimePicker();
            this.addReceiversB = new System.Windows.Forms.Button();
            this.nameReceiversTB = new System.Windows.Forms.TextBox();
            this.nameReceiversCB = new System.Windows.Forms.ComboBox();
            this.textLetterTB = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelReceivers = new System.Windows.Forms.Label();
            this.nameSenderTB = new System.Windows.Forms.TextBox();
            this.labelSender = new System.Windows.Forms.Label();
            this.dateLetterTB = new System.Windows.Forms.TextBox();
            this.nameLetterTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(412, 56);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(132, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "&Date of response required:";
            // 
            // dateTimePickerResponseRequired
            // 
            this.dateTimePickerResponseRequired.Location = new System.Drawing.Point(415, 72);
            this.dateTimePickerResponseRequired.Name = "dateTimePickerResponseRequired";
            this.dateTimePickerResponseRequired.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerResponseRequired.TabIndex = 1;
            // 
            // addReceiversB
            // 
            this.addReceiversB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addReceiversB.Location = new System.Drawing.Point(415, 109);
            this.addReceiversB.Name = "addReceiversB";
            this.addReceiversB.Size = new System.Drawing.Size(87, 23);
            this.addReceiversB.TabIndex = 25;
            this.addReceiversB.Text = "Add";
            this.addReceiversB.UseVisualStyleBackColor = true;
            this.addReceiversB.Click += new System.EventHandler(this.addReceiversB_Click);
            // 
            // nameReceiversTB
            // 
            this.nameReceiversTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameReceiversTB.Location = new System.Drawing.Point(40, 111);
            this.nameReceiversTB.Name = "nameReceiversTB";
            this.nameReceiversTB.ReadOnly = true;
            this.nameReceiversTB.Size = new System.Drawing.Size(330, 20);
            this.nameReceiversTB.TabIndex = 24;
            // 
            // nameReceiversCB
            // 
            this.nameReceiversCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameReceiversCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameReceiversCB.FormattingEnabled = true;
            this.nameReceiversCB.Location = new System.Drawing.Point(40, 110);
            this.nameReceiversCB.Name = "nameReceiversCB";
            this.nameReceiversCB.Size = new System.Drawing.Size(330, 21);
            this.nameReceiversCB.TabIndex = 23;
            this.nameReceiversCB.Visible = false;
            // 
            // textLetterTB
            // 
            this.textLetterTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLetterTB.Location = new System.Drawing.Point(40, 154);
            this.textLetterTB.Multiline = true;
            this.textLetterTB.Name = "textLetterTB";
            this.textLetterTB.ReadOnly = true;
            this.textLetterTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLetterTB.Size = new System.Drawing.Size(330, 296);
            this.textLetterTB.TabIndex = 22;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(37, 138);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 21;
            this.labelMessage.Text = "&Message";
            // 
            // labelReceivers
            // 
            this.labelReceivers.AutoSize = true;
            this.labelReceivers.Location = new System.Drawing.Point(37, 94);
            this.labelReceivers.Name = "labelReceivers";
            this.labelReceivers.Size = new System.Drawing.Size(55, 13);
            this.labelReceivers.TabIndex = 20;
            this.labelReceivers.Text = "&Receivers";
            // 
            // nameSenderTB
            // 
            this.nameSenderTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSenderTB.Location = new System.Drawing.Point(40, 71);
            this.nameSenderTB.Name = "nameSenderTB";
            this.nameSenderTB.ReadOnly = true;
            this.nameSenderTB.Size = new System.Drawing.Size(330, 20);
            this.nameSenderTB.TabIndex = 19;
            // 
            // labelSender
            // 
            this.labelSender.AutoSize = true;
            this.labelSender.Location = new System.Drawing.Point(37, 55);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(41, 13);
            this.labelSender.TabIndex = 18;
            this.labelSender.Text = "&Sender";
            // 
            // dateLetterTB
            // 
            this.dateLetterTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLetterTB.BackColor = System.Drawing.SystemColors.Control;
            this.dateLetterTB.Location = new System.Drawing.Point(415, 30);
            this.dateLetterTB.Name = "dateLetterTB";
            this.dateLetterTB.ReadOnly = true;
            this.dateLetterTB.Size = new System.Drawing.Size(118, 20);
            this.dateLetterTB.TabIndex = 17;
            // 
            // nameLetterTB
            // 
            this.nameLetterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLetterTB.Location = new System.Drawing.Point(40, 32);
            this.nameLetterTB.Name = "nameLetterTB";
            this.nameLetterTB.ReadOnly = true;
            this.nameLetterTB.Size = new System.Drawing.Size(330, 20);
            this.nameLetterTB.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "&Date";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(37, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "&Name";
            // 
            // LetterWithResponseTimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addReceiversB);
            this.Controls.Add(this.nameReceiversTB);
            this.Controls.Add(this.nameReceiversCB);
            this.Controls.Add(this.textLetterTB);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelReceivers);
            this.Controls.Add(this.nameSenderTB);
            this.Controls.Add(this.labelSender);
            this.Controls.Add(this.dateLetterTB);
            this.Controls.Add(this.nameLetterTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dateTimePickerResponseRequired);
            this.Controls.Add(this.labelDate);
            this.Name = "LetterWithResponseTimeControl";
            this.Size = new System.Drawing.Size(609, 481);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerResponseRequired;
        private System.Windows.Forms.Button addReceiversB;
        private System.Windows.Forms.TextBox nameReceiversTB;
        private System.Windows.Forms.ComboBox nameReceiversCB;
        private System.Windows.Forms.TextBox textLetterTB;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelReceivers;
        private System.Windows.Forms.TextBox nameSenderTB;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.TextBox dateLetterTB;
        private System.Windows.Forms.TextBox nameLetterTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
    }
}
