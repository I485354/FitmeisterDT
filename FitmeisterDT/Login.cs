using BLL.Admin;
using BLL.Interface;
using Models.Model;

namespace FitmeisterDT
{
    public partial class Login : Form
    {
        public readonly IUserBLL userBLL;
        public Login(IUserBLL user)
        {
            InitializeComponent();
            this.userBLL = user;

        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = LoginEmailTxt.Text;
            string pass = passLoginTxt.Text;
            FitmeisterUser user;

            if (userBLL.IsUserAdmin(email,pass,out user))
            {
                new AdminPage(userBLL).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect data");
                LoginEmailTxt.Clear();
                passLoginTxt.Clear();
            }
        }
        private void CancelLoginBtn_Click(Object sender, EventArgs e) 
        {
            this.Close();
        }
    }
}
