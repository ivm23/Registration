namespace Registrstion.WinForms.Controlers
{
    partial class ImportantLetterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelImportanceDegree = new System.Windows.Forms.Label();
            this.comboImportanceDegree = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelImportanceDegree
            // 
            this.labelImportanceDegree.AutoSize = true;
            this.labelImportanceDegree.Location = new System.Drawing.Point(3, 9);
            this.labelImportanceDegree.Name = "labelImportanceDegree";
            this.labelImportanceDegree.Size = new System.Drawing.Size(109, 13);
            this.labelImportanceDegree.TabIndex = 0;
            this.labelImportanceDegree.Text = "Degree of importance";
            // 
            // comboImportanceDegree
            // 
            this.comboImportanceDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImportanceDegree.FormattingEnabled = true;
            this.comboImportanceDegree.Items.AddRange(new object[] {
            "Low",
            "Standart",
            "High"});
            this.comboImportanceDegree.Location = new System.Drawing.Point(118, 6);
            this.comboImportanceDegree.Name = "comboImportanceDegree";
            this.comboImportanceDegree.Size = new System.Drawing.Size(121, 21);
            this.comboImportanceDegree.TabIndex = 1;
            // 
            // ImportantLetterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboImportanceDegree);
            this.Controls.Add(this.labelImportanceDegree);
            this.Name = "ImportantLetterControl";
            this.Size = new System.Drawing.Size(251, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImportanceDegree;
        private System.Windows.Forms.ComboBox comboImportanceDegree;
    }
}
