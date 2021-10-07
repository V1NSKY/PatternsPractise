using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.Entities
{
    class User
    {
        private UserRole userRole;
        private String userName = "";
        private String userSurname = "";
        private String userMiddleName = "";
        private String userLogin = "";
        private String userPassword = "";
        private String userPhone = "";
        private String userDescription = "";

        private User (int roleId)
        {
            switch (roleId)
            {
                case 1:
                    userRole = UserRole.user;
                    break;
                case 2:
                    userRole = UserRole.admin;
                    break;
                default:
                    userRole = UserRole.user;
                    break;
            }
        }

        public override string ToString()
        {
            return "Роль: " + userRole + " Имя: " + userName + " Фамилия: " + userSurname + " Отчёство: " + userMiddleName
                + " Логин: " + userLogin + " Пароль: " + userPassword + " Номер телефона: " + userPhone + " Описание:" + userDescription;
        }

        public class UserBuilder
        {
            User user;
            public UserBuilder(int roleId)
            {
                user = new User(roleId);
            }
            public UserBuilder userName(String userName)
            {
                user.userName = userName;
                return this;
            }
            public UserBuilder userSurname(String userSurname)
            {
                user.userSurname = userSurname;
                return this;
            }
            public UserBuilder userMiddleName(String userMiddleName)
            {
                user.userMiddleName = userMiddleName;
                return this;
            }
            public UserBuilder userLogin(String userLogin)
            {
                user.userLogin = userLogin;
                return this;
            }
            public UserBuilder userPassword(String userPassword)
            {
                user.userPassword = userPassword;
                return this;
            }
            public UserBuilder userPhone(String userPhone)
            {
                user.userPhone = userPhone;
                return this;
            }
            public UserBuilder userDescription(String userDescription)
            {
                user.userDescription = userDescription;
                return this;
            }
            public User Build()
            {
                return user;
            }
        }
    }
}
