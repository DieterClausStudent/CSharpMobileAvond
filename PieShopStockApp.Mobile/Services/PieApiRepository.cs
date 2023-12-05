using PieShopStockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace PieShopStockApp.Services
{
    public  class PieApiRepository : IPieRepository
    {
        private readonly HttpClient _httpClient;
        //  private string baseUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5201/api/pies" : "http://localhost:5201/api/pies";

        private string baseUrl = "https://bqzk5657-5201.euw.devtunnels.ms/api/pies";

        public PieApiRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

        }
        public async Task<Pie> AddPie(Pie pie)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return new Pie();

            pie.ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg";

            var msg = new HttpRequestMessage(HttpMethod.Post, baseUrl);
            msg.Content = JsonContent.Create<Pie>(pie);

            var response = await _httpClient.SendAsync(msg);
            response.EnsureSuccessStatusCode();

            var returnedJson = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Pie>(returnedJson, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

        }

        public async Task<List<Pie>> GetAllPies()
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return new List<Pie>();

            string result = await _httpClient.GetStringAsync(baseUrl);

            return JsonSerializer.Deserialize<List<Pie>>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });
        }

        public async Task UpdatePie(Pie pie)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return;

            HttpRequestMessage msg = new(HttpMethod.Put, baseUrl);
            msg.Content = JsonContent.Create<Pie>(pie);

            var response = await _httpClient.SendAsync(msg);
            response.EnsureSuccessStatusCode();

        }
    }
}
