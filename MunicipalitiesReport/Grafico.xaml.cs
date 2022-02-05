using src;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MunicipalitiesReport
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        private List<Municipality> mn;
        private ObservableCollection<Department> dp;
        public Window1(List<Municipality> l)
        {
            mn = l;
            dp = new ObservableCollection<Department>();
            InitializeComponent();
            TransferData();
        }

        public ObservableCollection<Department> Dp { get => dp; set => dp = value; }

        public void TransferData()
        {
            for (int i = 0; i < mn.Count; i++)
            {
                Department d = new Department(mn[i].Department, 0);

                if (dp == null)
                {
                    dp.Add(d);
                } else if(dp.All(Department => Department.Name != d.Name))
                {
                    dp.Add(d);
                }
            }

            for(int i = 0; i < dp.Count; i++)
            {
                for(int j = 0; j < mn.Count; j++)
                {
                    if (dp[i].Name == mn[j].Department)
                    {
                        dp[i].NumberOfMunicipalities++;
                    }
                }
            }

            Chart1.DataContext = dp;
        }
    }
}
