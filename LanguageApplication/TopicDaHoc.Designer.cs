namespace LanguageApplication
{
    partial class TopicDaHoc
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
            cbtopic = new ComboBox();
            btnThem = new Button();
            btnEdit = new Button();
            btndelete = new Button();
            btnHoc = new Button();
            label1 = new Label();
            txtNameTopic = new TextBox();
            label2 = new Label();
            txtid = new TextBox();
            label3 = new Label();
            txtdescription = new TextBox();
            label4 = new Label();
            txtuserNameCreated = new TextBox();
            SuspendLayout();
            // 
            // cbtopic
            // 
            cbtopic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbtopic.FormattingEnabled = true;
            cbtopic.Location = new Point(264, 32);
            cbtopic.Name = "cbtopic";
            cbtopic.Size = new Size(232, 36);
            cbtopic.TabIndex = 0;
            cbtopic.Text = "Chọn Topic";
            cbtopic.SelectedIndexChanged += cbtopic_SelectedIndexChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(56, 318);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Add topic";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(226, 318);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit topic";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(378, 320);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(108, 29);
            btndelete.TabIndex = 3;
            btndelete.Text = "Delete Topic";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnHoc
            // 
            btnHoc.Location = new Point(543, 320);
            btnHoc.Name = "btnHoc";
            btnHoc.Size = new Size(107, 29);
            btnHoc.TabIndex = 4;
            btnHoc.Text = "Topic Detail";
            btnHoc.UseVisualStyleBackColor = true;
            btnHoc.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 182);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 6;
            label1.Text = "Name topic";
            // 
            // txtNameTopic
            // 
            txtNameTopic.Location = new Point(226, 175);
            txtNameTopic.Name = "txtNameTopic";
            txtNameTopic.Size = new Size(125, 27);
            txtNameTopic.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 100);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 7;
            label2.Text = "Id";
            // 
            // txtid
            // 
            txtid.Location = new Point(226, 97);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 223);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 9;
            label3.Text = "Description";
            // 
            // txtdescription
            // 
            txtdescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdescription.Location = new Point(226, 213);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(513, 34);
            txtdescription.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 141);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 11;
            label4.Text = "Username created";
            // 
            // txtuserNameCreated
            // 
            txtuserNameCreated.Location = new Point(226, 138);
            txtuserNameCreated.Name = "txtuserNameCreated";
            txtuserNameCreated.ReadOnly = true;
            txtuserNameCreated.Size = new Size(125, 27);
            txtuserNameCreated.TabIndex = 12;
            // 
            // TopicDaHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtuserNameCreated);
            Controls.Add(label4);
            Controls.Add(txtdescription);
            Controls.Add(label3);
            Controls.Add(txtid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNameTopic);
            Controls.Add(btnHoc);
            Controls.Add(btndelete);
            Controls.Add(btnEdit);
            Controls.Add(btnThem);
            Controls.Add(cbtopic);
            Name = "TopicDaHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Topic Đã Học";
            Load += TopicDaHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbtopic;
        private Button btnThem;
        private Button btnEdit;
        private Button btndelete;
        private Button btnHoc;
        private Label label1;
        private TextBox txtNameTopic;
        private Label label2;
        private TextBox txtid;
        private Label label3;
        private TextBox txtdescription;
        private Label label4;
        private TextBox txtuserNameCreated;
    }
}