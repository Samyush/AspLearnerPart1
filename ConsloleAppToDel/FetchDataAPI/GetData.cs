using System;
using System.Net.Http;

namespace ConsoleAppCalculator.FetchDataAPI;

public class GetData
{
    public static async void GettingData()
    {
        var baseUrl = "https://pokeapi.co/api/v2/pokemon/";

        try
        {
            //using (HttpClient client = new HttpClient())

            //objects can be made as belows too
            using (HttpClient client = new())
            {
                using (var response = await client.GetAsync(baseUrl))
                {
                    using (var content = response.Content)
                    {
                        var data = await content.ReadAsStringAsync();
                        if (data != null)
                            Console.WriteLine(data);
                        //Console.WriteLine(JObject.Parse(data)["result"]);
                        else
                            Console.WriteLine("no data");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}