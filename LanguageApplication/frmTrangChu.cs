namespace LanguageApplication
{
    public partial class frmTrangChu : Form
    {

        public frmTrangChu()
        {
            InitializeComponent();
            lbusername.Text = "Login";
            EnableAccountManagement(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Login theLogIn = new Login();
            //theLogIn.Show();
        }

        public void setMntFeatureEnableTrue()
        {
            this.mntFeature.Enabled = true;
        }

        public void openLogInForm()
        {
            Login theLogIn = new Login(this);
            theLogIn.Show();
        }

        private void mntLogIn_Click(object sender, EventArgs e)
        {
            openLogInForm();

        }

        private void mntLogOut_Click(object sender, EventArgs e)
        {
            // dang xuat thi phan chuc nang se bi tat
            this.mntFeature.Enabled = false;
            lbusername.Text = "Login";
            openLogInForm();
        }

        private void mntOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mntTopicStudied_Click(object sender, EventArgs e)
        {
            TopicDaHoc theTopicDaHoc = new TopicDaHoc();
            theTopicDaHoc.Show();

        }

        private void lbusername_Click(object sender, EventArgs e)
        {

        }
        public void UpdateUserName(string username)
        {
            lbusername.Text = username;
        }
        public void EnableAccountManagement(bool isVisible)
        {
            smQuanLyTaiKhoan.Visible = isVisible;
        }

        private void smQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            ManagerAcc manager=new ManagerAcc();
            manager.Show();
        }
    }
}
