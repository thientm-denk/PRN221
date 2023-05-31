
 using System;
 using Demo_DI__Constructor_Injection.Model;
 namespace Demo_DI__Constructor_Injection{
    // UI Layer
    class Program{
        static void Main(string[] args) {
            Console.Title = "DI-ConstructorInjection";
            BookManager bm;
            Console.WriteLine("Please, select reading type (XML or JSON)");
            var ans = Console.ReadLine();
            if (ans.ToLower() == "xml"){
                bm = new BookManager(new XMLBookReader());
            }
            else { 
                bm = new BookManager(new JSONBookReader()); 
            }
            bm.ReadBooks();
            Console.ReadLine();
        }
    }
}
