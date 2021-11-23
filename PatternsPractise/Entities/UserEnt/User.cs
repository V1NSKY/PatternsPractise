using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.Entities
{
    [BsonIgnoreExtraElements]
    public class User
    {
        private UserRole userRole;
        private int userId;
        private String userName = "";
        private String userSurname = "";
        private String? userMiddleName = "";
        private String userLogin = "";
        private String userPassword = "";
        private String? userPhone = "";
        private String? userDescription = "";

        private User (int roleId)
        {
            switch (roleId)
            {
                case 1:
                    userRole = UserRole.User;
                    break;
                case 2:
                    userRole = UserRole.Admin;
                    break;
                default:
                    userRole = UserRole.User;
                    break;
            }
        }
        public int UserId
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
            }
        }
        public UserRole UserRole
        {
            get
            {
                return this.userRole;
            }
            private set
            {
                this.userRole = value;
            }
        }
        public String UserName
        {
            get
            {
                return this.userName;
            }
            private set
            {
                this.userName = value;
            }
        }
        public String UserSurname
        {
            get
            {
                return this.userSurname;
            }
            private set
            {
                this.userSurname = value;
            }
        }
        public String UserMiddleName
        {
            get
            {
                return this.userMiddleName;
            }
            private set
            {
                this.userMiddleName = value;
            }
        }
        public String UserLogin
        {
            get
            {
                return this.userLogin;
            }
            private set
            {
                this.userLogin = value;
            }
        }
        public String UserPassword
        {
            get
            {
                return this.userPassword;
            }
            private set
            {
                this.userPassword = value;
            }
        }
        public String UserPhone
        {
            get
            {
                return this.userPhone;
            }
            private set
            {
                this.userPhone = value;
            }
        }
        public String UserDescription
        {
            get
            {
                return this.userDescription;
            }
            private set
            {
                this.userDescription = value;
            }
        }

        public override string ToString()
        {
            return "Роль: " + ((int)userRole) + " Имя: " + userName + " Фамилия: " + userSurname + " Отчёство: " + userMiddleName
                + " Логин: " + userLogin + " Пароль: " + userPassword + " Номер телефона: " + userPhone + " Описание:" + userDescription;
        }

        public class UserBuilder
        {
            User user;
            public UserBuilder(int roleId)
            {
                user = new User(roleId);
            }
            public UserBuilder userId(int userId)
            {
                user.userId = userId;
                return this;
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
