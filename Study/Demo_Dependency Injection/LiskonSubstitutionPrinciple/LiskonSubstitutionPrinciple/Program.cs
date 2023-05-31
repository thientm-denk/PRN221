﻿ using System;
 using System.Collections.Generic;
 class Program{
    static List<Book> bookList;
    static void PrintBooks(List<Book> books){
        Console.WriteLine(" List of Books");
        Console.WriteLine(" ----------------------");
        foreach (var item in books) {
            Console.WriteLine($" {item.Title.PadRight(36, ' ')} " +
                $"{item.Author.PadRight(20, ' ')} {item.Price}");
        }
        Console.ReadLine();
    }//end PrintBooks
    //-----------------------------------------
    static void Main(string[] args)
    {
        Console.Title = "Liskov Substitution Principle Demo";
        Console.WriteLine("Please, press 'yes' to read an extra file, ");
        Console.WriteLine("'topic' to include topic books or any other key for a single file");
        var ans = Console.ReadLine();
        bookList = ((ans != "yes") && (ans != "topic")) ? 
            Utilities.ReadData() : Utilities.ReadData(ans);
        PrintBooks(bookList);
    }//end Main   
 }