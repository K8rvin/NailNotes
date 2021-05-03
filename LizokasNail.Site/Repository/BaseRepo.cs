using LizokasNail.Site.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace LizokasNail.Site.Repository
{
    public static class BaseRepo
    {
        public static async Task<List<Base>> GetList()
        {
            List<Base> list = new List<Base>();

            using (var httpClient = new HttpClient())
            {
                var Url = $"{Properties.Resources.webApiUrl}/api/Base";

                using (var response = await httpClient.GetAsync(Url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<Base>>(apiResponse);
                }
            }

            return list;
        }
    }
}
