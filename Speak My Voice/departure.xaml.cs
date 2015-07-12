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
    public partial class departure : PhoneApplicationPage
    {
        public departure()
        {
            InitializeComponent();
        }

        private void textBlock1_Tap(object sender, GestureEventArgs e)
        {
            TextBlock asd = sender as TextBlock;
            NavigationService.Navigate(new Uri("/MainPage1.xaml?v=" + asd.Text, UriKind.Relative));
        }
    }
}