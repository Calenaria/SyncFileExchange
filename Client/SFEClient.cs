using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;

namespace SyncFileExchange.Client
{
    internal class SFEClient
    {
        // private readonly string SERVER_URL = "https://sfe.calenaria.com/api/v1/";
        private readonly string SERVER_URL = "http://127.0.0.1:8001/api/v1/";
        private readonly HttpClient Client;
        private string AccountToken;

        public SFEClient(string accountToken = null) {
            AccountToken = accountToken;
            Client = new HttpClient();
            if (AccountToken != null)
            {
                Client.DefaultRequestHeaders.Add("token", AccountToken);
            }
        }

        public void setToken(string token)
        {
            AccountToken = token;
            Client.DefaultRequestHeaders.Remove("token");
            Client.DefaultRequestHeaders.Add("token", AccountToken);
        }

        public async Task<string> registerAccount(string email, string password)
        {
            var jsonData = new
            {
                email = email,
                password = password
            };

            var jsonContent = new StringContent(JsonConvert.SerializeObject(jsonData), Encoding.UTF8, "application/json");

            var response = await Client.PostAsync(SERVER_URL + "account/register", jsonContent);

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

            var response = await Client.PostAsync(SERVER_URL + "account/login", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<dynamic>(responseContent);
                var token = responseObject.token;
                setToken(token);
                return responseContent;
            }
            else
            {
                throw new HttpRequestException($"Login failed.");
            }
        }


        public async Task<string> retrieveLastFile()
        {
            //get last file for user saved on server
            var response = await Client.GetAsync(SERVER_URL + "lastfile");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new HttpRequestException($"Request failed with status code: {response.StatusCode}");
            }
        }

        public async Task UploadFile(string filePath)
        {
            var fileBytes = await File.ReadAllBytesAsync(filePath);
            var fileName = Path.GetFileName(filePath);

            using var content = new MultipartFormDataContent();
            using var fileContent = new ByteArrayContent(fileBytes);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
            content.Add(fileContent, "file", fileName);

            var response = await Client.PostAsync(SERVER_URL + "file/upload", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"File upload failed with status code: {response.StatusCode}");
            }
        }
    }
}
