using DevExpress.Mvvm;
using GalaSoft.MvvmLight.Command;
using Library2_0.Models;
using Library2_0.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<ButtonViewModel> Buttons { get; set; } = new ObservableCollection<ButtonViewModel>();

        public ObservableCollection<ButtonViewModel> buttonViews
        {
            get { return Buttons; }
            set { Buttons = value; }
        }

        private bool IsCheck { get; set; } = true;
        

        public PageWEB()
        {
           
            InitializeComponent();

            DataContext = this;


            SliderPanel.Margin = new Thickness(0, 0, 180, 0);

            var Info = GetInformation();

            foreach (var info in Info)
            {

                Buttons.Add(new ButtonViewModel(info.Name, info.Id, info.This, info.Code));

            }

        }

        private static List<information> GetInformation()
        {
            var context = new MyDbContext2();

            var info = context.informations.ToList();

            return info;
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
            windows.WindowWEBAdd add = new windows.WindowWEBAdd();

            add.Show();

        }

        private void Button_Delet(object sender, RoutedEventArgs e)
        {
            windows.DeletWEBWindow delet = new windows.DeletWEBWindow();

            delet.Show();

        }

        public void what(object sender, RoutedEventArgs e)
        {

            Button btn = (Button)sender;
            int Fio = (int)btn.Tag;
            //MessageBox.Show($"{Fio}");

            var i = buttonViews[Fio - 1];

            _this.Text = i.This;
            _code.Text = i.Code;

        }

        
    }
}
