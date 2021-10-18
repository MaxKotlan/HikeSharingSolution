using HikeSharingUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HikeSharingUi.Services
{
    public class HttpParksService : IParkService
    {
        private readonly ParksHttpClient _client;

        public HttpParksService(ParksHttpClient client)
        {
            _client = client;
        }

        public async Task<List<ParkListItemModel>> GetAllParksAsync()
        {
            var response = await _client.GetParksResponseAsync();
            return response.Data;
        }
    }
}
