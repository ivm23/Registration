﻿namespace Registration.WinForms.Controlers
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
            this.importanceDegreeEditorControl1 = new ImportanceDegreeEditorControl();
            this.fullContentLetterControl1 = new FullContentLetterControl();
            this.SuspendLayout();
            // 
            // labelImportanceDegree
            // 
            this.labelImportanceDegree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelImportanceDegree.AutoSize = true;
            this.labelImportanceDegree.Location = new System.Drawing.Point(382, 56);
            this.labelImportanceDegree.Name = "labelImportanceDegree";
            this.labelImportanceDegree.Size = new System.Drawing.Size(109, 13);
            this.labelImportanceDegree.TabIndex = 23;
            this.labelImportanceDegree.Text = "Degree of importance";
            // 
            // importanceDegreeEditorControl1
            // 
            this.importanceDegreeEditorControl1.Location = new System.Drawing.Point(380, 70);
            this.importanceDegreeEditorControl1.Name = "importanceDegreeEditorControl1";
            this.importanceDegreeEditorControl1.Size = new System.Drawing.Size(111, 30);
            this.importanceDegreeEditorControl1.TabIndex = 38;
            // 
            // fullContentLetterControl1
            // 
            this.fullContentLetterControl1.Location = new System.Drawing.Point(-10, 4);
            this.fullContentLetterControl1.Name = "fullContentLetterControl1";
            this.fullContentLetterControl1.Size = new System.Drawing.Size(544, 457);
            this.fullContentLetterControl1.TabIndex = 39;
            // 
            // ImportantLetterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.importanceDegreeEditorControl1);
            this.Controls.Add(this.labelImportanceDegree);
            this.Controls.Add(this.fullContentLetterControl1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "ImportantLetterControl";
            this.Size = new System.Drawing.Size(555, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelImportanceDegree;
        private ImportanceDegreeEditorControl importanceDegreeEditorControl1;
        private FullContentLetterControl fullContentLetterControl1;
    }
}
