using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public class GoldService : IGoldService
    {
        private readonly HttpClient _http;

        public GoldService(HttpClient http)
        {
            _http = http;
        }

        public int Gold { get; set; } = 0;

        public event Action OnChange;

        public void ConsumeGold(int amount)
        {
            Gold -= amount;
            GoldChanged();
        }
        public async Task AddGold(int amount)
        {
            var result = await _http.PutAsJsonAsync<int>("api/user/addgold", amount);
            Gold = await result.Content.ReadFromJsonAsync<int>();
            GoldChanged();
        }

        void GoldChanged() => OnChange.Invoke();

        public async Task GetGold()
        {
            Gold = await _http.GetFromJsonAsync<int>("api/user/getgold");
            GoldChanged();
        }
    }
}
