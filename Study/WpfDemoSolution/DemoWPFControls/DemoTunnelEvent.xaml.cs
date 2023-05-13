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

namespace DemoWPFControls
{
    /// <summary>
    /// Interaction logic for DemoTunnelEvent.xaml
    /// </summary>
    public partial class DemoTunnelEvent : Window
    {
        public DemoTunnelEvent()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "Button is Clicked";
            MessageBox.Show("Button_Click", "Tunnel Event");
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            txt2.Text = "Click event is bubbled to Stack Panel";
            //e.Handled = true;
            MessageBox.Show("StackPanel_Click", "Tunnel Event");
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            txt3.Text = "Click event is bubbled to Window";
            MessageBox.Show("Window_Click", "Tunnel Event");
        }
    }
}
