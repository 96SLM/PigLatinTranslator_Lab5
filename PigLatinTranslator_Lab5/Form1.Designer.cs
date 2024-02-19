namespace PigLatinTranslator_Lab5
{
    partial class frmPigLatinTranslator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEnglishText = new TextBox();
            txtPigLatin = new TextBox();
            btnTranslate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblEnglishText = new Label();
            lblPigLatinText = new Label();
            SuspendLayout();
            // 
            // txtEnglishText
            // 
            txtEnglishText.Location = new Point(22, 27);
            txtEnglishText.Multiline = true;
            txtEnglishText.Name = "txtEnglishText";
            txtEnglishText.ScrollBars = ScrollBars.Vertical;
            txtEnglishText.Size = new Size(397, 118);
            txtEnglishText.TabIndex = 0;
            // 
            // txtPigLatin
            // 
            txtPigLatin.Location = new Point(22, 176);
            txtPigLatin.Multiline = true;
            txtPigLatin.Name = "txtPigLatin";
            txtPigLatin.ReadOnly = true;
            txtPigLatin.ScrollBars = ScrollBars.Vertical;
            txtPigLatin.Size = new Size(397, 118);
            txtPigLatin.TabIndex = 1;
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(22, 316);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(75, 23);
            btnTranslate.TabIndex = 2;
            btnTranslate.Text = "&Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(132, 316);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(361, 316);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblEnglishText
            // 
            lblEnglishText.AutoSize = true;
            lblEnglishText.Location = new Point(22, 9);
            lblEnglishText.Name = "lblEnglishText";
            lblEnglishText.Size = new Size(133, 15);
            lblEnglishText.TabIndex = 5;
            lblEnglishText.Text = "Enter English Text Here :";
            // 
            // lblPigLatinText
            // 
            lblPigLatinText.AutoSize = true;
            lblPigLatinText.Location = new Point(22, 158);
            lblPigLatinText.Name = "lblPigLatinText";
            lblPigLatinText.Size = new Size(119, 15);
            lblPigLatinText.TabIndex = 6;
            lblPigLatinText.Text = "Pig Latin Translation :";
            // 
            // frmPigLatinTranslator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(448, 351);
            Controls.Add(lblPigLatinText);
            Controls.Add(lblEnglishText);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnTranslate);
            Controls.Add(txtPigLatin);
            Controls.Add(txtEnglishText);
            Name = "frmPigLatinTranslator";
            Text = "Pig Latin Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEnglishText;
        private TextBox txtPigLatin;
        private Button btnTranslate;
        private Button btnClear;
        private Button btnExit;
        private Label lblEnglishText;
        private Label lblPigLatinText;
    }
}
