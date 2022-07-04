using Microsoft.Extensions.Configuration;
using DataAccess;
using DataAccess.Repository;
using BusinessObject.Models;
using BusinessObject;
namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) 
        {
            var adminLogin = Program.Configuration.GetSection("AdminAccount").Get<MemberTest>();

            string Email = adminLogin.Email;
            string Password = adminLogin.Password;

            string _Email = txtEmail.Text;
            string _Password = txtPassword.Text;

            if(Email.Equals(_Email) && Password.Equals(_Password))
            {
                frmMain  frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
            }


        }
    }
}