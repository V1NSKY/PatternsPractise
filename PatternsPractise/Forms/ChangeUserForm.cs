﻿using PatternsPractise.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;
using static PatternsPractise.Entities.User;

namespace PatternsPractise.Forms
{
    public partial class ChangeUserForm : Form
    {
        User user;
        static private ChangeUserForm changeUserForm;
        private ChangeUserForm()
        {
            InitializeComponent();
        }
        public static ChangeUserForm GetChangeUserForm()
        {
            if(changeUserForm == null || changeUserForm.IsDisposed)
            {
                return changeUserForm = new ChangeUserForm();
            }
            else
            {
                return changeUserForm;
            }
        }

        private void ChangeUserForm_Load(object sender, EventArgs e)
        {
            user = Session.daoUser.GetUserById(Session.user.UserId);

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
            if (Session.daoUser.GetUserIdByLogin(loginTextBox.Text.ToString()) == user.UserId && loginTextBox.Text != "" || Session.daoUser.GetUserIdByLogin(loginTextBox.Text.ToString()) != user.UserId && Session.daoUser.GetUserIdByLogin(loginTextBox.Text.ToString()) == 0 && loginTextBox.Text != "")
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

                Session.SetUser(newUser);

                Session.daoUser.UpdateUser(newUser);

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
