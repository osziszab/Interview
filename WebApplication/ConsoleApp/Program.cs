using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void  Main(string[] args)
        {
            var request = Console.ReadLine();
            var valami = AppLauncher.Launch(request).Wait();
            Console.WriteLine(valami);
            Console.ReadKey();
           
        }
    }
}
