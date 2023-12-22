using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace SyncFileExchange.Client
{
    internal class SFEClient
    {
        // private readonly string SERVER_URL = "https://sfe.calenaria.com/api/v1/";
        private readonly string SERVER_URL = "http://127.0.0.1:8001/api/v1/";
        private readonly HttpClient client;

        public SFEClient() {
            client = new HttpClient();
            //test connection
            //TestConnection().Wait();
        }

        public async Task<string> registerAccount(string email, string password)
        {
            var jsonData = new
            {
                email = email,
                password = password
            };

            var jsonContent = new StringContent(JsonConvert.SerializeObject(jsonData), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(SERVER_URL + "account/register", jsonContent);

            Debug.WriteLine(response.StatusCode);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {   
                throw new HttpRequestException($"Request failed with status code: {response.StatusCode}");
            }
        }

        public async Task<string> login(string email, string password)
        {
            var jsonData = new
            {
                email = email,
                password = password
            };

            var jsonContent = new StringContent(JsonConvert.SerializeObject(jsonData), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(SERVER_URL + "account/login", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new HttpRequestException($"Login failed.");
            }
        }


        public async Task<string> retrieveLastFile()
        {
            //get last file for user saved on server
            var response = await client.GetAsync(SERVER_URL + "lastfile");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new HttpRequestException($"Request failed with status code: {response.StatusCode}");
            }
        }

        private async Task TestConnection()
        {
            var response = await client.GetAsync(SERVER_URL);
            Console.WriteLine(response);
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Connection test failed with status code: {response.StatusCode}");
            }
        }
    }
}
