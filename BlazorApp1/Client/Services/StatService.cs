using Blazored.LocalStorage;

namespace BlazorApp1.Client.Services
{
    public class StatService : IStatService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly HttpClient _http;
        public StatService(ILocalStorageService localStorageService, HttpClient http)
        {
            _localStorageService = localStorageService;
            _http = http;
        }

        public async Task GetVisits()
        {
            int visits = int.Parse(await _http.GetStringAsync("api/Stat"));
            Console.WriteLine($"Visit: {visits}");
        }

        public async Task IncrementVisists()
        {
            DateTime? lastVisit = await _localStorageService.GetItemAsync<DateTime?>("lastVisit");
            if(lastVisit == null)
            {
                await _localStorageService.SetItemAsync("lastVisit", DateTime.Now);
                await _http.PostAsync("api/Stat", null);
            }
        }
    }
}
