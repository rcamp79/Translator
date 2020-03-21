namespace Translator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.radioButtonLatin = new System.Windows.Forms.RadioButton();
            this.radioButtonGreek = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Translation:";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(15, 25);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(417, 107);
            this.textBoxOriginal.TabIndex = 2;
            this.textBoxOriginal.Enter += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // textBoxTranslation
            // 
            this.textBoxTranslation.Location = new System.Drawing.Point(15, 189);
            this.textBoxTranslation.Multiline = true;
            this.textBoxTranslation.Name = "textBoxTranslation";
            this.textBoxTranslation.Size = new System.Drawing.Size(417, 107);
            this.textBoxTranslation.TabIndex = 4;
            this.textBoxTranslation.TextChanged += new System.EventHandler(this.textBoxTranslation_TextChanged);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.BackColor = System.Drawing.Color.Green;
            this.buttonTranslate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTranslate.Location = new System.Drawing.Point(15, 316);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(75, 30);
            this.buttonTranslate.TabIndex = 5;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = false;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Location = new System.Drawing.Point(96, 316);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 30);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(357, 316);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // radioButtonLatin
            // 
            this.radioButtonLatin.AutoSize = true;
            this.radioButtonLatin.Checked = true;
            this.radioButtonLatin.Location = new System.Drawing.Point(15, 138);
            this.radioButtonLatin.Name = "radioButtonLatin";
            this.radioButtonLatin.Size = new System.Drawing.Size(66, 17);
            this.radioButtonLatin.TabIndex = 8;
            this.radioButtonLatin.TabStop = true;
            this.radioButtonLatin.Text = "Pig Latin";
            this.radioButtonLatin.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreek
            // 
            this.radioButtonGreek.AutoSize = true;
            this.radioButtonGreek.Location = new System.Drawing.Point(106, 138);
            this.radioButtonGreek.Name = "radioButtonGreek";
            this.radioButtonGreek.Size = new System.Drawing.Size(72, 17);
            this.radioButtonGreek.TabIndex = 9;
            this.radioButtonGreek.TabStop = true;
            this.radioButtonGreek.Text = "Pig Greek";
            this.radioButtonGreek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 365);
            this.Controls.Add(this.radioButtonGreek);
            this.Controls.Add(this.radioButtonLatin);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.textBoxTranslation);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxTranslation;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton radioButtonLatin;
        private System.Windows.Forms.RadioButton radioButtonGreek;
    }
}

