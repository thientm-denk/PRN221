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
    /// Interaction logic for SampleDataTemplate.xaml
    /// </summary>
    public partial class SampleDataTemplate : Window
    {
        public SampleDataTemplate()
        {
            InitializeComponent();
            Loaded += SampleDataTemplate_Loaded;
        }

        private void SampleDataTemplate_Loaded(object sender, RoutedEventArgs e)
        {
            List<dynamic> Cars = new List<dynamic>
            {
                new { CarName = "A6", Color = "White", Brand = "Audi" },
                new { CarName = "Lexus 570", Color = "Black", Brand = "Toyota" },
                new { CarName = "Ford Ranger Raptor", Color = "White", Brand = "Ford" }
            };
            MyListBox.ItemsSource = Cars;
        }
    }
}
