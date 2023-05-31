using InterfaceSegregationPrinciple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using InterfaceSegregationPrinciple.Utilities;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static List<Video> bookList;
        static void PrintBooks(List<Video> books){
            Console.WriteLine(" List of Books");
            Console.WriteLine(" ----------------------");
            foreach (var item in books){
                Console.WriteLine($" {item.Title.PadRight(36, ' ')} " +
                $"{item.Author.PadRight(20, ' ')} {item.Price}" + " " +
                $"{item.Topic?.PadRight(12, ' ') } " +
                $"{item.Duration ?? ""}");
            }
            Console.WriteLine();
        }//end PrintBooks
        //------------------------------------------------------
        static void Main(string[] args){
            string id = string.Empty;
            Console.Title = "Interface Segregation Principle Demo";
            do
            {
                Console.Write("File no. to read: 1/2/3-Enter(exit): ");
                id = Console.ReadLine();
                if ("123".Contains(id) && !String.IsNullOrEmpty(id))
                {
                    bookList = Utilities.Utilities.ReadData(id);
                    PrintBooks(bookList);
                }
            } while (!String.IsNullOrWhiteSpace(id));
        }//end Main       
    }
}
