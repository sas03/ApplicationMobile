using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace App3.Services
{
    public class DataService
    {
        public static async Task<dynamic> GetDataFromService(string queryString)
        {
           HttpClient client = new HttpClient();
            try
            {
                var response = await client.GetAsync(queryString);

                dynamic data = null;
                if (response != null)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject(json);

                }
                return data;
            }
            catch (Exception e)
            {
                return null;
            }
            return null;
        }

    }
}
