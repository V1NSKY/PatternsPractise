using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using static PatternsPractise.Entities.User;
using MySql.Data.MySqlClient;
using PatternsPractise.DAO.ObserverDAO;

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
        readonly String SQLSelectUserIdByCred = "SELECT idUser FROM gamelibrarydb.user WHERE userLogin = @userLogin AND userPassword = @userPassword";
        readonly String SQLSelectUserIdByLogin = "SELECT idUser FROM gamelibrarydb.user WHERE userLogin = @userLogin";
        public DAOUser() { }
        private static List<IObserverDAOUser> observers = new List<IObserverDAOUser>();
        public void AddObserver(IObserverDAOUser observer)
        {
            observers.Add(observer);
        }

        //DAO AddUser

        public string AddUser(User user)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectUserRoleById
                };
                cmd.Parameters.AddWithValue("@idUserRole", ((int)user.UserRole));

                using (MySqlDataReader userRoleReader = cmd.ExecuteReader())
                {
                    if (!userRoleReader.HasRows)
                    {
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
                returnString += " Добавлена " + cmd.ExecuteNonQuery() + " запись ";
                cmd.Parameters.Clear();
                Notify();
                return returnString;
            }
            
        }

        public void DeleteObserver(IObserverDAOUser observer)
        {
            observers.Remove(observer);
        }

        //DAO DeleteUser

        public string DeleteUser(int idUser)
        {
            String returnString = "";

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLDeleteUser
                };
                cmd.Parameters.AddWithValue("@idUser", idUser);
                returnString += " Удалена " + cmd.ExecuteNonQuery() + " запись ";
                cmd.Parameters.Clear();
            }
            Notify();
            return returnString;
        }

        //DAO GetAllUsers

        public List<User> GetAllUsers()
        {
            List<User> listUser = new List<User>();
                       
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectAllUsers
                };
                using (MySqlDataReader selectAllUsersReader = cmd.ExecuteReader())
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
            }
            
            return listUser;
        }

        //DAO GetUserById

        public User GetUserById(int idUser)
        {
            User user = new UserBuilder(1).Build();           

            using(MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectUserById
                };
                cmd.Parameters.AddWithValue("@idUser", idUser);

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
                    else
                    {
                        return null;
                    }
                }
            }

            return user;
        }

        public int GetUserIdByCred(string login, string password)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectUserIdByCred
                };
                cmd.Parameters.AddWithValue("@userLogin", login);
                cmd.Parameters.AddWithValue("@userPassword", password);

                using (MySqlDataReader getUserReader = cmd.ExecuteReader())
                {
                    if (getUserReader.HasRows)
                    {
                        getUserReader.Read();
                        int userId = Convert.ToInt32(getUserReader.GetValue(0));
                        cmd.Parameters.Clear();
                        return userId;
                    }
                    else
                    {
                        cmd.Parameters.Clear();
                        return 0;
                    }
                }
            }   
        }

        public int GetUserIdByLogin(string login)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectUserIdByLogin
                };
                cmd.Parameters.AddWithValue("@userLogin", login);

                using (MySqlDataReader getUserReader = cmd.ExecuteReader())
                {
                    if (getUserReader.HasRows)
                    {
                        getUserReader.Read();
                        int userId = Convert.ToInt32(getUserReader.GetValue(0));
                        cmd.Parameters.Clear();
                        return userId;
                    }
                    else
                    {
                        cmd.Parameters.Clear();
                        return 0;
                    }
                }
            }
        }

        public void Notify()
        {
            foreach(IObserverDAOUser observer in observers)
            {
                observer.Update(this);
            }
        }

        //DAO SearchUsersByName

        public List<User> SearchUsersByName(String userName)
        {
            List<User> listUsers = new List<User>();

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectUserByName
                };
                cmd.Parameters.AddWithValue("@userName", userName);
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
            }
            
            return listUsers;
        }

        //DAO UpdateUser

        public string UpdateUser(User user)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLUpdateUserById
                };
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
                Notify();
                return returnString;
            }
        }

        public int DeleteUserByName(string name)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = "DELETE FROM gamelibrarydb.user WHERE userName = @userName;"
                };
                cmd.Parameters.AddWithValue("@userName", name);
                return cmd.ExecuteNonQuery();
            }
        }

        public List<User> SearchUsersByNameAndPassword(string userName, String password)
        {
            List<User> listUsers = new List<User>();

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = "SELECT * FROM gamelibrarydb.user WHERE userName = @userName AND userPassword = @userPassword;"
                };
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@userPassword", password);
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
            }

            return listUsers;
        }
    }
}
