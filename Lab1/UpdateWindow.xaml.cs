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
    /// Logika interakcji dla klasy UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        private TablePattern _pattern = new TablePattern();
        private string PhotoFile;
        public UpdateWindow(TablePattern pattern)
        {
            InitializeComponent();
            _pattern = pattern;
            InstrName.Text = _pattern.Nazwa;
            InstrGroup.Text = _pattern.Podgrupa;
            InstrTuned.Text = _pattern.Stroj;
            InstrRange.Text = _pattern.Skala;
            InstrDescription.Text = _pattern.Opis;
            if (!string.IsNullOrEmpty(_pattern.Zdjecie))
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = new Uri(Path.Combine(Environment.CurrentDirectory, _pattern.Zdjecie));
                image.EndInit();
                InstPhoto.Source = image;
            }
            else
            {
                InstPhoto.Source = null;   
            }
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
        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            _pattern.Nazwa = InstrName.Text;
            _pattern.Podgrupa = InstrGroup.Text;   
            _pattern.Stroj = InstrTuned.Text;
            _pattern.Skala = InstrRange.Text;
            _pattern.Opis = InstrDescription.Text;
            if (!string.IsNullOrEmpty(PhotoFile))
            {
                _pattern.Zdjecie = _pattern.Nazwa + ".bmp";
                string FileName = Path.Combine(Environment.CurrentDirectory, _pattern.Zdjecie);
                File.Copy(PhotoFile, FileName, true);
            }
            if (SQLiteAcces.Update(_pattern))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Błąd", "Warning", MessageBoxButton.OK);
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
