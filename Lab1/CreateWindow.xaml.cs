using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logika interakcji dla klasy CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        private string PhotoFile;
        public CreateWindow()
        {
            InitializeComponent();
        }

        private void BtnPhotoUpload_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            openFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFile.ShowDialog() == true)
            {
                PhotoFile = openFile.FileName;
                InstPhoto.Source = new BitmapImage(new Uri(PhotoFile));
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            TablePattern pattern = new TablePattern();
            pattern.Nazwa = InstrName.Text;
            pattern.Stroj = InstrGroup.Text;
            pattern.Podgrupa = InstrTuned.Text;
            pattern.Skala = InstrRange.Text;
            pattern.Opis = InstrDescription.Text;
            if (PhotoFile != null)
            {
                pattern.Zdjecie = pattern.Nazwa + ".bmp";
                string FileName = Path.Combine(Environment.CurrentDirectory, pattern.Zdjecie);
                File.Copy(PhotoFile, FileName, true);
            }
            if (SQLiteAcces.Create(pattern))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Błąd", "Error", MessageBoxButton.OK);
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
