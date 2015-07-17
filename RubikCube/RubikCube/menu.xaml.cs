using System;
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
    public partial class menu : PhoneApplicationPage
    {
        public menu()
        {
            InitializeComponent();
        }

        private void textBlock1_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/stage1.xaml", UriKind.Relative));
        }

        private void textBlock2_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/stage2.xaml", UriKind.Relative));
        }

        private void textBlock3_Tap(object sender, GestureEventArgs e)
        {

            NavigationService.Navigate(new Uri("/stage3.xaml", UriKind.Relative));
        }

        private void textBlock4_Tap(object sender, GestureEventArgs e)
        {

            NavigationService.Navigate(new Uri("/stage4.xaml", UriKind.Relative));
        }

        private void textBlock5_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/stageA.xaml", UriKind.Relative));
        }

        private void textBlock6_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/stage6.xaml", UriKind.Relative));
        }

        private void textBlock7_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/stage7.xaml", UriKind.Relative));
        }
    }
}