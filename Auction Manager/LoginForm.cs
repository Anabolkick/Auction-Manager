using System;
using System.Windows.Forms;

namespace Auction_Manager
{
    public partial class LoginForm : Form
    {
        private MainForm MainForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void login_btn__Click(object sender, EventArgs e)
        { 
            MainForm.Current_user = UserManager.Login(login_tb.Text, email_tb.Text,pass_tb.Text);
            if (MainForm.Current_user != null)
            {
                Close();
                login_error.Visible = false;
            }
            else
            {
                login_error.Visible = true;
                login_error.Text = "Can`t login to account!";
            }
            
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            MainForm.Current_user = UserManager.Register(login_tb.Text, email_tb.Text,pass_tb.Text);
            if (MainForm.Current_user != null)
            {
                login_error.Visible = false;
                Close();
            }
            else
            {
                login_error.Visible = true;
                login_error.Text = "login/email or password is empty!";
            }
        }

    }
}
