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
    /// Interaction logic for DemoDataGrid.xaml
    /// </summary>
    public partial class DemoDataGrid : Window{
        public DemoDataGrid() {
            InitializeComponent();
            //Event Handler: Loaded
            Loaded += DemoDataGrid_Loaded;
        }
        private void DemoDataGrid_Loaded(object sender, RoutedEventArgs e) {
            //Create a Car List
            List<dynamic> cars = new List<dynamic> { 
                new {CarName = "A6", Color="White", Brand="Audi" },
                new {CarName = "Lexus 570", Color="Black", Brand="Toyota" },
                new {CarName = "Ford Ranger Raptor", Color="White", Brand="Ford" }
            };
            //Binding on DataGrid
            dgCarList.ItemsSource = cars;
        }
    }
}
