﻿using System;
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
using WareHouse_Manager.ViewModel;

namespace WareHouse_Manager
{
    /// <summary>
    /// Interaction logic for StatisticalWindow.xaml
    /// </summary>
    /// 
    public partial class StatisticalWindow : Window
    {
        public StatisticalViewModel ViewModel { get; set; }
        public StatisticalWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModel = new StatisticalViewModel();
        }
    }
}
