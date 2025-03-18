namespace LanguageApplication
{
    partial class PracticePronunciation
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
            txtTranscription = new TextBox();
            txtEnglishWord = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSubmit = new Button();
            lblResuit = new Label();
            SuspendLayout();
            // 
            // txtTranscription
            // 
            txtTranscription.Location = new Point(97, 127);
            txtTranscription.Name = "txtTranscription";
            txtTranscription.ReadOnly = true;
            txtTranscription.Size = new Size(214, 27);
            txtTranscription.TabIndex = 0;
            // 
            // txtEnglishWord
            // 
            txtEnglishWord.Location = new Point(425, 127);
            txtEnglishWord.Name = "txtEnglishWord";
            txtEnglishWord.Size = new Size(214, 27);
            txtEnglishWord.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 70);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Transcription";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 70);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Englis word";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(318, 254);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblResuit
            // 
            lblResuit.AutoSize = true;
            lblResuit.Location = new Point(430, 174);
            lblResuit.Name = "lblResuit";
            lblResuit.Size = new Size(52, 20);
            lblResuit.TabIndex = 3;
            lblResuit.Text = "Resuit:";
            // 
            // PracticePronunciation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResuit);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEnglishWord);
            Controls.Add(txtTranscription);
            Name = "PracticePronunciation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PracticePronunciation";
            Load += PracticePronunciation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTranscription;
        private TextBox txtEnglishWord;
        private Label label1;
        private Label label2;
        private Button btnSubmit;
        private Label lblResuit;
    }
}