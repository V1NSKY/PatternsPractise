using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsPractise.Connection;
using static PatternsPractise.Entities.User;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace PatternsPractise.DAO
{
    class DAOUser : IDAOUser
    {
        readonly String SQLConnectionString;
        readonly String SQLSelectUserRoleById = "SELECT * FROM gamelibrarydb.userrole WHERE idUserRole = @idUserRole;";
        readonly String SQLInsertUser = "INSERT INTO gamelibrarydb.user(idUserRole,userName,userSurname,userMiddleName,userLogin,userPassword,userPhone,userDescription) VALUES (@idUserRole, @userName, @userSurname, @userMiddleName, @userLogin, @userPassword, @userPhone, @userDescription);";
        readonly String SQLDeleteUser = "DELETE FROM gamelibrarydb.user WHERE idUser = @idUser;";
        readonly String SQLSelectAllUsers = "SELECT * FROM gamelibrarydb.user;";
        readonly String SQLSelectUserById = "SELECT * FROM gamelibrarydb.user WHERE idUser = @idUser;";
        readonly String SQLSelectUserByName = "SELECT * FROM gamelibrarydb.user WHERE userName = @userName;";
        readonly String SQLUpdateUserById = "UPDATE gamelibrarydb.user SET idUserRole = @idUserRole, userName = @userName, userSurname = @userSurname, userMiddleName = @userMiddleName, userLogin = @userLogin, userPassword = @userPassword, userPhone = @userPhone, userDescription = @userDescription WHERE idUser = @idUser;";
        public DAOUser(String SQlConnectionString) { this.SQLConnectionString = SQlConnectionString; }

        //DAO AddUser

        public string AddUser(User user)
        {
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLSelectUserRoleById
            };
            cmd.Parameters.AddWithValue("@idUserRole", ((int)user.UserRole));
            conn.Open();

            using (MySqlDataReader userRoleReader = cmd.ExecuteReader())
            {
                if (!userRoleReader.HasRows)
                {
                    conn.Close();
                    return "Роль пользователя не найдена";
                }
            }
            cmd.Parameters.Clear();

            cmd.CommandText = SQLInsertUser;
            String returnString = "";
            cmd.Parameters.AddWithValue("@idUserRole", ((int)user.UserRole));
            cmd.Parameters.AddWithValue("@userName", user.UserName);
            cmd.Parameters.AddWithValue("@userSurname", user.UserSurname);
            cmd.Parameters.AddWithValue("@userMiddleName", user.UserMiddleName);
            cmd.Parameters.AddWithValue("@userLogin", user.UserLogin);
            cmd.Parameters.AddWithValue("@userPassword", user.UserPassword);
            cmd.Parameters.AddWithValue("@userPhone", user.UserPhone);
            cmd.Parameters.AddWithValue("@userDescription", user.UserDescription);
            returnString +=" Добавлена " + cmd.ExecuteNonQuery() + " запись ";
            cmd.Parameters.Clear();
            conn.Close();
            return returnString;
        }

        //DAO DeleteUser

        public string DeleteUser(int idUser)
        {
            String returnString = "";
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLDeleteUser
            };
            cmd.Parameters.AddWithValue("@idUser", idUser);
            conn.Open();
            returnString += " Удалена " + cmd.ExecuteNonQuery() + " запись ";
            cmd.Parameters.Clear();
            conn.Close();
            return returnString;
        }

        //DAO GetAllUsers

        public List<User> GetAllUsers()
        {
            List<User> listUser = new List<User>();
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLSelectAllUsers
            };
            conn.Open();

            using(MySqlDataReader selectAllUsersReader = cmd.ExecuteReader())
            {
                if (selectAllUsersReader.HasRows)
                {
                    while (selectAllUsersReader.Read())
                    {
                        User user = new UserBuilder(Convert.ToInt32(selectAllUsersReader.GetValue(1)))
                            .userId(Convert.ToInt32(selectAllUsersReader.GetValue(0)))
                            .userName(selectAllUsersReader.GetString(2))
                            .userSurname(selectAllUsersReader.GetString(3))
                            .userMiddleName(selectAllUsersReader.GetString(4))
                            .userLogin(selectAllUsersReader.GetString(5))
                            .userPassword(selectAllUsersReader.GetString(6))
                            .userPhone(selectAllUsersReader.GetString(7))
                            .userDescription(selectAllUsersReader.GetString(8))
                            .Build();
                        listUser.Add(user);
                    }
                }
            }

            cmd.Parameters.Clear();
            conn.Close();
            return listUser;
        }

        //DAO GetUserById

        public User GetUserById(int idUser)
        {
            User user = new UserBuilder(1).Build();
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLSelectUserById
            };
            cmd.Parameters.AddWithValue("@idUser", idUser);
            conn.Open();

            using (MySqlDataReader selectUserByIdReader = cmd.ExecuteReader())
            {
                if (selectUserByIdReader.HasRows)
                {
                    while (selectUserByIdReader.Read())
                    {
                        user = new UserBuilder(Convert.ToInt32(selectUserByIdReader.GetValue(1)))
                            .userId(Convert.ToInt32(selectUserByIdReader.GetValue(0)))
                            .userName(selectUserByIdReader.GetString(2))
                            .userSurname(selectUserByIdReader.GetString(3))
                            .userMiddleName(selectUserByIdReader.GetString(4))
                            .userLogin(selectUserByIdReader.GetString(5))
                            .userPassword(selectUserByIdReader.GetString(6))
                            .userPhone(selectUserByIdReader.GetString(7))
                            .userDescription(selectUserByIdReader.GetString(8))
                            .Build();
                    }
                }
            }

            cmd.Parameters.Clear();
            conn.Close();
            return user;
        }

        //DAO SearchUsersByName

        public List<User> SearchUsersByName(String userName)
        {
            List<User> listUsers = new List<User>();
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLSelectUserByName
            };
            cmd.Parameters.AddWithValue("@userName", userName);
            conn.Open();

            using (MySqlDataReader selectUserByNameReader = cmd.ExecuteReader())
            {
                if (selectUserByNameReader.HasRows)
                {
                    while (selectUserByNameReader.Read())
                    {
                        User user = new UserBuilder(Convert.ToInt32(selectUserByNameReader.GetValue(1)))
                            .userId(Convert.ToInt32(selectUserByNameReader.GetValue(0)))
                            .userName(selectUserByNameReader.GetString(2))
                            .userSurname(selectUserByNameReader.GetString(3))
                            .userMiddleName(selectUserByNameReader.GetString(4))
                            .userLogin(selectUserByNameReader.GetString(5))
                            .userPassword(selectUserByNameReader.GetString(6))
                            .userPhone(selectUserByNameReader.GetString(7))
                            .userDescription(selectUserByNameReader.GetString(8))
                            .Build();
                        listUsers.Add(user);
                    }
                }
            }

            cmd.Parameters.Clear();
            conn.Close();
            return listUsers;
        }

        //DAO UpdateUser

        public string UpdateUser(User user)
        {
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLUpdateUserById
            };
            conn.Open();

            String returnString = "";
            cmd.Parameters.AddWithValue("@idUser", user.UserId);
            cmd.Parameters.AddWithValue("@idUserRole", ((int)user.UserRole));
            cmd.Parameters.AddWithValue("@userName", user.UserName);
            cmd.Parameters.AddWithValue("@userSurname", user.UserSurname);
            cmd.Parameters.AddWithValue("@userMiddleName", user.UserMiddleName);
            cmd.Parameters.AddWithValue("@userLogin", user.UserLogin);
            cmd.Parameters.AddWithValue("@userPassword", user.UserPassword);
            cmd.Parameters.AddWithValue("@userPhone", user.UserPhone);
            cmd.Parameters.AddWithValue("@userDescription", user.UserDescription);
            returnString += " Изменена " + cmd.ExecuteNonQuery() + " запись ";

            cmd.Parameters.Clear();
            conn.Close();
            return returnString;
        }
    }
}
