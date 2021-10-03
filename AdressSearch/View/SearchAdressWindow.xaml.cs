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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class SearchAdressWindow : Window
    {
        public SearchAdressWindow()
        {
            InitializeComponent();
            AdressSearchWindowViewModel vm = new();
            this.DataContext = vm;
            if(vm.ShowAdressInfoWindowAction == null)
            {
                vm.ShowAdressInfoWindowAction = new Action<Dadata.Model.Suggestion<Dadata.Model.Address>>(ShowAdressInfoWindow);
            }
        }

        private void ShowAdressInfoWindow(Suggestion<Address> obj)
        {
            AdressInfoWindow window = new(obj);
            window.ShowDialog();
        }
    }
}
