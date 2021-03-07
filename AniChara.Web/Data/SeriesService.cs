using AniChara.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace AniChara.Web.Data
{
    public class SeriesService
    {
        public HttpClient _httpClient;

        public SeriesService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<Series>> GetSeriesAsync()
        {
            var response = await _httpClient.GetAsync("api/series");
            response.EnsureSuccessStatusCode();

            string responseContent = await response.Content.ReadAsStringAsync();

            var data =  JsonConvert.DeserializeObject<List<Series>>(responseContent);

            return data;

        }
    }
}
