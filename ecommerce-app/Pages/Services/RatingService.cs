using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using ecommerce_app.Models;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace ecommerce_app.Pages.Services
{
    public class RatingService : IRating
    {
        private HttpClient _httpClient = new HttpClient();
        private readonly JsonSerializer jsonSerializer = new JsonSerializer();
        public RatingResult _rating = new RatingResult();
        public AuthTokenResponse _authToken = new AuthTokenResponse();


        public RatingService()
        {
            _httpClient.BaseAddress = new Uri("https://c1aa-45-222-192-146.ngrok.io");
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", "PrivateKey asdf1234");
        

        }


        public async Task<IEnumerable<Rating>> GetRatings()
        {
            var responseMessage = await _httpClient.GetAsync("/ratings");

            using (var response = await responseMessage.Content.ReadAsStreamAsync())
            {
                using (var streamReader = new StreamReader(response))
                {
                    using (var jsonTextReader = new JsonTextReader(streamReader))
                    {
                         _rating = jsonSerializer.Deserialize<RatingResult>(jsonTextReader);

                        return _rating.Data.Results;
                    }
                }
            }
        }

       

        public void CreateRating()
        {
            throw new NotImplementedException();
        }
    }
}
