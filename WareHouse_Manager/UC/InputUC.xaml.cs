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
using WareHouse_Manager.ViewModel;

namespace WareHouse_Manager.UC
{
    /// <summary>
    /// Interaction logic for InputUC.xaml
    /// </summary>
    public partial class InputUC : UserControl
    {
        public InputViewModel ViewModel { get; set; }
        public InputUC()
        {
            InitializeComponent();
            this.DataContext = ViewModel = new InputViewModel();
        }
    }
}
