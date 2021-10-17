using PatternsPractise.DAO;
using PatternsPractise.DAO.FactoryDAOUser;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PatternsPractise.Entities.User;

namespace PatternsPractise.Forms
{
    public partial class ChangeUserForm : Form
    {
        User user;
        public ChangeUserForm()
        {
            InitializeComponent();
        }

        private void ChangeUserForm_Load(object sender, EventArgs e)
        {
            CreatorDAOUser creatorDAOUser = new CreatorSQLDAOUser();
            IDAOUser daoUser = creatorDAOUser.FactoryMetod();

            user = daoUser.GetUserById(Session.user.UserId);

            nameTextBox.Text = user.UserName;
            surnameTextBox.Text = user.UserSurname;
            middlenameTextBox.Text = user.UserMiddleName;
            loginTextBox.Text = user.UserLogin;
            passwordTextBox.Text = user.UserPassword;
            phoneTextBox.Text = user.UserPhone;
            descriptionTextBox.Text = user.UserDescription;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            CreatorDAOUser creatorDAOUser = new CreatorSQLDAOUser();
            IDAOUser daoUser = creatorDAOUser.FactoryMetod();

            

            if (daoUser.GetUserIdByLogin(loginTextBox.Text.ToString()) == user.UserId && loginTextBox.Text != "" || daoUser.GetUserIdByLogin(loginTextBox.Text.ToString()) != user.UserId && daoUser.GetUserIdByLogin(loginTextBox.Text.ToString()) == 0 && loginTextBox.Text != "")
            {

                User newUser = new UserBuilder(((int)user.UserRole))
                    .userId(user.UserId)
                    .userName(nameTextBox.Text.ToString())
                    .userSurname(surnameTextBox.Text.ToString())
                    .userMiddleName(middlenameTextBox.Text.ToString())
                    .userLogin(loginTextBox.Text.ToString())
                    .userPassword(passwordTextBox.Text.ToString())
                    .userPhone(phoneTextBox.Text)
                    .userDescription(descriptionTextBox.Text.ToString())
                    .Build();

                daoUser.UpdateUser(newUser);

                Session.SetUser(newUser);

                DialogResult result = MessageBox.Show(
                    "Пользователь изменён",
                    "Изменено",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );

                if (result == DialogResult.OK)
                {
                    this.Close();
                }

                this.Close(); 
            }
            else
            {
                notLoginLabel.ForeColor = Color.FromArgb(255, 76, 41);
                notLoginLabel.Text = "Логин занят";
                notLoginLabel.Visible = true;
                loginTextBox.Text = "";
            }

            

           
        }
    }
}
