﻿using DevExpress.Mvvm;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Library2_0.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageWEB.xaml
    /// </summary>
    public partial class PageWEB : Page
    {

        private bool IsCheck { get; set; } = true;

        public PageWEB()
        {
            InitializeComponent();

            DataContext = new ViewModels.MainPages();

            SliderPanel.Margin = new Thickness(0, 0, 180, 0);
        }

        public void ButtonBack(object sender, RoutedEventArgs e)
        {
            Pages.Buttons bt = new Pages.Buttons();
            this.NavigationService.Navigate(bt);

        }

        

        public async Task<bool> Metod1()
        {
            for (int i = 181; i > 0; i = i - 10)
            {
                SliderPanel.Margin = new Thickness(0, 0, i, 0);
                await Task.Delay(1);
            }
            return IsCheck = false;
        }

        public async Task<bool> Metod2()
        {
            for (int i = 0; i < 181; i = i + 10)
            {
                SliderPanel.Margin = new Thickness(0, 0, i, 0);
                await Task.Delay(1);
            }
            return IsCheck = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsCheck == false)
            {
                Metod2();
            }
            else
            {
                Metod1();
            }
        }
    }
}
