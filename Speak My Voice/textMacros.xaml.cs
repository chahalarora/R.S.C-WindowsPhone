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

namespace SampleVoiceApp
{
    public partial class textMacros : PhoneApplicationPage
    {
        public textMacros()
        {
            InitializeComponent();
        }

      

      

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/greetings.xaml", UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/home.xaml", UriKind.Relative));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/day.xaml", UriKind.Relative));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/responses.xaml", UriKind.Relative));
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/emergency.xaml", UriKind.Relative));
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/dating.xaml", UriKind.Relative));
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/weather.xaml", UriKind.Relative));
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/encouragement.xaml", UriKind.Relative));
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/guests.xaml", UriKind.Relative));
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/askingcontact.xaml", UriKind.Relative));
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/relationship.xaml", UriKind.Relative));
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/departure.xaml", UriKind.Relative));
        }

        

      

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/picturetalking.xaml", UriKind.Relative));
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/travel.xaml", UriKind.Relative));
        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/hotel.xaml", UriKind.Relative));
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/eat n drink.xaml", UriKind.Relative));
        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/shoping.xaml", UriKind.Relative));
        }

        private void button25_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/entertainment.xaml", UriKind.Relative));
        }

        private void button26_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/work.xaml", UriKind.Relative));
        }
    }
}