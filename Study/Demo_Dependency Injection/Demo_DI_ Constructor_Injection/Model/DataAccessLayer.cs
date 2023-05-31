using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Demo_DI__Constructor_Injection.Model {
    // Data Access Layer
    public interface IBookReader{
        void ReadBooks();
    }
    //---------------------------------------
    public class XMLBookReader : IBookReader{
        public void ReadBooks(){
            Console.WriteLine("Books read in XML Format");
        }
    }
    //---------------------------------------
    public class JSONBookReader : IBookReader{
        public void ReadBooks(){
            Console.WriteLine("Books read in JSON Format");
        }
    }
 }
