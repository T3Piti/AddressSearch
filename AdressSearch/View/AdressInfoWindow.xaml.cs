using AdressSearch.ViewModels;
using Dadata.Model;
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

namespace AdressSearch.View
{
    /// <summary>
    /// Логика взаимодействия для AdressInfoWindow.xaml
    /// </summary>
    public partial class AdressInfoWindow : Window
    {
        public AdressInfoWindow(Suggestion<Address> adress)
        {
            InitializeComponent();
            var vm = new AdressInfoWindowViewModel(adress);
            this.DataContext = vm;
        }
    }
}
