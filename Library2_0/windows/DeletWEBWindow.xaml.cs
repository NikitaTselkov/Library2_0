﻿using Library2_0.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для DeletWEBWindow.xaml
    /// </summary>
    public partial class DeletWEBWindow : Window
    {
        

        public DeletWEBWindow()
        {
            InitializeComponent();
        }

        private static void List(TextBlock text)
        {
            var Info = GetInformation();

            text.Text = "";
            foreach (var info in Info)
            {
                text.Text += $"Id: {info.Id}, {info.Name}, {info.This}, {info.Code} \n";

            }

        }

        private static List<information> GetInformation()
        {
            var context = new MyDbContext2();

            var info = context.informations.ToList();

            return info;
        }

        private static void Remove(TextBox box)
        {
            int _box = Convert.ToInt32(box.Text);
            using (MyDbContext2 myDb = new MyDbContext2())
            {

                var item = myDb.informations.Find(_box);
                if (item != null)
                {
                    myDb.informations.Remove(item);
                    myDb.SaveChanges();
                }

            }
        }

        
        

        private static void Edit(TextBox box, TextBox boxN, TextBox boxT, TextBox boxC)
        {
            int _box = Convert.ToInt32(box.Text);
            using (MyDbContext2 myDb = new MyDbContext2())
            {

                var item = myDb.informations.Find(_box);
                if (item != null)
                {
                    item.Name = boxN.Text;
                    item.This = boxT.Text;
                    item.Code = boxC.Text;
                    myDb.SaveChanges();
                }

            }
        }

        private void View_Click(object sender, RoutedEventArgs e)
        { 
            List(_textblock);
            
        }

        private void Delet_Click(object sender, RoutedEventArgs e)
        {
            Remove(TextBoxId);
            
        }
        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            Edit(TextBoxId, TextName, TextThis, TextCode);
            TextBoxId.Text = "";
            TextName.Text = "";
            TextThis.Text = "";
            TextCode.Text = "";
        }

        
    }
}
