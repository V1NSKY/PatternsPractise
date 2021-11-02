using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsPractise.DAO.ObserverDAO
{
    class ObserverDAOUser : IObserverDAOUser
    {
        Label label;
        public ObserverDAOUser(Label label)
        {
            this.label = label;
        }
        public void Update(IDAOUser daoUser)
        {
            label.Text = Session.user.UserName +" "+Session.user.UserSurname;
        }
    }
}
