namespace LanguageApplication
{
    partial class frmTrangChu
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
            menuStrip1 = new MenuStrip();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            mntLogIn = new ToolStripMenuItem();
            mntLogOut = new ToolStripMenuItem();
            mntOut = new ToolStripMenuItem();
            mntFeature = new ToolStripMenuItem();
            mntTopicStudied = new ToolStripMenuItem();
            thêmToolStripMenuItem = new ToolStripMenuItem();
            smQuanLyTaiKhoan = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            lbusername = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, mntFeature, thêmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(875, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mntLogIn, mntLogOut, mntOut });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(87, 24);
            tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // mntLogIn
            // 
            mntLogIn.Name = "mntLogIn";
            mntLogIn.Size = new Size(165, 26);
            mntLogIn.Text = "Đăng nhập";
            mntLogIn.Click += mntLogIn_Click;
            // 
            // mntLogOut
            // 
            mntLogOut.Name = "mntLogOut";
            mntLogOut.Size = new Size(165, 26);
            mntLogOut.Text = "Đăng xuất";
            mntLogOut.Click += mntLogOut_Click;
            // 
            // mntOut
            // 
            mntOut.Name = "mntOut";
            mntOut.Size = new Size(165, 26);
            mntOut.Text = "Thoát";
            mntOut.Click += mntOut_Click;
            // 
            // mntFeature
            // 
            mntFeature.DropDownItems.AddRange(new ToolStripItem[] { mntTopicStudied });
            mntFeature.Enabled = false;
            mntFeature.Name = "mntFeature";
            mntFeature.Size = new Size(93, 24);
            mntFeature.Text = "Chức năng";
            // 
            // mntTopicStudied
            // 
            mntTopicStudied.Name = "mntTopicStudied";
            mntTopicStudied.Size = new Size(177, 26);
            mntTopicStudied.Text = "Topic đã học";
            mntTopicStudied.Click += mntTopicStudied_Click;
            // 
            // thêmToolStripMenuItem
            // 
            thêmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smQuanLyTaiKhoan });
            thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            thêmToolStripMenuItem.Size = new Size(60, 24);
            thêmToolStripMenuItem.Text = "Thêm";
            // 
            // smQuanLyTaiKhoan
            // 
            smQuanLyTaiKhoan.Name = "smQuanLyTaiKhoan";
            smQuanLyTaiKhoan.Size = new Size(224, 26);
            smQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            smQuanLyTaiKhoan.Click += smQuanLyTaiKhoan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(275, 133);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(324, 46);
            label1.TabIndex = 1;
            label1.Text = "Lady and gentlemen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(229, 227);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(459, 46);
            label2.TabIndex = 1;
            label2.Text = "Wecome to Group 4's Project";
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbusername.Location = new Point(742, 42);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(59, 25);
            lbusername.TabIndex = 2;
            lbusername.Text = "label3";
            lbusername.Click += lbusername_Click;
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(875, 592);
            Controls.Add(lbusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem mntLogIn;
        private ToolStripMenuItem mntLogOut;
        private ToolStripMenuItem mntOut;
        private ToolStripMenuItem mntFeature;
        private ToolStripMenuItem thêmToolStripMenuItem;
        private ToolStripMenuItem mntTopicStudied;
        private Label label1;
        private Label label2;
        private Label lbusername;
        private ToolStripMenuItem smQuanLyTaiKhoan;
    }
}
