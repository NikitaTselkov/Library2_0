using DevExpress.Mvvm;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;


namespace Library2_0.ViewModels
{
    class MainButtons : ViewModelBase
    {

        private Page PageCSharp;

        private Page PageWPF;

        private Page PageWEB;

       

        private Page _CurrentPage;
        public Page CurrentPage
        {
            get { return _CurrentPage; }
            set
            {
                _CurrentPage = value;

            }

        }

      
        public MainButtons()
        {

            PageCSharp = new Pages.PageCSharp();

            PageWEB = new Pages.PageWEB();

            PageWPF = new Pages.PageWPF();

          

        }

       

        public ICommand btn_C_Click
        {
            get
            {
                return new RelayCommand(() =>  CurrentPage = PageCSharp);
            }
        }

        public ICommand btn_WPF_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = PageWPF);
            }
        }

        public ICommand btn_WEB_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = PageWEB);
            }
        }

        
    }   
}
