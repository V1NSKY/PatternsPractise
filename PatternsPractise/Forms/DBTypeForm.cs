using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsPractise.Forms
{
    public partial class DBTypeForm : Form
    {
        private static DBTypeForm dBTypeForm;
        private DBTypeForm()
        {
            InitializeComponent();
        }
        public static DBTypeForm GetDBTypeForm()
        {
            if(dBTypeForm == null || dBTypeForm.IsDisposed)
            {
                return dBTypeForm = new DBTypeForm();
            }
            else
            {
                return dBTypeForm;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            TEST tEST = new TEST();
            if (mySQLRadioButton.Checked)
            {
                Session.dbType = DBtype.MySQL;
                mainMenu.Show();
                this.Hide();
            }
            else if (mongoDBRadioButton.Checked)
            {
                Session.dbType = DBtype.MongoDB;
                mainMenu.Show();
                this.Hide();
            }
        }
    }
}
