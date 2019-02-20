using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WareHouse_Manager.UC;

namespace WareHouse_Manager.ViewModel
{
    public class StatisticalViewModel:BaseViewModel
    {
        public ICommand WindowLoadedCommand { get; set; }
        public StatisticalViewModel()
        {
            WindowLoadedCommand = new RelayCommand<Window>(
                x =>
                {
                    if (x == null)
                        return false;
                    return true;
                },
                x =>
                {
                    StatisticalWindow statisticalWindow = x as StatisticalWindow;
                    statisticalWindow.Grid_Parrent.Children.Clear();
                    statisticalWindow.Grid_Parrent.Children.Add(new InputUC());
                });
        }
    }
}
