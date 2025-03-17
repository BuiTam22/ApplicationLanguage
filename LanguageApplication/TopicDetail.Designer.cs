namespace LanguageApplication
{
    partial class TopicDetail
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
            btnViewVocabulary = new Button();
            btnPracticeVocabulary = new Button();
            btnPracticePronunciation = new Button();
            SuspendLayout();
            // 
            // btnViewVocabulary
            // 
            btnViewVocabulary.Location = new Point(79, 78);
            btnViewVocabulary.Name = "btnViewVocabulary";
            btnViewVocabulary.Size = new Size(159, 29);
            btnViewVocabulary.TabIndex = 0;
            btnViewVocabulary.Text = "View Vocabulary";
            btnViewVocabulary.UseVisualStyleBackColor = true;
            btnViewVocabulary.Click += btnViewVocabulary_Click;
            // 
            // btnPracticeVocabulary
            // 
            btnPracticeVocabulary.Location = new Point(281, 78);
            btnPracticeVocabulary.Name = "btnPracticeVocabulary";
            btnPracticeVocabulary.Size = new Size(159, 29);
            btnPracticeVocabulary.TabIndex = 0;
            btnPracticeVocabulary.Text = "Practice Vocabulary";
            btnPracticeVocabulary.UseVisualStyleBackColor = true;
            btnPracticeVocabulary.Click += btnPracticeVocabulary_Click;
            // 
            // btnPracticePronunciation
            // 
            btnPracticePronunciation.Location = new Point(171, 163);
            btnPracticePronunciation.Name = "btnPracticePronunciation";
            btnPracticePronunciation.Size = new Size(221, 29);
            btnPracticePronunciation.TabIndex = 0;
            btnPracticePronunciation.Text = "Practice Pronunciation";
            btnPracticePronunciation.UseVisualStyleBackColor = true;
            btnPracticePronunciation.Click += btnPracticePronunciation_Click;
            // 
            // TopicDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 397);
            Controls.Add(btnPracticePronunciation);
            Controls.Add(btnPracticeVocabulary);
            Controls.Add(btnViewVocabulary);
            Name = "TopicDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TopicDetail";
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewVocabulary;
        private Button btnPracticeVocabulary;
        private Button btnPracticePronunciation;
    }
}