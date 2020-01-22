using GalaSoft.MvvmLight.Command;
using Library2_0.Models;
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

namespace Library2_0.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCSharp.xaml
    /// </summary>
    public partial class PageCSharp : Page
    {
        private bool IsCheck { get; set; } = true;

        public PageCSharp()
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
                ContentPanel.Margin = new Thickness(0, 0, 0, 0);

                Metod2();
            }
            else
            {
                ContentPanel.Margin = new Thickness(0, 250, 0, 0);

                Metod1();
            }
        }



        private void Button_Add(object sender, RoutedEventArgs e)
        {
            windows.WindowAdd add = new windows.WindowAdd();

            add.Show();

        }

        private void Button_Delet(object sender, RoutedEventArgs e)
        {
            windows.Delet delet = new windows.Delet();

            delet.Show();

        }
    }
}
