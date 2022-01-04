using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsloleAppCalculator.FetchDataAPI
{
    public class GetData
    {
        public static async void GettingData()
        {
            string baseUrl = "https://pokeapi.co/api/v2/pokemon/";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = response.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                Console.WriteLine(data);
                                //Console.WriteLine(JObject.Parse(data)["result"]);
                            }
                            else
                            {
                                Console.WriteLine("no data");
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
