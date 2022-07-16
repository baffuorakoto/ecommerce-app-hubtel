using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ecommerce_app.Models;
using Newtonsoft.Json;

namespace ecommerce_app.Pages.Services
{
    public class AuthService: IAuth
    {
        private HttpClient _httpClient = new HttpClient();
        private readonly JsonSerializer jsonSerializer = new JsonSerializer();
        public RatingResult _rating = new RatingResult();
        public AuthTokenResponse _authToken = new AuthTokenResponse();

        public AuthService()
        {
            _httpClient.BaseAddress = new Uri("https://c1aa-45-222-192-146.ngrok.io");
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", "Basic YXBwMTpwYXNzd29yZA==");
        }
        public async Task<string> GetToken(string phoneNumber)
        {
            var userPhoneNumber = new UserPhoneNumber
            {
                PhoneNumber = phoneNumber
            };
            var serializedPhoneNumber = JsonConvert.SerializeObject(userPhoneNumber);

            var request = new HttpRequestMessage(HttpMethod.Post, "/Auth");
            request.Content = new StringContent(serializedPhoneNumber);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");




            var responseMessage = await _httpClient.SendAsync(request);
            responseMessage.EnsureSuccessStatusCode();


            using (var response = await responseMessage.Content.ReadAsStreamAsync())
            {
                using (var streamReader = new StreamReader(response))
                {
                    using (var jsonTextReader = new JsonTextReader(streamReader))
                    {

                        _authToken = jsonSerializer.Deserialize<AuthTokenResponse>(jsonTextReader);
                        return _authToken.Data.Token;
                    }

                }
            }

        }
    }
}
