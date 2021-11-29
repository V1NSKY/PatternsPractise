using PatternsPractise.DAO.MigrationMetod;
using System;
using System.Windows.Forms;

namespace PatternsPractise.Forms
{
    public partial class MigrateForm : Form
    {
        public MigrateForm()
        {
            InitializeComponent();
        }

        private void migrateButton_Click(object sender, EventArgs e)
        {
            Migration migration = new Migration();
            migration.Migrate_SQL_To_MongoBD();
        }
    }
}
