using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Lab1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (File.Exists(SQLiteAcces.DbFile) == false)
            {
                if (SQLiteAcces.CreateTable())
                {
                    MessageBox.Show("Utworzono tabelę", "Info", MessageBoxButton.OK);
                }
            }
        }
    }
}
