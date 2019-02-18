using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WareHouse_Manager.Model;

namespace WareHouse_Manager.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        public bool IsLoaded = false;
        public ICommand WindowLoadedCommand { get; set; }
        public ICommand WindowActivatedCommand { get; set; }
        public ICommand InputCommand { get; set; }
        public ICommand OutputCommand { get; set; }
        public ICommand ProductCommand { get; set; }
        public ICommand SuplierCommand { get; set; }
        public ICommand CustomerCommand { get; set; }
        public ICommand UnitCommand { get; set; }
        private string _date;
        public string Date { get=>_date; set {_date=value;OnPropertyChanged(); } }

        private int _daysInInventory;
        public int DaysInInventory { get=>_daysInInventory; set {_daysInInventory=value;OnPropertyChanged(); } }

        public double InputSum { get => _inputSum; set { _inputSum = value; OnPropertyChanged(); } }

        public double OutputSum { get => _outputSum; set { _outputSum = value;OnPropertyChanged(); } }

        public double InventorySum { get => _inventorySum; set { _inventorySum = value;OnPropertyChanged(); } }

        public ObservableCollection<INPUT_DETAIL> NewInputItemList { get => _newInputItemList; set { _newInputItemList = value;OnPropertyChanged(); } }

        private double _inputSum=0;
        private double _outputSum=0;
        private double _inventorySum=0;
        

        private ObservableCollection<INPUT_DETAIL> _newInputItemList;

        public MainViewModel()
        {
            WindowLoadedCommand = new RelayCommand<Window>(
                x => { return true; }, 
                x =>
                {
                    IsLoaded = true;
                    x.Hide();
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.ShowDialog();
                    var loginVM = loginWindow.DataContext as LoginViewModel;
                    if (loginVM.isLogin == true)
                    {
                        x.Show();
                        LoadDefault();
                    }
                });
            UnitCommand = new RelayCommand<object>(x => { return true; }, x => {UnitWindow window = new UnitWindow(); window.ShowDialog(); });
            InputCommand = new RelayCommand<object>(x => { return true; }, x => { InputWindow window = new InputWindow(); window.ShowDialog(); });
            OutputCommand = new RelayCommand<object>(x => { return true; }, x => { OutputWindow window = new OutputWindow(); window.ShowDialog(); });
            ProductCommand = new RelayCommand<object>(x => { return true; }, x => { ObjectTypeWindow window = new ObjectTypeWindow(); window.ShowDialog(); });
            SuplierCommand = new RelayCommand<object>(x => { return true; }, x => { SuplierWindow window = new SuplierWindow(); window.ShowDialog(); });
            CustomerCommand = new RelayCommand<object>(x => { return true; }, x => { CustomerWindow window = new CustomerWindow(); window.ShowDialog(); });

            WindowActivatedCommand = new RelayCommand<Window>(
                x => true,
                x => 
                {
                    LoadDefault();
                });

            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(100);
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Date = DateTime.Now.ToString();
        }
        void LoadDefault()
        {
            InventorySum = 0;
            InputSum = Convert.ToDouble(DataProvider.Instance.DB.INPUT_DETAIL.Sum(x=>x.AMOUNT));
            OutputSum = Convert.ToDouble(DataProvider.Instance.DB.OUTPUT_DETAIL.Sum(x => x.AMOUNT));
            DaysInInventory = DataProvider.Instance.DB.DAYSININVENTORY.Select(x => x.DAYSININVENTORY1).SingleOrDefault();
            var InputList1 = DataProvider.Instance.DB.INPUT.Where(x => SqlFunctions.DateDiff("day", x.DATE_INPUT, DateTime.Now) > DaysInInventory);

            if (InputList1 != null)
            {
                foreach (var item in InputList1)
                {
                    var InputList2 = DataProvider.Instance.DB.INPUT_DETAIL.Where(x => x.INPUT_ID == item.ID);
                    if (InputList2.Count() > 0)
                    {
                        foreach (var items in InputList2)
                        {
                            var OutputList = DataProvider.Instance.DB.OUTPUT_DETAIL.Where(x => x.INPUT_DETAIL_ID == items.ID);
                            if (OutputList.Count() > 0)
                            {
                                InventorySum += (double)items.AMOUNT - (double)OutputList.Sum(x => x.AMOUNT);
                            }
                            else
                            {
                                InventorySum += (double)items.AMOUNT;
                            }
                        }
                    }
                }
            }
            NewInputItemList = new ObservableCollection<INPUT_DETAIL>();
            var NewItemList = DataProvider.Instance.DB.INPUT_DETAIL.ToArray();
            if (NewItemList != null)
            {
                if (NewItemList.Count() > 5)
                {
                    for (int i = NewItemList.Count() - 1; i > NewItemList.Count() - 6; i--)
                    {          
                        NewInputItemList.Add(NewItemList[i]);
                    }
                }
                else
                {
                    foreach (var item in NewItemList)
                    {
                        NewInputItemList.Add(item);
                    }
                }
            }
        }
    }
}
