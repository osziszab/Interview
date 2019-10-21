using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class AppLauncher
    {
        public static async Task<List<Task>> Launch(string request)
        {
            using (var client = new HttpClient())
            {
                var baseUrl = $"https://localhost:44378";
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();

                switch (request)
                {
                    case "tests/ten":
                        var response = await client.GetAsync(request);
                        var exists = response.IsSuccessStatusCode;
                        return response;
                }
            }
        }
    }
}
