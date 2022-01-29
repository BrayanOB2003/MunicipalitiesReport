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

        public void LoadInformation()
        {

        }

        private void SearchFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Office Files| *.csv";

            if (file.ShowDialog() != null)
            {
                System.Windows.MessageBox.Show("papitas con salsa");
            }
        }
    }
}
