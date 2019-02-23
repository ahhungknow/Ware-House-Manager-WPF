using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WareHouse_Manager.UC;

namespace WareHouse_Manager.ViewModel
{
    public class StatisticalViewModel:BaseViewModel
    {
        public ICommand WindowLoadedCommand { get; set; }
        public ICommand SelectedItemChanged { get; set; }
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
            SelectedItemChanged = new RelayCommand<TreeView>(
                x =>
                {
                    if (x == null)
                        return false;
                    return true;
                },
                x =>
                {
                    TreeView treeView = x as TreeView;
                    TreeViewItem treeViewItem = x.SelectedItem as TreeViewItem;
                    StatisticalWindow statisticalWindow = GetParrent(x) as StatisticalWindow;
                    statisticalWindow.Grid_Parrent.Children.Clear();
                    if (treeViewItem.Header.ToString().Contains("Nhập kho") || treeViewItem.Header.ToString().Contains("Phiếu nhập"))
                    {
                        statisticalWindow.Grid_Parrent.Children.Add(new InputUC());
                    }
                    else if (treeViewItem.Header.ToString().Contains("Hàng nhập"))
                    {
                        statisticalWindow.Grid_Parrent.Children.Add(new InputDetailUC());
                    }
                    else if(treeViewItem.Header.ToString().Contains("Xuất kho") || treeViewItem.Header.ToString().Contains("Phiếu xuất"))
                    {
                        //Some code
                    }
                    else if (treeViewItem.Header.ToString().Contains("Xuất hàng"))
                    {
                        //Some code
                    }
                    else if(treeViewItem.Header.ToString().Contains("Tồn kho"))
                    {
                        //Some code
                    }
                    else if (treeViewItem.Header.ToString().Contains("Nhà cung cấp"))
                    {
                        //Some code
                    }
                    else if (treeViewItem.Header.ToString().Contains("Khách hàng"))
                    {
                        //Some code
                    }
                    else
                    {
                        statisticalWindow.Grid_Parrent.Children.Add(new InputUC());
                    }
                });
        }
        FrameworkElement GetParrent(FrameworkElement e)
        {
            while(e.Parent!=null)
            {
                e=e.Parent as FrameworkElement;
            }
            return e;
        }
    }
}
