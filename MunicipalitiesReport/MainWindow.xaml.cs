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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using src;
namespace MunicipalitiesReport
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Municipality> municipalities;
        public MainWindow()
        {
            InitializeComponent();
            municipalities = new List<Municipality>();
        }

        public void LoadInformation(String path)
        {
            int cont = 0;
            Municipality mn;
            foreach (string line in System.IO.File.ReadLines(path))
            {

                if (cont > 0 && cont < 1122)
                {
                    String[] data = line.Split(',');
                    mn = new Municipality(data[4], data[1], data[2], data[0], data[3]);
                    municipalities.Add(mn);
                }
                cont++;
            }
            table.ItemsSource = municipalities;
            Char[] charList = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Cbox.ItemsSource = charList;
        }

        private void SearchFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Office Files| *.csv";

            if (file.ShowDialog() != null)
            {
                LoadInformation(file.FileName);
            }
        }

        private void ShowGraphic(object sender, RoutedEventArgs e)
        {

            Window1 window1 = new Window1(municipalities);
            window1.Show();

            Window window = Window.GetWindow(this);
            window.Close();
        }

        private void SelectItem(object sender, SelectionChangedEventArgs e)
        {
            char letter = (char)Cbox.SelectedItem;
            List<Municipality> mn = new List<Municipality>();

            for (int i = 0; i < municipalities.Count; i++)
            {
                if(municipalities[i].Department.Substring(0, 1).ToLower().Equals(letter.ToString()))
                {
                    mn.Add(municipalities[i]);
                }
            }

            table.ItemsSource = mn;
            System.Windows.MessageBox.Show(mn.Count + "");
        }
    }
}
