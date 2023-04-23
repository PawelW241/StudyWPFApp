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
using Path = System.IO.Path;

namespace Lab1
{
    /// <summary>
    /// Logika interakcji dla klasy BrowseWindow.xaml
    /// </summary>
    public partial class BrowseWindow : Window
    {
        List<TablePattern> patterns = new List<TablePattern>();
        public BrowseWindow()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (InstrNameList.SelectedItem != null)
            {
                UpdateWindow updateWindow = new UpdateWindow(patterns[InstrNameList.SelectedIndex]);
                updateWindow.ShowDialog();
                InstrNameList.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Wybierz który wpis chciałbyś zaktualizować", "Warning", MessageBoxButton.OK);
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (InstrNameList.SelectedItem != null)
            {
                if (MessageBox.Show("Czy napewno chcesz usunąć ten obiekt?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if(SQLiteAcces.Delete(patterns[InstrNameList.SelectedIndex]))
                    {
                        if (patterns[InstrNameList.SelectedIndex].Zdjecie != String.Empty)
                        {
                            string PhotoFile = Path.Combine(Environment.CurrentDirectory, patterns[InstrNameList.SelectedIndex].Zdjecie);
                            InstrNameList.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Błąd", "Error", MessageBoxButton.OK);
                    }
                }
            }
        }
        private void InstrNameList_DropDown(object sender, EventArgs e)
        {
            patterns = SQLiteAcces.Read();
            InstrNameList.ItemsSource = patterns.Select(n => n.Nazwa);
        }
        private void InstrNameList_SelectionChanged(object sender, EventArgs e)
        {
            if (InstrNameList.SelectedIndex != -1)
            {
                InstrName.Text = patterns[InstrNameList.SelectedIndex].Nazwa;
                InstrGroup.Text = patterns[InstrNameList.SelectedIndex].Stroj;
                InstrTuned.Text = patterns[InstrNameList.SelectedIndex].Podgrupa;
                InstrRange.Text = patterns[InstrNameList.SelectedIndex].Skala;
                InstrDescription.Text = patterns[InstrNameList.SelectedIndex].Opis;
                if (patterns[InstrNameList.SelectedIndex].Zdjecie != String.Empty)
                {
                    string PhotoFile = Path.Combine(Environment.CurrentDirectory, patterns[InstrNameList.SelectedIndex].Zdjecie);
                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.UriSource = new Uri(PhotoFile);
                    image.EndInit();
                    InstPhoto.Source = image;
                }
                else
                {
                    InstPhoto.Source = null;
                }

            }
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnOpenBase_Click(object sender, RoutedEventArgs e)
        {
            DbShowWindow dbShowWindow = new DbShowWindow();
            dbShowWindow.ShowDialog();
        }
    }
}
