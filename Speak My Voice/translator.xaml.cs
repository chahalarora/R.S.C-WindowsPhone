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
    public partial class translator : PhoneApplicationPage
    {
        public translator()
        {
            InitializeComponent();
        }

       


        private void webBrowser1_Loaded(object sender, RoutedEventArgs e)
        {
            webBrowser1.Navigate(new Uri("http://translate.reference.com/", UriKind.Absolute));
        }

        
    }
}