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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interfazdinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbInterfaz.SelectedIndex)
            {
                case 0: //Alumnno
                    Alumno.Visibility = Visibility.Visible;
                    break;
                default:
                case 1: //Maestro
                    Maestro.Visibility = Visibility.Visible;
                    break;
            }

        }

        private void CbInterfaz_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            grdInterfaz.Children.Clear();
            switch (cbInterfaz.SelectedIndex)
            {
                case 0: //Alumno
                    grdInterfaz.Children.
                        Add(new Alumno());
                    break;
                default:
                    break;
                case 1: //Maestro
                    grdInterfaz.Children.
                        Add(new Maestro());
                    break;
            }
        }
    }
}