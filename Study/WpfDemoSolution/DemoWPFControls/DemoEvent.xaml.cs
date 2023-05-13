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
    /// Interaction logic for DemoEvent.xaml
    /// </summary>
    public partial class DemoEvent : Window{
        public DemoEvent()
        {
            InitializeComponent();
        }
        private void Window_MouseRightButtonDown(object sender, 
            MouseButtonEventArgs e){
            // Display information about this event
            this.Title = "Source = " + e.Source.GetType().Name + ", OriginalSource = " +
                         e.OriginalSource.GetType().Name + ", Timestamp= " + e.Timestamp;
            // Derive all possible sources from Control in this example
            Control source = e.Source as Control;
            // Toggle the border on the source control
            if (source.BorderThickness != new Thickness(3)) {
                source.BorderThickness = new Thickness(3);
                source.BorderBrush = Brushes.Red;
            }
            else
                source.BorderThickness = new Thickness(0);
        }
    }
}

