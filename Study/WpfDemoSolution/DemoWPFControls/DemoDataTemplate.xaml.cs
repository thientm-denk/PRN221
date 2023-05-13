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

using System.Collections.ObjectModel;
namespace DemoWPFControls
{  
   
    /// <summary>
    /// Interaction logic for DemoDataTemplate.xaml
    /// </summary>
    public partial class DemoDataTemplate : Window
    {
        public DemoDataTemplate()
        {
            InitializeComponent();
        }
    }
    //---------------------------------------
    public class Car
    {
        public string CarName { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
    }
    public class Cars : ObservableCollection<Car>
    {
        public Cars()
        {
            Add(new Car { CarName = "A6", Color = "White", Brand = "Audi" });
            Add(new Car { CarName = "Lexus 570", Color = "Black", Brand = "Toyota" });
            Add(new Car { CarName = "Ford Ranger Raptor", Color = "White", Brand = "Ford" });
            Add(new Car { CarName = "A8", Color = "Green", Brand = "Audi" });
            Add(new Car { CarName = "RAW 4", Color = "Black", Brand = "Toyota" });
            Add(new Car { CarName = "Civic", Color = "White", Brand = "Honda" });
        }
    }
}
