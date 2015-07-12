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
using Microsoft.Phone.Tasks;
namespace SampleVoiceApp
{
    public partial class canada : PhoneApplicationPage
    {
        public canada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask call = new PhoneCallTask();
            call.PhoneNumber = "911";
            call.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask call = new PhoneCallTask();
            call.PhoneNumber = "911";
            call.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask call = new PhoneCallTask();
            call.PhoneNumber = "911";
            call.Show();
        }
    }
}