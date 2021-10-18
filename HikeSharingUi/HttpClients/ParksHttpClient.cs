using HikeSharingUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;



namespace HikeSharingUi.HttpClients
{
    public class ParksHttpClient
    {
        private readonly HttpClient _httpClient;



        public ParksHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "HikeSharingUi");
        }

        public async Task<GetParksResponse> GetParksResponseAsync()
        {
            var response = await _httpClient.GetAsync("/parks");
            var json = await response.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<GetParksResponse>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return data;
        }
    }



    public class GetParksResponse
    {
        public List<ParkListItemModel> Data { get; set; }
    }
}