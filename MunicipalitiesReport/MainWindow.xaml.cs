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
                
                if(cont > 0 && cont < 1122)
                {
                    String[] data = line.Split(',');
                    mn = new Municipality(data[4], data[1], data[2], data[0], data[3]);
                    municipalities.Add(mn);
                }
                cont++;
            }
            table.ItemsSource = municipalities;
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
    }
}
