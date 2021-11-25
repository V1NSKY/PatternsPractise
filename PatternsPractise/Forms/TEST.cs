using PatternsPractise.DAO;
using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
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
using static PatternsPractise.Entities.Game;
using static PatternsPractise.Entities.User;

namespace PatternsPractise.Forms
{
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }
        private String Test(int count, DBtype btype)
        {
            String returnString = "";
            IDAOUser daoUser = new CreatorDBDAOUser().FactoryMetod(btype);
            var timer = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
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
            returnString += "Insert " + count + ": " + timer.Elapsed.TotalSeconds + " s\n";
            timer.Restart();
            daoUser.SearchUsersByNameAndPassword("Test", "Test");
            returnString += "Select " + count + ": " + timer.Elapsed.TotalSeconds + " s\n";
            timer.Reset();
            daoUser.DeleteUserByName("Test");
            return returnString;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                   "MySQL\n"+
                   Test(Convert.ToInt32(textBox1.Text), DBtype.MySQL) + 
                   "MongoDB\n" +
                   Test(Convert.ToInt32(textBox1.Text), DBtype.MongoDB),
                   "Тест",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1
                   );
        }
    }
}