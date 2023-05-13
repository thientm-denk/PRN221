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

namespace ManageCategoriesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WindowManageCategories : Window
    {
        public WindowManageCategories()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------------------------
        ManageCategories categories = new ManageCategories();
        private void Window_Loaded(object sender, RoutedEventArgs e) => LoadCategories();
        //--------------------------------------------------------------------------------
        private void LoadCategories(){
            lvCategories.ItemsSource = categories.GetCategories();           
        }      
        //--------------------------------------------------------------------------------
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var category = new Category { CategoryName = txtCategoryName.Text };
                categories.InsertCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Category");
            }
        }
        //--------------------------------------------------------------------------------
        private void btnUpdate_Click(object sender, RoutedEventArgs e){
            try{
                var category = new Category{
                    CategoryID = int.Parse(txtCategoryID.Text),
                    CategoryName = txtCategoryName.Text
                };
                categories.UpdateCategory(category);
                LoadCategories();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Update Category");
            }
        }
        //--------------------------------------------------------------------------------
        private void btnDelete_Click(object sender, RoutedEventArgs e){
            try{
                var category = new Category {
                    CategoryID = int.Parse(txtCategoryID.Text)
                };
                categories.DeleteCategory(category);
                LoadCategories();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Delete Category");
            }
        }
    }//End Class
}