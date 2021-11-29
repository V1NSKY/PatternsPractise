using System;
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
            if (mySQLRadioButton.Checked)
            {
                Session.dbType = DBtype.MySQL;
                new MainMenu().Show();
                this.Hide();
            }
            else if (mongoDBRadioButton.Checked)
            {
                Session.dbType = DBtype.MongoDB;
                new MainMenu().Show();
                this.Hide();
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            new TEST().Show();
        }

        private void migrateButton_Click(object sender, EventArgs e)
        {
            new MigrateForm().Show();
        }
    }
}
