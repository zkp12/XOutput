﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using XOutput.Devices;

namespace XOutput.UI.Component
{
    /// <summary>
    /// Interaction logic for AxisView.xaml
    /// </summary>
    public partial class AxisView : UserControl, IUpdatableView, IViewBase<AxisViewModel, AxisModel>
    {
        protected readonly AxisViewModel viewModel;
        public AxisViewModel ViewModel => viewModel;

        public AxisView(AxisViewModel viewModel)
        {
            this.viewModel = viewModel;
            DataContext = viewModel;
            InitializeComponent();
        }

        public void UpdateValues(IDevice device)
        {
            viewModel.UpdateValues(device);
        }
    }
}
