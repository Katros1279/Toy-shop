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
using Toy_shop.all_folder.home;

namespace Toy_shop.all_folder.catalog.createToy
{
    /// <summary>
    /// Логика взаимодействия для vibor_CREATE.xaml
    /// </summary>
    public partial class vibor_CREATE : Window
    {
        public vibor_CREATE()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            perehod perehod = new perehod();
            perehod.Show();
            this.Close();
        }
    }
}