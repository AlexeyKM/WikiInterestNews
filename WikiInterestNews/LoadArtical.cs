using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WikiInterestNews.Models;

namespace WikiInterestNews
{
    public static class LoadArtical
    {
        private static HttpClient client = new HttpClient();
        public static async Task<Artical> LoadArticalsTitle(string title = "Stack Overflow")
        {
            string url = $"https://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&titles={title}&explaintext";
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                string responceString = await response.Content.ReadAsStringAsync();
                Artical articalModel = JsonConvert.DeserializeObject<Artical>(responceString);
                return articalModel;
            }
        }
        
      
        public static async Task<Artical> LoadArticalsId(int id) //максимальный id 6 миллиардов
        {

            string url = "";
            url = $"https://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&pageids={324325}&explaintext"; //для примера такое значение, а так там рандом будет

            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                var headers = response.Headers;

                string responceString = await response.Content.ReadAsStringAsync();

                Artical articalModel = JsonConvert.DeserializeObject<Artical>(responceString);

                return articalModel;
            }

            return null;
        }
    }
}
