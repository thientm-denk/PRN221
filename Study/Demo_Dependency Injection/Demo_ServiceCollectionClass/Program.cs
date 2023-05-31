
 using System;
 using System.Collections;
 using Demo_ServiceCollectionClass.Model;
 using Microsoft.Extensions.DependencyInjection;
 namespace Demo_ServiceCollectionClass{
    class Program{
        static void Main(string[] args){
            Console.Title = "DI-ServiceCollection Class";

            var services = new ServiceCollection();
            services.AddTransient<IXMLWriter, XMLWriter>();
            services.AddScoped<IJSONWriter, JSONWriter>();

            var provider = services.BuildServiceProvider();
            
            Console.WriteLine("Dependency Injection Demo");
            Console.WriteLine("Mapping Interfaces to instance classes");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Please, select message format (1):XML | (2):JSON");
            var res = Console.ReadLine();
            if (res == "1") {
                var XMLInstance = provider.GetService<IXMLWriter>();
                XMLInstance.WriteXML();
            }
            else{
                var JSONInstance = provider.GetService<IJSONWriter>();
                JSONInstance.WriteJSON();
            }
            /* Invoke registered services */
            var registeredXMLServices = provider.GetServices<IXMLWriter>();
            foreach (var svc in registeredXMLServices) {
                Console.WriteLine($"Service Name:{svc.ToString()}");           
            }                      
            Console.WriteLine(new string('*', 20));
            /* Description of properties in the service collection  */
            foreach (var svc in services) {
                Console.WriteLine($"Type: {svc.ImplementationType} \n" +
                                  $"Lifetime: {svc.Lifetime} \n" +
                                  $"Service Type: {svc.ServiceType}");             
            }
            Console.ReadLine();
        }//end Main
    }//end Program
}
