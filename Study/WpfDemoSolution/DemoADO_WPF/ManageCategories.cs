
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;
namespace ManageCategoriesApp
{
    //Declaring record Category
    public record Category 
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
    //------------------------------------------
    public class ManageCategories{
        SqlConnection connection;
        SqlCommand command;    
        string ConnectionString = "Server=TV\\SQLEXPRESS;uid=sa;pwd=1234567890;database=MyStore";
        public List<Category> GetCategories() {
            List<Category> categories = new List<Category>();          
            connection = new SqlConnection(ConnectionString);
            string SQL = "Select CategoryID, CategoryName from Categories";
            command = new SqlCommand(SQL, connection);
            try{
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                if (reader.HasRows == true){
                    while (reader.Read()){
                        categories.Add(new Category{
                            CategoryID = reader.GetInt32("CategoryID"),
                            CategoryName = reader.GetString("CategoryName")
                        });
                    }//end while             
                }//end if
            }
            catch (Exception ex){
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return categories;
        }//end GetCategories
        //------------------------------------------
        public void InsertCategory(Category category){
            connection = new SqlConnection(ConnectionString);
            //CategoryID is auto increment
            command = new SqlCommand("Insert Categories values(@CategoryName)", connection);
            command.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = category.CategoryName;
            try {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex){
                throw new Exception(ex.Message);
            }
            finally{
                connection.Close();
            }
        }//end InsertCategory
        //------------------------------------------
        public void UpdateCategory(Category category){
            connection = new SqlConnection(ConnectionString);           
            string SQL = "Update Categories set CategoryName=@CategoryName where CategoryID=@CategoryID";
            command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@CategoryID",category.CategoryID);
            command.Parameters.AddWithValue("@CategoryName",category.CategoryName);
            try {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex){
                throw new Exception(ex.Message);
            }
            finally{
                connection.Close();
            }
        }//end UpdateCategory
        //------------------------------------------
        public void DeleteCategory(Category category) {
            connection = new SqlConnection(ConnectionString);          
            string SQL = "Delete Categories where CategoryID=@CategoryID";
            command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@CategoryID", category.CategoryID);
            try {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex){
                throw new Exception(ex.Message);
            }
            finally{
                connection.Close();
            }
        }//end DeleteCategory
    }//end ManageCategories
}
