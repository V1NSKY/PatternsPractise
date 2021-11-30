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

        private void ShowFinalMessageBox()
        {
            MessageBox.Show(
                "Миграция закончена!",
                "Миграция",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
        }

        private void migrateButton_Click(object sender, EventArgs e)
        {
            if (mySqlMongoRadioButton.Checked)
            {
                var result = MessageBox.Show(
                    "Очистить MongoDB",
                    "Очистка",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );
                if (result == DialogResult.Yes)
                {
                    Migration.daoGameMongo.TruncateGame();
                    Migration.daoUserMongo.TruncateUser();
                    Migration.daoSysReqMongo.TruncateSysReq();
                    Migration.daoLibraryMongo.TruncateLibrary();
                    Migration.Migrate_SQL_To_MongoBD();
                    ShowFinalMessageBox();
                }
                else
                {
                    Migration.Migrate_SQL_To_MongoBD();
                    ShowFinalMessageBox();
                }
            }

            if (mongoMySqlRadioButton.Checked)
            {
                var result = MessageBox.Show(
                    "Очистить MySQL",
                    "Очистка",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );
                if (result == DialogResult.Yes)
                {
                    Migration.daoGameSQL.TruncateGame();
                    Migration.daoUserSQL.TruncateUser();
                    Migration.Migrate_MongoDB_To_SQL();
                    ShowFinalMessageBox();
                }
                else
                {
                    Migration.Migrate_MongoDB_To_SQL();
                    ShowFinalMessageBox();
                }
            }
        }
    }
}
