namespace LanguageApplication
{
    partial class ManagerAcc
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
            dgvManagerAcc = new DataGridView();
            label1 = new Label();
            txtSearchAcc = new TextBox();
            btnSreachAcc = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvManagerAcc).BeginInit();
            SuspendLayout();
            // 
            // dgvManagerAcc
            // 
            dgvManagerAcc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManagerAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManagerAcc.Location = new Point(12, 77);
            dgvManagerAcc.Name = "dgvManagerAcc";
            dgvManagerAcc.RowHeadersWidth = 51;
            dgvManagerAcc.Size = new Size(764, 361);
            dgvManagerAcc.TabIndex = 0;
            dgvManagerAcc.CellClick += dgvManagerAcc_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 34);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm Kiếm";
            // 
            // txtSearchAcc
            // 
            txtSearchAcc.Location = new Point(243, 31);
            txtSearchAcc.Name = "txtSearchAcc";
            txtSearchAcc.Size = new Size(259, 27);
            txtSearchAcc.TabIndex = 2;
            // 
            // btnSreachAcc
            // 
            btnSreachAcc.Location = new Point(534, 30);
            btnSreachAcc.Name = "btnSreachAcc";
            btnSreachAcc.Size = new Size(94, 29);
            btnSreachAcc.TabIndex = 3;
            btnSreachAcc.Text = "Tìm Kiếm";
            btnSreachAcc.UseVisualStyleBackColor = true;
            // 
            // ManagerAcc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSreachAcc);
            Controls.Add(txtSearchAcc);
            Controls.Add(label1);
            Controls.Add(dgvManagerAcc);
            Name = "ManagerAcc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerAcc";
            Load += ManagerAcc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManagerAcc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvManagerAcc;
        private Label label1;
        private TextBox txtSearchAcc;
        private Button btnSreachAcc;
    }
}