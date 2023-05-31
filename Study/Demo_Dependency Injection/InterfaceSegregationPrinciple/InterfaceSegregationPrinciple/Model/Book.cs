using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Model {
    class Book : IBook{
        public string Author { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
    }
    //------------------------------------
    class TopicBook : IBook, ITopic {
        public string Author { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
    }
    //------------------------------------
    class Video : IBook, ITopic, IDuration{
        public string Author { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public string Duration { get; set; }
    }
}
