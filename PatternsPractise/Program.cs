using PatternsPractise.Forms;
using System;
using System.Windows.Forms;

namespace PatternsPractise
{
    class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(DBTypeForm.GetDBTypeForm());
        }
    }
}
