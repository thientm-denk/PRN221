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
    /// Interaction logic for DemoBubbleEvent.xaml
    /// </summary>
    public partial class DemoBubbleEvent : Window
    {
        public DemoBubbleEvent()
        {
            InitializeComponent();
        }
        private void OuterButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("You've clicked in outer button", "Outer Button");
        }

        private void InnerButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("You've clicked on a inner button", "Inner Button");
        }
        //Tunnel Event
        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Window_PreviewMouseDown", "Tunnel Event");
        }
        //Tunnel Event
        private void OuterButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("OuterButton_PreviewMouseDown", "Tunnel Event");
        }
        //Tunnel Event
        private void InnerButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("InnerButton_PreviewMouseDown", "Tunnel Event");
        }
        //----------------------------------------------------------------
        //BubbleEvent
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Window_MouseDown", "Bubble Event");
        }
        //BubbleEvent
        private void OuterButton_MouseDown(object sender, MouseButtonEventArgs e)
        {         
            MessageBox.Show("OuterButton_MouseDown", "Bubble Event");
        }
        //BubbleEvent
        private void InnerButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("InnerButton_MouseDown", "Bubble Event");
        }
    }
}
