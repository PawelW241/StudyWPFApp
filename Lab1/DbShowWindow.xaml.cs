using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab1
{
    /// <summary>
    /// Logika interakcji dla klasy DbShowWindow.xaml
    /// </summary>
    public partial class DbShowWindow : Window
    {
        List<TablePattern2> patterns = new List<TablePattern2>();
        public DbShowWindow()
        {
            InitializeComponent();
            patterns = SQLiteAcces.Read2();
            WListBox.ItemsSource = patterns;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
