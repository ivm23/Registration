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
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(13, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(132, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "&Date of response required:";
            // 
            // dateTimePickerResponseRequired
            // 
            this.dateTimePickerResponseRequired.Location = new System.Drawing.Point(146, 11);
            this.dateTimePickerResponseRequired.Name = "dateTimePickerResponseRequired";
            this.dateTimePickerResponseRequired.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerResponseRequired.TabIndex = 1;
            // 
            // LetterWithResponseTimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerResponseRequired);
            this.Controls.Add(this.labelDate);
            this.Name = "LetterWithResponseTimeControl";
            this.Size = new System.Drawing.Size(296, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerResponseRequired;
    }
}
