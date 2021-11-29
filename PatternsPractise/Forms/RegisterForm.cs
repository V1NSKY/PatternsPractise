using PatternsPractise.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;
using static PatternsPractise.Entities.User;

namespace PatternsPractise.Forms
{
    public partial class RegisterForm : Form
    {
        static private RegisterForm registerForm;
        private RegisterForm()
        {
            InitializeComponent();
        }
        public static RegisterForm GetRegisterForm()
        {
            if (registerForm == null || registerForm.IsDisposed)
            {
                return registerForm = new RegisterForm();
            }
            else
            {
                return registerForm;
            }
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            if(Session.daoUser.GetUserIdByLogin(loginTextBox.Text.ToString()) == 0 && loginTextBox.Text != "")
            {
                notLoginLabel.ForeColor = Color.Green;
                notLoginLabel.Visible = true;
                Session.daoUser.AddUser(new UserBuilder(Convert.ToInt32(roleComboBox.SelectedItem))
                .userName(nameTextBox.Text.ToString())
                .userSurname(surnameTextBox.Text.ToString())
                .userMiddleName(middlenameTextBox.Text.ToString())
                .userLogin(loginTextBox.Text.ToString())
                .userPassword(passwordTextBox.Text.ToString())
                .userDescription(descriptionTextBox.Text.ToString())
                .Build());
                notLoginLabel.Text = "Пользователь зарегистрирован";
            }
            else
            {
                notLoginLabel.ForeColor = Color.FromArgb(255, 76, 41);
                notLoginLabel.Text = "Логин занят";
                notLoginLabel.Visible = true;
                loginTextBox.Text = "";
            }
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            roleComboBox.SelectedItem = 1;
            if(Session.user != null)
            {
                if (Session.user.UserRole == UserRole.Admin)
                {
                    roleLabel.Visible = true;
                    roleComboBox.Visible = true;
                }
            }
            
        }
    }
}
