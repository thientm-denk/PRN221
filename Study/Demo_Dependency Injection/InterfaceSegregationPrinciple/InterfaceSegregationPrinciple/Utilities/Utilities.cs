 using System;
 using System.Collections.Generic;
 using System.Text;
 using System.IO;
 using Newtonsoft.Json;
 using InterfaceSegregationPrinciple.Model;

 namespace InterfaceSegregationPrinciple.Utilities
 {
    internal class Utilities{
        internal static List<Video> ReadData(string fileId){
            var filename = "Data/BookStore" + fileId + ".json";
            var cadJSON = ReadFile(filename);
            return JsonConvert.DeserializeObject<List<Video>>(cadJSON);
        }
        //----------------------------------------------------------
        internal static string ReadFile(string filename){
            return File.ReadAllText(filename);
        }
    }//end Utilities
 }
