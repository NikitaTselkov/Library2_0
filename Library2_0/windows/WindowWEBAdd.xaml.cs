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
using System.Windows.Shapes;

namespace Library2_0.windows
{
    /// <summary>
    /// Логика взаимодействия для WindowWEBAdd.xaml
    /// </summary>
    public partial class WindowWEBAdd : Window
    {
        public WindowWEBAdd()
        {
            InitializeComponent();
        }

        public static void Add(TextBox text1, TextBox text2, TextBox text3)
        {
            using (var context = new MyDbContext2())
            {
                var info = new information()
                {

                    Name = text1.Text,
                    This = text2.Text,
                    Code = text3.Text
                };
                context.informations.Add(info);
                context.SaveChanges();

            }



        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            Add(_name, _this, _code);

        }
    }
}
