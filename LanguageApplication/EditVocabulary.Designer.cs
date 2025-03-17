namespace LanguageApplication
{
    partial class EditVocabulary
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtid = new TextBox();
            txtEnglishWord = new TextBox();
            txtVietnamWord = new TextBox();
            txtTranscription = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            cbTitleTopic = new ComboBox();
            cbTitleWordType = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 27);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 71);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "EnglishWord";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 117);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "VietnamWord";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 171);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 3;
            label4.Text = "Transcription";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 222);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 4;
            label5.Text = "Topic";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(161, 273);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 5;
            label6.Text = "WordType";
            // 
            // txtid
            // 
            txtid.Location = new Point(294, 27);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(195, 27);
            txtid.TabIndex = 6;
            // 
            // txtEnglishWord
            // 
            txtEnglishWord.Location = new Point(294, 71);
            txtEnglishWord.Name = "txtEnglishWord";
            txtEnglishWord.Size = new Size(195, 27);
            txtEnglishWord.TabIndex = 7;
            // 
            // txtVietnamWord
            // 
            txtVietnamWord.Location = new Point(294, 110);
            txtVietnamWord.Name = "txtVietnamWord";
            txtVietnamWord.Size = new Size(195, 27);
            txtVietnamWord.TabIndex = 8;
            // 
            // txtTranscription
            // 
            txtTranscription.Location = new Point(294, 164);
            txtTranscription.Name = "txtTranscription";
            txtTranscription.Size = new Size(195, 27);
            txtTranscription.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(483, 326);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 37);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DELETE Vocabulary";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(294, 326);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 37);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "EDIT Vocabulary";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(79, 326);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 37);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ADD Vocabulary";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbTitleTopic
            // 
            cbTitleTopic.FormattingEnabled = true;
            cbTitleTopic.Location = new Point(294, 219);
            cbTitleTopic.Name = "cbTitleTopic";
            cbTitleTopic.Size = new Size(195, 28);
            cbTitleTopic.TabIndex = 15;
            // 
            // cbTitleWordType
            // 
            cbTitleWordType.FormattingEnabled = true;
            cbTitleWordType.Location = new Point(294, 265);
            cbTitleWordType.Name = "cbTitleWordType";
            cbTitleWordType.Size = new Size(195, 28);
            cbTitleWordType.TabIndex = 16;
            // 
            // EditVocabulary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 386);
            Controls.Add(cbTitleWordType);
            Controls.Add(cbTitleTopic);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtTranscription);
            Controls.Add(txtVietnamWord);
            Controls.Add(txtEnglishWord);
            Controls.Add(txtid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditVocabulary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditVocabulary";
            Load += EditVocabulary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtid;
        private TextBox txtEnglishWord;
        private TextBox txtVietnamWord;
        private TextBox txtTranscription;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private ComboBox cbTitleTopic;
        private ComboBox cbTitleWordType;
    }
}