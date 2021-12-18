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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PatternsPractise.Entities.User;

namespace PatternsPractise.Forms
{
    public partial class ReplicationTestForm : Form
    {
        private string insertRep(int count) 
        {
            String returnString = "";
            IDAOUser daoUser = new CreatorDBDAOUser().FactoryMetod(DBtype.MongoDB);
            daoUser.TruncateUser();
            var timer = System.Diagnostics.Stopwatch.StartNew();
            int errorCount = 0;
                try
                {
                    for (int i = 0; i < count; i++)
                    {
                    if(errorCount <= 3)
                    {
                        User user = new UserBuilder(1)
                           .userName("Test")
                           .userSurname("Test")
                           .userMiddleName("Test")
                           .userPhone("Test")
                           .userLogin("Test" + i)
                           .userPassword("Test")
                           .userDescription("Test")
                           .Build();
                        daoUser.AddUser(user);
                    }
                    else
                    {
                        break;
                    }
                    }
                }
                catch (Exception e)
                {
                    errorCount++;
                    Thread.Sleep(1000);
                }
            timer.Stop();
            if(errorCount > 3)
            {
                return "Ошибка записи";
            }
            return returnString += "Insert " + count + ": " + timer.Elapsed.TotalSeconds + " s\n";
        }
        private string readRep()
        {
            string returnString = "";
            var timer = System.Diagnostics.Stopwatch.StartNew();
            IDAOUser daoUser = new CreatorDBDAOUser().FactoryMetod(DBtype.MongoDB);
            daoUser.GetAllUsers();
            timer.Stop();
            int count = daoUser.GetAllUsers().Count;
            daoUser.TruncateUser();
            return returnString += "Select " + count + ": " + timer.Elapsed.TotalSeconds + " s\n";

        }
        public ReplicationTestForm()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                insertRep(Convert.ToInt32(writeNumberTextBox.Text)) +
                readRep(),
                "Тест",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
        }
    }
}
