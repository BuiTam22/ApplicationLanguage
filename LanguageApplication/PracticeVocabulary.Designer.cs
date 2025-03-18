namespace LanguageApplication
{
    partial class PracticeVocabulary
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
            txtVietnameseWord = new TextBox();
            txtEnglishWord = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSubmit = new Button();
            lblResuit = new Label();
            SuspendLayout();
            // 
            // txtVietnameseWord
            // 
            txtVietnameseWord.Location = new Point(46, 119);
            txtVietnameseWord.Name = "txtVietnameseWord";
            txtVietnameseWord.ReadOnly = true;
            txtVietnameseWord.Size = new Size(231, 27);
            txtVietnameseWord.TabIndex = 0;
            // 
            // txtEnglishWord
            // 
            txtEnglishWord.Location = new Point(417, 119);
            txtEnglishWord.Name = "txtEnglishWord";
            txtEnglishWord.Size = new Size(209, 27);
            txtEnglishWord.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 74);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Vietnamese word";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 74);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "English word";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(286, 252);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // lblResuit
            // 
            lblResuit.AutoSize = true;
            lblResuit.Location = new Point(417, 163);
            lblResuit.Name = "lblResuit";
            lblResuit.Size = new Size(52, 20);
            lblResuit.TabIndex = 1;
            lblResuit.Text = "Resuit:";
            lblResuit.Click += label1_Click;
            // 
            // PracticeVocabulary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 450);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(lblResuit);
            Controls.Add(label1);
            Controls.Add(txtEnglishWord);
            Controls.Add(txtVietnameseWord);
            Name = "PracticeVocabulary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PracticeVocabulary";
            Load += PracticeVocabulary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVietnameseWord;
        private TextBox txtEnglishWord;
        private Label label1;
        private Label label2;
        private Button btnSubmit;
        private Label lblResuit;
    }
}