using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WebApplication.Entities;

namespace ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome User!");
            Console.WriteLine(" If you want to display the second task please write tests/ten to the console.");
            Console.WriteLine(" If you want to display the third task please write modify to the console, than provide a text.");
                
            var request = Console.ReadLine();
            switch (request)
            {
                case "tests/ten":
                    List<Test> tests = AppLauncher.GetTestfromFixedDate(request).GetAwaiter().GetResult();
                    Console.WriteLine(JsonConvert.SerializeObject(tests));
                    break;

                case "modify":
                   var stringToModify = Console.ReadLine();
                    string modified = AppLauncher.PostString(request,stringToModify).GetAwaiter().GetResult();
                    Console.WriteLine(modified);
                    break;

                case "":
                    Console.WriteLine("You must write one from the given opportunities");
                    break;
            }
            Console.ReadKey();
        }
    }
}
