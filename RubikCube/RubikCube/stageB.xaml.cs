﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace RubikCube
{
    public partial class stageB : PhoneApplicationPage
    {
        public stageB()
        {
            InitializeComponent();
        }

        private void textBlock2_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/stage6.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/stage6.xaml", UriKind.Relative));
        }
    }
}