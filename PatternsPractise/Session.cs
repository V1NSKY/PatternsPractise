using PatternsPractise.Entities;
using static PatternsPractise.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsPractise
{
    public static class Session
    {
        public static User user { private set; get; }
        public static int selectedGameid { set; get; }
        public static Form mainMenu { set; get; }
        public static void SetUser(User newUser)
        {
            user = newUser;
        }
        public static User GetUser(User newUser)
        {
            if(user == null)
            {
                return user = newUser;
            }
            else
            {
                return user;
            }
        }
        public static void NullUser()
        {
            user = null;
        }
    }
}
