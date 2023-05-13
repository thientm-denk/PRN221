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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoWPFControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{
        public MainWindow()
        {
            InitializeComponent();           
        }
        private void cboColor_SelectionChanged(object sender, 
            SelectionChangedEventArgs e){
            var stackPanel = (StackPanel)cboColor.SelectedItem;
            var label = stackPanel.Children[1] as Label;
            string color = label.Content.ToString();
            lbMsg.Content = "Your color is "+color;            
        }
    }
}

//switch (color)
//{
//    case "Green":
//        myPanel.Background = new SolidColorBrush(Colors.Green);
//        break;
//    case "Red":
//        myPanel.Background = new SolidColorBrush(Colors.Red);
//        break;
//    case "Yellow":
//        myPanel.Background = new SolidColorBrush(Colors.Yellow);
//        break;               
//}           