namespace LanguageApplication
{
    partial class ViewVocabulary
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
            dgvVocabulary = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVocabulary).BeginInit();
            SuspendLayout();
            // 
            // dgvVocabulary
            // 
            dgvVocabulary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVocabulary.Location = new Point(28, 106);
            dgvVocabulary.Name = "dgvVocabulary";
            dgvVocabulary.RowHeadersWidth = 51;
            dgvVocabulary.Size = new Size(791, 411);
            dgvVocabulary.TabIndex = 0;
            dgvVocabulary.CellClick += dgvVocabulary_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 44);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(245, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(476, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ViewVocabulary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 529);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dgvVocabulary);
            Name = "ViewVocabulary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewVocabulary";
            Load += ViewVocabulary_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVocabulary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVocabulary;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}