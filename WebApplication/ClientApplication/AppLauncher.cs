using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Entities;

namespace ClientApplication
{
    public class AppLauncher
    {
        public static async Task<List<Test>> GetTestfromFixedDate(string request)
        {
            using (var client = new HttpClient())
            {
                var baseUrl = $"https://localhost:44378";
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
 
                var response = await client.GetAsync(request);
                var exists = response.IsSuccessStatusCode;
                var content = await response.Content.ReadAsStringAsync();
                var converter = JsonConvert.DeserializeObject<List<Test>>(content);
                return converter;
            }
        }

        public static async Task<string> PostString(string request, string input)
        {
            using (var client = new HttpClient())
            {
                var baseUrl = $"https://localhost:44378";
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                Input userInput = new Input()
                {
                    Userinput = input
                };
   
                var json = JsonConvert.SerializeObject(userInput);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(request, stringContent);
                var exists = response.IsSuccessStatusCode;
                var content = await response.Content.ReadAsStringAsync();               
                return content;
            }
        }
    }
}
